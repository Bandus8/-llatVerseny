namespace diakkezelo
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.adatbevitel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kivalaszt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.legidosebbek = new System.Windows.Forms.ListBox();
            this.kivalsztott = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(109, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diákok";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(25, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 317);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(535, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kiválasztottak";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(470, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 121);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // adatbevitel
            // 
            this.adatbevitel.Location = new System.Drawing.Point(25, 415);
            this.adatbevitel.Name = "adatbevitel";
            this.adatbevitel.Size = new System.Drawing.Size(75, 23);
            this.adatbevitel.TabIndex = 4;
            this.adatbevitel.Text = "Adatbevitel";
            this.adatbevitel.UseVisualStyleBackColor = true;
            this.adatbevitel.Click += new System.EventHandler(this.adatbevitel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kivalaszt
            // 
            this.kivalaszt.Location = new System.Drawing.Point(207, 415);
            this.kivalaszt.Name = "kivalaszt";
            this.kivalaszt.Size = new System.Drawing.Size(75, 23);
            this.kivalaszt.TabIndex = 5;
            this.kivalaszt.Text = "Kiválasztás";
            this.kivalaszt.UseVisualStyleBackColor = true;
            this.kivalaszt.Click += new System.EventHandler(this.kivalaszt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(535, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Legidősebbek";
            // 
            // legidosebbek
            // 
            this.legidosebbek.FormattingEnabled = true;
            this.legidosebbek.Location = new System.Drawing.Point(470, 281);
            this.legidosebbek.Name = "legidosebbek";
            this.legidosebbek.Size = new System.Drawing.Size(299, 95);
            this.legidosebbek.TabIndex = 7;
            // 
            // kivalsztott
            // 
            this.kivalsztott.BackColor = System.Drawing.Color.PeachPuff;
            this.kivalsztott.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kivalsztott.Location = new System.Drawing.Point(470, 415);
            this.kivalsztott.Name = "kivalsztott";
            this.kivalsztott.Size = new System.Drawing.Size(299, 13);
            this.kivalsztott.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kivalsztott);
            this.Controls.Add(this.legidosebbek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kivalaszt);
            this.Controls.Add(this.adatbevitel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Diákok adatai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button adatbevitel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button kivalaszt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox legidosebbek;
        private System.Windows.Forms.TextBox kivalsztott;
    }
}

