using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uszasvegso
{
    public partial class VersenyForm : Form
    {
        public int Tav;
        public string Fajta;
        public int szam = 0;
        List<Versenyzo> versenyzoks = new List<Versenyzo>();
        private DateTime alap = new DateTime(2000, 01, 01, 0, 0, 0);
        public VersenyForm()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            button2.Enabled = false;
            dateTimePicker1.Value = alap;
            comboBox1.SelectedIndex = 0;

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        internal void Betolt(List<Versenyzo> versenyzok)
        {
            
            for (int i = 0; i < versenyzok.Count; i++)
            {
                versenyzoks.Add(versenyzok[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon úszásnemet!", "Hiba!");
            }
            else
            {
                Tav = (int)numericUpDown1.Value;
                Fajta = comboBox1.Text;
                button2.Enabled = true;
                Beiras();
            }
           
            
        }
        private void Beiras()
        {
            dateTimePicker1.Value = alap;
            if (szam < versenyzoks.Count)
            {
                textBox1.Text = versenyzoks[szam].Nev;

            }
            else 
            {
               
                this.Close();
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeSpan idoEredmeny = dateTimePicker1.Value - alap;
            versenyzoks[szam].Versenyez(idoEredmeny);
            szam++;
            Beiras();
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
