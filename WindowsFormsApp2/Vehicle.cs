using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsPlane
{
    public abstract class Vehicle : IFighter
    {

        protected float StartPosX;
        protected float StartPosY;
        protected int pictureWidth;
        protected int pictureHeight;

        public int MaxSpeed { protected set; get; }

        public float Weight { protected set; get; }

        public Color MainColor { protected set; get; }
        public void SetPosition(int x, int y, int width, int height)
        {
            StartPosX = x;
            StartPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }
        public void SetMainColor(Color color)
        {
            MainColor = color;
        }
        public abstract void DrawFighter(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}
