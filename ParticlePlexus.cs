using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class ParticlePlexus : StoryboardObjectGenerator
    {
        [Configurable]
        public string ParticlePath = "sb/particle.png";

        [Configurable]
        public double ParticleFadeMin = 0.8;

        [Configurable]
        public double ParticleFadeMax = 1;

        [Configurable]
        public bool RandomParticleFade = true;

        [Configurable]
        public OsbOrigin ParticleOrigin = OsbOrigin.Centre;

        // [Configurable]
        // public string LinePath = "sb/line.png";

        // [Configurable]
        // public float lineThickness = 1.5f;

        // [Configurable]
        // public double LineFadeMin = 0.8;

        // [Configurable]
        // public double LineFadeMax = 1;

        // [Configurable]
        // public bool RandomLineFade = true;

        // [Configurable]
        // public OsbOrigin LineOrigin = OsbOrigin.BottomCentre;

        [Configurable]
        public int ConnectRadiusMin = 50;

        [Configurable]
        public int ConnectRadiusMax = 100;

        [Configurable]
        public int TimeBetweenParticles = 400;

        [Configurable]
        public bool RandomTravelTime = true;

        [Configurable]
        public int MinTravelTime = 8000;

        [Configurable]
        public int MaxTravelTime = 10000;

        [Configurable]
        public int TravelSpeed = 50;

        [Configurable]
        public bool RandomMovement = true;

        [Configurable]
        public Vector2 StartPosition = new Vector2(-107, 0);

        [Configurable]
        public Vector2 EndPosition = new Vector2(747, 480);

        [Configurable]
        public bool RandomX;

        [Configurable]
        public bool RandomY;

        [Configurable]
        public int FadeTimeIn = 500;

        [Configurable]
        public int FadeTimeOut = 500;

        [Configurable]
        public double StartScale = 0.3;

        [Configurable]
        public double EndScale = 0.8;

        [Configurable]
        public bool RandomScale = true;

        [Configurable]
        public double StartRotation = 0;

        [Configurable]
        public double EndRotation = 0;

        [Configurable]
        public bool RandomRotation = false;

        [Configurable]
        public bool ParticleAdditive = true;

        [Configurable]
        public Color4 ParticleColor = Color4.White;

        [Configurable]
        public bool LineAdditive = true;

        [Configurable]
        public Color4 LineColor = Color4.Orange;

        public override void Generate()
        {
            ParticleGen(275480, 287510);
        }

        private void ParticleGen(int StartTime, int EndTime)
        {
            if (StartTime == EndTime)
            {
                StartTime = (int)Beatmap.HitObjects.First().StartTime;
                EndTime = (int)Beatmap.HitObjects.Last().EndTime;
            }
            EndTime = Math.Min(EndTime, (int)AudioDuration);
            StartTime = Math.Min(StartTime, EndTime);

            // This is an example of using a particle pool.
            // Sprites using the same layer, path and origin can be reused as if they were multiple sprites.

            //Line Stuff
            // var lines = new Dictionary<OsbSprite, OsbSprite>();
            var pos = new Dictionary<OsbSprite, Vector2d>();
            var connected = new Dictionary<int, List<OsbSprite>>();
            // Line stuff ends here

            var layer = GetLayer("");
            using (var pool = new OsbSpritePool(layer, ParticlePath, ParticleOrigin, (particle, startTime, endTime) =>
            { }))
            {
                for (int i = StartTime; i < (EndTime); i += TimeBetweenParticles)
                {
                    var RealTravelTime = RandomTravelTime ? Random(MinTravelTime, MaxTravelTime) : MinTravelTime;
                    var ParticleFade = RandomParticleFade ? Random(ParticleFadeMin, ParticleFadeMax) : ParticleFadeMin;
                    // var LineFade = RandomLineFade ? Random(LineFadeMin, LineFadeMax) : LineFadeMin;
                    var particle = pool.Get(i, i + RealTravelTime);

                    // if (!lines.ContainsKey(particle))
                    // {
                    //     lines[particle] = layer.CreateSprite(LinePath, LineOrigin, new Vector2(320, 240));
                    //     pos[particle] = new Vector2d(320, 240);
                    // }
                    // var line = lines[particle];

                    particle.Color(i, ParticleColor);
                    // line.Color(i, LineColor);

                    if (StartScale == EndScale && StartScale != 1)
                        particle.Scale(i, StartScale);

                    if (StartRotation == EndRotation && StartRotation != 0)
                        particle.Rotate(i, MathHelper.DegreesToRadians(StartRotation));

                    if (StartScale != EndScale)
                        if (RandomScale)
                            particle.Scale(i, i + RealTravelTime, Random(StartScale, EndScale), Random(StartScale, EndScale));
                        else particle.Scale(i, i + RealTravelTime, StartScale, EndScale);

                    if (StartRotation != EndRotation)
                        if (RandomRotation)
                            particle.Rotate(i, i + RealTravelTime, MathHelper.DegreesToRadians(Random(StartRotation, EndRotation)), MathHelper.DegreesToRadians(Random(StartRotation, EndRotation)));
                        else particle.Rotate(i, i + RealTravelTime, MathHelper.DegreesToRadians(StartRotation), MathHelper.DegreesToRadians(EndRotation));

                    if (ParticleAdditive)
                    {
                        particle.Additive(i, i + RealTravelTime);
                    }

                    // if (ParticleAdditive)
                    // {
                    //     line.Additive(i, i + RealTravelTime);
                    // }

                    if (!RandomMovement)
                    {
                        var startX = RandomX ? Random(StartPosition.X, EndPosition.X) : StartPosition.X;
                        var startY = RandomY ? Random(EndPosition.Y, StartPosition.Y) : StartPosition.Y;
                        var endX = RandomX ? startX : EndPosition.X;
                        var endY = RandomY ? startY : EndPosition.Y;
                        particle.Move(i, i + RealTravelTime, startX, startY, endX, endY);
                    }

                    else
                    {
                        var lastX = Random(StartPosition.X, EndPosition.X);
                        var lastY = Random(StartPosition.Y, EndPosition.Y);

                        var UpdateRate = 500;
                        var lastAngle = 0d;
                        var lastDistance = 0d;

                        var rVec = MathHelper.DegreesToRadians(Random(0, 360));
                        var sVec = Random(1, 16);
                        var vX = (Math.Cos(rVec) * sVec) / (TravelSpeed / 2);
                        var vY = (Math.Sin(rVec) * sVec) / (TravelSpeed / 2);

                        var startPosition = new Vector2d(lastX, lastY);
                        pos[particle] = startPosition;
                        var endPosition = new Vector2d(lastX, lastY);

                        for (var t = i; t < i + RealTravelTime; t += UpdateRate)
                        {
                            var nextX = lastX + (vX / 10);
                            var nextY = lastY + (vY / 10);

                            // Line stuff
                            startPosition.X = lastX;
                            startPosition.Y = lastY;
                            // var ShowLines = false;

                            // foreach (var item in lines)
                            // {
                            //     if (item.Key == particle)
                            //     {
                            //         continue;
                            //     }
                            //     var spos = item.Key.PositionAt(t + UpdateRate);

                            //     if (!connected.ContainsKey(t))
                            //     {
                            //         connected[t] = new List<OsbSprite>();
                            //     }

                            //     if ((Math.Sqrt(Math.Pow(spos.Y - startPosition.Y, 2) + Math.Pow(spos.X - startPosition.X, 2))) < ConnectRadiusMin
                            //     && (Math.Sqrt(Math.Pow(spos.Y - startPosition.Y, 2) + Math.Pow(spos.X - startPosition.X, 2))) < ConnectRadiusMax)
                            //     {
                            //         if (!connected[t].Contains(particle))
                            //         {
                            //             endPosition.X = spos.X;
                            //             endPosition.Y = spos.Y;
                            //             ShowLines = false;
                            //             connected[t].Add(particle);
                            //             break;
                            //         }
                            //     }
                            // }

                            // if (!ShowLines)
                            // {
                            //     // line.Fade(i, 0);
                            //     endPosition.X = startPosition.X;
                            //     endPosition.Y = startPosition.Y;
                            // }
                            // else
                            // {
                            //     //line.Fade(i + RealTravelTime, LineFade);
                            // }

                            // Line stuff
                            // double distance = Math.Sqrt(Math.Pow(endPosition.Y - startPosition.Y, 2) + Math.Pow(endPosition.X - startPosition.X, 2));
                            // var angle = Math.Atan2((startPosition.Y - endPosition.Y), (startPosition.X - endPosition.X)) - Math.PI / 2f;

                            // line.ScaleVec(t, t + UpdateRate, lineThickness, lastDistance, lineThickness, distance);
                            // line.Rotate(t, t + UpdateRate, lastAngle, angle);
                            // line.Move(t, t + UpdateRate, lastX, lastY, nextX, nextY);;

                            // lastDistance = distance;
                            // lastAngle = angle;

                            particle.Move(t, t + UpdateRate, lastX, lastY, nextX, nextY);

                            vX += Random(-TravelSpeed, TravelSpeed) * UpdateRate / 1000;
                            vY += Random(-TravelSpeed, TravelSpeed) * UpdateRate / 1000;

                            lastX = nextX;
                            lastY = nextY;
                        }
                    }

                    if (i < EndTime - (FadeTimeIn + FadeTimeOut))
                    {
                        particle.Fade(i, i + FadeTimeIn, 0, ParticleFade);
                        // line.Fade(i, i + FadeTimeIn, 0, LineFade);
                        if (i < EndTime - RealTravelTime)
                        {
                            particle.Fade(i + RealTravelTime - FadeTimeOut, i + RealTravelTime, ParticleFade, 0);
                            // line.Fade(i + RealTravelTime - FadeTimeOut, i + RealTravelTime, LineFade, 0);
                        }
                        else
                        {
                            particle.Fade(EndTime - FadeTimeOut, EndTime, ParticleFade, 0);
                            // line.Fade(EndTime - FadeTimeOut, EndTime, LineFade, 0);
                        }
                    }
                    else
                    {
                        particle.Fade(i, 0);
                        // line.Fade(i, 0);
                    }
                }
            }
        }
    }
}