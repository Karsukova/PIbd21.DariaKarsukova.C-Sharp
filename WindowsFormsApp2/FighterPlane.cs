using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WindowsFormsPlane
{
    class FighterPlane
    {
        private float StartPosX;
        private float StartPosY;
        private float pictureHeight;
        private float pictureWidth;
        private const int planeWidth = 163;
        private const int planeHeight = 160;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool MainEllipse { private set; get; }
        public FighterPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
mainEllipse)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            MainEllipse = mainEllipse;
            
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            StartPosX = x;
            StartPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (StartPosX + step < pictureWidth - planeWidth)
                    {
                        StartPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (StartPosX - step > 0 - planeWidth/5)
                    {
                        StartPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (StartPosY - step > 0)
                    {
                        StartPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (StartPosY + step < pictureHeight - planeHeight)
                    {
                        StartPosY += step;
                    }
                    break;
            }
        }
        public void DrawFighter(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            if (MainEllipse)
            {
                Brush ff = new SolidBrush(Color.Red);
                g.FillEllipse(ff, StartPosX + 145, StartPosY + 40, 7, 25);
                g.FillEllipse(ff, StartPosX + 134, StartPosY + 35, 7, 25);
                g.FillEllipse(ff, StartPosX + 122, StartPosY + 32, 7, 25);
              

                g.FillEllipse(ff, StartPosX + 48, StartPosY + 40, 7, 25);
                g.FillEllipse(ff, StartPosX + 59, StartPosY + 35, 7, 25);
                g.FillEllipse(ff, StartPosX + 70, StartPosY + 32, 7, 25);

                Brush jr = new SolidBrush(Color.Orange);
                g.FillEllipse(jr, StartPosX + 28, StartPosY + 40, 140, 30);
                g.DrawEllipse(pen, StartPosX +28, StartPosY + 40, 140, 30);

                g.FillEllipse(jr, StartPosX + 60, StartPosY + 130, 80, 15);
                g.DrawEllipse(pen, StartPosX + 60, StartPosY + 130, 80, 15);

                Brush wing = new SolidBrush(Color.Yellow);
                g.FillEllipse(wing, StartPosX + 80, StartPosY - 6, 40, 160);
                g.DrawEllipse(pen, StartPosX + 80, StartPosY - 6, 40, 160);

                Brush pp = new SolidBrush(Color.Gray);
                g.FillEllipse(pp, StartPosX + 85, StartPosY + 26, 30, 15);
                g.DrawEllipse(pen, StartPosX + 85, StartPosY +26 , 30, 15);

                g.FillEllipse(jr, StartPosX + 97, StartPosY + 120, 7, 30);
                g.DrawEllipse(pen, StartPosX + 97, StartPosY + 120, 7, 30);

                g.DrawLine(pen, StartPosX + 100, StartPosY + 25, StartPosX + 100, StartPosY + 40);

            }
        }
    }
}
