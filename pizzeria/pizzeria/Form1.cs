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

namespace pizzeria
{
    
    public partial class Pizzéria : Form
    {

        private int meretKicsi = 32, meretNagy = 45;
        private bool lathato;
        private List<Pizza> pizzak = new List<Pizza>();
        private List<CheckBox> jeloloNegyzetek = new List<CheckBox>(); 
        private List<RadioButton> rdBtnKicsiArak = new List<RadioButton>(); 
        private List<RadioButton> rdBtnNagyArak = new List<RadioButton>(); 
        private List<TextBox> txtDarabok = new List<TextBox>();
        public Pizzéria()
        {

            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
            bool lathato = false;
            ElemekMegjelen(lathato);

        }

        private void adatbevitel_Click(object sender, EventArgs e)
        {
            lathato = true;
            try 
            {
                AdatBevitel();
                ElemekMegjelen(lathato);
                this.BackgroundImage = null;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Hiba");
            }
            
        }
        private void AdatBevitel()
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    adatBeolvas(fajlNev);

                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
            }
        
        }
        private void adatBeolvas(string fajlNev)
        {
            string adat;
            StreamReader sr = new StreamReader(fajlNev);
            while(!sr.EndOfStream)
            {
            adat = sr.ReadLine();
             Feldolgoz(adat);
            }
            sr.Close();
        }
        private void Feldolgoz(string adat)
        {
            string[] s = adat.Split(';');
            pizzak.Add(new Pizza(s[0], int.Parse(s[1]), int.Parse(s[2])));
            for (int i = 0; i < pizzak.Count; i++)
            {
                int teteje = i * 52 - panel1.AutoScrollPosition.Y;

                UserControl1 control = new UserControl1(pizzak[i]);
                control.Top = teteje;
                panel1.Controls.Add(control);
            }
        }
        private void ElemekMegjelen(bool lathato)
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = lathato;
                
            }
            adatbevitel.Visible = !lathato;
        }

        private void szamol_Click(object sender, EventArgs e)
        {
            int osszeg = 0;
            foreach (UserControl1 item in panel1.Controls)
            {
                if (item.Checked)
                {
                    osszeg += item.Ar * item.Darab;
                }
            }
            fizetendo.Text = osszeg.ToString();
            
        }

        private void torol_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is CheckBox) (item as CheckBox).Checked = false;
                if (item is TextBox) ((TextBox)item).Clear();
                if (item.HasChildren)
                {
                    foreach (Control gyerek in item.Controls)
                    {
                        if (gyerek is RadioButton)(gyerek as RadioButton).Checked = false;
                        if (gyerek is NumericUpDown) (gyerek as NumericUpDown).Value = 0;
                        if(gyerek is CheckBox)(gyerek as CheckBox).Checked = false;
                    }

                }

               
            
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bezar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pizzéria_Load(object sender, EventArgs e)
        {

        }
    }
    public class Pizza
    {
        public string Nev { get; private set; }
        public int arKicsi { get; private set; }
        public int arNagy { get; private set; }

        public Pizza(string nev, int arKicsi, int arNagy)
        {
            Nev = nev;
            this.arKicsi = arKicsi;
            this.arNagy = arNagy;
        }
        public override string ToString()
        {
            return this.Nev;
        }
    }
}
