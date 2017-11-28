﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Intersect.Editor.Classes.Localization
{
    public static class Strings
    {
        public struct About
        {
            public static LocalizedString site = @"Click here to visit the Ascension Game Dev community for support, updates and more!";
            public static LocalizedString title = @"About";
            public static LocalizedString version = @"v{00}";
        }

        public struct AnimationEditor
        {
            public static LocalizedString animations = @"Animations";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString copy = @"Copy Animation";
            public static LocalizedString delete = @"Delete Animation";
            public static LocalizedString deleteprompt = @"Are you sure you want to delete this animation? This action cannot be reverted!";
            public static LocalizedString deletetitle = @"Delete Animation";
            public static LocalizedString general = @"General";
            public static LocalizedString lowerclone = @"Clone From Previous";
            public static LocalizedString lowerframe = @"Frame: {00}";
            public static LocalizedString lowerframecount = @"Graphic Frame Count:";
            public static LocalizedString lowerframeduration = @"Frame Duration (ms):";
            public static LocalizedString lowerframeoptions = @"Frame Options";
            public static LocalizedString lowergraphic = @"Graphic:";
            public static LocalizedString lowergroup = @"Lower Layer (Below Target) ";
            public static LocalizedString lowerhorizontalframes = @"Graphic Horizontal Frames:";
            public static LocalizedString lowerloopcount = @"Loop Count:";
            public static LocalizedString lowerplay = @"Play Lower Animation";
            public static LocalizedString lowerplayback = @"Playback";
            public static LocalizedString lowerstop = @"Stop Upper Animation";
            public static LocalizedString lowerverticalframes = @"Graphic Vertical Frames:";
            public static LocalizedString name = @"Name:";
            public static LocalizedString New = @"New Animation";
            public static LocalizedString paste = @"Paste Animation";
            public static LocalizedString save = @"Save";
            public static LocalizedString simulatedarkness = @"Simulate Darkness: {00}";
            public static LocalizedString sound = @"Sound:";
            public static LocalizedString swap = @"Swap Upper/Lower";
            public static LocalizedString title = @"Animation Editor";
            public static LocalizedString undo = @"Undo Changes";
            public static LocalizedString undoprompt = @"Are you sure you want to undo changes made to this animation? This action cannot be reverted!";
            public static LocalizedString undotitle = @"Undo Changes";
            public static LocalizedString upperclone = @"Clone From Previous";
            public static LocalizedString upperframe = @"Frame: {00}";
            public static LocalizedString upperframecount = @"Graphic Frame Count:";
            public static LocalizedString upperframeduration = @"Frame Duration (ms):";
            public static LocalizedString upperframeoptions = @"Frame Options";
            public static LocalizedString uppergraphic = @"Graphic:";
            public static LocalizedString uppergroup = @"Upper Layer (Above Target) ";
            public static LocalizedString upperhorizontalframes = @"Graphic Horizontal Frames:";
            public static LocalizedString upperloopcount = @"Loop Count:";
            public static LocalizedString upperplay = @"Play Upper Animation";
            public static LocalizedString upperplayback = @"Playback";
            public static LocalizedString upperstop = @"Stop Upper Animation";
            public static LocalizedString upperverticalframes = @"Graphic Vertical Frames:";
        }

        public struct Attributes
        {
            public static LocalizedString animation = @"Animation:";
            public static LocalizedString blocked = @"Blocked";
            public static LocalizedString dir = @"Dir:";
            public static LocalizedString distance = @"Distance (In Tiles):";
            public static LocalizedString grapple = @"Grapple Stone";
            public static LocalizedString item = @"Item:";
            public static LocalizedString itemspawn = @"Item Spawn";
            public static LocalizedString mapanimation = @"Animation";
            public static LocalizedString mapsound = @"Map Sound";
            public static LocalizedString npcavoid = @"NPC Avoid";
            public static LocalizedString quantity = @"Quantity:";
            public static LocalizedString resource = @"Resource:";
            public static LocalizedString resourcespawn = @"Resource";
            public static LocalizedString slide = @"Slide";
            public static LocalizedString sound = @"Sound:";
            public static LocalizedString warp = @"Warp";
            public static LocalizedString zblock = @"Block";
            public static LocalizedString zdimension = @"Z-Dimension";
            public static LocalizedString zgateway = @"Gateway";
            public static LocalizedString zlevel1 = @"Level 1";
            public static LocalizedString zlevel2 = @"Level 2";
            public static LocalizedString znone = @"None";
        }

        public struct ClassEditor
        {
            public static LocalizedString abilitypowerboost = @"Ability Pwr (+{00}):";
            public static LocalizedString addicon = @"+";
            public static LocalizedString addspell = @"Add";
            public static LocalizedString amount = @"Amount:";
            public static LocalizedString armorboost = @"Armor (+{00}):";
            public static LocalizedString attackanimation = @"Attack Animation:";
            public static LocalizedString attackboost = @"Attack (+{00}):";
            public static LocalizedString baseabilitypower = @"Ability Pwr:";
            public static LocalizedString basearmor = @"Armor:";
            public static LocalizedString baseattack = @"Attack:";
            public static LocalizedString basedamage = @"Base Damage:";
            public static LocalizedString basehp = @"HP:";
            public static LocalizedString basemagicresist = @"Magic Resist:";
            public static LocalizedString basemp = @"Mana:";
            public static LocalizedString basepoints = @"Points:";
            public static LocalizedString basespeed = @"Speed:";
            public static LocalizedString basestats = @"Base Stats:";
            public static LocalizedString boostpercent = @" %";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString classes = @"Classes";
            public static LocalizedString combat = @"Combat (Unarmed)";
            public static LocalizedString copy = @"Copy Class";
            public static LocalizedString critchance = @"Crit Chance (%):";
            public static LocalizedString damagetype = @"Damage Type:";
            public static LocalizedString delete = @"Delete Class";
            public static LocalizedString deleteprompt = @"Are you sure you want to delete this class? This action cannot be reverted!";
            public static LocalizedString deletetitle = @"Delete Class";
            public static LocalizedString face = @"Face:";
            public static LocalizedString female = @"Female";
            public static LocalizedString gender = @"Gender";
            public static LocalizedString general = @"General";
            public static LocalizedString hpboost = @"Max HP (+{00}):";
            public static LocalizedString hpregen = @"HP (%);";
            public static LocalizedString item = @"Item:";
            public static LocalizedString itemindex = @"Item Index: {00}";
            public static LocalizedString items = @"Starting Items";
            public static LocalizedString learntspells = @"Spells";
            public static LocalizedString levelboosts = @"Level Up Boosts";
            public static LocalizedString levelexp = @"Base Exp to Level:";
            public static LocalizedString levelexpscale = @"Exp Increase (Per Level %):";
            public static LocalizedString leveling = @"Leveling Up";
            public static LocalizedString locked = @"Locked";
            public static LocalizedString magicresistboost = @"Magic Resist (+{00}):";
            public static LocalizedString male = @"Male";
            public static LocalizedString mpboost = @"Max MP (+{00}):";
            public static LocalizedString mpregen = @"MP (%):";
            public static LocalizedString name = @"Name:";
            public static LocalizedString New = @"New Class";
            public static LocalizedString paste = @"Paste Class";
            public static LocalizedString percentageboost = @"Percentage";
            public static LocalizedString pointsboost = @"Points (+):";
            public static LocalizedString regen = @"Regen";
            public static LocalizedString regenhint = @"% of HP/Mana to restore per tick.

Tick timer saved in server config.xml.";
            public static LocalizedString removeicon = @"-";
            public static LocalizedString removespell = @"Remove";
            public static LocalizedString save = @"Save";
            public static LocalizedString scalingamount = @"Scaling Amount (%):";
            public static LocalizedString scalingstat = @"Scaling Stat:";
            public static LocalizedString spawnpoint = @"Spawn Point";
            public static LocalizedString speedboost = @"Speed (+{00}):";
            public static LocalizedString spell = @"Spell:";
            public static LocalizedString spellitem = @"{00}. {01} - Level: {02}";
            public static LocalizedString spelllevel = @"Level:";
            public static LocalizedString sprite = @"Sprite:";
            public static LocalizedString spriteface = @"Sprite and Face";
            public static LocalizedString spriteitemfemale = @"{00}. {01} - F";
            public static LocalizedString spriteitemmale = @"{00}. {01} - M";
            public static LocalizedString spriteoptions = @"Options:";
            public static LocalizedString staticboost = @"Static";
            public static LocalizedString title = @"Class Editor";
            public static LocalizedString undo = @"Undo Changes";
            public static LocalizedString undoprompt = @"Are you sure you want to undo changes made to this class? This action cannot be reverted!";
            public static LocalizedString undotitle = @"Undo Changes";
        }

        public struct Colors
        {
            public static LocalizedString[] presets = new LocalizedString[]
            {
                @"Black",
                @"White",
                @"Pink",
                @"Blue",
                @"Red",
                @"Green",
                @"Yellow",
                @"Orange",
                @"Purple",
                @"Gray",
                @"Cyan"
            };
        }
        
        public struct Combat
        {
            public static LocalizedString[] damagetypes = new LocalizedString[]
            {
                @"Physical",
                @"Magic",
                @"True",
            };
            public static LocalizedString exp = @"Experience";
            public static LocalizedString[] stats = new LocalizedString[]
            {
                @"Attack",
                @"Ability Power",
                @"Defense",
                @"Magic Resist",
                @"Speed",
            };
            public static LocalizedString[] vitals = new LocalizedString[]
            {
                @"Health",
                @"Mana",
            };
        }

        public struct CommoneEventEditor
        {
            public static LocalizedString delete = @"Delete";
            public static LocalizedString events = @"Common Events";
            public static LocalizedString New = @"New";
            public static LocalizedString title = @"Common Event Editor";
        }

        public struct CraftingEditor
        {
            public static LocalizedString benches = @"Benches";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString copy = @"Copy Bench";
            public static LocalizedString crafts = @"Crafts";
            public static LocalizedString delete = @"Delete Bench";
            public static LocalizedString deletecraft = @"Delete";
            public static LocalizedString deleteingredient = @"Delete";
            public static LocalizedString deleteprompt = @"Are you sure you want to delete this bench? This action cannot be reverted!";
            public static LocalizedString deletetitle = @"Delete Bench";
            public static LocalizedString duplicatecraft = @"Duplicate";
            public static LocalizedString duplicateingredient = @"Duplicate";
            public static LocalizedString general = @"General";
            public static LocalizedString ingredientitem = @"Item:";
            public static LocalizedString ingredientlistitem = @"Ingredient: {00} x{01}";
            public static LocalizedString ingredientnone = @"None";
            public static LocalizedString ingredientquantity = @"Quantity:";
            public static LocalizedString ingredients = @"Ingredients";
            public static LocalizedString item = @"Item:";
            public static LocalizedString name = @"Name:";
            public static LocalizedString New = @"New Bench";
            public static LocalizedString newcraft = @"New";
            public static LocalizedString newingredient = @"New";
            public static LocalizedString paste = @"Paste Bench";
            public static LocalizedString save = @"Save";
            public static LocalizedString time = @"Time (ms):";
            public static LocalizedString title = @"Crafting Bench Editor";
            public static LocalizedString undo = @"Undo Changes";
            public static LocalizedString undoprompt = @"Are you sure you want to undo changes made to this bench? This action cannot be reverted!";
            public static LocalizedString undotitle = @"Undo Changes";
        }

        public struct Directions
        {
            public static Dictionary<int, LocalizedString> dir = new Dictionary<int, LocalizedString>()
            {
                {-1, @"Retain Direction"},
                {0, @"Up"},
                {1, @"Down"},
                {2, @"Left"},
                {3, @"Right"}
            };
        }
        
        public struct DynamicRequirements
        {
            public static LocalizedString addcondition = @"Add Condition";
            public static LocalizedString addlist = @"Add List";
            public static LocalizedString cancelconditions = @"Cancel";
            public static LocalizedString cancellists = @"Cancel";
            public static LocalizedString conditioneditor = @"Add/Edit Condition";
            public static LocalizedString conditionlist = @"Condition List";
            public static LocalizedString conditionlists = @"Condition Lists";
            public static LocalizedString instructionsevent = @"Below are condition lists. If conditions are met on any of the lists then the event can spawn/run.";
            public static LocalizedString instructionsitem = @"Below are condition lists. If conditions are met on any of the lists then the player can use the item.";
            public static LocalizedString instructionsquest = @"Below are condition lists. If conditions are met on any of the lists then the player can start the quest.";
            public static LocalizedString instructionsresource = @"Below are condition lists. If conditions are met on any of the lists then the player can harvest the resource.";
            public static LocalizedString instructionsspell = @"Below are condition lists. If conditions are met on any of the lists then the player can use cast the spell.";
            public static LocalizedString listname = @"Name:";
            public static LocalizedString removecondition = @"Remove Condition";
            public static LocalizedString removelist = @"Remove List";
            public static LocalizedString saveconditions = @"Okay";
            public static LocalizedString savelists = @"Save";
            public static LocalizedString title = @"Dynamic Requirements";
        }

        public struct Errors
        {
            public static LocalizedString disconnected = @"Disconnected!";
            public static LocalizedString disconnectedclosing = @"You have lost connection to the server. The editor will now close.";
            public static LocalizedString disconnectedsave = @"You have been disconnected from the server! Would you like to export this map before closing this editor?";
            public static LocalizedString disconnectedsavecaption = @"Disconnected -- Export Map?";
            public static LocalizedString importfailed = @"Cannot import map. Currently selected map is not an Intersect map file or was exported with a different version of the Intersect editor!";
            public static LocalizedString importfailedcaption = @"Failed to import map!";
        }

        public struct EventChangeFace
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Face:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Change Face";
        }

        public struct EventChangeGender
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString[] genders = new LocalizedString[]
            {
                @"Male",
                @"Female"
            };
            public static LocalizedString label = @"Gender:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Change Gender";
        }

        public struct EventChangeItems
        {
            public static LocalizedString action = @"Action:";
            public static LocalizedString[] actions = new LocalizedString[]
            {
                @"Give",
                @"Take",
            };
            public static LocalizedString amount = @"Amount:";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString item = @"Item:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Change Player Items";
        }

        public struct EventChangeLevel
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Set Level:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Change Level";
        }

        public struct EventChangeSpells
        {
            public static LocalizedString action = @"Action: ";
            public static LocalizedString[] actions = new LocalizedString[]
            {
                @"Add",
                @"Remove,"
            };
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString spell = @"Spell: ";
            public static LocalizedString title = @"Change Player Spells";
        }

        public struct EventChangeSprite
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Sprite:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Change Sprite";
        }

        public struct EventChatboxText
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString channel = @"Channel:";
            public static LocalizedString[] channels = new LocalizedString[]
            {
                @"Player",
                @"Local",
                @"Global",
            };
            public static LocalizedString color = @"Color:";
            public static LocalizedString commands = @"Chat Commands";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString text = @"Text:";
            public static LocalizedString title = @"Add Chatbox Text";
        }

        public struct EventCommandList
        {
            public static LocalizedString addvariable = @"Add {00}";
            public static LocalizedString admin = @"Owner/Developer";
            public static LocalizedString animationonevent = @"On Event #{00} {01} [X Offset: {02} Y Offset: {03} {04}]";
            public static LocalizedString animationonmap = @"[On Map {00} X: {01} Y: {02} Dir: {03}]";
            public static LocalizedString animationonplayer = @"On Player [X Offset: {00} Y Offset: {01} {02}]";
            public static LocalizedString animationrelativedir = @"Spawn Relative To Direction";
            public static LocalizedString animationrelativerotate = @"Spawn And Rotate Relative To Direction";
            public static LocalizedString animationrotatedir = @"Rotate Relative To Direction";
            public static LocalizedString changeitems = @"Change Player Items [{00}]";
            public static LocalizedString changespells = @"Change Player Spells [{00}]";
            public static LocalizedString chatboxtext = @"Show Chatbox Text [Channel: {00}, Color: {01}] - {02}";
            public static LocalizedString chatglobal = @"Global";
            public static LocalizedString chatlocal = @"Local";
            public static LocalizedString chatplayer = @"Player";
            public static LocalizedString commonevent = @"Start Common Event: {00}";
            public static LocalizedString completetask = @"Complete Quest Task [Quest: {00}, Task: {01}]";
            public static LocalizedString conditionalbranch = @"Conditional Branch: [{00}]";
            public static LocalizedString conditionalelse = @"Else";
            public static LocalizedString conditionalend = @"End Branch";
            public static LocalizedString deletedevent = @"Deleted Event!";
            public static LocalizedString despawnnpcs = @"Despawn NPCs";
            public static LocalizedString enditemchange = @"End Item Change";
            public static LocalizedString endoptions = @"End Options";
            public static LocalizedString endquest = @"End Quest [{00}, {01}]";
            public static LocalizedString endspell = @"End Spell Change";
            public static LocalizedString endstartquest = @"End Start Quest";
            public static LocalizedString exitevent = @"Exit Event Processing";
            public static LocalizedString fadeoutbgm = @"Fadeout BGM";
            public static LocalizedString False = @"False";
            public static LocalizedString female = @"Female";
            public static LocalizedString forcedstart = @"Forced Start";
            public static LocalizedString forget = @"Remove: Spell {00}";
            public static LocalizedString give = @"Give: Item {00}";
            public static LocalizedString giveexp = @"Give Player {00} Experience";
            public static LocalizedString globalswitch = @"Set Global Switch {00} to {01}";
            public static LocalizedString globalvariable = @"Set Global Variable {00} ({01})";
            public static LocalizedString gotolabel = @"Go to Label {00}";
            public static LocalizedString holdplayer = @"Hold Player";
            public static LocalizedString invalid = @"Invalid Command";
            public static LocalizedString itemnotchanged = @"Item(s) Not Given/Taken (Doesn't have/Inventory full)";
            public static LocalizedString itemschanged = @"Item(s) Given/Taken Successfully";
            public static LocalizedString label = @"Label: {00}";
            public static LocalizedString levelup = @"Level Up Player";
            public static LocalizedString linestart = @"@>";
            public static LocalizedString male = @"Male";
            public static LocalizedString mapnotfound = @"NOT FOUND";
            public static LocalizedString moderator = @"Moderator";
            public static LocalizedString moveroute = @"Set Move Route for {00}";
            public static LocalizedString moverouteevent = @"Event #{00} {01}";
            public static LocalizedString moverouteplayer = @"Player";
            public static LocalizedString notcommon = @"Cannot use this command in common events.";
            public static LocalizedString notcommoncaption = @"Common Event Warning!";
            public static LocalizedString openbank = @"Open Bank";
            public static LocalizedString opencrafting = @"Open Crafting Bench [{00}]";
            public static LocalizedString openshop = @"Open Shop [{00}]";
            public static LocalizedString playanimation = @"Play Animation {00} {01}";
            public static LocalizedString playbgm = @"Play BGM [File: {00}]";
            public static LocalizedString playerswitch = @"Set Player Switch {00} to {01}";
            public static LocalizedString playervariable = @"Set Player Variable {00} ({01})";
            public static LocalizedString playsound = @"Play Sound [File: {00}]";
            public static LocalizedString questnotstarted = @"Quest Declined or Failed to Start (Reqs not met, already started, etc)";
            public static LocalizedString queststarted = @"Quest Accepted/Started Successfully";
            public static LocalizedString randvariable = @"Random Number {00} to {01}";
            public static LocalizedString regularuser = @"Regulator User";
            public static LocalizedString releaseplayer = @"Release Player";
            public static LocalizedString restorehp = @"Restore Player HP";
            public static LocalizedString restoremp = @"Restore Player MP";
            public static LocalizedString runcompletionevent = @"Running Completion Event";
            public static LocalizedString selfswitch = @"Set Self Switch {00} to {01}";
            public static LocalizedString[] selfswitches = new LocalizedString[]
            {
                @"A",
                @"B",
                @"C",
                @"D",
            };
            public static LocalizedString setaccess = @"Set Player Access to {00}";
            public static LocalizedString setclass = @"Set Class [{00}]";
            public static LocalizedString setface = @"Set Player Face to {00}";
            public static LocalizedString setgender = @"Set Player Gender to {00}";
            public static LocalizedString setlevel = @"Set Player Level To: {00}";
            public static LocalizedString setsprite = @"Set Player Sprite to {00}";
            public static LocalizedString setvariable = @"Set to {00}";
            public static LocalizedString showoffer = @"Show Offer Window";
            public static LocalizedString showoptions = @"Show Options: {00}";
            public static LocalizedString showtext = @"Show Text: {00}";
            public static LocalizedString skipcompletionevent = @"Without Running Completion Event";
            public static LocalizedString spawnnpc = @"Spawn Npc {00} {01}";
            public static LocalizedString spawnonevent = @"On Event #{00} {01} [X Offset: {02} Y Offset: {03} Dir: {04}]";
            public static LocalizedString spawnonmap = @"[On Map {00} X: {01} Y: {02} Dir: {03}]";
            public static LocalizedString spawnonplayer = @"On Player [X Offset: {00} Y Offset: {01} Dir: {02}]";
            public static LocalizedString spellfailed = @"Spell Not Taught/Moved (Already Knew/Spellbook full/Didn't Know)";
            public static LocalizedString spellsucceeded = @"Spell Taught/Removed Successfully";
            public static LocalizedString startquest = @"Start Quest [{00}, {01}]";
            public static LocalizedString stopsounds = @"Stop Sounds";
            public static LocalizedString subtractvariable = @"Subtract {00}";
            public static LocalizedString take = @"Take: Item {00}";
            public static LocalizedString taskundefined = @"Undefined";
            public static LocalizedString teach = @"Teach: Spell {00}";
            public static LocalizedString True = @"True";
            public static LocalizedString unknown = @"Unknown Command";
            public static LocalizedString unknownrole = @"Unknown Access";
            public static LocalizedString wait = @"Wait {00}ms";
            public static LocalizedString waitforroute = @"Wait for Move Route Completion of {00}";
            public static LocalizedString warp = @"Warp Player [Map: {00} X: {01} Y: {02} Dir: {03}]";
            public static LocalizedString whenoption = @"When [{00}]";
        }

        public struct EventCommands
        {
            public static Dictionary<string, string> commands = new Dictionary<string, string>()
            {
                {"addchatboxtext", @"Add Chatbox Text"},
                {"changeclass", @"Change Class"},
                {"changeface", @"Change Face"},
                {"changegender", @"Change Gender"},
                {"changeitems", @"Change Items"},
                {"changelevel", @"Change Level"},
                {"changespells", @"Change Spells"},
                {"changesprite", @"Change Sprite"},
                {"completequesttask", @"Complete Quest Task"},
                {"conditionalbranch", @"Conditional Branch"},
                {"despawnnpcs", @"Despawn NPC"},
                {"dialogue", @"Dialogue"},
                {"endquest", @"End Quest"},
                {"etc", @"Etc"},
                {"exiteventprocess", @"Exit Event Process"},
                {"fadeoutbgm", @"Fadeout BGM"},
                {"giveexperience", @"Give Experience"},
                {"gotolabel", @"Go To Label"},
                {"holdplayer", @"Hold Player"},
                {"label", @"Label"},
                {"levelup", @"Level Up"},
                {"logicflow", @"Logic Flow"},
                {"movement", @"Movement"},
                {"openbank", @"Open Bank"},
                {"opencraftingstation", @"Open Crafting Station"},
                {"openshop", @"Open Shop"},
                {"playanimation", @"Play Animation"},
                {"playbgm", @"Play BGM"},
                {"playercontrol", @"Player Control"},
                {"playsound", @"Play Sound"},
                {"questcontrol", @"Quest Control"},
                {"releaseplayer", @"Release Player"},
                {"restorehp", @"Restore HP"},
                {"restoremp", @"Restore MP"},
                {"setaccess", @"Set Access"},
                {"setmoveroute", @"Set Move Route"},
                {"setselfswitch", @"Set Self Switch"},
                {"setswitch", @"Set Switch"},
                {"setvariable", @"Set Variable"},
                {"shopandbank", @"Shop and Bank"},
                {"showoptions", @"Show Options"},
                {"showtext", @"Show Text"},
                {"spawnnpc", @"Spawn NPC"},
                {"specialeffects", @"Special Effects"},
                {"startcommonevent", @"Start Common Event"},
                {"startquest", @"Start Quest"},
                {"stopsounds", @"Stop Sounds"},
                {"wait", @"Wait..."},
                {"waitmoveroute", @"Wait for Route Completion"},
                {"warpplayer", @"Warp Player"},
            };
        }

        public struct EventCompleteQuestTask
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString quest = @"Quest:";
            public static LocalizedString task = @"Task:";
            public static LocalizedString title = @"Complete Quest Task";
        }

        public struct EventConditional
        {
            public static LocalizedString and = @"And";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString canstartquest = @"Can Start Quest";
            public static LocalizedString Class = @"Class:";
            public static LocalizedString classis = @"Class Is";
            public static LocalizedString command = @"/command:   /";
            public static LocalizedString commandis = @"/command is...";
            public static LocalizedString commoneventsonly = @"This condition works for Common Events activation only!";
            public static LocalizedString comparator = @"Comparator:";
            public static LocalizedString[] comparators = new LocalizedString[]
            {
                @"Equal To",
                @"Greater Than or Equal To",
                @"Greater Than",
                @"Less Than",
                @"Does Not Equal"
            };

            public static LocalizedString[] conditions = new LocalizedString[]
            {
                @"Player Switch is...",
                @"Player Variable is...",
                @"Global Switch is...",
                @"Global Variable is...",
                @"Has item...",
                @"Class is...",
                @"Knows spell...",
                @"Level or Stat is....",
                @"Self Switch is....",
                @"Power level is....",
                @"Time is between....",
                @"Can Start Quest....",
                @"Quest In Progress....",
                @"Quest Completed....",
                @"Player Death",
                @"No NPCs on Map",
                @"Gender is...",
                @"/command is...",
            };
            public static LocalizedString endrange = @"End Range:";
            public static LocalizedString False = @"False";
            public static LocalizedString female = @"Female";
            public static LocalizedString gender = @"Gender:";
            public static LocalizedString genderis = @"Gender Is..";
            public static LocalizedString globalswitch = @"Global Switch";
            public static LocalizedString globalvariable = @"Global Variable";
            public static LocalizedString hasatleast = @"Has at least:";
            public static LocalizedString hasitem = @"Has Item";
            public static LocalizedString item = @"Item:";
            public static LocalizedString knowsspell = @"Knows Spell";
            public static LocalizedString level = @"Level";
            public static LocalizedString levelorstat = @"Level or Stat Is....";
            public static LocalizedString levelstatitem = @"Level or Stat:";
            public static LocalizedString levelstatvalue = @"Value:";
            public static LocalizedString male = @"Male";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString playerswitch = @"Player Switch";
            public static LocalizedString playervariable = @"Player Variable";
            public static LocalizedString power = @"Power:";
            public static LocalizedString power0 = @"Mod or Admin";
            public static LocalizedString power1 = @"Admin";
            public static LocalizedString poweris = @"Power Is";
            public static LocalizedString[] questcomparators = new LocalizedString[]
            {
                @"On Any Task",
                @"Before Task...",
                @"After Task...",
                @"On Task...",
            };
            public static LocalizedString questcompleted = @"Quest Completed";
            public static LocalizedString questcompletedlabel = @"Quest:";
            public static LocalizedString questinprogress = @"Quest In Progress";
            public static LocalizedString questis = @"Is:";
            public static LocalizedString questprogress = @"Quest:";
            public static LocalizedString selfswitch = @"Self Switch:";
            public static LocalizedString[] selfswitches = new LocalizedString[]
            {
                @"A",
                @"B",
                @"C",
                @"D",
            };
            public static LocalizedString selfswitchis = @"Self Switch Is";
            public static LocalizedString spell = @"Spell:";
            public static LocalizedString startquest = @"Quest:";
            public static LocalizedString startrange = @"Start Range:";
            public static LocalizedString Switch = @"Switch:";
            public static LocalizedString switchis = @"Is";
            public static LocalizedString task = @"Task:";
            public static LocalizedString time = @"Time is between:";
            public static LocalizedString title = @"Conditional";
            public static LocalizedString to = @"to";
            public static LocalizedString True = @"True";
            public static LocalizedString type = @"Condition Type:";
            public static LocalizedString value = @"Value:";
            public static LocalizedString variable = @"Variable:";
        }

        public struct EventConditionDesc
        {
            public static LocalizedString admin = @"Admin";
            public static LocalizedString aftertask = @", After Task: {00}";
            public static LocalizedString beforetask = @", Before Task: {00}";
            public static LocalizedString Class = @"Player's class is {00}";
            public static LocalizedString equal = @"is equal to {00}";
            public static LocalizedString False = @"False";
            public static LocalizedString female = @"Female";
            public static LocalizedString gender = @"Player's Gender is {00}";
            public static LocalizedString globalswitch = @"Global Switch {00} is {01}";
            public static LocalizedString globalvariable = @"Global Variable {00} {01}";
            public static LocalizedString greater = @"is greather than {00}";
            public static LocalizedString greaterequal = @"is greater than or equal to {00}";
            public static LocalizedString hasitem = @"Player has at least {00} of Item {01}";
            public static LocalizedString knowsspell = @"Player knows Spell {00}";
            public static LocalizedString lessthan = @"is less than {00}";
            public static LocalizedString lessthanequal = @"is less than or equal to {00}";
            public static LocalizedString level = @"Level";
            public static LocalizedString levelorstat = @"{00} {01}";
            public static LocalizedString male = @"Male";
            public static LocalizedString modadmin = @"Mod or Admin";
            public static LocalizedString nonpcsonmap = @"No NPCs on the map";
            public static LocalizedString notequal = @"does not equal {00}";
            public static LocalizedString onanytask = @", On Any Task";
            public static LocalizedString ontask = @", On Task: {00}";
            public static LocalizedString playerdeath = @"Player Death";
            public static LocalizedString playerswitch = @"Player Switch {00} is {01}";
            public static LocalizedString playervariable = @"Player Variable {00} {01}";
            public static LocalizedString power = @"Player's Power is {00}";
            public static LocalizedString questcompleted = @"Quest is Completed: {00}";
            public static LocalizedString questinprogress = @"Quest In Progress: {00} {01}";
            public static LocalizedString selfswitch = @"Self Switch {00} is {01}";
            public static LocalizedString[] selfswitches = new LocalizedString[]
            {
                @"A",
                @"B",
                @"C",
                @"D",
            };
            public static LocalizedString startquest = @"Can Start Quest: {00}";
            public static LocalizedString tasknotfound = @"Not Found";
            public static LocalizedString time = @"Time is between {00} and {01}";
            public static LocalizedString timeinvalid = @"invalid";
            public static LocalizedString True = @"True";
        }

        public struct EventEditor
        {
            public static LocalizedString addcommand = @"Add Commands";
            public static LocalizedString animation = @"Animation";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString clearpage = @"Clear Page";
            public static LocalizedString command = @"/Command: /";
            public static LocalizedString commandlist = @"Commands:";
            public static LocalizedString[] commontriggers = new LocalizedString[]
            {
                @"None",
                @"Login",
                @"Level Up",
                @"On Respawn",
                @"/Command",
                @"Autorun",
            };
            public static LocalizedString conditions = @"Conditions";
            public static LocalizedString copypage = @"Copy Page";
            public static LocalizedString deletecommand = @"Delete";
            public static LocalizedString deletepage = @"Delete Page";
            public static LocalizedString directionfix = @"Dir Fix";
            public static LocalizedString disableinspector = @"Disable Inspector";
            public static LocalizedString editcommand = @"Edit";
            public static LocalizedString editconditions = @"Spawn/Execution Conditions";
            public static LocalizedString entityoptions = @"Entity Options";
            public static LocalizedString eventpreview = @"Preview";
            public static LocalizedString extras = @"Extras:";
            public static LocalizedString face = @"Face:";
            public static LocalizedString frequency = @"Freq:";
            public static LocalizedString[] frequencies = new LocalizedString[]
            {
                @"Not Very Often",
                @"Not Often",
                @"Normal",
                @"Often",
                @"Very Often",
            };
            public static LocalizedString general = @"General";
            public static LocalizedString global = @"Global Event";
            public static LocalizedString hidename = @"Hide Name";
            public static LocalizedString insertcommand = @"Insert";
            public static LocalizedString inspector = @"Entity Inspector Options";
            public static LocalizedString inspectordesc = @"Inspector Description:";
            public static LocalizedString interactionfreeze = @"Interaction Freeze";
            public static LocalizedString layer = @"Layer:";
            public static LocalizedString[] layers = new LocalizedString[]
            {
                @"Below Player",
                @"Same as Player",
                @"Above Player",
            };
            public static LocalizedString movement = @"Movement";
            public static LocalizedString movementtype = @"Type:";
            public static LocalizedString[] movementtypes = new LocalizedString[]
            {
                @"None",
                @"Random",
                @"Move Route",
            };
            public static LocalizedString name = @"Name:";
            public static LocalizedString newpage = @"New Page";
            public static LocalizedString pageoptions = @"Page Options";
            public static LocalizedString passable = @"Passable";
            public static LocalizedString pastepage = @"Paste Page";
            public static LocalizedString projectile = @"Projectile:";
            public static LocalizedString save = @"Save";
            public static LocalizedString savecaption = @"Save Event?";
            public static LocalizedString savedialogue = @"Do you want to save changes to this event?";
            public static LocalizedString setroute = @"Set Route...";
            public static LocalizedString speed = @"Speed:";
            public static LocalizedString[] speeds = new LocalizedString[]
            {
                @"Slowest",
                @"Slower",
                @"Normal",
                @"Faster",
                @"Fastest",
            };
            public static LocalizedString title = @"Event Editor - Event #{00}: {01}";
            public static LocalizedString trigger = @"Trigger";
            public static LocalizedString[] triggers = new LocalizedString[]
            {
                @"Action Button",
                @"Player Touch",
                @"Autorun",
            };
            public static LocalizedString walkinganim = @"Walking Anim";
        }

        public struct EventEndQuest
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Quest:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString skipcompletion = @"Do not run completion event?";
            public static LocalizedString title = @"End Quest";
        }

        public struct EventGiveExperience
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Give Experience:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Give Experience";
        }

        public struct EventGotoLabel
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Label:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Go To Label";
        }

        public struct EventGraphic
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString graphic = @"Graphic:";
            public static LocalizedString graphictype0 = @"None";
            public static LocalizedString graphictype1 = @"Sprite";
            public static LocalizedString graphictype2 = @"Tileset";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString preview = @"Graphic Preview";
            public static LocalizedString title = @"Graphic Selector";
            public static LocalizedString type = @"Graphic Type:";
        }

        public struct EventLabel
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Label:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Label";
        }

        public struct EventMoveRoute
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString command = @"Commands";
            public static Dictionary<string, LocalizedString> commands = new Dictionary<string, LocalizedString>()
            {
                {"directionfixoff", @"Direction Fix: Off"},
                {"directionfixon", @"Direction Fix: On"},
                {"etc", @"Etc"},
                {"facedown", @"Face Down"},
                {"faceleft", @"Face Left"},
                {"faceright", @"Face Right"},
                {"faceup", @"Face Up"},
                {"faster", @"Faster"},
                {"fastest", @"Fastest"},
                {"frequencynormal", @"Normal"},
                {"hidename", @"Hide Name"},
                {"higher", @"Higher"},
                {"highest", @"Highest"},
                {"lower", @"Lower"},
                {"lowest", @"Lowest"},
                {"move", @"Move"},
                {"moveawayfromplayer", @"Move Away From Player"},
                {"movedown", @"Move Down"},
                {"moveleft", @"Move Left"},
                {"moverandomly", @"Move Randomly"},
                {"moveright", @"Move Right"},
                {"movetowardplayer", @"Move Toward Player"},
                {"moveup", @"Move Up"},
                {"setanimation", @"Set Animation..."},
                {"setattribute", @"Set Attribute"},
                {"setgraphic", @"Set Graphic..."},
                {"setlayerabove", @"Set Layer: Above Player"},
                {"setlayerbelow", @"Set Layer: Below Player"},
                {"setlayersame", @"Set Layer: Same as Player"},
                {"setmovementfrequency", @"Set Movement Frequency"},
                {"setspeed", @"Set Speed"},
                {"showname", @"Show Name"},
                {"slower", @"Slower"},
                {"slowest", @"Slowest"},
                {"speednormal", @"Normal"},
                {"stepbackward", @"Step Backward"},
                {"stepforward", @"Step Forward"},
                {"turn", @"Turn"},
                {"turn180", @"Turn 180*"},
                {"turn90clockwise", @"Turn 90* Clockwise"},
                {"turn90counterclockwise", @"Turn 90* Counter Clockwise"},
                {"turnawayfromplayer", @"Turn Away From Player"},
                {"turnrandomly", @"Turn Randomly"},
                {"turntowardplayer", @"Turn Toward Player"},
                {"wait100", @"Wait 100ms"},
                {"wait1000", @"Wait 1000ms"},
                {"wait500", @"Wait 500ms"},
                {"walkinganimoff", @"Walking Animation: Off"},
                {"walkinganimon", @"Walking Animation: On"},
                {"walkthroughoff", @"Walkthrough: Off"},
                {"walkthroughon", @"Walkthrough: On"},
            };
            public static LocalizedString ignoreblocked = @"Ignore if Blocked";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString player = @"Player";
            public static LocalizedString repeatroute = @"Repeat Route";
            public static LocalizedString thisevent = @"[THIS EVENT]";
            public static LocalizedString title = @"Move Route";

        }

        public struct EventOpenBench
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Bench:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Open Bench";
        }

        public struct EventOpenShop
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Shop:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Open Shop";
        }

        public struct EventPlayAnimation
        {
            public static LocalizedString animation = @"Animation:";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString entity = @"Entity:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString player = @"Player";
            public static LocalizedString relativelocation = @"Relative Location:";
            public static LocalizedString rotaterelative = @"Rotate Relative to Direction";
            public static LocalizedString spawnrelative = @"Spawn Relative to Direction";
            public static LocalizedString spawntype = @"Spawn Type:";
            public static LocalizedString spawntype0 = @"Specific Tile";
            public static LocalizedString spawntype1 = @"On/Around Entity";
            public static LocalizedString This = @"[THIS EVENT]";
            public static LocalizedString title = @"Play Animation";
        }

        public struct EventPlayBgm
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"BGM:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Play BGM";
        }

        public struct EventPlayBgs
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Sound:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Play BGS";
        }

        public struct EventSelfSwitch
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString False = @"False";
            public static LocalizedString label = @"Set Self Switch:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString[] selfswitches = new LocalizedString[]
            {
                @"A",
                @"B",
                @"C",
                @"D",
            };
            public static LocalizedString title = @"Set Self Switch";
            public static LocalizedString True = @"True";
        }

        public struct EventSetAccess
        {
            public static LocalizedString access0 = @"Regular User";
            public static LocalizedString access1 = @"In-Game Moderator";
            public static LocalizedString access2 = @"Owner/Designer (Allows editor access)";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Access:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Set Access";
        }

        public struct EventSetAnimation
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Animation:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Set Animation";
        }

        public struct EventSetClass
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Class:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Set Class";
        }

        public struct EventSetSwitch
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString False = @"False";
            public static LocalizedString global = @"Global Switch";
            public static LocalizedString label = @"Set Switch:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString player = @"Player Switch";
            public static LocalizedString title = @"Set Switch";
            public static LocalizedString to = @"to";
            public static LocalizedString True = @"True";
        }

        public struct EventSetVariable
        {
            public static LocalizedString add = @"Add";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString global = @"Global Variable";
            public static LocalizedString label = @"Variable:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString player = @"Player Variable";
            public static LocalizedString random = @"Random";
            public static LocalizedString randomhigh = @"High:";
            public static LocalizedString randomlow = @"Low:";
            public static LocalizedString set = @"Set";
            public static LocalizedString subtract = @"Subtract";
            public static LocalizedString title = @"Set Variable";
        }

        public struct EventShowOptions
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString commands = @"Chat Commands";
            public static LocalizedString face = @"Face:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString option1 = @"Option 1";
            public static LocalizedString option2 = @"Option 2";
            public static LocalizedString option3 = @"Option 3";
            public static LocalizedString option4 = @"Option 4";
            public static LocalizedString text = @"Text:";
            public static LocalizedString title = @"Show Options";
        }

        public struct EventShowText
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString commands = @"Chat Commands";
            public static LocalizedString face = @"Face:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString text = @"Text:";
            public static LocalizedString title = @"Show Text";
        }

        public struct EventSpawnNpc
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString entity = @"Entity:";
            public static LocalizedString npc = @"NPC:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString player = @"Player";
            public static LocalizedString relativelocation = @"Relative Location:";
            public static LocalizedString spawnrelative = @"Relative to Entity Direction";
            public static LocalizedString spawntype = @"Spawn Type:";
            public static LocalizedString spawntype0 = @"Specific Tile";
            public static LocalizedString spawntype1 = @"On/Around Entity";
            public static LocalizedString This = @"[THIS EVENT]";
            public static LocalizedString title = @"Spawn Npc";
        }

        public struct EventStartCommonEvent
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Common Event:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Start Common Event";
        }

        public struct EventStartQuest
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Quest:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString showwindow = @"Show Offer Window?";
            public static LocalizedString title = @"Start Quest";
        }

        public struct EventWait
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Wait (ms):";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Wait";
        }

        public struct EventWaitForRouteCompletion
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString label = @"Entity:";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString player = @"Player";
            public static LocalizedString This = @"[THIS EVENT]";
            public static LocalizedString title = @"Wait for Move Route Completion";
        }

        public struct EventWarp
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Warp";
        }

        public struct General
        {
            public static LocalizedString none = @"None";
        }

        public struct ItemEditor
        {
            public static LocalizedString abilitypowerbonus = @"Ability Pwr:";
            public static LocalizedString animation = @"Animation:";
            public static LocalizedString attackanimation = @"Attack Animation:";
            public static LocalizedString attackbonus = @"Attack:";
            public static LocalizedString bagpanel = @"Bag:";
            public static LocalizedString bagslots = @"Bag Slots:";
            public static LocalizedString basedamage = @"Base Damage:";
            public static LocalizedString bonusamount = @"Effect Amount (%):";
            public static LocalizedString bonuseffect = @"Bonus Effect:";
            public static LocalizedString[] bonuseffects = new LocalizedString[]
            {
                @"None",
                @"Cooldown Reduction",
                @"Life Steal",
            };
            public static LocalizedString bonuses = @"Stat Bonuses";
            public static LocalizedString bonusrange = @"Stat Bonus Range (+-):";
            public static LocalizedString bound = @"Bound?";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString consumeablepanel = @"Consumable";
            public static LocalizedString consumeinterval = @"Interval:";
            public static LocalizedString copy = @"Copy Item";
            public static LocalizedString critchance = @"Crit Chance (%):";
            public static LocalizedString damagetype = @"Damage Type:";
            public static LocalizedString defensebonus = @"Defense:";
            public static LocalizedString delete = @"Delete Item";
            public static LocalizedString deleteprompt = @"Are you sure you want to delete this item? This action cannot be reverted!";
            public static LocalizedString deletetitle = @"Delete Item";
            public static LocalizedString description = @"Desc:";
            public static LocalizedString equipment = @"Equipment";
            public static LocalizedString Event = @"Event:";
            public static LocalizedString eventpanel = @"Event";
            public static LocalizedString femalepaperdoll = @"Female Paperdoll:";
            public static LocalizedString general = @"General";
            public static LocalizedString items = @"Items";
            public static LocalizedString magicresistbonus = @"Magic Resist:";
            public static LocalizedString malepaperdoll = @"Male Paperdoll:";
            public static LocalizedString name = @"Name:";
            public static LocalizedString New = @"New Item";
            public static LocalizedString paste = @"Paste Item";
            public static LocalizedString picture = @"Pic:";
            public static LocalizedString price = @"Price:";
            public static LocalizedString projectile = @"Projectile:";
            public static LocalizedString requirements = @"Edit Usage Requirements";
            public static LocalizedString save = @"Save";
            public static LocalizedString scalingamount = @"Scaling Amount (%):";
            public static LocalizedString scalingstat = @"Scaling Stat:";
            public static LocalizedString slot = @"Equipment Slot:";
            public static LocalizedString speedbonus = @"Speed:";
            public static LocalizedString spell = @"Spell:";
            public static LocalizedString spellpanel = @"Spell";
            public static LocalizedString stackable = @"Stackable?";
            public static LocalizedString title = @"Item Editor";
            public static LocalizedString tooltype = @"Tool Type:";
            public static LocalizedString twohanded = @"2 Hand";
            public static LocalizedString type = @"Type:";
            public static LocalizedString[] types = new LocalizedString[]
            {
                @"None",
                @"Equipment",
                @"Consumable",
                @"Currency",
                @"Spell",
                @"Event",
                @"Bag",
            };
            public static LocalizedString undo = @"Undo Changes";
            public static LocalizedString undoprompt = @"Are you sure you want to undo changes made to this item? This action cannot be reverted!";
            public static LocalizedString undotitle = @"Undo Changes";
            public static LocalizedString vital = @"Vital:";
            public static LocalizedString weaponproperties = @"Weapon Properties";
        }

        public struct LightEditor
        {
            public static LocalizedString color = @"Color:";
            public static LocalizedString expandamt = @"Expand Amt:";
            public static LocalizedString intensity = @"Intensity:";
            public static LocalizedString revert = @"Revert";
            public static LocalizedString save = @"Save";
            public static LocalizedString selectcolor = @"Select Color";
            public static LocalizedString size = @"Size:";
            public static LocalizedString title = @"Light Editor";
            public static LocalizedString xoffset = @"Offset X:";
            public static LocalizedString yoffset = @"Offset Y:";
        }

        public struct Login
        {
            public static LocalizedString connected = @"Connected to server. Ready to login!";
            public static LocalizedString connecting = @"Connecting to server...";
            public static LocalizedString failedtoconnect = @"Failed to connect, retrying in {00} seconds.";
            public static LocalizedString gettingstarted = @"Getting Started?
        1. Start the Intersect Server
        2. Open the Intersect Client and Create an Account
        3. Login to that account here to start designing your game!";
            public static LocalizedString login = @"Login";
            public static LocalizedString password = @"Password: ";
            public static LocalizedString raptr = @"Please close AMD Gaming Evolved before logging into the Intersect editor.";
            public static LocalizedString rememberme = @"Remember Me";
            public static LocalizedString title = @"Intersect Editor Login";
            public static LocalizedString username = @"Username: ";
            public static LocalizedString version = @"Editor v{00}";
        }

        public struct MainForm
        {
            public static LocalizedString about = @"About";
            public static LocalizedString alllayers = @"All Layers";
            public static LocalizedString animationeditor = @"Animation Editor";
            public static LocalizedString classeditor = @"Class Editor";
            public static LocalizedString commoneventeditor = @"Common Event Editor";
            public static LocalizedString copy = @"Copy";
            public static LocalizedString craftingbencheditor = @"Crafting Bench Editor";
            public static LocalizedString currentonly = @"Current Layer Only";
            public static LocalizedString cut = @"Cut";
            public static LocalizedString darkness = @"Darkness";
            public static LocalizedString donate = @"Buy the devs a coffee :)";
            public static LocalizedString droppler = @"Droppler Tool";
            public static LocalizedString edit = @"Edit";
            public static LocalizedString editors = @"Game Editors";
            public static LocalizedString erase = @"Erase";
            public static LocalizedString exit = @"Exit";
            public static LocalizedString exportmap = @"Export Map";
            public static LocalizedString externaltools = @"External Tools";
            public static LocalizedString file = @"File";
            public static LocalizedString fill = @"Fill";
            public static LocalizedString fog = @"Fog";
            public static LocalizedString fps = @"FPS: {00}";
            public static LocalizedString grid = @"Map Grid";
            public static LocalizedString help = @"Help";
            public static LocalizedString importmap = @"Import Map";
            public static LocalizedString itemeditor = @"Item Editor";
            public static LocalizedString lighting = @"Toggle Time of Day Simulation On/Off";
            public static LocalizedString loc = @"CurX: {00}  CurY: {01}";
            public static LocalizedString newmap = @"New Map";
            public static LocalizedString npceditor = @"Npc Editor";
            public static LocalizedString options = @"Options";
            public static LocalizedString overlay = @"Overlay";
            public static LocalizedString paste = @"Paste";
            public static LocalizedString pen = @"Pen Tool";
            public static LocalizedString postquestion = @"Post Question";
            public static LocalizedString projectileeditor = @"Projectile Editor";
            public static LocalizedString questeditor = @"Quest Editor";
            public static LocalizedString rectangle = @"Rectangle Tool";
            public static LocalizedString redo = @"Redo";
            public static LocalizedString reportbug = @"Report Bug";
            public static LocalizedString resourceeditor = @"Resource Editor";
            public static LocalizedString resources = @"Resources";
            public static LocalizedString revision = @"Revision: {00}";
            public static LocalizedString run = @"Run Client";
            public static LocalizedString savemap = @"Save Map";
            public static LocalizedString screenshot = @"Screenshot Map";
            public static LocalizedString selection = @"Selection Tool";
            public static LocalizedString selectlayers = @"Select...";
            public static LocalizedString shopeditor = @"Shop Editor";
            public static LocalizedString spelleditor = @"Spell Editor";
            public static LocalizedString switchvariableeditor = @"Switch and Variable Editor";
            public static LocalizedString tilepreview = @"Tile Preview";
            public static LocalizedString timeeditor = @"Time Editor";
            public static LocalizedString title = @"Intersect Editor - {00}";
            public static LocalizedString toolsdir = @"tools";
            public static LocalizedString undo = @"Undo";
            public static LocalizedString view = @"View";
        }

        public struct MapGrid
        {
            public static LocalizedString clearandfetch = @"Are you sure you want to clear the existing previews and fetch previews for each map on this grid? This could take several minutes based on the number of maps in this grid!";
            public static LocalizedString downloadall = @"Re-Download All Previews";
            public static LocalizedString downloadmissing = @"Download Missing Previews";
            public static LocalizedString fetchcaption = @"Fetch Preview?";
            public static LocalizedString fetchingmaps = @"Fetching Map Previews";
            public static LocalizedString fetchingprogress = @"Fetching Maps {00} / {01}";
            public static LocalizedString gridlines = @"Show/Hide Grid Lines";
            public static LocalizedString justfetch = @"Are you sure you want to fetch previews for each map? This could take several minutes based on the number of maps in this grid!";
            public static LocalizedString keepmapcache = @"Use your current settings with the map cache? (No to disable lighting/fogs/other effects)";
            public static LocalizedString link = @"Link Map";
            public static LocalizedString mapcachecaption = @"Map Cache Options";
            public static LocalizedString preview = @"Fetch Preview";
            public static LocalizedString recache = @"Recache Map";
            public static LocalizedString savescreenshotconfirm = @"Are you sure you want to save a screenshot of your world to a file? This could take several minutes!";
            public static LocalizedString savescreenshotdialogue = @"Save a screenshot of the world";
            public static LocalizedString savescreenshottitle = @"Save Screenshot?";
            public static LocalizedString savingrow = @"Saving Row: {00} / {01}";
            public static LocalizedString savingscreenshot = @"Saving Screenshot";
            public static LocalizedString screenshotworld = @"Take a world screenshot";
            public static LocalizedString title = @"Map Grid";
            public static LocalizedString unlink = @"Unlink Map";
            public static LocalizedString unlinkcaption = @"Unlink Map";
            public static LocalizedString unlinkprompt = @"Are you sure you want to unlink map {00}?";
        }

        public struct MapLayers
        {
            public static LocalizedString attributes = @"Attributes";
            public static LocalizedString eventinstructions = @"Double click a tile on the map to create an event!";
            public static LocalizedString events = @"Events";
            public static LocalizedString lightinstructions = @"Lower the maps brightness and double click on a tile to create a light!";
            public static LocalizedString lights = @"Lights";
            public static LocalizedString npcs = @"Npcs";
            public static LocalizedString tiles = @"Tiles";
            public static LocalizedString title = @"Map Layers";
        }

        public struct MapList
        {
            public static LocalizedString chronological = @"Order Chronologically";
            public static LocalizedString delete = @"Delete";
            public static LocalizedString deleteconfirm = @"Are you sure you want to delete {00}?";
            public static LocalizedString newfolder = @"New Folder";
            public static LocalizedString newmap = @"New Map";
            public static LocalizedString rename = @"Rename";
            public static LocalizedString selectcurrent = @"Select Current Map";
            public static LocalizedString selecttodelete = @"Please select a folder or map to delete.";
            public static LocalizedString selecttorename = @"Please select a folder or map to rename.";
            public static LocalizedString title = @"Map List";
        }

        public struct Mapping
        {
            public static LocalizedString createmap = @"Create new map.";
            public static LocalizedString createmapdialogue = @"Do you want to create a map here?";
            public static LocalizedString diagonalwarning = @"Cannot create maps diagonally!";
            public static LocalizedString editortitle = @"Map Editor";
            public static LocalizedString eraselayer = @"Erase Layer";
            public static LocalizedString eraselayerdialogue = @"Are you sure you want to erase this layer?";
            public static LocalizedString filllayer = @"Fill Layer";
            public static LocalizedString filllayerdialogue = @"Are you sure you want to fill this layer?";
            public static LocalizedString newmap = @"Are you sure you want to create a new, unconnected map?";
            public static LocalizedString newmapcaption = @"New Map";
            public static LocalizedString savemap = @"Save current map?";
            public static LocalizedString savemapdialogue = @"Do you want to save your current map?";
            public static LocalizedString savemapdialoguesure = @"Are you sure you want to save your current map?";
        }

        public struct MapProperties
        {
            public static Dictionary<string, string> categories = new Dictionary<string, string>()
            {
                {"General", @"General"},
                {"lighting", @"Lighting"},
                {"misc", @"Misc"},
                {"overlay", @"Overlay"},
            };
            public static Dictionary<string, string> displaynames = new Dictionary<string, string>()
            {
                {"ahue", @"AHue"},
                {"audio", @"Audio"},
                {"bhue", @"BHue"},
                {"brightness", @"Brightness"},
                {"fog", @"Fog"},
                {"fogalpha", @"Fog Alpha"},
                {"fogxspeed", @"Fog X Speed"},
                {"fogyspeed", @"Fog Y Speed"},
                {"ghue", @"GHue"},
                {"isindoors", @"Is Indoors"},
                {"music", @"Music"},
                {"name", @"Name"},
                {"overlaygraphic", @"Overlay Graphic"},
                {"panorama", @"Panorama"},
                {"playerlightcolor", @"Player Light Color"},
                {"playerlightexpand", @"Player Light Expand"},
                {"playerlightintensity", @"Player Light Intensity"},
                {"playerlightsize", @"Player Light Size"},
                {"rhue", @"RHue"},
                {"sound", @"Sound"},
                {"zonetype", @"Zone Type"},
            };
            public static Dictionary<string, string> descriptions = new Dictionary<string, string>()
            {
                {"ahuedesc", @"How strong the overlay appears. (Range: 0 [transparent/invisible] to 255 [solid/can't see map])"},
                {"bhuedesc", @"The amount of blue in the overlay. (Range: 0 to 255)"},
                {"brightnessdesc", @"How bright is this map? (Range: 0 to 100)."},
                {"fogalphadesc", @"How strong the fog overlay appears. (Range: 0 [transparent/invisible] to 255 [solid/can't see map])"},
                {"fogdesc", @"The overlayed image on the map. Generally used for fogs or sun beam effects."},
                {"fogxspeeddesc", @"Fog Horizontal Speed (Range: -5 to 5)"},
                {"fogyspeeddesc", @"Fog Vertical Speed (Range: -5 to 5)"},
                {"ghuedesc", @"The amount of green in the overlay. (Range: 0 to 255)"},
                {"isindoorsdesc", @"Is this map indoors?"},
                {"musicdesc", @"Looping background music for this map."},
                {"namedesc", @"The name of this map."},
                {"overlaygraphicdesc", @"This is an image that appears above the map. (Not shown in editor.)"},
                {"panormadesc", @"This is an image that appears behind the map. It can be seen where no tiles are placed."},
                {"playerlightcolordesc", @"Which color is the players light? (Default: White)"},
                {"playerlightexpanddesc", @"How far into the light does the effect start fading? (0.00 to 1.00)"},
                {"playerlightintensitydesc", @"How strong the light is at its brightest point. (0 to 255)"},
                {"playerlightsizedesc", @"How large is the light around the player? (In pixels 0-1000)"},
                {"rhuedesc", @"The amount of red in the overlay. (Range: 0 to 255)"},
                {"sounddesc", @"Looping sound effect for this map."},
                {"zonedesc", @"The type of map this is."},
            };
            public static LocalizedString title = @"Map Properties";
            public static LocalizedString[] zones = new LocalizedString[]
            {
                @"Normal",
                @"Safe",
                @"Arena",
            };
        }

        public struct NpcEditor
        {
            public static LocalizedString abilitypower = @"Ability Pwr:";
            public static LocalizedString addhostility = @"Add";
            public static LocalizedString addspell = @"Add";
            public static LocalizedString attack = @"Attack:";
            public static LocalizedString attackallies = @"Attack Allies?";
            public static LocalizedString attackanimation = @"Attack Animation:";
            public static LocalizedString basedamage = @"Base Damage:";
            public static LocalizedString behavior = @"Behavior:";
            public static LocalizedString[] behaviors = new LocalizedString[]
            {
                @"Attack when Attacked",
                @"Attack on Sight",
                @"Friendly",
                @"Guard",
             };
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString combat = @"Combat";
            public static LocalizedString copy = @"Copy Npc";
            public static LocalizedString critchance = @"Crit Chance (%):";
            public static LocalizedString damagetype = @"Damage Type:";
            public static LocalizedString defense = @"Defense:";
            public static LocalizedString delete = @"Delete Npc";
            public static LocalizedString deleteprompt = @"Are you sure you want to delete this npc? This action cannot be reverted!";
            public static LocalizedString deletetitle = @"Delete Item";
            public static LocalizedString dropamount = @"Drop Amount:";
            public static LocalizedString dropchance = @"Drop Chance (%):";
            public static LocalizedString dropindex = @"Drop Index: ";
            public static LocalizedString dropitem = @"Item:";
            public static LocalizedString drops = @"Drops";
            public static LocalizedString enabled = @"Enabled?";
            public static LocalizedString exp = @"Exp:";
            public static LocalizedString frequency = @"Freq:";
            public static LocalizedString[] frequencies = new LocalizedString[]
            {
                @"Not Very Often",
                @"Not Often",
                @"Normal",
                @"Often",
                @"Very Often",
            };
            public static LocalizedString general = @"General";
            public static LocalizedString hp = @"HP:";
            public static LocalizedString magicresist = @"Magic Resist:";
            public static LocalizedString mana = @"Mana:";
            public static LocalizedString name = @"Name:";
            public static LocalizedString New = @"New Npc";
            public static LocalizedString npc = @"NPC:";
            public static LocalizedString npcs = @"Npcs";
            public static LocalizedString npcvsnpc = @"NPC vs NPC Combat/Hostility  ";
            public static LocalizedString paste = @"Paste Npc";
            public static LocalizedString removehostility = @"Remove";
            public static LocalizedString removespell = @"Remove";
            public static LocalizedString save = @"Save";
            public static LocalizedString scalingamount = @"Scaling Amount (%):";
            public static LocalizedString scalingstat = @"Scaling Stat:";
            public static LocalizedString sightrange = @"Sight Range:";
            public static LocalizedString spawnduration = @"Spawn Duration:";
            public static LocalizedString speed = @"Speed:";
            public static LocalizedString spell = @"Spell:";
            public static LocalizedString spells = @"Spells";
            public static LocalizedString sprite = @"Sprite";
            public static LocalizedString stats = @"Stats:";
            public static LocalizedString title = @"Npc Editor";
            public static LocalizedString undo = @"Undo Changes";
            public static LocalizedString undoprompt = @"Are you sure you want to undo changes made to this npc? This action cannot be reverted!";
            public static LocalizedString undotitle = @"Undo Changes";
        }

        public struct NpcSpawns
        {
            public static LocalizedString add = @"Add";
            public static LocalizedString addremove = @"Add/Remove Map NPCs";
            public static LocalizedString declaredlocation = @"Declared";
            public static LocalizedString direction = @"Direction:";
            public static LocalizedString randomdirection = @"Random";
            public static LocalizedString randomlocation = @"Random";
            public static LocalizedString remove = @"Remove";
            public static LocalizedString spawndeclared = @"Spawn Location: Declared";
            public static LocalizedString spawnrandom = @"Spawn Location: Random";
        }

        public struct Options
        {
            public static LocalizedString browsebtn = @"Browse";
            public static LocalizedString dialogueallfiles = @"All Files";
            public static LocalizedString dialogueheader = @"Browse for client...";
            public static LocalizedString generaltab = @"General";
            public static LocalizedString pathgroup = @"Client Path";
            public static LocalizedString tilesetwarning = @"Suppress large tileset size warning.";
            public static LocalizedString title = @"Options";
        }

        public struct ProgressForm
        {
            public static LocalizedString cancel = @"Cancel";
        }

        public struct ProjectileEditor
        {
            public static LocalizedString addanimation = @"Add";
            public static LocalizedString ammo = @"Ammunition Requirements:";
            public static LocalizedString ammoamount = @"Amount:";
            public static LocalizedString ammoitem = @"Item:";
            public static LocalizedString animation = @"Animation:";
            public static LocalizedString animationline = @"[Spawn Range: {00} - {01}]  Animation: {02}";
            public static LocalizedString animations = @"Animations";
            public static LocalizedString autorotate = @"Auto Rotate Animation?";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString collisions = @"Ignore Collision:";
            public static LocalizedString copy = @"Copy Projectile";
            public static LocalizedString delete = @"Delete Projectile";
            public static LocalizedString deleteprompt = @"Are you sure you want to delete this projectile? This action cannot be reverted!";
            public static LocalizedString deletetitle = @"Delete Projectile";
            public static LocalizedString grapple = @"Grapple hook?";
            public static LocalizedString homing = @"Homing?";
            public static LocalizedString ignoreactiveresources = @"Active Resources";
            public static LocalizedString ignoreblocks = @"Map Blocks";
            public static LocalizedString ignoreinactiveresources = @"Inactive Resources";
            public static LocalizedString ignorezdimension = @"Z-Dimension Blocks";
            public static LocalizedString knockback = @"Knockback:";
            public static LocalizedString name = @"Name:";
            public static LocalizedString New = @"New Projectile";
            public static LocalizedString paste = @"Paste Projectile";
            public static LocalizedString projectiles = @"Projectiles";
            public static LocalizedString properties = @"Properties";
            public static LocalizedString quantity = @"Quantity:";
            public static LocalizedString range = @"Range:";
            public static LocalizedString removeanimation = @"Remove";
            public static LocalizedString save = @"Save";
            public static LocalizedString spawndelay = @"Spawn Delay (ms):";
            public static LocalizedString spawnrange = @"Spawn Range: {00} - {01}";
            public static LocalizedString spawns = @"Projectile Spawns";
            public static LocalizedString speed = @"Speed (ms):";
            public static LocalizedString spell = @"Collision Spell:";
            public static LocalizedString title = @"Projectile Editor";
            public static LocalizedString undo = @"Undo Changes";
            public static LocalizedString undoprompt = @"Are you sure you want to undo changes made to this projectile? This action cannot be reverted!";
            public static LocalizedString undotitle = @"Undo Changes";
        }

        public struct QuestEditor
        {
            public static LocalizedString actions = @"Quest Actions:";
            public static LocalizedString addtask = @"Add Task";
            public static LocalizedString beforeofferdesc = @"Before Offer Description:";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString completeddesc = @"Completed Description:";
            public static LocalizedString copy = @"Copy Quest";
            public static LocalizedString delete = @"Delete Quest";
            public static LocalizedString deleteprompt = @"Are you sure you want to delete this quest? This action cannot be reverted!";
            public static LocalizedString deletetitle = @"Delete Quest";
            public static LocalizedString editendevent = @"Edit Quest Completion Event";
            public static LocalizedString editrequirements = @"Edit Quest Requirements";
            public static LocalizedString editstartevent = @"Edit Quest Start Event";
            public static LocalizedString endevent = @"Quest {00} Completion Event";
            public static LocalizedString general = @"General";
            public static LocalizedString inprogressdesc = @"In Progress Description:";
            public static LocalizedString logoptions = @"Quest Log Options";
            public static LocalizedString name = @"Name:";
            public static LocalizedString New = @"New Quest";
            public static LocalizedString offerdesc = @"Offer Description:";
            public static LocalizedString onend = @"On Quest Completion:";
            public static LocalizedString onstart = @"On Quest Start:";
            public static LocalizedString options = @"Progression Options";
            public static LocalizedString paste = @"Paste Quest";
            public static LocalizedString quests = @"Quests";
            public static LocalizedString quit = @"Can Quit Quest?";
            public static LocalizedString removetask = @"Remove Task";
            public static LocalizedString repeatable = @"Quest Repeatable?";
            public static LocalizedString requirements = @"Quest Requirements";
            public static LocalizedString save = @"Save";
            public static LocalizedString showafter = @"Show in quest log after completing quest?";
            public static LocalizedString showbefore = @"Show in quest log before accepting quest?";
            public static LocalizedString startevent = @"Quest {00} Start Event";
            public static LocalizedString tasks = @"Quest Tasks";
            public static LocalizedString title = @"Quest Editor";
            public static LocalizedString undo = @"Undo Changes";
            public static LocalizedString undoprompt = @"Are you sure you want to undo changes made to this quest? This action cannot be reverted!";
            public static LocalizedString undotitle = @"Undo Changes";
        }

        public struct ResourceEditor
        {
            public static LocalizedString animation = @"Animation:";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString copy = @"Copy Resource";
            public static LocalizedString delete = @"Delete Resource";
            public static LocalizedString deleteprompt = @"Are you sure you want to delete this resource? This action cannot be reverted!";
            public static LocalizedString deletetitle = @"Delete Item";
            public static LocalizedString dropamount = @"Amount:";
            public static LocalizedString dropchance = @"Chance (%):";
            public static LocalizedString dropindex = @"Drop Index:";
            public static LocalizedString dropitem = @"Item:";
            public static LocalizedString drops = @"Drops";
            public static LocalizedString exhaustedgraphic = @"Exhausted Graphic:";
            public static LocalizedString general = @"General";
            public static LocalizedString graphics = @"Graphics";
            public static LocalizedString initialgraphic = @"Initial Graphic:";
            public static LocalizedString maxhp = @"Max HP:";
            public static LocalizedString minhp = @"Min HP:";
            public static LocalizedString name = @"Name:";
            public static LocalizedString New = @"New Resource";
            public static LocalizedString paste = @"Paste Resource";
            public static LocalizedString requirements = @"Harvesting Requirements";
            public static LocalizedString resources = @"Resources";
            public static LocalizedString save = @"Save";
            public static LocalizedString spawnduration = @"Spawn Duration:";
            public static LocalizedString title = @"Resource Editor";
            public static LocalizedString tooltype = @"Tool Type:";
            public static LocalizedString undo = @"Undo Changes";
            public static LocalizedString undoprompt = @"Are you sure you want to undo changes made to this resource? This action cannot be reverted!";
            public static LocalizedString undotitle = @"Undo Changes";
            public static LocalizedString walkableafter = @"Walkable after resource removal?";
            public static LocalizedString walkablebefore = @"Walkable before resource removal?";
        }

        public struct ShopEditor
        {
            public static LocalizedString addboughtitem = @"Add Item:";
            public static LocalizedString addlabel = @"Add Item to be Sold:";
            public static LocalizedString addsolditem = @"Add Selected";
            public static LocalizedString blacklist = @"Blacklist";
            public static LocalizedString buycost = @"Sell Amount:";
            public static LocalizedString buyfor = @"Buy For:";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString copy = @"Copy Shop";
            public static LocalizedString defaultcurrency = @"Default Currency:";
            public static LocalizedString delete = @"Delete Shop";
            public static LocalizedString deleteprompt = @"Are you sure you want to delete this shop? This action cannot be reverted!";
            public static LocalizedString deletetitle = @"Delete Item";
            public static LocalizedString general = @"General";
            public static LocalizedString itemsboughtblacklist = @"Items Bought (Blacklist - Don't Buy Listed Items)  ";
            public static LocalizedString itemsboughtwhitelist = @"Items Bought (Whitelist - Buy Listed Items)  ";
            public static LocalizedString itemssold = @"Items Sold";
            public static LocalizedString name = @"Name:";
            public static LocalizedString New = @"New Shop";
            public static LocalizedString paste = @"Paste Shop";
            public static LocalizedString removeboughtitem = @"Remove Selected";
            public static LocalizedString removesolditem = @"Remove Selected";
            public static LocalizedString save = @"Save";
            public static LocalizedString sellcost = @"Sell Cost:";
            public static LocalizedString sellfor = @"Sell for:";
            public static LocalizedString shops = @"Shops";
            public static LocalizedString title = @"Shop Editor";
            public static LocalizedString undo = @"Undo Changes";
            public static LocalizedString undoprompt = @"Are you sure you want to undo changes made to this shop? This action cannot be reverted!";
            public static LocalizedString undotitle = @"Undo Changes";
            public static LocalizedString whitelist = @"Whitelist";
        }

        public struct SpellEditor
        {
            public static LocalizedString abilitypower = @"Ability Pwr:";
            public static LocalizedString attack = @"Attack:";
            public static LocalizedString boostduration = @"Stat Boost/Effect Duration";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString castanimation = @"Cast Animation:";
            public static LocalizedString castrange = @"Cast Range (tiles):";
            public static LocalizedString casttime = @"Cast Time (ms):";
            public static LocalizedString combatspell = @"Combat Spell";
            public static LocalizedString cooldown = @"Cooldown (ms):";
            public static LocalizedString copy = @"Copy Spell";
            public static LocalizedString cost = @"Spell Cost:";
            public static LocalizedString critchance = @"Crit Chance (%):";
            public static LocalizedString damagegroup = @"Damage";
            public static LocalizedString damagetype = @"Damage Type:";
            public static LocalizedString dash = @"Dash";
            public static LocalizedString dashcollisions = @"Ignore Collision:";
            public static LocalizedString dashrange = @"Dash Range (tiles): {00}";
            public static LocalizedString defense = @"Defense:";
            public static LocalizedString delete = @"Delete Spell";
            public static LocalizedString deleteprompt = @"Are you sure you want to delete this spell? This action cannot be reverted!";
            public static LocalizedString deletetitle = @"Delete Spell";
            public static LocalizedString description = @"Desc:";
            public static LocalizedString duration = @"Stat Boost/Effect Duration";
            public static LocalizedString[] effects = new LocalizedString[]
            {
                @"None",
                @"Silence",
                @"Stun",
                @"Snare",
                @"Blind",
                @"Stealth",
                @"Transform",
            };
            public static LocalizedString effectgroup = @"Effect";
            public static LocalizedString effectlabel = @"Extra Effect:";
            public static LocalizedString Event = @"Event";
            public static LocalizedString eventlabel = @"Event:";
            public static LocalizedString friendly = @"Friendly";
            public static LocalizedString general = @"General";
            public static LocalizedString hitanimation = @"Hit Animation:";
            public static LocalizedString hitradius = @"Hit Radius:";
            public static LocalizedString hotdot = @"Heal/Damage Over Time";
            public static LocalizedString hotdottick = @"Tick (ms):";
            public static LocalizedString hpcost = @"HP Cost:";
            public static LocalizedString hpdamage = @"HP Damage:";
            public static LocalizedString icon = @"Icon:";
            public static LocalizedString ignoreactiveresources = @"Active Resources";
            public static LocalizedString ignoreblocks = @"Map Blocks";
            public static LocalizedString ignoreinactiveresources = @"Inactive Resources";
            public static LocalizedString ignorezdimension = @"Z-Dimension Blocks";
            public static LocalizedString ishotdot = @"HOT/DOT?";
            public static LocalizedString magicresist = @"Magic Resist:";
            public static LocalizedString manacost = @"Mana Cost:";
            public static LocalizedString mpdamage = @"Mana Damage:";
            public static LocalizedString name = @"Name:";
            public static LocalizedString New = @"New Spell";
            public static LocalizedString paste = @"Paste Spell";
            public static LocalizedString projectile = @"Projectile:";
            public static LocalizedString requirements = @"Casting Requirements";
            public static LocalizedString requirementsbutton = @"Edit Casting Requirements";
            public static LocalizedString save = @"Save";
            public static LocalizedString scalingamount = @"Scaling Amount (%):";
            public static LocalizedString scalingstat = @"Scaling Stat:";
            public static LocalizedString speed = @"Speed:";
            public static LocalizedString spells = @"Spells";
            public static LocalizedString stats = @"Stat Modifiers";
            public static LocalizedString targetting = @"Targetting Info";
            public static LocalizedString targettype = @"Target Type:";
            public static LocalizedString[] targettypes = new LocalizedString[]
            {
                @"Self",
                @"Single Target (includes self)",
                @"AOE",
                @"Linear (projectile)",
            };
            public static LocalizedString title = @"Spell Editor";
            public static LocalizedString transformsprite = @"Sprite:";
            public static LocalizedString type = @"Type:";
            public static LocalizedString[] types = new LocalizedString[]
            {
                @"Combat Spell",
                @"Warp to Map",
                @"Warp to Target",
                @"Dash",
                @"Event",
            };
            public static LocalizedString undo = @"Undo Changes";
            public static LocalizedString undoprompt = @"Are you sure you want to undo changes made to this spell? This action cannot be reverted!";
            public static LocalizedString undotitle = @"Undo Changes";
            public static LocalizedString warptomap = @"Warp Caster:";
        }

        public struct SwitchVariableEditor
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString delete = @"Delete";
            public static LocalizedString deletecaption = @"Delete?";
            public static LocalizedString deleteprompt = @"Are you sure you want to delete this switch/variable? This action cannot be reverted!";
            public static LocalizedString editor = @"Switch and Variable Editor";
            public static LocalizedString False = @"False";
            public static LocalizedString globalswitch = @"Server Switch";
            public static LocalizedString globalswitches = @"Global Switches";
            public static LocalizedString globalvariable = @"Server Variable";
            public static LocalizedString globalvariables = @"Global Variables";
            public static LocalizedString list = @"Switch/Variable List";
            public static LocalizedString name = @"Name:";
            public static LocalizedString New = @"New";
            public static LocalizedString playerswitch = @"Player Switch";
            public static LocalizedString playerswitches = @"Player Switches";
            public static LocalizedString playervariable = @"Player Variable";
            public static LocalizedString playervariables = @"Player Variables";
            public static LocalizedString save = @"Save";
            public static LocalizedString title = @"Switch and Variable Editor";
            public static LocalizedString True = @"True";
            public static LocalizedString type = @"Switch or Variable Type";
            public static LocalizedString undo = @"Undo Changes";
            public static LocalizedString value = @"Value:";
        }

        public struct TaskEditor
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString completionevent = @"Task Completion Event";
            public static LocalizedString desc = @"Desc:";
            public static LocalizedString editcompletionevent = @"Edit Task Completion Event";
            public static LocalizedString editor = @"Task Editor";
            public static LocalizedString eventdriven = @"Event Driven: The description should lead the player to an event. The event will then complete the task using the complete quest task command.";
            public static LocalizedString gatheramount = @"Amount:";
            public static LocalizedString gatheritems = @"Gather Item(s)";
            public static LocalizedString item = @"Item:";
            public static LocalizedString killnpcs = @"Kill NPC(s)";
            public static LocalizedString npc = @"NPC:";
            public static LocalizedString npcamount = @"Amount:";
            public static LocalizedString ok = @"Ok";
            public static LocalizedString title = @"Add/Edit Quest Task";
            public static LocalizedString type = @"Task Type:";
            public static LocalizedString[] types = new LocalizedString[]
            {
                @"Event Driven",
                @"Gather Item(s)",
                @"Kill NPC(s)",
            };
        }

        public struct Tiles
        {
            public static LocalizedString animated = @"Animated  [VX Format]";
            public static LocalizedString animatedxp = @"Animated  [XP Format]";
            public static LocalizedString autotile = @"Autotile     [VX Format]";
            public static LocalizedString autotilexp = @"Autotile     [XP Format]";
            public static LocalizedString cliff = @"Cliff           [VX Format]";
            public static LocalizedString fake = @"Fake         [VX Format]";
            public static LocalizedString layer = @"Layer:";
            public static LocalizedString[] layers = new LocalizedString[]
            {
                @"Ground",
                @"Mask",
                @"Mask 2",
                @"Fringe",
                @"Fringe 2",
            };
            public static LocalizedString normal = @"Normal";
            public static LocalizedString tileset = @"Tileset:";
            public static LocalizedString tiletype = @"Tile Type:";
            public static LocalizedString waterfall = @"Waterfall   [VX Format]";
        }

        public struct TimeEditor
        {
            public static LocalizedString brightness = @"Brightness: {00}%";
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString colorpaneldesc = @"Double click the panel above to change the overlay color.";
            public static LocalizedString interval = @"Invervals:";
            public static LocalizedString[] intervals = new LocalizedString[]
            {
                @"24 hours",
                @"12 hours",
                @"8 hours",
                @"6 hours",
                @"4 hours",
                @"3 hours",
                @"2 hours",
                @"1 hour",
                @"45 minutes",
                @"30 minutes",
                @"15 minutes",
                @"10 minutes",
            };
            public static LocalizedString overlay = @"Range Overlay";
            public static LocalizedString rate = @"Time Rate:";
            public static LocalizedString ratedesc = @"Enter 1 for normal rate of time.
Values larger than one for faster days. 
Values between 0 and 1 for longer days. 
Negative values for time to flow backwards.";
            public static LocalizedString ratesuffix = @"x Normal";
            public static LocalizedString save = @"Save";
            public static LocalizedString settings = @"Time Settings";
            public static LocalizedString sync = @"Sync With Server";
            public static LocalizedString times = @"Time of Day";
            public static LocalizedString title = @"Time Editor (Day/Night Settings)";
            public static LocalizedString to = @"to";
        }

        public struct Warping
        {
            public static LocalizedString direction = @"Dir: {00}";
            public static LocalizedString map = @"Map: {00}";
            public static LocalizedString visual = @"Open Visual Interface";
            public static LocalizedString x = @"X: {00}";
            public static LocalizedString y = @"Y: {00}";
        }

        public struct WarpSelection
        {
            public static LocalizedString cancel = @"Cancel";
            public static LocalizedString chronological = @"Chronological";
            public static LocalizedString maplist = @"Map List";
            public static LocalizedString mappreview = @"Map Preview";
            public static LocalizedString mapselectiontitle = @"Map Selection";
            public static LocalizedString okay = @"Ok";
            public static LocalizedString title = @"Warp Tile Selection";
        }

        public static string GetEventConditionalDesc(EventCommand cmd)
        {
            if (cmd.Type != EventCommandType.ConditionalBranch) return "";
            switch (cmd.Ints[0])
            {
                case 0: //Player Switch
                    var pValue = Strings.EventConditionDesc.False;
                    if (Convert.ToBoolean(cmd.Ints[2])) pValue = Strings.EventConditionDesc.True;
                    return Strings.EventConditionDesc.playerswitch.ToString( PlayerSwitchBase.GetName(cmd.Ints[1]), pValue);
                case 1: //Player Variables
                    var pVar = "";
                    switch (cmd.Ints[2])
                    {
                        case 0:
                            pVar = Strings.EventConditionDesc.equal.ToString( cmd.Ints[3]);
                            break;
                        case 1:
                            pVar = Strings.EventConditionDesc.greaterequal.ToString( cmd.Ints[3]);
                            break;
                        case 2:
                            pVar = Strings.EventConditionDesc.lessthanequal.ToString( cmd.Ints[3]);
                            break;
                        case 3:
                            pVar = Strings.EventConditionDesc.greater.ToString( cmd.Ints[3]);
                            break;
                        case 4:
                            pVar = Strings.EventConditionDesc.lessthan.ToString( cmd.Ints[3]);
                            break;
                        case 5:
                            pVar = Strings.EventConditionDesc.notequal.ToString( cmd.Ints[3]);
                            break;
                    }
                    return Strings.EventConditionDesc.playervariable.ToString( PlayerVariableBase.GetName(cmd.Ints[1]),
                        pVar);
                case 2: //Global Switch
                    var gValue = Strings.EventConditionDesc.False;
                    if (Convert.ToBoolean(cmd.Ints[2])) gValue = Strings.EventConditionDesc.True;
                    return Strings.EventConditionDesc.globalswitch.ToString( ServerSwitchBase.GetName(cmd.Ints[1]), gValue);
                case 3: //Global Variables
                    var gVar = "";
                    switch (cmd.Ints[2])
                    {
                        case 0:
                            gVar = Strings.EventConditionDesc.equal.ToString( cmd.Ints[3]);
                            break;
                        case 1:
                            gVar = Strings.EventConditionDesc.greaterequal.ToString( cmd.Ints[3]);
                            break;
                        case 2:
                            gVar = Strings.EventConditionDesc.lessthanequal.ToString( cmd.Ints[3]);
                            break;
                        case 3:
                            gVar = Strings.EventConditionDesc.greater.ToString( cmd.Ints[3]);
                            break;
                        case 4:
                            gVar = Strings.EventConditionDesc.lessthan.ToString( cmd.Ints[3]);
                            break;
                        case 5:
                            gVar = Strings.EventConditionDesc.notequal.ToString( cmd.Ints[3]);
                            break;
                    }
                    return Strings.EventConditionDesc.globalvariable.ToString( ServerVariableBase.GetName(cmd.Ints[1]),
                        gVar);
                case 4: //Has Item
                    return Strings.EventConditionDesc.hasitem.ToString( cmd.Ints[2], ItemBase.GetName(cmd.Ints[1]));
                case 5: //Class Is
                    return Strings.EventConditionDesc.Class.ToString( ClassBase.GetName(cmd.Ints[1]));
                case 6: //Knows spell
                    return Strings.EventConditionDesc.knowsspell.ToString( SpellBase.GetName(cmd.Ints[1]));
                case 7: //Level or Stat is
                    var pLvl = "";
                    switch (cmd.Ints[1])
                    {
                        case 0:
                            pLvl = Strings.EventConditionDesc.equal.ToString( cmd.Ints[2]);
                            break;
                        case 1:
                            pLvl = Strings.EventConditionDesc.greaterequal.ToString( cmd.Ints[2]);
                            break;
                        case 2:
                            pLvl = Strings.EventConditionDesc.lessthanequal.ToString( cmd.Ints[2]);
                            break;
                        case 3:
                            pLvl = Strings.EventConditionDesc.greater.ToString( cmd.Ints[2]);
                            break;
                        case 4:
                            pLvl = Strings.EventConditionDesc.lessthan.ToString( cmd.Ints[2]);
                            break;
                        case 5:
                            pLvl = Strings.EventConditionDesc.notequal.ToString( cmd.Ints[2]);
                            break;
                    }
                    var lvlorstat = "";
                    switch (cmd.Ints[3])
                    {
                        case 0:
                            lvlorstat = Strings.EventConditionDesc.level;
                            break;
                        default:
                            lvlorstat = Strings.Combat.stats[cmd.Ints[3] - 1];
                            break;
                    }
                    return Strings.EventConditionDesc.levelorstat.ToString( lvlorstat, pLvl);
                case 8: //Self Switch
                    var sValue = Strings.EventConditionDesc.False;
                    if (Convert.ToBoolean(cmd.Ints[2])) sValue = Strings.EventConditionDesc.True;
                    return Strings.EventConditionDesc.selfswitch.ToString(
                        Strings.EventConditionDesc.selfswitches[cmd.Ints[1]], sValue);
                case 9: //Power is
                    if (cmd.Ints[1] == 0)
                    {
                        return Strings.EventConditionDesc.power.ToString(
                            Strings.EventConditionDesc.modadmin);
                    }
                    else
                    {
                        return Strings.EventConditionDesc.power.ToString( Strings.EventConditionDesc.admin);
                    }
                case 10: //Time is between
                    var timeRanges = new List<string>();
                    var time = new DateTime(2000, 1, 1, 0, 0, 0);
                    for (int i = 0; i < 1440; i += TimeBase.GetTimeBase().RangeInterval)
                    {
                        var addRange = time.ToString("h:mm:ss tt") + " to ";
                        time = time.AddMinutes(TimeBase.GetTimeBase().RangeInterval);
                        addRange += time.ToString("h:mm:ss tt");
                        timeRanges.Add(addRange);
                    }
                    var time1 = "";
                    var time2 = "";
                    if (cmd.Ints[1] > -1 && cmd.Ints[1] < timeRanges.Count)
                    {
                        time1 = timeRanges[cmd.Ints[1]];
                    }
                    else
                    {
                        time1 = Strings.EventConditionDesc.timeinvalid;
                    }
                    if (cmd.Ints[2] > -1 && cmd.Ints[2] < timeRanges.Count)
                    {
                        time2 = timeRanges[cmd.Ints[2]];
                    }
                    else
                    {
                        time2 = Strings.EventConditionDesc.timeinvalid;
                    }
                    return Strings.EventConditionDesc.time.ToString( time1, time2);
                case 11: //Can Start Quest...
                    return Strings.EventConditionDesc.startquest.ToString( QuestBase.GetName(cmd.Ints[1]));
                case 12: //Quest In Progress...
                    var quest = QuestBase.Lookup.Get<QuestBase>(cmd.Ints[1]);
                    if (quest != null)
                    {
                        QuestBase.QuestTask task = null;
                        foreach (var tsk in quest.Tasks)
                        {
                            if (tsk.Id == cmd.Ints[3])
                            {
                                task = tsk;
                            }
                        }
                        var taskName = task != null ? task.GetTaskString() : Strings.EventConditionDesc.tasknotfound.ToString();
                        switch (cmd.Ints[2])
                        {
                            case 1:
                                return Strings.EventConditionDesc.questinprogress.ToString( QuestBase.GetName(cmd.Ints[1]),
                                    Strings.EventConditionDesc.beforetask.ToString( taskName));
                            case 2:
                                return Strings.EventConditionDesc.questinprogress.ToString( QuestBase.GetName(cmd.Ints[1]),
                                    Strings.EventConditionDesc.aftertask.ToString( taskName));
                            case 3:
                                return Strings.EventConditionDesc.questinprogress.ToString( QuestBase.GetName(cmd.Ints[1]),
                                    Strings.EventConditionDesc.ontask.ToString( taskName));
                            default:
                                return Strings.EventConditionDesc.questinprogress.ToString( QuestBase.GetName(cmd.Ints[1]),
                                    Strings.EventConditionDesc.onanytask);
                        }
                    }
                    return Strings.EventConditionDesc.questinprogress.ToString( QuestBase.GetName(cmd.Ints[1]));
                case 13: //Quest Completed
                    return Strings.EventConditionDesc.questcompleted.ToString( QuestBase.GetName(cmd.Ints[1]));
                case 14: //Player death
                    return Strings.EventConditionDesc.playerdeath;
                case 15: //No NPCs on map
                    return Strings.EventConditionDesc.nonpcsonmap;
                case 16: //Gender Is
                    return Strings.EventConditionDesc.gender.ToString(
                        (cmd.Ints[1] == 0
                            ? Strings.EventConditionDesc.male
                            : Strings.EventConditionDesc.female));
            }
            return "";
        }


        public static void Load(string language)
        {
            if (File.Exists(Path.Combine("resources", "languages", "Editor." + language + ".json")))
            {
                Dictionary<string, Dictionary<string, object>> strings =
                    new Dictionary<string, Dictionary<string, object>>();
                strings = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(
                    File.ReadAllText(Path.Combine("resources", "languages", "Editor." + language + ".json")));
                Type type = typeof(Strings);

                var fields = new List<Type>();
                fields.AddRange(type.GetNestedTypes(System.Reflection.BindingFlags.Static |
                                                 System.Reflection.BindingFlags.Public));

                foreach (var p in fields)
                {
                    if (strings.ContainsKey(p.Name))
                    {
                        var dict = strings[p.Name];
                        foreach (var p1 in p.GetFields(System.Reflection.BindingFlags.Static |
                                                       System.Reflection.BindingFlags.Public))
                        {
                            if (dict.ContainsKey(p1.Name))
                            {
                                if (p1.GetValue(null).GetType() == typeof(LocalizedString))
                                {
                                    p1.SetValue(null, new LocalizedString((string)dict[p1.Name]));
                                }
                                else if (p1.GetValue(null).GetType() == typeof(LocalizedString[]))
                                {
                                    string[] values = ((JArray)dict[p1.Name]).ToObject<string[]>();
                                    List<LocalizedString> list = new List<LocalizedString>();
                                    for (int i = 0; i < values.Length; i++)
                                        list.Add(new LocalizedString(values[i]));
                                    p1.SetValue(null, list.ToArray());
                                }
                                else if (p1.GetValue(null).GetType() == typeof(Dictionary<int, LocalizedString>))
                                {
                                    var dic = new Dictionary<int, LocalizedString>();
                                    Dictionary<int, string> values = ((JObject)dict[p1.Name]).ToObject<Dictionary<int, string>>();
                                    foreach (var val in values)
                                    {
                                        dic.Add(val.Key, val.Value);
                                    }
                                    p1.SetValue(null, dic);
                                }
                                else if (p1.GetValue(null).GetType() == typeof(Dictionary<string, LocalizedString>))
                                {
                                    var dic = new Dictionary<string, LocalizedString>();
                                    Dictionary<string, string> values = ((JObject)dict[p1.Name]).ToObject<Dictionary<string, string>>();
                                    foreach (var val in values)
                                    {
                                        dic.Add(val.Key, val.Value);
                                    }
                                    p1.SetValue(null, dic);
                                }
                            }
                        }
                    }
                }
            }
            Save(language);
        }

        public static void Save(string language)
        {
            Dictionary<string, Dictionary<string, object>> strings =
                new Dictionary<string, Dictionary<string, object>>();
            Type type = typeof(Strings);
            var fields = type.GetNestedTypes(System.Reflection.BindingFlags.Static |
                                             System.Reflection.BindingFlags.Public);
            foreach (var p in fields)
            {
                var dict = new Dictionary<string, object>();
                foreach (var p1 in p.GetFields(System.Reflection.BindingFlags.Static |
                                               System.Reflection.BindingFlags.Public))
                {
                    if (p1.GetValue(null).GetType() == typeof(LocalizedString))
                    {
                        dict.Add(p1.Name, ((LocalizedString)p1.GetValue(null)).ToString());
                    }
                    else if (p1.GetValue(null).GetType() == typeof(LocalizedString[]))
                    {
                        string[] values = ((LocalizedString[])p1.GetValue(null)).Select(x => x.ToString()).ToArray();
                        dict.Add(p1.Name, values);
                    }
                    else if (p1.GetValue(null).GetType() == typeof(Dictionary<int, LocalizedString>))
                    {
                        var dic = new Dictionary<int, string>();
                        foreach (var val in (Dictionary<int, LocalizedString>)p1.GetValue(null))
                        {
                            dic.Add(val.Key, val.Value.ToString());
                        }
                        dict.Add(p1.Name, dic);
                    }
                    else if (p1.GetValue(null).GetType() == typeof(Dictionary<string, LocalizedString>))
                    {
                        var dic = new Dictionary<string, string>();
                        foreach (var val in (Dictionary<string, LocalizedString>)p1.GetValue(null))
                        {
                            dic.Add(val.Key, val.Value.ToString());
                        }
                        dict.Add(p1.Name, dic);
                    }
                }
                strings.Add(p.Name, dict);
            }
            File.WriteAllText(Path.Combine("resources", "languages", "Editor." + language + ".json"), JsonConvert.SerializeObject(strings, Formatting.Indented));
        }
    }

    public struct LocalizedString
    {
        private string _mValue;

        public LocalizedString(string value)
        {
            _mValue = value;
        }

        public static implicit operator LocalizedString(string value)
        {
            return new LocalizedString(value);
        }

        public static implicit operator string(LocalizedString str)
        {
            return str._mValue;
        }

        public override string ToString()
        {
            return _mValue;
        }

        public string ToString(params object[] args)
        {
            try
            {
                if (args.Length == 0) return _mValue;
                return string.Format(_mValue, args);
            }
            catch (FormatException)
            {
                return "Format Exception!";
            }
        }
    }
}
