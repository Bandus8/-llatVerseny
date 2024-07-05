using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retoxikáló
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        internal void Kitol(List<Italok> italok)
        {
            richTextBox1.Clear();
            foreach (Italok item in italok)
            {
                if (item.Mennyiseg != 0)
                {
                    richTextBox1.Text += item.ToString() + "\r\n";
                }
            }
        }
    }
}
