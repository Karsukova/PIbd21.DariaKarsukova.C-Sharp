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

            Pen pp = new Pen(Color.Red);
            if (Weapon)
            {
                g.FillEllipse(ff, StartPosX + 48, StartPosY + 40, 7, 25);
                g.FillEllipse(ff, StartPosX + 59, StartPosY + 35, 7, 25);
                g.FillEllipse(ff, StartPosX + 70, StartPosY + 32, 7, 25);

                g.FillEllipse(ff, StartPosX + 145, StartPosY + 40, 7, 25);
                g.FillEllipse(ff, StartPosX + 134, StartPosY + 35, 7, 25);
                g.FillEllipse(ff, StartPosX + 122, StartPosY + 32, 7, 25);

            }
            base.DrawFighter(g);

            if (Line)
            {
                g.DrawLine(pp, StartPosX + 100, StartPosY + 125, StartPosX + 100, StartPosY + 40);
                g.DrawLine(pp, StartPosX + 80, StartPosY + 105, StartPosX + 120, StartPosY + 105);
            }

        }
    }
}

