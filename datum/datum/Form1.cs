using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datum
{
    public partial class Form1 : Form
    {
        private DateTime ma = DateTime.Now; 
        private DateTime szulDatum;
        private DateTime valasztottDatum;
       
            public Form1()
        {
            InitializeComponent();
            ActiveControl = szuldat;
            ennyievesvagy.Enabled = false;
            szülnap.Enabled = false;
            ennyinap.Enabled = false;
            nappalkesoob.Enabled = false;
            pontdatum.Text = ma.ToString("F");
            grat.Text = " ";
            valasztottDatum = dateTimePicker1.Value;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hu-HU");
            
        }
        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pontdatum.Text = DateTime.Now.ToString("F");
        }

        private void kiir_Click_1(object sender, EventArgs e)
        {

            ennyievesvagy.Text = (DateTime.Now.Year - szulDatum.Year).ToString();
            szülnap.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(szulDatum.DayOfWeek);
            ennyinap.Text = valasztottDatum.DayOfYear.ToString();
        }

        private void torol_Click_1(object sender, EventArgs e)
        {
            ennyievesvagy.Clear();
            szülnap.Clear();
            ennyinap.Clear();
            nappalkesoob.Clear();
            napvalaszt.Clear();
            grat.Text = " ";
            szuldat.Clear();
        }

        private void bezar_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Biztosan ki akar lépni?", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            valasztottDatum = dateTimePicker1.Value;
            ennyinap.Text = valasztottDatum.DayOfYear.ToString();
        }

        private void szuldat_Leave_1(object sender, EventArgs e)
        {
            try
            {
                szulDatum = DateTime.Parse(szuldat.Text);
                if (szulDatum.Month == DateTime.Now.Month && szulDatum.Day == DateTime.Now.Day)
                    grat.Text = "Boldog születésnapot!";
                else
                    grat.Text = "Boldog hétköznapot";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Hiba");
                szuldat.Focus();
            }
        }

        private void napvalaszt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int nap = int.Parse(napvalaszt.Text);
               nappalkesoob.Text = valasztottDatum.AddDays(nap).ToString("d");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Hiba");
            }
        }
    }
}
