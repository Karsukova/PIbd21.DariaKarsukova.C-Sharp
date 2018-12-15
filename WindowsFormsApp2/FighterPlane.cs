using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WindowsFormsPlane
{
    class FighterPlane : Airplane
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
    }
}

