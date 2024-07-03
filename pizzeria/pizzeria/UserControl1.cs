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

namespace pizzeria
{
    public partial class UserControl1 : UserControl
    {
        private Pizza pizza;
        public bool Checked => checkBox1.Checked;
        public int Darab => (int)(darba.Value);
        public int Ar
        {
            get 
            {
                if (arkicsi.Checked) 
                {
                    return pizza.arKicsi;
                }
                if (arnagy.Checked)
                {
                    return pizza.arNagy;
                }
                return 0;
            }
        
        }
        public UserControl1(Pizza pizza)
        {
            InitializeComponent();

            this.pizza = pizza;
            checkBox1.Text = pizza.Nev;
            arkicsi.Text = pizza.arKicsi.ToString();
            arnagy.Text = pizza.arNagy.ToString();
        



        }
        public void Clear()
        {
            checkBox1.Checked = false;
            arkicsi.Checked = false;   
            arnagy.Checked = false;
            darba.Value = 0;
        
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
