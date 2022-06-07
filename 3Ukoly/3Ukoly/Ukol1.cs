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
    public partial class Ukol1 : Form
    {
        public Ukol1()
        {
            InitializeComponent();
        }

        bool JeAlfanum(TextBox textBox,ref int pocetmalych,ref int pocetvelkych,ref int pocetjinych)
        {
            int pocetcelk = 0;
            string znaky = textBox1.Text;
            bool pomocna = true;
            foreach(char znak in znaky)
            {
                if(znak >= 'a' && znak <= 'z' || znak >= 'A' && znak <= 'Z' || znak >= '0' && znak <= '9')
                {
                    if (znak >= 'a' && znak <= 'z') pocetmalych++;
                    if (znak >= 'A' && znak <= 'Z') pocetvelkych++;
                    pocetcelk++;
                }
                else
                {
                    pocetjinych++;
                    pomocna = false;
                }
            }
            return pomocna;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pocetmalych = 0;
            int pocetvelkych = 0;
            int pocetjinych = 0;

            bool pravda = JeAlfanum(textBox1, ref pocetmalych, ref pocetvelkych, ref pocetjinych);

            if (textBox1.TextLength < 1)
            {
                label1.Text = "Textbox neobsahuje žádné znaky";
            }
            else
            {
                label1.Text = String.Format("Text {0} alfanumerický\nPocet malych pismen : {1}\nPocet velkych Pismen:{2} \nOstatní znaky:{3}"
                                            , pravda ? "je" : "neni", pocetmalych, pocetvelkych, pocetjinych);
            }
        }
    }
}
