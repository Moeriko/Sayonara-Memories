using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Subtitles;
using System;
using System.Drawing;
using System.IO;

namespace StorybrewScripts
{
    public class LyricsScript : StoryboardObjectGenerator
    {
        [Configurable]
        public OsbOrigin LyricsOrigin = OsbOrigin.Centre;

        [Configurable]
        public string FontName = "Kozuka Gothic Pr6N EL";

        [Configurable]
        public string OutputPath = "sb/lyrics";

        [Configurable]
        public float LetterSpacing = 4f;

        [Configurable]
        public float LyricsFade = 0.8f;

        [Configurable]
        public int FontSize = 26;

        // [Configurable]
        // public float FontScale = 0.5f;

        [Configurable]
        public FontStyle FontStyle = FontStyle.Regular;

        [Configurable]
        public int GlowRadius = 0;

        [Configurable]
        public Color4 GlowColor = new Color4(255, 255, 255, 255);

        [Configurable]
        public bool AdditiveGlow = true;

        [Configurable]
        public int OutlineThickness = 0;

        [Configurable]
        public Color4 OutlineColor = new Color4(50, 50, 50, 200);

        [Configurable]
        public int ShadowThickness = 4;

        [Configurable]
        public Color4 ShadowColor = new Color4(0, 0, 0, 200);

        [Configurable]
        public Vector2 Padding = Vector2.Zero;

        [Configurable]
        public bool TrimTransparency = true;

        [Configurable]
        public bool EffectsOnly = false;

        [Configurable]
        public bool Debug = false;

        [Configurable]
        public bool Additive = false;

        [Configurable]
        public bool RandomLyricsColor = false;

        [Configurable]
        public Color4 Color1 = new Color4(255, 255, 255, 255);

        [Configurable]
        public Color4 Color2 = new Color4(100, 100, 100, 255);

        [Configurable]
        public Color4 Color3 = new Color4(100, 100, 100, 255);

        [Configurable]
        public Color4 Color4 = new Color4(100, 100, 100, 255);

        [Configurable]
        public Color4 Color5 = new Color4(100, 100, 100, 255);

        [Configurable]
        public Color4 Color6 = new Color4(100, 100, 100, 255);

