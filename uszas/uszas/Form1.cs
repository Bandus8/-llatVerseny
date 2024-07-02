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
using System.Runtime.InteropServices.ComTypes;

namespace uszas
{

    
    public partial class Form1 : Form
        {
            public TimeSpan ido;
            
        public Form1()
            {
                InitializeComponent();
            
            rajtszam.Enabled = false;
                kor.Enabled = false;
                orszag.Enabled = false;
            gyoztes.Enabled = false;
           idoered.Enabled = false;
        }

        private void Beolvas()
        {
            StreamReader sr = new StreamReader("uszok.txt");

            string rajt;
            string nev;
            DateTime kor;
            string orszag;
            TimeSpan ido;


            while (!sr.EndOfStream)
            {
                string sor;
                string[] s;
                sor = sr.ReadLine();
                s = sor.Split(';');
                rajt = s[0];
                nev = s[1];
                kor = DateTime.Parse(s[2]);
                orszag = s[3];
                ido = TimeSpan.Parse(s[4]);
                Versenyzo versenyzo = new Versenyzo(rajt, nev, kor, orszag, ido);
                listBox1.Items.Add(versenyzo);
               
            }



        
        }


            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void bezar_Click(object sender, EventArgs e)
            {
            if (MessageBox.Show("Biztosan ki akar lépni?", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void beolvas_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
            Beolvas();
            beolvas.Enabled = false;
            gyoztes.Enabled = true;
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Versenyzo versenyzo = (Versenyzo)listBox1.SelectedItem;
            rajtszam.Text = versenyzo.Rajtszam;
            kor.Text = (DateTime.Now.Year - versenyzo.SzulDatum.Year) + " év";
            orszag.Text = versenyzo.Orszag;
            idoered.Text = new DateTime(versenyzo.IdoEredmeny.Ticks).ToString("h.m.ss");

            
        }

        private void gyoztes_Click(object sender, EventArgs e)
        {
            TimeSpan min = (listBox1.Items[0] as Versenyzo). IdoEredmeny;
            foreach (var item in listBox1.Items)
            {
                if ((item as Versenyzo).IdoEredmeny < min)
                {
                    min = (item as Versenyzo).IdoEredmeny;
                }
            } 
                maskedTextBox1.Text = new DateTime(min.Ticks).ToString("d:m:ss"); 
                listBox2.Items.Clear();
            foreach (var item in listBox1.Items)
            {

                if ((item as Versenyzo).IdoEredmeny == min)
                {
                    listBox2.Items.Add(item + "\n");
                }
            }
                
            
        }
    }
    class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Nev { get; private set; }
        public DateTime SzulDatum { get; private set; }
        public string Orszag { get; private set; }
        public TimeSpan IdoEredmeny { get; private set; }

        public Versenyzo(string rajtszam, string nev, DateTime szulDatum, string orszag, TimeSpan idoEredmeny)
        {
            this.Rajtszam = rajtszam;
            this.Nev = nev;
            this.SzulDatum = szulDatum;
            this.Orszag = orszag;
            this.IdoEredmeny = idoEredmeny;
        }

        public override string ToString()
        {
            return Nev;
        }
    }
}
