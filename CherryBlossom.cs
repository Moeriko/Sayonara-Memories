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
    public class CherryBlossom : StoryboardObjectGenerator
    {
        [Configurable]
        public Color4 MinColor = Color4.White;

        [Configurable]
        public Color4 MaxColor = Color4.LightPink;

        public override void Generate()
        {
            Petals(227509, 239479, 75, 8000, 10000, 0.025, 0.15, 50, 150);
            Petals(227509, 239479, 75, 8000, 10000, 0.025, 0.15, 0, 100);
            Petals(251479, 269498, 25, 2000, 2500, 0.025, 0.15, 50, 150);
            Petals(251479, 269498, 25, 2000, 2500, 0.025, 0.15, 0, 100);
            Petals(338493, 350489, 33, 4000, 5000, 0.025, 0.15, -300, -150);
            Petals(354855, 362712, 33, 2000, 6000, 0.025, 0.15, -100, -50);
            Petals(354855, 362712, 33, 2000, 6000, 0.025, 0.15, 50, 100);
        }

        public void Petals(int startTime, int endTime, int interval, int minDuration, int maxDuration, double minScale, double maxScale, int tiltA, int tiltB)
        {
            for (int i = startTime; i < endTime; i += interval)
            {
                var layer = GetLayer("CherryBlossom");
                var sprite = layer.CreateSprite("sb/sprites/petal-" + Random(1, 3) + ".png", OsbOrigin.Centre);

                var tilt = Random(tiltA, tiltB);
                var velocity = Random(minDuration, maxDuration);
                var duration = i + velocity;

                var scale = Random(minScale, maxScale);
                var randomX = Random(-150, 1000);

                var startRotation = MathHelper.DegreesToRadians(Random(-180, 180));
                var endRotation = MathHelper.DegreesToRadians(Random(-90, 90));

                var fadeTime = 187;

                var pos = new Vector2(randomX, Random(-20, 0));
                var newPos = new Vector2(randomX, Random(460, 480));

                var opacity = Random(0.25, 0.75);
                var color = true ? new Color4((float)Random(MinColor.R, MaxColor.R),
                                                            (float)Random(MinColor.G, MaxColor.G),
                                                            (float)Random(MinColor.B, MaxColor.B), 255) : MinColor;

                sprite.MoveX(i, duration, pos.X - 150 - tilt, newPos.X - 150 + tilt);
                sprite.MoveY(i, duration, pos.Y, newPos.Y);
                sprite.Fade(i, i + fadeTime, 0, opacity);
                sprite.Scale(i, scale);
                sprite.Color(i, color);

                if (duration < endTime)
                {
                    sprite.Fade(duration - fadeTime, duration, opacity, 0);
                    sprite.Rotate(i, duration, startRotation, endRotation);
                }

                else if (duration >= endTime)
                {
                    sprite.Fade(endTime - fadeTime, endTime, opacity, 0);
                    sprite.Rotate(duration, endTime, startRotation, endRotation);
                }
            }
        }
    }
}