        public override void Generate()
        {
            // these variables are for how the lyrics looks
            var font = LoadFont(OutputPath, new FontDescription()
            {
                FontPath = FontName,
                FontSize = FontSize,
                Color = Color4.White,
                Padding = Padding,
                FontStyle = FontStyle,
                TrimTransparency = TrimTransparency,
                EffectsOnly = EffectsOnly,
                Debug = Debug,
            },
            new FontGlow()
            {
                Radius = AdditiveGlow ? 0 : GlowRadius,
                Color = GlowColor,
            },
            new FontOutline()
            {
                Thickness = OutlineThickness,
                Color = OutlineColor,
            },
            new FontShadow()
            {
                Thickness = ShadowThickness,
                Color = ShadowColor,
            });

            // this is where you generate the lyrics
            CreateLyrics(font, Color1, "さ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 690, 2932);
            CreateLyrics(font, Color1, "　く　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 1437, 2932);
            CreateLyrics(font, Color1, "　　ら　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 2185, 2932);
            CreateLyrics(font, Color3, "　　桜　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 2932, 5736);
            CreateLyrics(font, Color1, "　　　が　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 2932, 5736);
            CreateLyrics(font, Color3, "　　　　咲　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 3680, 5736);
            CreateLyrics(font, Color3, "　　　　　く　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 4428, 5736);
            CreateLyrics(font, Color3, "　　　　　　よ　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 5175, 5736);

            CreateLyrics(font, Color1, "見　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 5923, 13581);
            CreateLyrics(font, Color1, "　慣　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 6296, 13581);
            CreateLyrics(font, Color1, "　　れ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 6684, 13581);
            CreateLyrics(font, Color1, "　　　た　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 7435, 13581);
            CreateLyrics(font, Color1, "　　　　い　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 7834, 13581);
            CreateLyrics(font, Color1, "　　　　　つ　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 8229, 13581);
            CreateLyrics(font, Color1, "　　　　　　も　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 8629, 13581);
            CreateLyrics(font, Color1, "　　　　　　　の　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 9029, 13581);
            CreateLyrics(font, Color1, "　　　　　　　　坂　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 9434, 13581);
            CreateLyrics(font, Color1, "　　　　　　　　　道　", FontName, FontSize, 0.5f, new Vector2(320, 435), 11134, 13581);
            CreateLyrics(font, Color1, "　　　　　　　　　　に", FontName, FontSize, 0.5f, new Vector2(320, 435), 11666, 13581);

            CreateLyrics(font, Color1, "ああ　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 14220, 20510);
            CreateLyrics(font, Color5, "　　　別　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 15398, 20510);
            CreateLyrics(font, Color5, "　　　　れ　", FontName, FontSize, 0.5f, new Vector2(320, 435), 17080, 20510);
            CreateLyrics(font, Color5, "　　　　　を", FontName, FontSize, 0.5f, new Vector2(320, 435), 17510, 20510);

            LyricsBackground(690, 20510);

            CreateLyrics(font, Color1, "（いぇ）", FontName, FontSize, 0.5f, new Vector2(320, 435), 22947, 23510);

            LyricsBackground(22947, 23510);

            CreateLyrics(font, Color5, "泣　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 48250, 55014);
            CreateLyrics(font, Color5, "　い　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 48624, 55014);
            CreateLyrics(font, Color5, "　　て　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 49000, 55014);
            CreateLyrics(font, Color1, "　　　笑　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 49374, 55014);
            CreateLyrics(font, Color1, "　　　　った　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 50500, 55014);
            CreateLyrics(font, Color1, "　　　　　　あ　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 52374, 55014);
            CreateLyrics(font, Color1, "　　　　　　　の　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 52750, 55014);
            CreateLyrics(font, Color1, "　　　　　　　　日　", FontName, FontSize, 0.5f, new Vector2(320, 435), 53124, 55014);
            CreateLyrics(font, Color1, "　　　　　　　　　々", FontName, FontSize, 0.5f, new Vector2(320, 435), 53510, 55014);

            CreateLyrics(font, Color1, "な　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 55390, 59874);
            CreateLyrics(font, Color1, "　ん　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 55750, 59874);
            CreateLyrics(font, Color1, "　　だ　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 56124, 59874);
            CreateLyrics(font, Color1, "　　　か　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 56484, 59874);
            CreateLyrics(font, Color1, "　　　　昨　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 57626, 59874);
            CreateLyrics(font, Color1, "　　　　　日　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 58004, 59874);
            CreateLyrics(font, Color1, "　　　　　　の　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 58380, 59874);
            CreateLyrics(font, Color1, "　　　　　　　こ　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 58567, 59874);
            CreateLyrics(font, Color1, "　　　　　　　　と　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 58941, 59874);
            CreateLyrics(font, Color1, "　　　　　　　　　の　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 59314, 59874);
            CreateLyrics(font, Color1, "　　　　　　　　　　よう", FontName, FontSize, 0.5f, new Vector2(320, 435), 59500, 59874);

            CreateLyrics(font, Color1, "こ　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 60250, 63999);
            CreateLyrics(font, Color1, "　の　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 60624, 63999);
            CreateLyrics(font, Color1, "　　道　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 61000, 63999);
            CreateLyrics(font, Color1, "　　　は　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 61750, 63999);
            CreateLyrics(font, Color1, "　　　　そう", FontName, FontSize, 0.5f, new Vector2(320, 435), 62124, 63999);

            CreateLyrics(font, Color1, "未　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 64374, 69437);
            CreateLyrics(font, Color1, "　来　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 64749, 69437);
            CreateLyrics(font, Color1, "　　へ　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 65500, 69437);
            CreateLyrics(font, Color1, "　　　続　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 67374, 69437);
            CreateLyrics(font, Color1, "　　　　く　", FontName, FontSize, 0.5f, new Vector2(320, 435), 68124, 69437);
            CreateLyrics(font, Color1, "　　　　　道", FontName, FontSize, 0.5f, new Vector2(320, 435), 68500, 69437);

            CreateLyrics(font, Color1, "そん　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 69624, 74500);
            CreateLyrics(font, Color1, "　　な　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 70000, 74500);
            CreateLyrics(font, Color1, "　　　気　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 70374, 74500);
            CreateLyrics(font, Color1, "　　　　が　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 70562, 74500);
            CreateLyrics(font, Color1, "　　　　　し　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 70899, 74500);
            CreateLyrics(font, Color1, "　　　　　　た　", FontName, FontSize, 0.5f, new Vector2(320, 435), 71312, 74500);
            CreateLyrics(font, Color1, "　　　　　　　の", FontName, FontSize, 0.5f, new Vector2(320, 435), 71500, 74500);

            LyricsBackground(48250, 74500);

            CreateLyrics(font, Color1, "例　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 76381, 84437);
            CreateLyrics(font, Color1, "　年　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 77112, 84437);
            CreateLyrics(font, Color1, "　　よ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 78624, 84437);
            CreateLyrics(font, Color1, "　　　り　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 78812, 84437);
            CreateLyrics(font, Color1, "　　　　早　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 79750, 84437);
            CreateLyrics(font, Color1, "　　　　　い　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 80500, 84437);
            CreateLyrics(font, Color3, "　　　　　　開　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 81624, 84437);
            CreateLyrics(font, Color3, "　　　　　　　花　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 82000, 84437);
            CreateLyrics(font, Color1, "　　　　　　　　予　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 82374, 84437);
            CreateLyrics(font, Color1, "　　　　　　　　　想　", FontName, FontSize, 0.5f, new Vector2(320, 435), 82562, 84437);
            CreateLyrics(font, Color1, "　　　　　　　　　　を", FontName, FontSize, 0.5f, new Vector2(320, 435), 83312, 84437);

            CreateLyrics(font, Color1, "キ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 84624, 88729);
            CreateLyrics(font, Color1, "　ミ　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 85000, 88729);
            CreateLyrics(font, Color1, "　　は　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 85374, 88729);
            CreateLyrics(font, Color4, "　　　嬉　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 85750, 88729);
            CreateLyrics(font, Color4, "　　　　し　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 86500, 88729);
            CreateLyrics(font, Color1, "　　　　　が　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 87051, 88729);
            CreateLyrics(font, Color1, "　　　　　　って　", FontName, FontSize, 0.5f, new Vector2(320, 435), 87614, 88729);
            CreateLyrics(font, Color1, "　　　　　　　　た", FontName, FontSize, 0.5f, new Vector2(320, 435), 87801, 88729);

            CreateLyrics(font, Color1, "私　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 89100, 93244);
            CreateLyrics(font, Color1, "　は　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 90058, 93244);
            CreateLyrics(font, Color1, "　　笑　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 90624, 93244);
            CreateLyrics(font, Color1, "　　　って　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 91554, 93244);
            CreateLyrics(font, Color1, "　　　　　「　　　　」", FontName, FontSize, 0.5f, new Vector2(320, 435), 92106, 93244);
            CreateLyrics(font, Color5, "　　　　　　そう　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 92106, 93244);
            CreateLyrics(font, Color5, "　　　　　　　　だ　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 92494, 93244);
            CreateLyrics(font, Color5, "　　　　　　　　　ね　", FontName, FontSize, 0.5f, new Vector2(320, 435), 93057, 93244);

            CreateLyrics(font, Color1, "って　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 93432, 95124);
            CreateLyrics(font, Color5, "　　言　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 94000, 95124);
            CreateLyrics(font, Color5, "　　　った", FontName, FontSize, 0.5f, new Vector2(320, 435), 94562, 95124);

            CreateLyrics(font, Color1, "あ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 95490, 97552);
            CreateLyrics(font, Color1, "　と　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 95677, 97552);
            CreateLyrics(font, Color1, "　　少　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 95864, 97552);
            CreateLyrics(font, Color1, "　　　し　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 96240, 97552);
            CreateLyrics(font, Color1, "　　　　し　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 96614, 97552);
            CreateLyrics(font, Color1, "　　　　　た　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 96802, 97552);
            CreateLyrics(font, Color1, "　　　　　　ら　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 96990, 97552);
            CreateLyrics(font, Color1, "　　　　　　　もう", FontName, FontSize, 0.5f, new Vector2(320, 435), 97177, 97552);

            CreateLyrics(font, Color1, "こ　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 97740, 101376);
            CreateLyrics(font, Color1, "　こ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 97927, 101376);
            CreateLyrics(font, Color1, "　　に　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 98114, 101376);
            CreateLyrics(font, Color1, "　　　は　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 98323, 101376);
            CreateLyrics(font, Color6, "　　　　戻　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 98490, 101376);
            CreateLyrics(font, Color6, "　　　　　れ　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 99240, 101376);
            CreateLyrics(font, Color6, "　　　　　　な　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 99802, 101376);
            CreateLyrics(font, Color6, "　　　　　　　い　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 99990, 101376);
            CreateLyrics(font, Color1, "　　　　　　　　の　", FontName, FontSize, 0.5f, new Vector2(320, 435), 100551, 101376);
            CreateLyrics(font, Color1, "　　　　　　　　　に", FontName, FontSize, 0.5f, new Vector2(320, 435), 100759, 101376);

            CreateLyrics(font, Color1, "言　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 101500, 104124);
            CreateLyrics(font, Color1, "　葉　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 101874, 104124);
            CreateLyrics(font, Color1, "　　じゃ　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 102062, 104124);
            CreateLyrics(font, Color1, "　　　　う　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 102250, 104124);
            CreateLyrics(font, Color1, "　　　　　ま　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 102437, 104124);
            CreateLyrics(font, Color1, "　　　　　　く　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 102624, 104124);
            CreateLyrics(font, Color1, "　　　　　　　言　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 102812, 104124);
            CreateLyrics(font, Color1, "　　　　　　　　え　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 103000, 104124);
            CreateLyrics(font, Color1, "　　　　　　　　　ない　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 103187, 104124);
            CreateLyrics(font, Color1, "　　　　　　　　　　　想　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 103374, 104124);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　い　", FontName, FontSize, 0.5f, new Vector2(320, 435), 103750, 104124);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　　を", FontName, FontSize, 0.5f, new Vector2(320, 435), 103937, 104124);

            CreateLyrics(font, Color1, "キ　　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 104312, 107312);
            CreateLyrics(font, Color1, "　ミ　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 104500, 107312);
            CreateLyrics(font, Color1, "　　に　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 104687, 107312);
            CreateLyrics(font, Color1, "　　　打　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 104874, 107312);
            CreateLyrics(font, Color1, "　　　　ち　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 105062, 107312);
            CreateLyrics(font, Color1, "　　　　　明　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 105250, 107312);
            CreateLyrics(font, Color1, "　　　　　　け　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 105437, 107312);
            CreateLyrics(font, Color1, "　　　　　　　る　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 105624, 107312);
            CreateLyrics(font, Color1, "　　　　　　　　と　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 105812, 107312);
            CreateLyrics(font, Color1, "　　　　　　　　　し　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 106000, 107312);
            CreateLyrics(font, Color1, "　　　　　　　　　　た　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 106187, 107312);
            CreateLyrics(font, Color1, "　　　　　　　　　　　ら　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 106374, 107312);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　なん　", FontName, FontSize, 0.5f, new Vector2(320, 435), 106562, 107312);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　　　て", FontName, FontSize, 0.5f, new Vector2(320, 435), 106937, 107312);

            CreateLyrics(font, Color1, "つ　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 107500, 109000);
            CreateLyrics(font, Color1, "　た　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 108250, 109000);
            CreateLyrics(font, Color2, "　伝　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 109000, 111250);
            CreateLyrics(font, Color1, "　　え　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 109000, 111250);
            CreateLyrics(font, Color1, "　　　よ　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 109750, 111250);
            CreateLyrics(font, Color1, "　　　　う　", FontName, FontSize, 0.5f, new Vector2(320, 435), 110500, 111250);

            CreateLyrics(font, Color1, "最　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 111624, 113312);
            CreateLyrics(font, Color1, "　初　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 112000, 113312);
            CreateLyrics(font, Color1, "　　で　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 112374, 113312);
            CreateLyrics(font, Color1, "　　　最　", FontName, FontSize, 0.5f, new Vector2(320, 435), 112562, 113312);
            CreateLyrics(font, Color1, "　　　　後", FontName, FontSize, 0.5f, new Vector2(320, 435), 112937, 113312);

            CreateLyrics(font, Color1, "い　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 113500, 116124);
            CreateLyrics(font, Color1, "　つか　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 113874, 116124);
            CreateLyrics(font, Color1, "　　　一　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 114062, 116124);
            CreateLyrics(font, Color1, "　　　　緒　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 114437, 116124);
            CreateLyrics(font, Color1, "　　　　　に　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 114624, 116124);
            CreateLyrics(font, Color1, "　　　　　　帰　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 114812, 116124);
            CreateLyrics(font, Color1, "　　　　　　　った　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 115374, 116124);
            CreateLyrics(font, Color1, "　　　　　　　　　道　", FontName, FontSize, 0.5f, new Vector2(320, 435), 115562, 116124);
            CreateLyrics(font, Color1, "　　　　　　　　　　は", FontName, FontSize, 0.5f, new Vector2(320, 435), 115937, 116124);

            CreateLyrics(font, Color1, "私　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 116312, 119312);
            CreateLyrics(font, Color1, "　に　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 116687, 119312);
            CreateLyrics(font, Color1, "　　と　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 116874, 119312);
            CreateLyrics(font, Color1, "　　　って　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 117250, 119312);
            CreateLyrics(font, Color3, "　　　　　特　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 117437, 119312);
            CreateLyrics(font, Color3, "　　　　　　別　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 117812, 119312);
            CreateLyrics(font, Color1, "　　　　　　　な　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 118187, 119312);
            CreateLyrics(font, Color1, "　　　　　　　　思　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 118374, 119312);
            CreateLyrics(font, Color1, "　　　　　　　　　い　", FontName, FontSize, 0.5f, new Vector2(320, 435), 118750, 119312);
            CreateLyrics(font, Color1, "　　　　　　　　　　出", FontName, FontSize, 0.5f, new Vector2(320, 435), 118937, 119312);

            CreateLyrics(font, Color1, "わ　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 119500, 121000);
            CreateLyrics(font, Color1, "　す　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 120250, 121000);
            CreateLyrics(font, Color2, "　忘　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 121000, 123437);
            CreateLyrics(font, Color1, "　　れ　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 121000, 123437);
            CreateLyrics(font, Color6, "　　　ない　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 121750, 123437);
            CreateLyrics(font, Color1, "　　　　　よ　", FontName, FontSize, 0.5f, new Vector2(320, 435), 122500, 123437);

            CreateLyrics(font, Color1, "さ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 123624, 125312);
            CreateLyrics(font, Color1, "　よ　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 123812, 125312);
            CreateLyrics(font, Color1, "　　な　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 124000, 125312);
            CreateLyrics(font, Color1, "　　　ら　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 124187, 125312);
            CreateLyrics(font, Color1, "　　　　メ　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 124374, 125312);
            CreateLyrics(font, Color1, "　　　　　モ　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 124562, 125312);
            CreateLyrics(font, Color1, "　　　　　　リー　", FontName, FontSize, 0.5f, new Vector2(320, 435), 124937, 125312);
            CreateLyrics(font, Color1, "　　　　　　　　ズ", FontName, FontSize, 0.5f, new Vector2(320, 435), 125124, 125312);

            CreateLyrics(font, Color4, "春　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 125500, 127937);
            CreateLyrics(font, Color1, "　が　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 125874, 127937);
            CreateLyrics(font, Color1, "　　来　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 126062, 127937);
            CreateLyrics(font, Color1, "　　　た　", FontName, FontSize, 0.5f, new Vector2(320, 435), 126437, 127937);
            CreateLyrics(font, Color1, "　　　　ら", FontName, FontSize, 0.5f, new Vector2(320, 435), 126624, 127937);

            CreateLyrics(font, Color1, "そ　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 128124, 133750);
            CreateLyrics(font, Color1, "　れ　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 128322, 133750);
            CreateLyrics(font, Color1, "　　ぞ　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 128520, 133750);
            CreateLyrics(font, Color1, "　　　れ　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 129270, 133750);
            CreateLyrics(font, Color1, "　　　　の　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 130020, 133750);
            CreateLyrics(font, Color1, "　　　　　道　", FontName, FontSize, 0.5f, new Vector2(320, 435), 130750, 133750);
            CreateLyrics(font, Color1, "　　　　　　を", FontName, FontSize, 0.5f, new Vector2(320, 435), 131500, 133750);

            CreateLyrics(font, Color1, "（は　）", FontName, FontSize, 0.5f, new Vector2(320, 435), 133937, 136000);
            CreateLyrics(font, Color1, "　　あ　", FontName, FontSize, 0.5f, new Vector2(320, 435), 134312, 136000);

            LyricsBackground(76381, 136000);

            CreateLyrics(font, Color1, "ま　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 144250, 151009);
            CreateLyrics(font, Color1, "　た　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 144620, 151009);
            CreateLyrics(font, Color1, "　　会　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 144990, 151009);
            CreateLyrics(font, Color1, "　　　え　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 145360, 151009);
            CreateLyrics(font, Color1, "　　　　る　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 145753, 151009);
            CreateLyrics(font, Color1, "　　　　　日　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 146126, 151009);
            CreateLyrics(font, Color1, "　　　　　　を　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 146509, 151009);
            CreateLyrics(font, Color5, "　　　　　　　願　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 148384, 151009);
            CreateLyrics(font, Color5, "　　　　　　　　って", FontName, FontSize, 0.5f, new Vector2(320, 435), 149509, 151009);

            CreateLyrics(font, Color1, "さ　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 151384, 153259);
            CreateLyrics(font, Color1, "　よ　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 151759, 153259);
            CreateLyrics(font, Color1, "　　な　", FontName, FontSize, 0.5f, new Vector2(320, 435), 152134, 153259);
            CreateLyrics(font, Color1, "　　　ら", FontName, FontSize, 0.5f, new Vector2(320, 435), 152509, 153259);

            CreateLyrics(font, Color1, "小　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 153634, 155880);
            CreateLyrics(font, Color1, "　さ　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 154009, 155880);
            CreateLyrics(font, Color1, "　　く　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 154197, 155880);
            CreateLyrics(font, Color1, "　　　つ　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 154384, 155880);
            CreateLyrics(font, Color1, "　　　　ぶ　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 154572, 155880);
            CreateLyrics(font, Color1, "　　　　　や　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 154947, 155880);
            CreateLyrics(font, Color1, "　　　　　　い　", FontName, FontSize, 0.5f, new Vector2(320, 435), 155321, 155880);
            CreateLyrics(font, Color1, "　　　　　　　た", FontName, FontSize, 0.5f, new Vector2(320, 435), 155488, 155880);

            CreateLyrics(font, Color5, "空　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 156259, 163000);
            CreateLyrics(font, Color1, "　は　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 157009, 163000);
            CreateLyrics(font, Color1, "　　あ　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 157369, 163000);
            CreateLyrics(font, Color1, "　　　の　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 157759, 163000);
            CreateLyrics(font, Color1, "　　　　日　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 158126, 163000);
            CreateLyrics(font, Color1, "　　　　　と　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 158501, 163000);
            CreateLyrics(font, Color1, "　　　　　　変　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 160373, 163000);
            CreateLyrics(font, Color1, "　　　　　　　わ　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 160744, 163000);
            CreateLyrics(font, Color1, "　　　　　　　　ら　", FontName, FontSize, 0.5f, new Vector2(320, 435), 161119, 163000);
            CreateLyrics(font, Color1, "　　　　　　　　　ず", FontName, FontSize, 0.5f, new Vector2(320, 435), 161500, 163000);

            CreateLyrics(font, Color5, "青　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 163374, 169936);
            CreateLyrics(font, Color1, "　く　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 164124, 169936);
            CreateLyrics(font, Color1, "　　て　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 164500, 169936);
            CreateLyrics(font, Color1, "　　　　だ　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 165624, 169936);
            CreateLyrics(font, Color1, "　　　　　か　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 165812, 169936);
            CreateLyrics(font, Color1, "　　　　　　ら　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 166000, 169936);
            CreateLyrics(font, Color1, "　　　　　　　ちょ　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 166557, 169936);
            CreateLyrics(font, Color1, "　　　　　　　　　っと　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 166932, 169936);
            CreateLyrics(font, Color5, "　　　　　　　　　　　泣　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 167115, 169936);
            CreateLyrics(font, Color5, "　　　　　　　　　　　　け　", FontName, FontSize, 0.5f, new Vector2(320, 435), 167298, 169936);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　　た", FontName, FontSize, 0.5f, new Vector2(320, 435), 167479, 169936);


            LyricsBackground(144250, 169936);

            CreateLyrics(font, Color1, "わ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 172364, 177240);
            CreateLyrics(font, Color1, "　ざ　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 172740, 177240);
            CreateLyrics(font, Color1, "　　と　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 173114, 177240);
            CreateLyrics(font, Color1, "　　　遠　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 173470, 177240);
            CreateLyrics(font, Color1, "　　　　回　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 174614, 177240);
            CreateLyrics(font, Color1, "　　　　　り　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 175364, 177240);
            CreateLyrics(font, Color1, "　　　　　　し　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 175740, 177240);
            CreateLyrics(font, Color1, "　　　　　　　た　", FontName, FontSize, 0.5f, new Vector2(320, 435), 176114, 177240);
            CreateLyrics(font, Color1, "　　　　　　　　の", FontName, FontSize, 0.5f, new Vector2(320, 435), 176302, 177240);

            CreateLyrics(font, Color1, "少　　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 177614, 184732);
            CreateLyrics(font, Color1, "　し　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 178364, 184732);
            CreateLyrics(font, Color1, "　　で　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 178552, 184732);
            CreateLyrics(font, Color1, "　　　も　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 178927, 184732);
            CreateLyrics(font, Color1, "　　　　長　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 179302, 184732);
            CreateLyrics(font, Color1, "　　　　　く　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 180052, 184732);
            CreateLyrics(font, Color3, "　　　　　　キ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 180614, 184732);
            CreateLyrics(font, Color3, "　　　　　　　ミ　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 180990, 184732);
            CreateLyrics(font, Color3, "　　　　　　　　の　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 181364, 184732);
            CreateLyrics(font, Color3, "　　　　　　　　　隣　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 181734, 184732);
            CreateLyrics(font, Color1, "　　　　　　　　　　に　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 182861, 184732);
            CreateLyrics(font, Color1, "　　　　　　　　　　　い　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 183050, 184732);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　た　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 183428, 184732);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　　く　", FontName, FontSize, 0.5f, new Vector2(320, 435), 183615, 184732);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　　　て", FontName, FontSize, 0.5f, new Vector2(320, 435), 183803, 184732);

            CreateLyrics(font, Color1, "私　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 185106, 189242);
            CreateLyrics(font, Color1, "　は　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 186061, 189242);
            CreateLyrics(font, Color1, "　　お　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 186620, 189242);
            CreateLyrics(font, Color1, "　　　ど　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 186992, 189242);
            CreateLyrics(font, Color1, "　　　　け　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 187180, 189242);
            CreateLyrics(font, Color1, "　　　　　て　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 187555, 189242);
            CreateLyrics(font, Color1, "　　　　　　「　　　　　　」", FontName, FontSize, 0.5f, new Vector2(320, 435), 188117, 189242);
            CreateLyrics(font, Color5, "　　　　　　　ま　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 188117, 189242);
            CreateLyrics(font, Color5, "　　　　　　　　ち　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 188305, 189242);
            CreateLyrics(font, Color5, "　　　　　　　　　が　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 188492, 189242);
            CreateLyrics(font, Color5, "　　　　　　　　　　え　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 188867, 189242);
            CreateLyrics(font, Color5, "　　　　　　　　　　　た！　", FontName, FontSize, 0.5f, new Vector2(320, 435), 189055, 189242);

            CreateLyrics(font, Color1, "って　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 189435, 191305);
            CreateLyrics(font, Color5, "　　言　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 189992, 191305);
            CreateLyrics(font, Color5, "　　　った", FontName, FontSize, 0.5f, new Vector2(320, 435), 190555, 191305);

            CreateLyrics(font, Color1, "キ　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 191492, 193555);
            CreateLyrics(font, Color1, "　ミ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 191680, 193555);
            CreateLyrics(font, Color1, "　　は　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 191867, 193555);
            CreateLyrics(font, Color4, "　　　笑　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 192055, 193555);
            CreateLyrics(font, Color4, "　　　　う　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 192430, 193555);
            CreateLyrics(font, Color1, "　　　　　　そ　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 192617, 193555);
            CreateLyrics(font, Color1, "　　　　　　　の　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 192805, 193555);
            CreateLyrics(font, Color1, "　　　　　　　　顔　", FontName, FontSize, 0.5f, new Vector2(320, 435), 192992, 193555);
            CreateLyrics(font, Color1, "　　　　　　　　　が", FontName, FontSize, 0.5f, new Vector2(320, 435), 193367, 193555);

            CreateLyrics(font, Color2, "ま　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 193742, 197322);
            CreateLyrics(font, Color2, "　ぶ　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 193930, 197322);
            CreateLyrics(font, Color2, "　　し　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 194117, 197322);
            CreateLyrics(font, Color2, "　　　く　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 194305, 197322);
            CreateLyrics(font, Color2, "　　　　て　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 194492, 197322);
            CreateLyrics(font, Color1, "　　　　　目　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 195055, 197322);
            CreateLyrics(font, Color1, "　　　　　　を　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 195242, 197322);
            CreateLyrics(font, Color1, "　　　　　　　そ　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 195805, 197322);
            CreateLyrics(font, Color1, "　　　　　　　　ら　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 195992, 197322);
            CreateLyrics(font, Color1, "　　　　　　　　　し　", FontName, FontSize, 0.5f, new Vector2(320, 435), 196559, 197322);
            CreateLyrics(font, Color1, "　　　　　　　　　　た", FontName, FontSize, 0.5f, new Vector2(320, 435), 196746, 197322);

            CreateLyrics(font, Color1, "言　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 197490, 200124);
            CreateLyrics(font, Color1, "　葉　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 197858, 200124);
            CreateLyrics(font, Color1, "　　じゃ　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 198054, 200124);
            CreateLyrics(font, Color1, "　　　　う　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 198250, 200124);
            CreateLyrics(font, Color1, "　　　　　ま　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 198437, 200124);
            CreateLyrics(font, Color1, "　　　　　　く　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 198624, 200124);
            CreateLyrics(font, Color1, "　　　　　　　言　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 198812, 200124);
            CreateLyrics(font, Color1, "　　　　　　　　え　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 199000, 200124);
            CreateLyrics(font, Color1, "　　　　　　　　　ない　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 199187, 200124);
            CreateLyrics(font, Color1, "　　　　　　　　　　　想　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 199374, 200124);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　い　", FontName, FontSize, 0.5f, new Vector2(320, 435), 199750, 200124);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　　を", FontName, FontSize, 0.5f, new Vector2(320, 435), 199937, 200124);

            CreateLyrics(font, Color1, "胸　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 200311, 203317);
            CreateLyrics(font, Color1, "　に　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 200696, 203317);
            CreateLyrics(font, Color1, "　　抱　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 200880, 203317);
            CreateLyrics(font, Color1, "　　　い　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 201067, 203317);
            CreateLyrics(font, Color1, "　　　　て　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 201254, 203317);
            CreateLyrics(font, Color1, "　　　　　こ　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 201442, 203317);
            CreateLyrics(font, Color1, "　　　　　　の　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 201630, 203317);
            CreateLyrics(font, Color1, "　　　　　　　道　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 201816, 203317);
            CreateLyrics(font, Color1, "　　　　　　　　を　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 202191, 203317);
            CreateLyrics(font, Color1, "　　　　　　　　　歩　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 202374, 203317);
            CreateLyrics(font, Color1, "　　　　　　　　　　い　", FontName, FontSize, 0.5f, new Vector2(320, 435), 202750, 203317);
            CreateLyrics(font, Color1, "　　　　　　　　　　　た", FontName, FontSize, 0.5f, new Vector2(320, 435), 202937, 203317);

            CreateLyrics(font, Color1, "お　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 203509, 205009);
            CreateLyrics(font, Color1, "　ぼ　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 204259, 205009);
            CreateLyrics(font, Color2, "　覚　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 205009, 207250);
            CreateLyrics(font, Color1, "　　え　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 205009, 207250);
            CreateLyrics(font, Color1, "　　　て　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 205750, 207250);
            CreateLyrics(font, Color1, "　　　　る　", FontName, FontSize, 0.5f, new Vector2(320, 435), 206504, 207250);

            CreateLyrics(font, Color1, "あ　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 207624, 209317);
            CreateLyrics(font, Color1, "　の　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 207812, 209317);
            CreateLyrics(font, Color1, "　　時　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 208000, 209317);
            CreateLyrics(font, Color1, "　　　キ　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 208374, 209317);
            CreateLyrics(font, Color1, "　　　　ミ　", FontName, FontSize, 0.5f, new Vector2(320, 435), 208562, 209317);
            CreateLyrics(font, Color1, "　　　　　は", FontName, FontSize, 0.5f, new Vector2(320, 435), 208937, 209317);

            CreateLyrics(font, Color1, "私　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 209509, 212130);
            CreateLyrics(font, Color1, "　の　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 210069, 212130);
            CreateLyrics(font, Color1, "　　名　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 210255, 212130);
            CreateLyrics(font, Color1, "　　　前　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 210441, 212130);
            CreateLyrics(font, Color1, "　　　　を　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 210814, 212130);
            CreateLyrics(font, Color1, "　　　　　呼ん　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 211000, 212130);
            CreateLyrics(font, Color1, "　　　　　　　で　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 211376, 212130);
            CreateLyrics(font, Color1, "　　　　　　　　く　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 211472, 212130);
            CreateLyrics(font, Color1, "　　　　　　　　　れ　", FontName, FontSize, 0.5f, new Vector2(320, 435), 211568, 212130);
            CreateLyrics(font, Color1, "　　　　　　　　　　た", FontName, FontSize, 0.5f, new Vector2(320, 435), 211945, 212130);

            CreateLyrics(font, Color1, "二　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 212320, 215311);
            CreateLyrics(font, Color1, "　人　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 212697, 215311);
            CreateLyrics(font, Color2, "　　　夕　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 213072, 215311);
            CreateLyrics(font, Color2, "　　　　暮　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 213447, 215311);
            CreateLyrics(font, Color2, "　　　　　れ　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 213634, 215311);
            CreateLyrics(font, Color1, "　　　　　　の　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 213822, 215311);
            CreateLyrics(font, Color1, "　　　　　　　帰　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 214009, 215311);
            CreateLyrics(font, Color1, "　　　　　　　　り　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 214369, 215311);
            CreateLyrics(font, Color1, "　　　　　　　　　道　", FontName, FontSize, 0.5f, new Vector2(320, 435), 214571, 215311);
            CreateLyrics(font, Color1, "　　　　　　　　　　で", FontName, FontSize, 0.5f, new Vector2(320, 435), 214947, 215311);

            CreateLyrics(font, Color1, "わ　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 215500, 217004);
            CreateLyrics(font, Color1, "　す　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 216244, 217004);
            CreateLyrics(font, Color2, "　忘　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 217004, 219240);
            CreateLyrics(font, Color1, "　　れ　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 217004, 219240);
            CreateLyrics(font, Color6, "　　　ない　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 217750, 219240);
            CreateLyrics(font, Color1, "　　　　　よ　", FontName, FontSize, 0.5f, new Vector2(320, 435), 218490, 219240);

            CreateLyrics(font, Color1, "さ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 219614, 221315);
            CreateLyrics(font, Color1, "　よ　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 219814, 221315);
            CreateLyrics(font, Color1, "　　な　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 220000, 221315);
            CreateLyrics(font, Color1, "　　　ら　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 220187, 221315);
            CreateLyrics(font, Color1, "　　　　メ　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 220374, 221315);
            CreateLyrics(font, Color1, "　　　　　モ　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 220562, 221315);
            CreateLyrics(font, Color1, "　　　　　　リー　", FontName, FontSize, 0.5f, new Vector2(320, 435), 220925, 221315);
            CreateLyrics(font, Color1, "　　　　　　　　ズ", FontName, FontSize, 0.5f, new Vector2(320, 435), 221120, 221315);

            CreateLyrics(font, Color1, "出　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 221509, 223752);
            CreateLyrics(font, Color1, "　会　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 221703, 223752);
            CreateLyrics(font, Color1, "　　え　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 221896, 223752);
            CreateLyrics(font, Color1, "　　　た　", FontName, FontSize, 0.5f, new Vector2(320, 435), 222074, 223752);
            CreateLyrics(font, Color1, "　　　　事", FontName, FontSize, 0.5f, new Vector2(320, 435), 222433, 223752);

            CreateLyrics(font, Color5, "感　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 224129, 227884);
            CreateLyrics(font, Color5, "　謝　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 224520, 227884);
            CreateLyrics(font, Color1, "　　し　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 225283, 227884);
            CreateLyrics(font, Color1, "　　　て　", FontName, FontSize, 0.5f, new Vector2(320, 435), 226009, 227884);
            CreateLyrics(font, Color1, "　　　　る", FontName, FontSize, 0.5f, new Vector2(320, 435), 226759, 227884);

            CreateLyrics(font, Color1, "初　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 228633, 235936);
            CreateLyrics(font, Color1, "　め　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 229382, 235936);
            CreateLyrics(font, Color1, "　　て　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 229569, 235936);
            CreateLyrics(font, Color1, "　　　み　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 229944, 235936);
            CreateLyrics(font, Color1, "　　　　た　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 230318, 235936);
            CreateLyrics(font, Color3, "　　　　　満　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 231629, 235936);
            CreateLyrics(font, Color3, "　　　　　　開　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 232004, 235936);
            CreateLyrics(font, Color3, "　　　　　　　の　", FontName, FontSize, 0.5f, new Vector2(320, 435), 232378, 235936);
            CreateLyrics(font, Color3, "　　　　　　　　桜", FontName, FontSize, 0.5f, new Vector2(320, 435), 232566, 235936);

            CreateLyrics(font, Color1, "（は　）", FontName, FontSize, 0.5f, new Vector2(320, 435), 236311, 238759);
            CreateLyrics(font, Color1, "　　あ　", FontName, FontSize, 0.5f, new Vector2(320, 435), 236498, 238759);

            LyricsBackground(172364, 238759);

            CreateLyrics(font, Color1, "あ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 240614, 247724);
            CreateLyrics(font, Color1, "　れ　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 240990, 247724);
            CreateLyrics(font, Color1, "　　か　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 241740, 247724);
            CreateLyrics(font, Color1, "　　　ら　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 242490, 247724);
            CreateLyrics(font, Color1, "　　　　ど　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 243240, 247724);
            CreateLyrics(font, Color1, "　　　　　れ　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 243990, 247724);
            CreateLyrics(font, Color1, "　　　　　　ぐ　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 244740, 247724);
            CreateLyrics(font, Color1, "　　　　　　　らい", FontName, FontSize, 0.5f, new Vector2(320, 435), 245500, 247724);

            CreateLyrics(font, Color1, "買　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 248119, 254490);
            CreateLyrics(font, Color1, "　わ　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 248500, 254490);
            CreateLyrics(font, Color1, "　　れ　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 249242, 254490);
            CreateLyrics(font, Color1, "　　　たん　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 249982, 254490);
            CreateLyrics(font, Color1, "　　　　　だ　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 250712, 254490);
            CreateLyrics(font, Color1, "　　　　　　ろう", FontName, FontSize, 0.5f, new Vector2(320, 435), 251479, 254490);

            LyricsBackground(240614, 254490);

            CreateLyrics(font, Color1, "一　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 275480, 278105);
            CreateLyrics(font, Color1, "　目　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 275855, 278105);
            CreateLyrics(font, Color1, "　　見　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 276042, 278105);
            CreateLyrics(font, Color1, "　　　た　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 276230, 278105);
            CreateLyrics(font, Color1, "　　　　時　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 276417, 278105);
            CreateLyrics(font, Color1, "　　　　　に　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 276792, 278105);
            CreateLyrics(font, Color1, "　　　　　　思　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 276980, 278105);
            CreateLyrics(font, Color1, "　　　　　　　ったん　", FontName, FontSize, 0.5f, new Vector2(320, 435), 277542, 278105);
            CreateLyrics(font, Color1, "　　　　　　　　　　だ", FontName, FontSize, 0.5f, new Vector2(320, 435), 277917, 278105);

            CreateLyrics(font, Color1, "こ　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 278292, 281292);
            CreateLyrics(font, Color1, "　の　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 278480, 281292);
            CreateLyrics(font, Color1, "　　人　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 278667, 281292);
            CreateLyrics(font, Color1, "　　　の　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 279042, 281292);
            CreateLyrics(font, Color1, "　　　　事　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 279230, 281292);
            CreateLyrics(font, Color3, "　　　　　好　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 279605, 281292);
            CreateLyrics(font, Color3, "　　　　　　き　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 279792, 281292);
            CreateLyrics(font, Color1, "　　　　　　　に　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 279980, 281292);
            CreateLyrics(font, Color1, "　　　　　　　　な　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 280167, 281292);
            CreateLyrics(font, Color1, "　　　　　　　　　り　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 280355, 281292);
            CreateLyrics(font, Color1, "　　　　　　　　　　そう　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 280542, 281292);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　って", FontName, FontSize, 0.5f, new Vector2(320, 435), 280917, 281292);

            CreateLyrics(font, Color1, "な　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 281480, 282980);
            CreateLyrics(font, Color1, "　ん　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 282230, 282980);
            CreateLyrics(font, Color2, "　何　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 282980, 285417);
            CreateLyrics(font, Color1, "　　で　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 282980, 285417);
            CreateLyrics(font, Color1, "　　　か　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 283730, 285417);
            CreateLyrics(font, Color1, "　　　　な　", FontName, FontSize, 0.5f, new Vector2(320, 435), 284480, 285417);

            CreateLyrics(font, Color1, "わ　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 285605, 287307);
            CreateLyrics(font, Color1, "　か　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 285980, 287307);
            CreateLyrics(font, Color1, "　　ん　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 286355, 287307);
            CreateLyrics(font, Color1, "　　　な　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 286542, 287307);
            CreateLyrics(font, Color1, "　　　　い　", FontName, FontSize, 0.5f, new Vector2(320, 435), 286730, 287307);
            CreateLyrics(font, Color1, "　　　　　よ", FontName, FontSize, 0.5f, new Vector2(320, 435), 286917, 287307);

            CreateLyrics(font, Color1, "そ　　　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 287510, 291260);
            CreateLyrics(font, Color1, "　れ　　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 287697, 291260);
            CreateLyrics(font, Color1, "　　か　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 287885, 291260);
            CreateLyrics(font, Color1, "　　　ら　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 288072, 291260);
            CreateLyrics(font, Color1, "　　　　の　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 288260, 291260);
            CreateLyrics(font, Color1, "　　　　　毎　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 288447, 291260);
            CreateLyrics(font, Color1, "　　　　　　日　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 288822, 291260);
            CreateLyrics(font, Color1, "　　　　　　　は　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 289197, 291260);
            CreateLyrics(font, Color1, "　　　　　　　　と　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 289385, 291260);
            CreateLyrics(font, Color1, "　　　　　　　　　て　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 289572, 291260);
            CreateLyrics(font, Color1, "　　　　　　　　　　も　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 289947, 291260);
            CreateLyrics(font, Color1, "　　　　　　　　　　　楽　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 290322, 291260);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　し　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 290697, 291260);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　　く　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 290885, 291260);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　　　って", FontName, FontSize, 0.5f, new Vector2(320, 435), 291072, 291260);

            CreateLyrics(font, Color1, "だ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 291447, 293322);
            CreateLyrics(font, Color1, "　け　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 291635, 293322);
            CreateLyrics(font, Color1, "　　ど　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 291822, 293322);
            CreateLyrics(font, Color1, "　　　同　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 292010, 293322);
            CreateLyrics(font, Color1, "　　　　じ　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 292385, 293322);
            CreateLyrics(font, Color1, "　　　　　く　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 292572, 293322);
            CreateLyrics(font, Color1, "　　　　　　らい　", FontName, FontSize, 0.5f, new Vector2(320, 435), 292760, 293322);
            CreateLyrics(font, Color1, "　　　　　　　　に", FontName, FontSize, 0.5f, new Vector2(320, 435), 292947, 293322);

            CreateLyrics(font, Color1, "つ　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 293510, 295010);
            CreateLyrics(font, Color1, "　ら　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 294260, 295010);
            CreateLyrics(font, Color2, "　辛　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 295010, 297596);
            CreateLyrics(font, Color1, "　　か　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 295010, 297596);
            CreateLyrics(font, Color1, "　　　ったん　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 295760, 297596);
            CreateLyrics(font, Color1, "　　　　　　だ　", FontName, FontSize, 0.5f, new Vector2(320, 435), 296500, 297596);

            CreateLyrics(font, Color1, "（はあ）", FontName, FontSize, 0.5f, new Vector2(320, 435), 297971, 299096);

            CreateLyrics(font, Color1, "ご　　　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 299284, 302114);
            CreateLyrics(font, Color1, "　めん　　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 299471, 302114);
            CreateLyrics(font, Color1, "　　　ね　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 299846, 302114);
            CreateLyrics(font, Color1, "　　　　　なん　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 300034, 302114);
            CreateLyrics(font, Color1, "　　　　　　　か　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 300428, 302114);
            CreateLyrics(font, Color1, "　　　　　　　　う　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 300635, 302114);
            CreateLyrics(font, Color1, "　　　　　　　　　ま　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 300802, 302114);
            CreateLyrics(font, Color1, "　　　　　　　　　　く　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 301000, 302114);
            CreateLyrics(font, Color1, "　　　　　　　　　　　言　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 301175, 302114);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　え　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 301350, 302114);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　　ない　", FontName, FontSize, 0.5f, new Vector2(320, 435), 301537, 302114);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　　　　よ", FontName, FontSize, 0.5f, new Vector2(320, 435), 301920, 302114);

            CreateLyrics(font, Color1, "だ　　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 302285, 305295);
            CreateLyrics(font, Color1, "　か　　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 302474, 305295);
            CreateLyrics(font, Color1, "　　ら　　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 302664, 305295);
            CreateLyrics(font, Color1, "　　　私　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 302853, 305295);
            CreateLyrics(font, Color1, "　　　　　君　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 303426, 305295);
            CreateLyrics(font, Color1, "　　　　　　と　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 303799, 305295);
            CreateLyrics(font, Color1, "　　　　　　　なん　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 303989, 305295);
            CreateLyrics(font, Color1, "　　　　　　　　　て　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 304364, 305295);
            CreateLyrics(font, Color1, "　　　　　　　　　　いう　", FontName, FontSize, 0.5f, new Vector2(320, 435), 304552, 305295);
            CreateLyrics(font, Color1, "　　　　　　　　　　　　か", FontName, FontSize, 0.5f, new Vector2(320, 435), 304927, 305295);

            CreateLyrics(font, Color1, "い　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 305484, 306998);
            CreateLyrics(font, Color1, "　ま　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 306248, 306998);
            CreateLyrics(font, Color2, "　今　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 306998, 309249);
            CreateLyrics(font, Color1, "　　の　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 306998, 309249);
            CreateLyrics(font, Color1, "　　　ま　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 307753, 309249);
            CreateLyrics(font, Color1, "　　　　ま　", FontName, FontSize, 0.5f, new Vector2(320, 435), 308484, 309249);

            CreateLyrics(font, Color1, "さ　　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 309630, 312244);
            CreateLyrics(font, Color1, "　よ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 309813, 312244);
            CreateLyrics(font, Color1, "　　な　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 309995, 312244);
            CreateLyrics(font, Color1, "　　　ら　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 310183, 312244);
            CreateLyrics(font, Color1, "　　　　し　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 310370, 312244);
            CreateLyrics(font, Color1, "　　　　　た　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 310558, 312244);
            CreateLyrics(font, Color1, "　　　　　　く　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 310930, 312244);
            CreateLyrics(font, Color6, "　　　　　　　ない　", FontName, FontSize, 0.5f, new Vector2(320, 435), 311114, 312244);
            CreateLyrics(font, Color1, "　　　　　　　　　の", FontName, FontSize, 0.5f, new Vector2(320, 435), 311494, 312244);

            CreateLyrics(font, Color4, "友　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 312619, 317106);
            CreateLyrics(font, Color4, "　達　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 313369, 317106);
            CreateLyrics(font, Color1, "　　の　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 314119, 317106);
            CreateLyrics(font, Color1, "　　　ま　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 314494, 317106);
            CreateLyrics(font, Color1, "　　　　ま　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 315244, 317106);
            CreateLyrics(font, Color1, "　　　　　じゃ", FontName, FontSize, 0.5f, new Vector2(320, 435), 316004, 317106);

            CreateLyrics(font, Color1, "もう　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 317484, 321244);
            CreateLyrics(font, Color1, "　　い　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 318239, 319734);
            CreateLyrics(font, Color1, "　　　や　", FontName, FontSize, 0.5f, new Vector2(320, 435), 318993, 319734);
            CreateLyrics(font, Color6, "　　嫌　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 319734, 321244);
            CreateLyrics(font, Color1, "　　　な　", FontName, FontSize, 0.5f, new Vector2(320, 435), 319734, 321244);
            CreateLyrics(font, Color1, "　　　　の", FontName, FontSize, 0.5f, new Vector2(320, 435), 320494, 321244);

            CreateLyrics(font, Color1, "言　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 321594, 324247);
            CreateLyrics(font, Color1, "　おう　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 321787, 324247);
            CreateLyrics(font, Color1, "　　　と　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 322365, 324247);
            CreateLyrics(font, Color1, "　　　　思　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 322552, 324247);
            CreateLyrics(font, Color1, "　　　　　って　", FontName, FontSize, 0.5f, new Vector2(320, 435), 323297, 324247);
            CreateLyrics(font, Color1, "　　　　　　　た", FontName, FontSize, 0.5f, new Vector2(320, 435), 323483, 324247);

            CreateLyrics(font, Color1, "私", FontName, FontSize, 0.5f, new Vector2(320, 435), 324619, 325751);

            CreateLyrics(font, Color1, "キ　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 326129, 327254);
            CreateLyrics(font, Color1, "　ミ　", FontName, FontSize, 0.5f, new Vector2(320, 435), 326317, 327254);
            CreateLyrics(font, Color1, "　　の", FontName, FontSize, 0.5f, new Vector2(320, 435), 326506, 327254);

            CreateLyrics(font, Color1, "キ　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 327615, 330255);
            CreateLyrics(font, Color1, "　ミ　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 327808, 330255);
            CreateLyrics(font, Color1, "　　の　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 328000, 330255);
            CreateLyrics(font, Color1, "　　　事　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 328374, 330255);
            CreateLyrics(font, Color5, "　　　　ず　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 328937, 330255);
            CreateLyrics(font, Color5, "　　　　　っと", FontName, FontSize, 0.5f, new Vector2(320, 435), 329320, 330255);

            CreateLyrics(font, Color5, "ず　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 330435, 331750);
            CreateLyrics(font, Color5, "　っと", FontName, FontSize, 0.5f, new Vector2(320, 435), 330813, 331750);

            CreateLyrics(font, Color1, "ま　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 332126, 334004);
            CreateLyrics(font, Color1, "　え　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 332510, 334004);
            CreateLyrics(font, Color2, "　前　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 334004, 337344);
            CreateLyrics(font, Color1, "　　か　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 334004, 337344);
            CreateLyrics(font, Color1, "　　　ら　", FontName, FontSize, 0.5f, new Vector2(320, 435), 335504, 337344);

            CreateLyrics(font, Color3, "好　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 337529, 340567);
            CreateLyrics(font, Color3, "　き　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 337734, 340567);
            CreateLyrics(font, Color3, "　　で　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 337924, 340567);
            CreateLyrics(font, Color3, "　　　し　", FontName, FontSize, 0.5f, new Vector2(320, 435), 338114, 340567);
            CreateLyrics(font, Color3, "　　　　た", FontName, FontSize, 0.5f, new Vector2(320, 435), 338304, 340567);

            CreateLyrics(font, Color1, "（は　）", FontName, FontSize, 0.5f, new Vector2(320, 435), 340942, 343189);
            CreateLyrics(font, Color1, "　　あ　", FontName, FontSize, 0.5f, new Vector2(320, 435), 341516, 343189);

            LyricsBackground(275480, 343189);

            CreateLyrics(font, Color1, "あ　　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 349907, 358426);
            CreateLyrics(font, Color1, "　あ　　　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 350489, 358426);
            CreateLyrics(font, Color1, "　　　や　　　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 351462, 358426);
            CreateLyrics(font, Color1, "　　　　っと　　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 351838, 358426);
            CreateLyrics(font, Color3, "　　　　　　言　　", FontName, FontSize, 0.5f, new Vector2(320, 435), 353160, 358426);
            CreateLyrics(font, Color3, "　　　　　　　え　", FontName, FontSize, 0.5f, new Vector2(320, 435), 353390, 358426);
            CreateLyrics(font, Color3, "　　　　　　　　た", FontName, FontSize, 0.5f, new Vector2(320, 435), 353644, 358426);

            CreateLyrics(font, Color1, "（ああ）", FontName, FontSize, 0.5f, new Vector2(320, 435), 358902, 361997);

            LyricsBackground(349907, 361997);

            // info section

            CreateLyrics(font, Color1, "supercell", FontName, FontSize, 0.55f, new Vector2(660, 410), 24260, 26134);
            CreateLyrics(font, Color1, "さよなら　　　　　", FontName, FontSize, 0.6f, new Vector2(600, 440), 24822, 26134);
            CreateLyrics(font, Color1, "　　　　メモリーズ", FontName, FontSize, 0.6f, new Vector2(600, 440), 25572, 26134);

            CreateLyrics(font, Color1, "vocals", FontName, FontSize, 0.55f, new Vector2(675, 410), 26510, 29134);
            CreateLyrics(font, Color1, "やなぎ　　", FontName, FontSize, 0.6f, new Vector2(645, 440), 27822, 29134);
            CreateLyrics(font, Color1, "　　　なぎ", FontName, FontSize, 0.6f, new Vector2(645, 440), 28572, 29134);

            CreateLyrics(font, Color1, "producer", FontName, FontSize, 0.5f, new Vector2(663, 412), 29510, 32317);
            CreateLyrics(font, Color1, "ryo", FontName, FontSize, 0.6f, new Vector2(690, 440), 30822, 32317);

            CreateLyrics(font, Color1, "beatmap", FontName, FontSize, 0.325f, new Vector2(680, 405), 32500, 34936);
            CreateLyrics(font, Color1, "storyboard", FontName, FontSize, 0.325f, new Vector2(675, 420), 33062, 34936);
            CreateLyrics(font, Color1, "Moecho", FontName, FontSize, 0.6f, new Vector2(665, 440), 33812, 34936);

            InfoBackground(23884, 34936);

            // ending section

            CreateLyrics(font, Color1, "終了", FontName, FontSize, 0.5f, new Vector2(320, 230), 354855, 358664);
            CreateLyrics(font, Color1, "ありがとう", FontName, FontSize, 0.5f, new Vector2(320, 230), 358902, 362712);

            EndBackground(354855, 362712);
        }

        // this is for calling the lyric's background
        private void LyricsBackground(int StartTime, int EndTime)
        {
            string SpritePath = "sb/sprites/lyrics-background.png";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = 1;

            sprite.Fade(OsbEasing.InOutSine, StartTime - 187 * 2.5, StartTime, 0, Opacity);
            sprite.Fade(OsbEasing.InOutSine, EndTime, EndTime + 187 * 2.5, Opacity, 0);

            sprite.Scale(StartTime, 480.0f / bitmap.Height);
        }

        // this is for calling the information background
        private void InfoBackground(int StartTime, int EndTime)
        {
            string SpritePath = "sb/sprites/info-background.png";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = 1;

            sprite.Fade(OsbEasing.InOutSine, StartTime - 187 * 2.5, StartTime, 0, Opacity);
            sprite.Fade(OsbEasing.InOutSine, EndTime, EndTime + 187 * 2.5, Opacity, 0);

            sprite.Scale(StartTime, 480.0f / bitmap.Height);
        }

        // this is for calling the information background
        private void EndBackground(int StartTime, int EndTime)
        {
            string SpritePath = "sb/sprites/end-background.png";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = 1;

            sprite.Fade(OsbEasing.InOutSine, StartTime - 187 * 2.5, StartTime, 0, Opacity);
            sprite.Fade(OsbEasing.InOutSine, EndTime, EndTime + 187 * 2.5, Opacity, 0);

            sprite.Scale(StartTime, 480.0f / bitmap.Height);
        }

        // this is where you create the lyrics
        private void CreateLyrics(FontGenerator font, Color4 ColorType, string Sentence, string FontName, int FontSize, float FontScale, Vector2 position, int StartTime, int EndTime)
        {
            var LyricsLayer = GetLayer("Lyrics");
            var letterY = position.Y;
            var lineWidth = 0f;
            var lineHeight = 0f;
            var letterSpacing = LetterSpacing * FontScale;
            foreach (var letter in Sentence)
            {
                var texture = font.GetTexture(letter.ToString());
                lineWidth += texture.BaseWidth * FontScale + letterSpacing;
                lineHeight = Math.Max(lineHeight, texture.BaseHeight * FontScale);
            }

            var letterX = position.X - lineWidth * 0.5f;

            foreach (var letter in Sentence)
            {
                var texture = font.GetTexture(letter.ToString());
                if (!texture.IsEmpty)
                {
                    var FadeTime = 187 / 1.5;
                    var RandomRotate = Random(MathHelper.DegreesToRadians(-20), MathHelper.DegreesToRadians(20));
                    var letterPos = new Vector2(letterX, letterY)
                        + texture.OffsetFor(LyricsOrigin) * FontScale;

                    var sprite = LyricsLayer.CreateSprite(texture.Path, LyricsOrigin);

                    sprite.Move(StartTime, letterPos.X, letterPos.Y);
                    sprite.Fade(StartTime - FadeTime, StartTime + FadeTime, 0, LyricsFade);
                    sprite.Fade(EndTime - FadeTime, EndTime + FadeTime, LyricsFade, 0);
                    sprite.Scale(StartTime, FontScale);

                    if (Additive)
                    {
                        sprite.Additive(StartTime, EndTime);
                    }

                    sprite.Color(StartTime, ColorType);
                }
                letterX += texture.BaseWidth * FontScale + letterSpacing;
            }
            letterY += lineHeight;
        }
    }
}