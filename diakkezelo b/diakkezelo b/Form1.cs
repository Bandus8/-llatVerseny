using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace diakkezelo_b
{
    public partial class Form1 : Form
    {
        public List<Diak> diak = new List<Diak>();
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }

        private void adatbe_Click(object sender, EventArgs e)
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {

                    AdatBeolvasas(fajlNev);
                    FelrakDiakok();
                  
                }
                catch (Exception)
                {

                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
            }

            List<int> szamok = new List<int>();

            for (int i = 0; i < diak.Count; i++)
            {
                if (!szamok.Contains(diak[i].ido))
                {
                    szamok.Add(diak[i].ido);
                }
            }
            for (int i = 0; i < szamok.Count; i++)
            {
               Button b = new Button();
                b.Text = Convert.ToString(szamok[i]);
                b.Left = gombok.AutoScrollPosition.X + 60 * gombok.Controls.Count;
                b.Width = 45;
                b.Click += Kivalaszt;

                gombok.Controls.Add(b);

            }

        }
        private void AdatBeolvasas(string fajlNev)
        {

            StreamReader sr = new StreamReader(fajlNev);
            while (!sr.EndOfStream)
            {
                string sor;
                string[] s;
                sor = sr.ReadLine();
                s = sor.Split(';');
                diak.Add(new Diak(s[0], s[1], int.Parse(s[2])));
            }
            sr.Close();
        }
        private void FelrakDiakok()
        {
            for (int i = 0; i < diak.Count; i++)
            {
                listBox1.Items.Add(diak[i]);
            }
        }
        public void Kivalaszt(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int kiv = int.Parse((sender as Button).Text);

            for (int i = 0; i < diak.Count; i++)
            {
                if (diak[i].ido == kiv)
                {
                    listBox2.Items.Add(diak[i]);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = $"{diak[listBox2.SelectedIndex].Nev} {diak[listBox2.SelectedIndex].kod} {diak[listBox2.SelectedIndex].ido}";
        }
    }


    public class Diak
    {
        public string Nev;
        public string kod;
        public int ido;

        public Diak(string nev, string kod, int ido)
        {
            Nev = nev;
            this.kod = kod;
            this.ido = ido;
        }
        public override string ToString()
        {
            return Nev + ' ' + kod;
        }

    }

}
