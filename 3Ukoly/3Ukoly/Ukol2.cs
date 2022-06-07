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
    public partial class Ukol2 : Form
    {
        public Ukol2()
        {
            InitializeComponent();
        }

        void cisliceremove(TextBox textBox,ListBox listBox)
        {
            string text = textBox1.Text;
            int pozice = 0;
            foreach (char znak in text)
            {
                if (znak >= '0' && znak <= '9')
                {
                    //text = text.Replace(text[pozice], ' ');
                    text = text.Remove(pozice,1);
                    pozice--;
                }
                pozice++;
            }

            text.Trim();
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }

            string[] pole = text.Split(' ');
            foreach(string slova in pole)
            {
                listBox1.Items.Add(slova);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            cisliceremove(textBox1, listBox1);

        }
    }
}
