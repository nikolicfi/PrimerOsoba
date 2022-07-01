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

namespace PrimerOsoba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox4.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox4.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = textBox1.Text;
                string prezime = textBox2.Text;
                int god = Convert.ToInt32(textBox3.Text);

                Osoba o = new Osoba(ime, prezime, god);

                StreamWriter f = new StreamWriter("spisak.txt", true);
                o.Pisi(f);
                f.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch(Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message, "Greska");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Osoba o, max;
                listBox1.Items.Clear();
                StreamReader f = new StreamReader("spisak.txt");

                max = new Osoba();
                max.Citaj(f);
                listBox1.Items.Add(max.ToString());

                while (!f.EndOfStream) {
                    o = new Osoba();
                    o.Citaj(f);
                    listBox1.Items.Add(o.ToString());
                    if (o.StarijaOd(max)) max = new Osoba(o);

                
                
                }
                textBox4.Text = max.ToString();
                f.Close();
            }
            catch(Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message, "Greska");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
