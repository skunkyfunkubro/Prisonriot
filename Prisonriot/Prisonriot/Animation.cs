using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Prisonriot;

public class Animation
{
    public Point frameSize;
    public Point currentFrame;
    public Point sheetSize;
    public int timeSinceLastFrame = 0;
    public int milliSecondsPerFrame;

    public Animation(Point frameSize, int milliSecondsPerFrame, Point sheetSize)
    {
        this.frameSize = frameSize;
        this.milliSecondsPerFrame = milliSecondsPerFrame;
        this.sheetSize = sheetSize;
        currentFrame = new Point(0, 0);
    }

    public void Update(GameTime gameTime)
    {
        timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if(timeSinceLastFrame > milliSecondsPerFrame)
            {
                timeSinceLastFrame -= milliSecondsPerFrame;
                ++currentFrame.X;
                if(currentFrame.X >= sheetSize.X)
                {
                    currentFrame.X = 0;
                }
            }
    }
}