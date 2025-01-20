﻿using Intersect.Plugins.Interfaces;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using Serilog.Extensions.Logging;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Intersect.Plugins.Helpers;

/// <inheritdoc />
internal sealed partial class LoggingHelper : ILoggingHelper
{
    private static readonly string BasePluginLogPath = Path.Combine(
        "plugins", $"{Process.GetCurrentProcess().StartTime:yyyy_MM_dd-HH_mm_ss_fff}"
    );

    private static Logger CreateLogger(IManifestHelper manifest, CreateLoggerOptions createLoggerOptions)
    {
        var logName = string.IsNullOrWhiteSpace(createLoggerOptions.Name)
            ? manifest.Key
            : $"{manifest.Key}.{createLoggerOptions.Name}";

        var loggerConfiguration = new LoggerConfiguration().Enrich.FromLogContext();

        if (createLoggerOptions.File > LogLevel.None)
        {
            var pluginLogPath = Path.Combine(BasePluginLogPath, $"{logName}.log");
            loggerConfiguration = loggerConfiguration.WriteTo.File(
                path: pluginLogPath,
                restrictedToMinimumLevel: LevelConvert.ToSerilogLevel(createLoggerOptions.File)
            );
        }

        if (createLoggerOptions.Console > LogLevel.None)
        {
            loggerConfiguration = loggerConfiguration.WriteTo.Console(
                restrictedToMinimumLevel: LevelConvert.ToSerilogLevel(createLoggerOptions.File)
            );
        }

        return loggerConfiguration.CreateLogger();
    }

    private readonly IManifestHelper mManifest;

    /// <inheritdoc />
    public ILogger Application { get; }

    public ILogger Plugin { get; }

    internal LoggingHelper(ILogger applicationLogger, IManifestHelper manifest)
    {
        mManifest = manifest;

        Application = applicationLogger;
        Plugin = CreateLogger(
            new CreateLoggerOptions
            {
                Console = Debugger.IsAttached ? LogLevel.Debug : LogLevel.None, File = LogLevel.Information,
            }
        );
    }

    /// <inheritdoc />
    public ILogger CreateLogger(CreateLoggerOptions createLoggerOptions) =>
        new SerilogLoggerFactory(CreateLogger(mManifest, createLoggerOptions)).CreateLogger(
            createLoggerOptions.ContextType
        );

    /// <inheritdoc />
    public ILogger<TContext> CreateLogger<TContext>(CreateLoggerOptions createLoggerOptions) =>
        new SerilogLoggerFactory(CreateLogger(mManifest, createLoggerOptions)).CreateLogger<TContext>();
}
