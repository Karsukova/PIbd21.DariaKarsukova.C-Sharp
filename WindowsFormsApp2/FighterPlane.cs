using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WindowsFormsPlane
{
    public class FighterPlane : Airplane
    {
        public Color DopColor { private set; get; }
        public bool Weapon { private set; get; }
        public bool Line { private set; get; }
        public FighterPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
       weapon, bool line) :
 base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Weapon = weapon;
            Line = line;
        }

        public FighterPlane(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Weapon = Convert.ToBoolean(strs[4]);
                Line = Convert.ToBoolean(strs[5]);
            }
        }
        public override void MoveTransport(Direction direction)
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
                     if (StartPosX - step > 0)
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
        public override void DrawFighter(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush ff = new SolidBrush(DopColor);

            Pen pp = new Pen(DopColor);
            if (Weapon)
            {
                g.FillEllipse(ff, StartPosX + 48 / 3, StartPosY + 40 / 3, 7 / 3, 25 / 3);
                g.FillEllipse(ff, StartPosX + 59 / 3, StartPosY + 35 / 3, 7 / 3, 25 / 3);
                g.FillEllipse(ff, StartPosX + 70 / 3, StartPosY + 32 / 3, 7 / 3, 25 / 3);

                g.FillEllipse(ff, StartPosX + 145 / 3, StartPosY + 40 / 3, 7 / 3, 25 / 3);
                g.FillEllipse(ff, StartPosX + 134 / 3, StartPosY + 35 / 3, 7 / 3, 25 / 3);
                g.FillEllipse(ff, StartPosX + 122 / 3, StartPosY + 32 / 3, 7 / 3, 25 / 3);

            }
            base.DrawFighter(g);

            if (Line)
            {
                g.DrawLine(pp, StartPosX + 100 / 3, StartPosY + 125 / 3, StartPosX + 100 / 3, StartPosY + 40 / 3);
                g.DrawLine(pp, StartPosX + 80 / 3, StartPosY + 105 / 3, StartPosX + 120 / 3, StartPosY + 105 / 3);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Weapon + ";" +
           Line;
        }
    }
}


