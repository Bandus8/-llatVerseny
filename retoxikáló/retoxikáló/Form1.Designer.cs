namespace retoxikáló
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itallapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galériaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.itallapToolStripMenuItem,
            this.galériaToolStripMenuItem,
            this.súgóToolStripMenuItem,
            this.névjegyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mentésToolStripMenuItem,
            this.kilépsToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Megnyitás";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // kilépsToolStripMenuItem
            // 
            this.kilépsToolStripMenuItem.Name = "kilépsToolStripMenuItem";
            this.kilépsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépsToolStripMenuItem.Text = "Kilépés";
            this.kilépsToolStripMenuItem.Click += new System.EventHandler(this.kilépsToolStripMenuItem_Click);
            // 
            // itallapToolStripMenuItem
            // 
            this.itallapToolStripMenuItem.Name = "itallapToolStripMenuItem";
            this.itallapToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.itallapToolStripMenuItem.Text = "Itallap";
            this.itallapToolStripMenuItem.Click += new System.EventHandler(this.itallapToolStripMenuItem_Click);
            // 
            // galériaToolStripMenuItem
            // 
            this.galériaToolStripMenuItem.Name = "galériaToolStripMenuItem";
            this.galériaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.galériaToolStripMenuItem.Text = "Galéria";
            this.galériaToolStripMenuItem.Click += new System.EventHandler(this.galériaToolStripMenuItem_Click);
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.súgóToolStripMenuItem.Text = "Súgó";
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Nyertes kocsma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itallapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galériaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

