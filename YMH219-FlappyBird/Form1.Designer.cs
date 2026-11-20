namespace YMH219_FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbZemin = new PictureBox();
            pbKus = new PictureBox();
            pbBoruUst = new PictureBox();
            pbBoruAlt = new PictureBox();
            lblSkor = new Label();
            lblMesaj = new Label();
            tmrOyun = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbZemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBoruUst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBoruAlt).BeginInit();
            SuspendLayout();
            // 
            // pbZemin
            // 
            pbZemin.BackColor = Color.ForestGreen;
            pbZemin.Location = new Point(0, 570);
            pbZemin.Name = "pbZemin";
            pbZemin.Size = new Size(600, 90);
            pbZemin.TabIndex = 0;
            pbZemin.TabStop = false;
            // 
            // pbKus
            // 
            pbKus.BackColor = Color.Gold;
            pbKus.Location = new Point(90, 280);
            pbKus.Name = "pbKus";
            pbKus.Size = new Size(40, 35);
            pbKus.TabIndex = 1;
            pbKus.TabStop = false;
            // 
            // pbBoruUst
            // 
            pbBoruUst.BackColor = Color.SeaGreen;
            pbBoruUst.Location = new Point(450, 0);
            pbBoruUst.Name = "pbBoruUst";
            pbBoruUst.Size = new Size(75, 200);
            pbBoruUst.TabIndex = 2;
            pbBoruUst.TabStop = false;
            // 
            // pbBoruAlt
            // 
            pbBoruAlt.BackColor = Color.SeaGreen;
            pbBoruAlt.Location = new Point(450, 350);
            pbBoruAlt.Name = "pbBoruAlt";
            pbBoruAlt.Size = new Size(75, 220);
            pbBoruAlt.TabIndex = 3;
            pbBoruAlt.TabStop = false;
            // 
            // lblSkor
            // 
            lblSkor.AutoSize = true;
            lblSkor.BackColor = Color.Transparent;
            lblSkor.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSkor.Location = new Point(12, 9);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(110, 38);
            lblSkor.TabIndex = 4;
            lblSkor.Text = "Skor: 0";
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMesaj.Location = new Point(120, 220);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(377, 31);
            lblMesaj.TabIndex = 5;
            lblMesaj.Text = "Başlamak için SPACE tuşuna basın";
            // 
            // tmrOyun
            // 
            tmrOyun.Interval = 20;
            tmrOyun.Tick += tmrOyun_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(582, 653);
            Controls.Add(lblMesaj);
            Controls.Add(lblSkor);
            Controls.Add(pbBoruAlt);
            Controls.Add(pbBoruUst);
            Controls.Add(pbKus);
            Controls.Add(pbZemin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Flappy Bird - YMH 219";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbZemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBoruUst).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBoruAlt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZemin;
        private PictureBox pbKus;
        private PictureBox pbBoruUst;
        private PictureBox pbBoruAlt;
        private Label lblSkor;
        private Label lblMesaj;
        private System.Windows.Forms.Timer tmrOyun;
    }
}
