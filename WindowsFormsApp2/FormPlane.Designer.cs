namespace WindowsFormsPlane
{
    partial class FormPlane
    {

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SetFighterPlane = new System.Windows.Forms.Button();
            this.pictureFighterPark = new System.Windows.Forms.PictureBox();
            this.SetPlane = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.TextBox();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFighterPark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).BeginInit();
            this.SuspendLayout();
            // 
            // SetFighterPlane
            // 
            this.SetFighterPlane.Location = new System.Drawing.Point(956, 96);
            this.SetFighterPlane.Name = "SetFighterPlane";
            this.SetFighterPlane.Size = new System.Drawing.Size(234, 76);
            this.SetFighterPlane.TabIndex = 1;
            this.SetFighterPlane.Text = "Поставить истребитель";
            this.SetFighterPlane.UseVisualStyleBackColor = true;
            this.SetFighterPlane.Click += new System.EventHandler(this.buttonSetFighterPlane_Click);
            // 
            // pictureFighterPark
            // 
            this.pictureFighterPark.Location = new System.Drawing.Point(12, 12);
            this.pictureFighterPark.Name = "pictureFighterPark";
            this.pictureFighterPark.Size = new System.Drawing.Size(881, 639);
            this.pictureFighterPark.TabIndex = 0;
            this.pictureFighterPark.TabStop = false;
            // 
            // SetPlane
            // 
            this.SetPlane.Location = new System.Drawing.Point(956, 12);
            this.SetPlane.Name = "SetPlane";
            this.SetPlane.Size = new System.Drawing.Size(234, 68);
            this.SetPlane.TabIndex = 6;
            this.SetPlane.Text = "Поставить самолёт";
            this.SetPlane.UseVisualStyleBackColor = true;
            this.SetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(912, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Забрать самолёт или истребитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(995, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Место";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(1081, 224);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(77, 26);
            this.maskedTextBox.TabIndex = 9;
            // 
            // buttonTakePlane
            // 
            this.buttonTakePlane.Location = new System.Drawing.Point(1015, 268);
            this.buttonTakePlane.Name = "buttonTakePlane";
            this.buttonTakePlane.Size = new System.Drawing.Size(110, 35);
            this.buttonTakePlane.TabIndex = 10;
            this.buttonTakePlane.Text = "Забрать";
            this.buttonTakePlane.UseVisualStyleBackColor = true;
            this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click_1);
            // 
            // pictureBoxTakeCar
            // 
            this.pictureBoxTakeCar.Location = new System.Drawing.Point(956, 373);
            this.pictureBoxTakeCar.Name = "pictureBoxTakeCar";
            this.pictureBoxTakeCar.Size = new System.Drawing.Size(229, 178);
            this.pictureBoxTakeCar.TabIndex = 11;
            this.pictureBoxTakeCar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 682);
            this.Controls.Add(this.pictureBoxTakeCar);
            this.Controls.Add(this.buttonTakePlane);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetPlane);
            this.Controls.Add(this.SetFighterPlane);
            this.Controls.Add(this.pictureFighterPark);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ангар";
            ((System.ComponentModel.ISupportInitialize)(this.pictureFighterPark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureFighterPark;
        private System.Windows.Forms.Button SetFighterPlane;
        private System.Windows.Forms.Button SetPlane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maskedTextBox;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.PictureBox pictureBoxTakeCar;
    }
}
