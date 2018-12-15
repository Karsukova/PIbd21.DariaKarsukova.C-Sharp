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
        Parking<IFighter> parking;
        public FormPlane()
        {
            InitializeComponent();
            parking = new Parking<IFighter>(20, pictureFighterPark.Width,
           pictureBoxTakeCar.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureFighterPark.Width, pictureFighterPark.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureFighterPark.Image = bmp;
        }
        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fighter = new Airplane(100, 1000, dialog.Color);
                int place = parking + fighter;
                Draw();
            }
        }
        private void buttonSetFighterPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var fighter = new FighterPlane(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    int place = parking + fighter;
                    Draw();
                }
            }
        }



        private void buttonTakePlane_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var fighter = parking - Convert.ToInt32(maskedTextBox.Text);
                if (fighter != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width,
                   pictureBoxTakeCar.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    fighter.SetPosition(5, 5, pictureBoxTakeCar.Width,
                   pictureBoxTakeCar.Height);
                    fighter.DrawFighter(gr);
                    pictureBoxTakeCar.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width,
                   pictureBoxTakeCar.Height);
                    pictureBoxTakeCar.Image = bmp;
                }
                Draw();
            }
        }

    }
}
