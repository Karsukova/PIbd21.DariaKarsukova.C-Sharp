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
        private IFighter fighter;
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

        private void pictureBoxFighter_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            fighter = new Airplane(rnd.Next(100, 300), rnd.Next(1000, 2000),
           Color.Orange);
            fighter.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxFighter.Width,
           pictureBoxFighter.Height);
            Draw();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            fighter = new FighterPlane(rnd.Next(100, 300), rnd.Next(1000, 2000),
           Color.Green, Color.Red, true, true);
            fighter.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxFighter.Width,
           pictureBoxFighter.Height);

            Draw();
        }
        private void buttonRight_Click(object sender, EventArgs e)
        {
            fighter.MoveTransport(Direction.Right);
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            fighter.MoveTransport(Direction.Up);
            Draw();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            fighter.MoveTransport(Direction.Left);
            Draw();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {

            fighter.MoveTransport(Direction.Down);
            Draw();
        }

    }
}
