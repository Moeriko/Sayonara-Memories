using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Backgrounds : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            BG(35490, 47500);
            BG(101500, 125500);
            BG(131500, 143500);
            BG(197490, 224520);
            BG(302474, 311494);
            BG(317484, 329515);
            BG(338493, 350489);

            BGB(316, 35490);
            BGB(47500, 77480);
            BGB(125500, 131500);
            BGB(143500, 173470);
            BGB(224520, 227509);
            BGB(296500, 302474);
            BGB(311494, 317484);
            BGB(329515, 338493);
            BGB(350489, 368483);

            BG2(275480, 287510);

            BG2B(77480, 101500);
            BG2B(173470, 197490);
            BG2B(287510, 296500);

            BG3(227509, 239479);
            BG3(251479, 269498);

            BG3B(239479, 251479);
            BG3B(269498, 275480);

            Overlay(316, 227509);
            Overlay(239479, 275480);
            Overlay(287510, 362712);

            Flash();
            Bottom(-1, 368484);
        }

        public void BG(int StartTime, int EndTime)
        {
            string SpritePath = "background.jpg";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = .75;

            sprite.Fade(StartTime - 187, StartTime, 0, Opacity);
            sprite.Fade(EndTime, EndTime + 187, Opacity, 0);

            sprite.Scale(StartTime, 480.0f / bitmap.Height);
        }

        public void BGB(int StartTime, int EndTime)
        {
            string SpritePath = "sb/sprites/background-blurred.jpg";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = .75;

            sprite.Fade(StartTime - 187, StartTime, 0, Opacity);
            sprite.Fade(EndTime, EndTime + 187, Opacity, 0);

            sprite.Scale(StartTime, 480.0f / bitmap.Height);
        }

        public void BG2(int StartTime, int EndTime)
        {
            string SpritePath = "sb/sprites/background-2.jpg";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = .75;

            sprite.Fade(StartTime - 187, StartTime, 0, Opacity);
            sprite.Fade(EndTime, EndTime + 187, Opacity, 0);

            sprite.Scale(StartTime, 480.0f / bitmap.Height);
        }

        public void BG2B(int StartTime, int EndTime)
        {
            string SpritePath = "sb/sprites/background-2-blurred.jpg";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = .75;

            sprite.Fade(StartTime - 187, StartTime, 0, Opacity);
            sprite.Fade(EndTime, EndTime + 187, Opacity, 0);

            sprite.Scale(StartTime, 480.0f / bitmap.Height);
        }

        public void BG3(int StartTime, int EndTime)
        {
            string SpritePath = "sb/sprites/background-3.jpg";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = .75;

            sprite.Fade(StartTime - 187, StartTime, 0, Opacity);
            sprite.Fade(EndTime, EndTime + 187, Opacity, 0);

            sprite.Scale(StartTime, 480.0f / bitmap.Height);
        }

        public void BG3B(int StartTime, int EndTime)
        {
            string SpritePath = "sb/sprites/background-3-blurred.jpg";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = .75;

            sprite.Fade(StartTime - 187, StartTime, 0, Opacity);
            sprite.Fade(EndTime, EndTime + 187, Opacity, 0);

            sprite.Scale(StartTime, 480.0f / bitmap.Height);
        }

        public void Overlay(int StartTime, int EndTime)
        {
            string SpritePath = "sb/sprites/overlay-dark.png";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = 1;

            sprite.Fade(StartTime - 187, StartTime, 0, Opacity);
            sprite.Fade(EndTime, EndTime + 187, Opacity, 0);

            sprite.Scale(StartTime, 480.0f / bitmap.Height);
        }

        public void Bottom(int StartTime, int EndTime)
        {
            string SpritePath = "sb/sprites/pixel-white.png";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = 1;

            sprite.Fade(StartTime, StartTime, 0, Opacity);
            sprite.Fade(EndTime, EndTime, Opacity, 0);

            sprite.Color(StartTime, 0, 0, 0);

            sprite.ScaleVec(StartTime, 880.0f / bitmap.Width, 480.0f / bitmap.Height);
        }

        private void Flash()
        {
            foreach (var hitobject in Beatmap.HitObjects)
            {
                var duration = 187 * 4;
                var flashFade = .2;
                var flashSprite = "sb/sprites/pixel-white.png";

                var layer = GetLayer("Flash");
                var bitmap = GetMapsetBitmap(flashSprite);
                var Scale = new Vector2(854.0f / bitmap.Width, 480.0f / bitmap.Height);
                var sprite = layer.CreateSprite(flashSprite, OsbOrigin.Centre, new Vector2(320, 240));

                if (hitobject.Additions.HasFlag(HitSoundAddition.Finish))
                {
                    sprite.Fade(hitobject.StartTime, hitobject.StartTime + duration, flashFade, 0);
                    sprite.ScaleVec(hitobject.StartTime, Scale.X, Scale.Y);
                }

                if (hitobject is OsuSlider)
                {
                    var sliderObject = (OsuSlider)hitobject;
                    foreach (var node in sliderObject.Nodes)
                    {
                        if (hitobject.Additions.HasFlag(HitSoundAddition.Finish) || sliderObject.Nodes.Any(n => n.Additions.HasFlag(HitSoundAddition.Finish)))
                        {
                            sprite.Fade(sliderObject.StartTime, hitobject.StartTime + duration, flashFade, 0);
                            sprite.ScaleVec(sliderObject.StartTime, Scale.X, Scale.Y);
                        }
                    }
                }
            }
        }
    }
}
