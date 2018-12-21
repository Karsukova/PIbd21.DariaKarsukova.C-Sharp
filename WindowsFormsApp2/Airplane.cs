using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace WindowsFormsPlane
{
    public class Airplane : Plane
    {
        
        protected const int planeWidth = 163;
        protected const int planeHeight = 160;
        public Airplane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Airplane(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
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


            Brush jr = new SolidBrush(MainColor);
            g.FillEllipse(jr, StartPosX + 28 / 3, StartPosY + 40 / 3, 140 / 3, 30 / 3);
            g.DrawEllipse(pen, StartPosX + 28 / 3, StartPosY + 40 / 3, 140 / 3, 30 / 3);

            g.FillEllipse(jr, StartPosX + 60 / 3, StartPosY + 130 / 3, 80 / 3, 15 / 3);
            g.DrawEllipse(pen, StartPosX + 60 / 3, StartPosY + 130 / 3, 80 / 3, 15 / 3);

            Brush wing = new SolidBrush(MainColor);
            g.FillEllipse(wing, StartPosX + 80 / 3, StartPosY - 6 / 3, 40 / 3, 160 / 3);
            g.DrawEllipse(pen, StartPosX + 80 / 3, StartPosY - 6 / 3, 40 / 3, 160 / 3);

            Brush pp = new SolidBrush(Color.Gray);
            g.FillEllipse(pp, StartPosX + 85 / 3, StartPosY + 26 / 3, 30 / 3, 15 / 3);
            g.DrawEllipse(pen, StartPosX + 85 / 3, StartPosY + 26 / 3, 30 / 3, 15 / 3);

            g.FillEllipse(jr, StartPosX + 97 / 3, StartPosY + 120 / 3, 7 / 3, 30 / 3);
            g.DrawEllipse(pen, StartPosX + 97 / 3, StartPosY + 120 / 3, 7 / 3, 30 / 3);

            g.DrawLine(pen, StartPosX + 100 / 3, StartPosY + 25 / 3, StartPosX + 100 / 3, StartPosY + 40 / 3);


        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }

}
