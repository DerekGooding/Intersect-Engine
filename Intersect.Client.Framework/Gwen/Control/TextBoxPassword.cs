﻿namespace Intersect.Client.Framework.Gwen.Control;


/// <summary>
///     Text box with masked text.
/// </summary>
/// <remarks>
///     This class doesn't prevent programatic access to the text in any way.
/// </remarks>
public partial class TextBoxPassword : TextBox
{

    private string mMask;

    private char mMaskCharacter;

    /// <summary>
    ///     Initializes a new instance of the <see cref="TextBoxPassword" /> class.
    /// </summary>
    /// <param name="parent">Parent control.</param>
    /// <param name="name"></param>
    public TextBoxPassword(Base parent, string? name = default) : base(parent, name)
    {
        mMaskCharacter = '*';
    }

    /// <summary>
    ///     Character used in place of actual characters for display.
    /// </summary>
    public char MaskCharacter
    {
        get => mMaskCharacter;
        set => mMaskCharacter = value;
    }

    /// <summary>
    ///     Handler for text changed event.
    /// </summary>
    protected override void OnTextChanged()
    {
        mMask = new string(MaskCharacter, Text?.Length ?? 0);
        TextOverride = mMask;
        base.OnTextChanged();
    }

}
