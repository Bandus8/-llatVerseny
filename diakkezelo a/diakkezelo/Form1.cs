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

namespace diakkezelo
{
   
    public partial class Form1 : Form
    {
        public  List<Diak> diak = new List<Diak>();
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
            

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            GombBeallitas(true);

        }
        private void GombBeallitas(bool b)
        { 
        adatbevitel.Enabled = b;
            kivalaszt.Enabled = !b;

        }

        private void adatbevitel_Click(object sender, EventArgs e)
        {
            Adatbevitel();
            GombBeallitas(false);
        }

        private void kivalaszt_Click(object sender, EventArgs e)
        {
            legidosebbek.Items.Clear();
            listBox1.Items.Clear();
            List<Diak> list = new List<Diak>();
            foreach (UserControl1 item in panel1.Controls)
            {
                if (item.Checked)
                {
                    list.Add(item.Diak);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                listBox1.Items.Add(list[i]);
            }

            int max = list[0].ido;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ido < max)
                {
                    max = list[i].ido;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ido == max)
                {
                    legidosebbek.Items.Add(list[i]);
                }
            }
            
            
        }

        private void Adatbevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {

                    AdatBeolvasas(fajlNev);
                    FelrakDiakok();
                    GombBeallitas(true);
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
                diak.Add(new Diak(s[0], s[1], int.Parse(s[2])));
            }
            sr.Close();
        }
        private void FelrakDiakok()
        {
            for (int i = 0; i < diak.Count ; i++)
            {
                int teteje = i * 52 - panel1.AutoScrollPosition.Y;

                UserControl1 control1 = new UserControl1(diak[i]);
                control1.Top = teteje;
                panel1.Controls.Add(control1);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kivalsztott.Text = $"{diak[listBox1.SelectedIndex].Nev}  {diak[listBox1.SelectedIndex].kod}  {diak[listBox1.SelectedIndex].ido}";
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
