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
            this.pboxMonkey = new System.Windows.Forms.PictureBox();
            this.pBoxBanana = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMonkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBanana)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 92);
            this.button2.TabIndex = 2;
            this.button2.Text = "Fire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 456);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(874, 24);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(203, 55);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score: 0";
            // 
            // pboxMonkey
            // 
            this.pboxMonkey.BackColor = System.Drawing.Color.Transparent;
            this.pboxMonkey.Image = global::Gorilla_Throw.Properties.Resources.monkey_selfie;
            this.pboxMonkey.Location = new System.Drawing.Point(664, 75);
            this.pboxMonkey.Name = "pboxMonkey";
            this.pboxMonkey.Size = new System.Drawing.Size(141, 214);
            this.pboxMonkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxMonkey.TabIndex = 4;
            this.pboxMonkey.TabStop = false;
            // 
            // pBoxBanana
            // 
            this.pBoxBanana.Image = global::Gorilla_Throw.Properties.Resources.banana1;
            this.pBoxBanana.Location = new System.Drawing.Point(566, 404);
            this.pBoxBanana.Name = "pBoxBanana";
            this.pBoxBanana.Size = new System.Drawing.Size(148, 144);
            this.pBoxBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxBanana.TabIndex = 0;
            this.pBoxBanana.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1767, 1174);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pboxMonkey);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pBoxBanana);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxMonkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBanana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxBanana;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pboxMonkey;
        private System.Windows.Forms.Label lblScore;
    }
}

