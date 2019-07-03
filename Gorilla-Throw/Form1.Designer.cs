namespace Gorilla_Throw
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBoxDK = new System.Windows.Forms.PictureBox();
            this.pBoxBanana = new System.Windows.Forms.PictureBox();
            this.pboxBackground = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(912, 661);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 93);
            this.button2.TabIndex = 2;
            this.button2.Text = "Fire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1024, 568);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(875, 24);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(203, 55);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(904, 575);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Angle";
            // 
            // pBoxDK
            // 
            this.pBoxDK.BackColor = System.Drawing.Color.Transparent;
            this.pBoxDK.Image = global::Gorilla_Throw.Properties.Resources.DonkeyKong;
            this.pBoxDK.Location = new System.Drawing.Point(627, 74);
            this.pBoxDK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBoxDK.Name = "pBoxDK";
            this.pBoxDK.Size = new System.Drawing.Size(164, 155);
            this.pBoxDK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxDK.TabIndex = 4;
            this.pBoxDK.TabStop = false;
            // 
            // pBoxBanana
            // 
            this.pBoxBanana.Image = global::Gorilla_Throw.Properties.Resources.banana1;
            this.pBoxBanana.Location = new System.Drawing.Point(24, 661);
            this.pBoxBanana.Margin = new System.Windows.Forms.Padding(0);
            this.pBoxBanana.Name = "pBoxBanana";
            this.pBoxBanana.Size = new System.Drawing.Size(96, 93);
            this.pBoxBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxBanana.TabIndex = 0;
            this.pBoxBanana.TabStop = false;
            // 
            // pboxBackground
            // 
            this.pboxBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxBackground.Location = new System.Drawing.Point(24, 24);
            this.pboxBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pboxBackground.Name = "pboxBackground";
            this.pboxBackground.Size = new System.Drawing.Size(837, 727);
            this.pboxBackground.TabIndex = 6;
            this.pboxBackground.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1119, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(52, 492);
            this.vScrollBar1.TabIndex = 8;
            this.vScrollBar1.Value = 50;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(907, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "velocity = 0.13";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 782);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pBoxDK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pBoxBanana);
            this.Controls.Add(this.pboxBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxBanana;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pBoxDK;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pboxBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label2;
    }
}

