using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retoxikáló
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private List<Italok> italok = new List<Italok>();
        
        private List<CheckBox> chk = new List<CheckBox>();
        private List<NumericUpDown> numeric = new List<NumericUpDown>();

        private int bal = 50, fent = 10, chkXmeret = 250, chkYtav = 40,
            txtXmeret = 50, txtYmeret = 17, xKoz = 5;

        private void kifizetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Italok item in italok)
            {
                item.Fizet();
            }
        }

        private void számlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 szamla = new Form4();
            szamla.Kitol(italok);
            szamla.ShowDialog();

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                contextMenuStrip1.Show(ptLowerLeft);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valasztott = false;
            bool vanhiba = false;
            int mennyiseg = 0;

            for (int i = 0; i < chk.Count; i++)
            {
                if (chk[i].Checked)
                {
                    valasztott = true;
                    try {
                        mennyiseg = Convert.ToInt32(numeric[i].Value);
                        if (mennyiseg <= 0 || mennyiseg > 999) throw new Exception();
                        italok[i].Rendel(mennyiseg);
                        numeric[i].BackColor = Color.White;
                        chk[i].Checked = false;
                        numeric[i].Value = 0;



                        
                    }catch (Exception) { numeric[i].BackColor = Color.Salmon; vanhiba = true; }




                }
            }
            if (!valasztott)
            {
                MessageBox.Show("Semmit nem választott!", "Figyelmeztetés");
            }
            else if (vanhiba)
            {
                MessageBox.Show("A pirossal jelzett adagok hibásak!", "Figyelmeztetés");
            }
            

        }

        internal void ListaIr(List<Italok> italok)
        { 
            panel1.Controls.Clear();
            this.italok = italok;

            CheckBox chkBox;
            NumericUpDown nud;
            Label lbl;

            

            for (int i = 0; i < italok.Count; i++)
            {
                chkBox = new CheckBox();
                nud = new NumericUpDown();
                lbl = new Label();

                chkBox.Location = new Point(bal, fent + i * chkYtav);
                chkBox.Size = new Size(chkXmeret, txtYmeret);
                chkBox.Text = italok[i].Arlistaba();
                chkBox.TextAlign = ContentAlignment.MiddleLeft;

                nud.Maximum = 999;
                nud.Controls[0].Hide();
                nud.Location = new Point(bal + chkXmeret, fent + i * chkYtav - 2);
                nud.Size = new Size(txtXmeret, txtYmeret);

                lbl.AutoSize = true;
                lbl.Location = new Point(bal + chkXmeret + txtXmeret + xKoz, fent + i * chkYtav + 1);

                lbl.Text = "adag";


                panel1.Controls.Add(chkBox);
                panel1.Controls.Add(nud);
                panel1.Controls.Add(lbl);
                

                chk.Add(chkBox);
                numeric.Add(nud);

                



            }


        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
