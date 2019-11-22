namespace Circo
{
    partial class frmNivel4_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animal4 = new System.Windows.Forms.PictureBox();
            this.animal3 = new System.Windows.Forms.PictureBox();
            this.animal2 = new System.Windows.Forms.PictureBox();
            this.animal1 = new System.Windows.Forms.PictureBox();
            this.cmdClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.animal4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdClose)).BeginInit();
            this.SuspendLayout();
            // 
            // animal4
            // 
            this.animal4.BackColor = System.Drawing.Color.Transparent;
            this.animal4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animal4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animal4.Image = global::Circo.Properties.Resources.Coelho1;
            this.animal4.Location = new System.Drawing.Point(1129, 356);
            this.animal4.Name = "animal4";
            this.animal4.Size = new System.Drawing.Size(200, 200);
            this.animal4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animal4.TabIndex = 15;
            this.animal4.TabStop = false;
            this.animal4.Click += new System.EventHandler(this.animal4_Click);
            // 
            // animal3
            // 
            this.animal3.BackColor = System.Drawing.Color.Transparent;
            this.animal3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animal3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animal3.Image = global::Circo.Properties.Resources.Elefante2;
            this.animal3.Location = new System.Drawing.Point(831, 356);
            this.animal3.Name = "animal3";
            this.animal3.Size = new System.Drawing.Size(200, 200);
            this.animal3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animal3.TabIndex = 14;
            this.animal3.TabStop = false;
            this.animal3.Click += new System.EventHandler(this.animal3_Click);
            // 
            // animal2
            // 
            this.animal2.BackColor = System.Drawing.Color.Transparent;
            this.animal2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animal2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animal2.Image = global::Circo.Properties.Resources.Leao;
            this.animal2.Location = new System.Drawing.Point(523, 356);
            this.animal2.Name = "animal2";
            this.animal2.Size = new System.Drawing.Size(200, 200);
            this.animal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animal2.TabIndex = 13;
            this.animal2.TabStop = false;
            this.animal2.Click += new System.EventHandler(this.animal2_Click);
            // 
            // animal1
            // 
            this.animal1.BackColor = System.Drawing.Color.Transparent;
            this.animal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animal1.Image = global::Circo.Properties.Resources.Cachorro2;
            this.animal1.Location = new System.Drawing.Point(187, 356);
            this.animal1.Name = "animal1";
            this.animal1.Size = new System.Drawing.Size(200, 200);
            this.animal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animal1.TabIndex = 12;
            this.animal1.TabStop = false;
            this.animal1.Click += new System.EventHandler(this.animal1_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Transparent;
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClose.Image = global::Circo.Properties.Resources.close1;
            this.cmdClose.Location = new System.Drawing.Point(1446, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(60, 60);
            this.cmdClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdClose.TabIndex = 16;
            this.cmdClose.TabStop = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmNivel4_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Circo.Properties.Resources.Nivel_4_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 568);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.animal4);
            this.Controls.Add(this.animal3);
            this.Controls.Add(this.animal2);
            this.Controls.Add(this.animal1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNivel4_3";
            this.Text = "frmNivel4_3";
            ((System.ComponentModel.ISupportInitialize)(this.animal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox animal4;
        private System.Windows.Forms.PictureBox animal3;
        private System.Windows.Forms.PictureBox animal2;
        private System.Windows.Forms.PictureBox animal1;
        private System.Windows.Forms.PictureBox cmdClose;
    }
}