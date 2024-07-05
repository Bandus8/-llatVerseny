namespace retoxikáló
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBal = new System.Windows.Forms.Button();
            this.btnJobb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 377);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBal
            // 
            this.btnBal.Location = new System.Drawing.Point(183, 405);
            this.btnBal.Name = "btnBal";
            this.btnBal.Size = new System.Drawing.Size(75, 23);
            this.btnBal.TabIndex = 1;
            this.btnBal.Text = "<---";
            this.btnBal.UseVisualStyleBackColor = true;
            this.btnBal.Click += new System.EventHandler(this.btnBal_Click);
            // 
            // btnJobb
            // 
            this.btnJobb.Location = new System.Drawing.Point(508, 405);
            this.btnJobb.Name = "btnJobb";
            this.btnJobb.Size = new System.Drawing.Size(75, 23);
            this.btnJobb.TabIndex = 2;
            this.btnJobb.Text = "--->";
            this.btnJobb.UseVisualStyleBackColor = true;
            this.btnJobb.Click += new System.EventHandler(this.btnJobb_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJobb);
            this.Controls.Add(this.btnBal);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Galéria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBal;
        private System.Windows.Forms.Button btnJobb;
    }
}