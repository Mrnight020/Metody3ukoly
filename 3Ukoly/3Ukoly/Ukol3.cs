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
    public partial class Ukol3 : Form
    {
        public Ukol3()
        {
            InitializeComponent();
        }

        void Rozklad(int cislo1, int cislo2)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            int delitel = 2;
            while(cislo1 > 1)
            {
                if(cislo1 % delitel == 0)
                {
                    listBox1.Items.Add(delitel);
                    cislo1 = cislo1 / delitel;
                }
                else
                {
                    delitel++;
                }
            }
            delitel = 2;
            while (cislo2 > 1)
            {
                if (cislo2 % delitel == 0)
                {
                    listBox2.Items.Add(delitel);
                    cislo2 = cislo2 / delitel;
                }
                else
                {
                    delitel++;
                }
            }
        }

        int NSD(int a, int b)
        {
            int c = 0;
            while(b != 0)
            {
                c = b;
                b = a % b;
                a = c;
            }
            return a;
        }

        bool JePrvocislo(int cislo)
        {
            bool prvocislo = false;
            if (cislo == 1) prvocislo = false;
            else
            {
                if (cislo == 2 || cislo == 3) prvocislo = true;
                else
                {
                    int delitel = 3;
                    prvocislo = cislo % 2 != 0;
                    for(;delitel < (cislo/2) && prvocislo == true;delitel+=2)
                    {
                        if(cislo % delitel == 0)
                        {
                            prvocislo = false;
                        }
                    }
                }
            }
            return prvocislo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pomoc = 0;
            int cislo1 = (int)numericUpDown1.Value;
            int cislo2 = (int)numericUpDown2.Value;
            if(cislo1 < cislo2)
            {
                pomoc = cislo2;
                cislo2 = cislo1;
                cislo1 = pomoc;
            }

            int nsd = NSD(cislo1, cislo2);
            int NSN = (cislo1 * cislo2) / NSD(cislo1, cislo2);
            Rozklad(cislo1, cislo2);
            MessageBox.Show("Vetsi :" + cislo1 + "\nMenši :" + cislo2);
            MessageBox.Show("Největší společný delitel :" + nsd + "\nNejmenší společný násobek :" + NSN);
            MessageBox.Show(string.Format("Je větší číslo prvočíslo? : {0}\nJe menší číslo prvočíslo? : {1}", JePrvocislo(cislo1)? "Ano":"Ne", JePrvocislo(cislo2) ? "Ano" : "Ne"));

        }
    }
}
