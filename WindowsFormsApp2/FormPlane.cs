using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsPlane
{
    public partial class FormPlane : Form
    {
        private FighterPlane fighter;
        public FormPlane()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxFighter.Width, pictureBoxFighter.Height);
            Graphics gr = Graphics.FromImage(bmp);
            fighter.DrawFighter(gr);
            pictureBoxFighter.Image = bmp;
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            fighter = new FighterPlane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
           Color.Yellow, true);
            fighter.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxFighter.Width,
           pictureBoxFighter.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    fighter.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    fighter.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    fighter.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    fighter.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
