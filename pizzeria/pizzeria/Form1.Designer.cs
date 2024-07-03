namespace pizzeria
{
    partial class Pizzéria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pizzéria));
            this.adatbevitel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.torol = new System.Windows.Forms.Button();
            this.szamol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fizetendo = new System.Windows.Forms.RichTextBox();
            this.bezar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // adatbevitel
            // 
            this.adatbevitel.Location = new System.Drawing.Point(317, 400);
            this.adatbevitel.Name = "adatbevitel";
            this.adatbevitel.Size = new System.Drawing.Size(180, 20);
            this.adatbevitel.TabIndex = 0;
            this.adatbevitel.Text = "Adatbevitel";
            this.adatbevitel.UseVisualStyleBackColor = true;
            this.adatbevitel.Click += new System.EventHandler(this.adatbevitel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(71, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENÜVÁLASZTÉK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // torol
            // 
            this.torol.Location = new System.Drawing.Point(71, 400);
            this.torol.Name = "torol";
            this.torol.Size = new System.Drawing.Size(75, 23);
            this.torol.TabIndex = 3;
            this.torol.Text = "Töröl";
            this.torol.UseVisualStyleBackColor = true;
            this.torol.Click += new System.EventHandler(this.torol_Click);
            // 
            // szamol
            // 
            this.szamol.Location = new System.Drawing.Point(71, 351);
            this.szamol.Name = "szamol";
            this.szamol.Size = new System.Drawing.Size(75, 23);
            this.szamol.TabIndex = 4;
            this.szamol.Text = "Számol";
            this.szamol.UseVisualStyleBackColor = true;
            this.szamol.Click += new System.EventHandler(this.szamol_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(229, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fizetendő:";
            // 
            // fizetendo
            // 
            this.fizetendo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.fizetendo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fizetendo.Location = new System.Drawing.Point(336, 360);
            this.fizetendo.Name = "fizetendo";
            this.fizetendo.Size = new System.Drawing.Size(100, 23);
            this.fizetendo.TabIndex = 6;
            this.fizetendo.Text = "";
            // 
            // bezar
            // 
            this.bezar.Location = new System.Drawing.Point(646, 397);
            this.bezar.Name = "bezar";
            this.bezar.Size = new System.Drawing.Size(75, 23);
            this.bezar.TabIndex = 7;
            this.bezar.Text = "Bezár";
            this.bezar.UseVisualStyleBackColor = true;
            this.bezar.Click += new System.EventHandler(this.bezar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(71, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 250);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Pizzéria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bezar);
            this.Controls.Add(this.fizetendo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.szamol);
            this.Controls.Add(this.torol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adatbevitel);
            this.Name = "Pizzéria";
            this.Text = "Pizzéria";
            this.Load += new System.EventHandler(this.Pizzéria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adatbevitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button torol;
        private System.Windows.Forms.Button szamol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox fizetendo;
        private System.Windows.Forms.Button bezar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}

