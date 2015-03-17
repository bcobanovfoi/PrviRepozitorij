using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skripta_zadatak_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NovaKlasa nova = new NovaKlasa();

            string a = textBox1.Text;
            string b = textBox2.Text;

            int brojac = nova.getUppers(a);

            nova.Logika(a, b, this, brojac);




        }
    }
}
