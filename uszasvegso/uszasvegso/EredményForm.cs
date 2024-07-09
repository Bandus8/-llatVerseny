using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace uszasvegso
{
    public partial class EredményForm : Form
    {
        private List<Versenyzo> versenyzok = new List<Versenyzo> ();
        VersenyForm versenyForm = new VersenyForm ();
      
        public EredményForm()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;   
            textBox3.Enabled = false;
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < versenyzok.Count; i++)
            {
                if (versenyzok[listBox1.SelectedIndex].Rajtszam == versenyzok[i].Rajtszam)
                {
                    p = i;
                }
            }
            textBox1.Text = versenyzok[p].Rajtszam;
            textBox2.Text = versenyzok[p].Orszag;
            textBox3.Text = Convert.ToString(versenyzok[p].Idoeredmeny);

        }
        internal void felir(int Tav, string Fajta)
        {
            label4.Text = $"{Tav} méteres {Fajta} eredménye";
        }
        internal void ListaIr(List<Versenyzo> versenyzok)
        {
            listBox1.Items.Clear();
            this.versenyzok = versenyzok;
            for (int i = 0; i < versenyzok.Count; i++)
            {
                listBox1.Items.Add(versenyzok[i]);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Sorted = false;
            listBox1.Items.Clear();

            Versenyzo temp;
            for (int i = 0; i < versenyzok.Count - 1; i++)
            {
                for (int j = i + 1; j < versenyzok.Count; j++)
                {
                    if (versenyzok[i].Idoeredmeny > versenyzok[j].Idoeredmeny)
                    {
                        temp = versenyzok[i];
                        versenyzok[i] = versenyzok[j];
                        versenyzok[j] = temp;
                    }
                }
            }

            foreach (Versenyzo versenyzo in versenyzok)
            {
                listBox1.Items.Add(versenyzo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
