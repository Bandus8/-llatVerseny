using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uszasvegso
{
    public partial class Form1 : Form
    {
        public EredményForm eredmenyform = new EredményForm();
        public VersenyForm versenyForm = new VersenyForm();
        List<Versenyzo> versenyzok = new List<Versenyzo>();

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Title = "";
            eredményToolStripMenuItem.Enabled = false;
            
            versenyToolStripMenuItem.Enabled = false;
            mentésToolStripMenuItem.Enabled = false;


        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdatBevitel();
            mentésToolStripMenuItem.Enabled = true;
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan ki akar lépni?", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }
        private void AdatBevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {

                    AdatBeolvasas(fajlNev);
                    
                    névjegyToolStripMenuItem.Enabled = true;
                    versenyToolStripMenuItem.Enabled = true;


                }
                catch (Exception)
                {

                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
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
                versenyzok.Add(new Versenyzo(s[0], s[1], DateTime.Parse(s[2]), s[3]));
               
            }
            sr.Close();
        }

        private void eredményToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eredmenyform.ListaIr(versenyzok);
            eredmenyform.ShowDialog();

        }

        private void versenyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eredményToolStripMenuItem.Enabled = true;
            int Tav = versenyForm.Tav;
            string Fajta = versenyForm.Fajta;
            eredmenyform.felir(Tav, Fajta);
            versenyForm.Betolt(versenyzok);
            versenyForm.ShowDialog();

        }
    }
    class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Nev { get; private set; }
        public DateTime SzulDatum { get; private set; }
        public string Orszag { get; private set; }
        public TimeSpan Idoeredmeny { get;  set; }
        

        public Versenyzo(string rajtszam, string nev, DateTime szulDatum, string orszag)
        {
            this.Rajtszam = rajtszam;
            this.Nev = nev;
            this.SzulDatum = szulDatum;
            this.Orszag = orszag;
           
        }

        public override string ToString()
        {
            return Nev;
        }
        public void Versenyez(TimeSpan Idoeredmeny)
        {
            this.Idoeredmeny = Idoeredmeny;
        }
    }
}
