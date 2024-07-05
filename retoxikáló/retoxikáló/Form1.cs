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
using System.IO;

namespace retoxikáló
{
    public partial class Form1 : Form
    {
        public List<Italok> italok  = new List<Italok>();
        private List<Image> kepek = new List<Image>();
        private Form2 italform = new Form2();
        private int kepekszama = 3;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Title = "konyveles.txt";
            itallapToolStripMenuItem.Enabled = false;
            mentésToolStripMenuItem.Enabled = false;
            
        }

        private void kilépsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdatBevitel();
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
                    itallapToolStripMenuItem.Enabled =true;
                    mentésToolStripMenuItem.Enabled =true;
                    
                    
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
                italok.Add(new Italok(s[0], int.Parse(s[1])));
            }
            sr.Close();
        }

        private void itallapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italform.ListaIr(italok);
            italform.ShowDialog();
            

        }

        private void galériaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 galéria = new Form3();
            galéria.atad(kepek);
            galéria.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                KepBetoltes();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a képek létrehozásakor!", "Hiba");
            }
        }
        private void KepBetoltes()
        {
            Image kep;
            for (int i = 1; i < kepekszama+1; i++)
            {
                kep = Image.FromFile("kep" + i + ".jpg");
                kepek.Add(kep);
            }
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = null;
                try
                {
                    string fajlnev = saveFileDialog1.FileName;
                    sw = new StreamWriter(fajlnev);
                    foreach (Italok item in italok)
                    {
                        if (item.Mennyiseg > 0)
                        {
                            sw.WriteLine(item.Konyvelesbe());
                        }
                        
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájlba íráskor", "Hiba");
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
            }
        }
    }
    public class Italok
    { 
        public string Nev { get; set; }
        public int Ar { get; set; }
        public int Mennyiseg { get; set; }
        public int OsszMennyiseg { get; set; } 
        public string Bevetel { get; set; }


        public Italok(string nev, int ar)
        {
            Nev = nev;
            Ar = ar;
        }

        public override string ToString()
        {
            return Nev + " " + Ar + " Ft" + Mennyiseg + " Db" + Fizetendo() + " Ft";
        }
        public string Arlistaba()
        { 
        return Nev + "(" + Ar + ")";
        }
        public int Fizetendo()
        {
            return Mennyiseg * Ar;

        }
        public void Fizet()
        {
            OsszMennyiseg += Mennyiseg;
            Bevetel += Mennyiseg * Ar;
            
        }
        public void Rendel(int db)
        {
            Mennyiseg = 0;
            Mennyiseg += db;
        }
        public string Konyvelesbe()
        {
            return Nev + ';' + OsszMennyiseg + ';' +  Bevetel;

        }
    }
}
