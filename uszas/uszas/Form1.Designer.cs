namespace uszas
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
            this.bezar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.beolvas = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.gyoztes = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.rajtszam = new System.Windows.Forms.TextBox();
            this.orszag = new System.Windows.Forms.TextBox();
            this.idoered = new System.Windows.Forms.TextBox();
            this.kor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bezar
            // 
            this.bezar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bezar.Location = new System.Drawing.Point(299, 400);
            this.bezar.Name = "bezar";
            this.bezar.Size = new System.Drawing.Size(126, 23);
            this.bezar.TabIndex = 0;
            this.bezar.Text = "Bezár";
            this.bezar.UseVisualStyleBackColor = true;
            this.bezar.Click += new System.EventHandler(this.bezar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Brown;
            this.richTextBox1.Location = new System.Drawing.Point(73, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(339, 41);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "200m-es pillangó uszás";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 277);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox2.Location = new System.Drawing.Point(38, 59);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(173, 32);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "Résztvevők";
            // 
            // beolvas
            // 
            this.beolvas.Location = new System.Drawing.Point(38, 400);
            this.beolvas.Name = "beolvas";
            this.beolvas.Size = new System.Drawing.Size(173, 23);
            this.beolvas.TabIndex = 4;
            this.beolvas.Text = "Adatok beolvasása";
            this.beolvas.UseVisualStyleBackColor = true;
            this.beolvas.Click += new System.EventHandler(this.beolvas_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(258, 303);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(215, 69);
            this.listBox2.TabIndex = 5;
            // 
            // gyoztes
            // 
            this.gyoztes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gyoztes.Location = new System.Drawing.Point(258, 274);
            this.gyoztes.Name = "gyoztes";
            this.gyoztes.Size = new System.Drawing.Size(74, 23);
            this.gyoztes.TabIndex = 6;
            this.gyoztes.Text = "Győztes";
            this.gyoztes.UseVisualStyleBackColor = true;
            this.gyoztes.Click += new System.EventHandler(this.gyoztes_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(408, 277);
            this.maskedTextBox1.Mask = "00:00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(65, 20);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox3.Location = new System.Drawing.Point(258, 187);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(74, 24);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "Életkor";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox4.Location = new System.Drawing.Point(258, 157);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(108, 24);
            this.richTextBox4.TabIndex = 9;
            this.richTextBox4.Text = "Időeredmény";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.PeachPuff;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox5.Location = new System.Drawing.Point(258, 127);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(74, 24);
            this.richTextBox5.TabIndex = 10;
            this.richTextBox5.Text = "Ország";
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.PeachPuff;
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox6.Location = new System.Drawing.Point(258, 97);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(74, 24);
            this.richTextBox6.TabIndex = 11;
            this.richTextBox6.Text = "Rajtszám";
            // 
            // rajtszam
            // 
            this.rajtszam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rajtszam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rajtszam.Location = new System.Drawing.Point(365, 97);
            this.rajtszam.Name = "rajtszam";
            this.rajtszam.Size = new System.Drawing.Size(100, 13);
            this.rajtszam.TabIndex = 12;
            // 
            // orszag
            // 
            this.orszag.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.orszag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orszag.Location = new System.Drawing.Point(365, 131);
            this.orszag.Name = "orszag";
            this.orszag.Size = new System.Drawing.Size(100, 13);
            this.orszag.TabIndex = 13;
            // 
            // idoered
            // 
            this.idoered.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.idoered.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idoered.Location = new System.Drawing.Point(365, 161);
            this.idoered.Name = "idoered";
            this.idoered.Size = new System.Drawing.Size(100, 13);
            this.idoered.TabIndex = 14;
            // 
            // kor
            // 
            this.kor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kor.Location = new System.Drawing.Point(365, 198);
            this.kor.Name = "kor";
            this.kor.Size = new System.Drawing.Size(100, 13);
            this.kor.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.kor);
            this.Controls.Add(this.idoered);
            this.Controls.Add(this.orszag);
            this.Controls.Add(this.rajtszam);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.gyoztes);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.beolvas);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bezar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bezar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button beolvas;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button gyoztes;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.TextBox rajtszam;
        private System.Windows.Forms.TextBox orszag;
        private System.Windows.Forms.TextBox idoered;
        private System.Windows.Forms.TextBox kor;
    }
}

