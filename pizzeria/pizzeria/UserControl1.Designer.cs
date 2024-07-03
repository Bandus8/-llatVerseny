namespace pizzeria
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.arkicsi = new System.Windows.Forms.RadioButton();
            this.arnagy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.darba = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.darba)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // arkicsi
            // 
            this.arkicsi.AutoSize = true;
            this.arkicsi.Location = new System.Drawing.Point(162, 18);
            this.arkicsi.Name = "arkicsi";
            this.arkicsi.Size = new System.Drawing.Size(85, 17);
            this.arkicsi.TabIndex = 1;
            this.arkicsi.TabStop = true;
            this.arkicsi.Text = "radioButton1";
            this.arkicsi.UseVisualStyleBackColor = true;
            // 
            // arnagy
            // 
            this.arnagy.AutoSize = true;
            this.arnagy.Location = new System.Drawing.Point(352, 18);
            this.arnagy.Name = "arnagy";
            this.arnagy.Size = new System.Drawing.Size(85, 17);
            this.arnagy.TabIndex = 2;
            this.arnagy.TabStop = true;
            this.arnagy.Text = "radioButton2";
            this.arnagy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Darab";
            // 
            // darba
            // 
            this.darba.Location = new System.Drawing.Point(509, 18);
            this.darba.Name = "darba";
            this.darba.Size = new System.Drawing.Size(46, 20);
            this.darba.TabIndex = 5;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.darba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arnagy);
            this.Controls.Add(this.arkicsi);
            this.Controls.Add(this.checkBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(650, 50);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton arkicsi;
        private System.Windows.Forms.RadioButton arnagy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown darba;
    }
}
