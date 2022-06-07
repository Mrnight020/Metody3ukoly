using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Ukoly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ukol1 form = new Ukol1();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ukol2 form = new Ukol2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ukol3 form = new Ukol3();
            form.Show();
        }
    }
}
