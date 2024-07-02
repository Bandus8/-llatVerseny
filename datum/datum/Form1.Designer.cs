namespace datum
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pontdatum = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.szuldat = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ennyievesvagy = new System.Windows.Forms.TextBox();
            this.szülnap = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.kiir = new System.Windows.Forms.Button();
            this.torol = new System.Windows.Forms.Button();
            this.bezar = new System.Windows.Forms.Button();
            this.ennyinap = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.nappalkesoob = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.napvalaszt = new System.Windows.Forms.TextBox();
            this.grat = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(36, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Pontos dátum és idő:";
            // 
            // pontdatum
            // 
            this.pontdatum.BackColor = System.Drawing.SystemColors.Control;
            this.pontdatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pontdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pontdatum.Location = new System.Drawing.Point(297, 38);
            this.pontdatum.Name = "pontdatum";
            this.pontdatum.Size = new System.Drawing.Size(401, 25);
            this.pontdatum.TabIndex = 1;
            this.pontdatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(36, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 19);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Születési dátum";
            // 
            // szuldat
            // 
            this.szuldat.Location = new System.Drawing.Point(209, 120);
            this.szuldat.Mask = "0000-00-00";
            this.szuldat.Name = "szuldat";
            this.szuldat.Size = new System.Drawing.Size(68, 20);
            this.szuldat.TabIndex = 3;
            this.szuldat.Leave += new System.EventHandler(this.szuldat_Leave_1);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(36, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 19);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Ennyi éves vagy:";
            // 
            // ennyievesvagy
            // 
            this.ennyievesvagy.BackColor = System.Drawing.SystemColors.Control;
            this.ennyievesvagy.Location = new System.Drawing.Point(209, 201);
            this.ennyievesvagy.Name = "ennyievesvagy";
            this.ennyievesvagy.Size = new System.Drawing.Size(68, 20);
            this.ennyievesvagy.TabIndex = 5;
            // 
            // szülnap
            // 
            this.szülnap.BackColor = System.Drawing.SystemColors.Control;
            this.szülnap.Location = new System.Drawing.Point(583, 201);
            this.szülnap.Name = "szülnap";
            this.szülnap.Size = new System.Drawing.Size(104, 20);
            this.szülnap.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(375, 199);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(202, 19);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "Ilyen napon születtél";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // kiir
            // 
            this.kiir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kiir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kiir.Location = new System.Drawing.Point(128, 415);
            this.kiir.Name = "kiir";
            this.kiir.Size = new System.Drawing.Size(75, 23);
            this.kiir.TabIndex = 8;
            this.kiir.Text = "Kiír";
            this.kiir.UseVisualStyleBackColor = true;
            this.kiir.Click += new System.EventHandler(this.kiir_Click_1);
            // 
            // torol
            // 
            this.torol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.torol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.torol.Location = new System.Drawing.Point(347, 415);
            this.torol.Name = "torol";
            this.torol.Size = new System.Drawing.Size(75, 23);
            this.torol.TabIndex = 9;
            this.torol.Text = "Töröl";
            this.torol.UseVisualStyleBackColor = true;
            this.torol.Click += new System.EventHandler(this.torol_Click_1);
            // 
            // bezar
            // 
            this.bezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bezar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bezar.Location = new System.Drawing.Point(583, 415);
            this.bezar.Name = "bezar";
            this.bezar.Size = new System.Drawing.Size(75, 23);
            this.bezar.TabIndex = 10;
            this.bezar.Text = "Bezár";
            this.bezar.UseVisualStyleBackColor = true;
            this.bezar.Click += new System.EventHandler(this.bezar_Click_1);
            // 
            // ennyinap
            // 
            this.ennyinap.BackColor = System.Drawing.SystemColors.Control;
            this.ennyinap.Location = new System.Drawing.Point(583, 313);
            this.ennyinap.Name = "ennyinap";
            this.ennyinap.Size = new System.Drawing.Size(104, 20);
            this.ennyinap.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.Location = new System.Drawing.Point(375, 314);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(202, 19);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "Ez a év ennyiedik napja:";
            // 
            // nappalkesoob
            // 
            this.nappalkesoob.BackColor = System.Drawing.SystemColors.Control;
            this.nappalkesoob.Location = new System.Drawing.Point(583, 355);
            this.nappalkesoob.Name = "nappalkesoob";
            this.nappalkesoob.Size = new System.Drawing.Size(104, 20);
            this.nappalkesoob.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox9.Location = new System.Drawing.Point(375, 356);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(202, 19);
            this.textBox9.TabIndex = 13;
            this.textBox9.Text = "nappal később dátum:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(36, 314);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(202, 19);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Tetszőleges dátum:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 355);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // napvalaszt
            // 
            this.napvalaszt.Location = new System.Drawing.Point(297, 355);
            this.napvalaszt.Name = "napvalaszt";
            this.napvalaszt.Size = new System.Drawing.Size(52, 20);
            this.napvalaszt.TabIndex = 17;
            this.napvalaszt.TextChanged += new System.EventHandler(this.napvalaszt_TextChanged);
            // 
            // grat
            // 
            this.grat.BackColor = System.Drawing.SystemColors.Control;
            this.grat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grat.Location = new System.Drawing.Point(270, 253);
            this.grat.Name = "grat";
            this.grat.Size = new System.Drawing.Size(217, 25);
            this.grat.TabIndex = 18;
            this.grat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grat);
            this.Controls.Add(this.napvalaszt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.nappalkesoob);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.ennyinap);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.bezar);
            this.Controls.Add(this.torol);
            this.Controls.Add(this.kiir);
            this.Controls.Add(this.szülnap);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.ennyievesvagy);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.szuldat);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pontdatum);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Dátum és idő kezelése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox pontdatum;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox szuldat;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox ennyievesvagy;
        private System.Windows.Forms.TextBox szülnap;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button kiir;
        private System.Windows.Forms.Button torol;
        private System.Windows.Forms.Button bezar;
        private System.Windows.Forms.TextBox ennyinap;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox nappalkesoob;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox napvalaszt;
        private System.Windows.Forms.TextBox grat;
        private System.Windows.Forms.Timer timer1;
    }
}

