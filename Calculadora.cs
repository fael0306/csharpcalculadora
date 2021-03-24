using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGrandeVolta
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float a,b,c;

            try
            {
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);

                c = a + b;

                textBox3.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Digite valores válidos");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            float a, b, c;

            try
            {
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);

                c = a - b;

                textBox3.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Digite valores válidos");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            float a, b, c;

            try
            {
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);

                c = a * b;

                textBox3.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Digite valores válidos");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            float a, b, c;

            try
            {
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);

                c = a / b;

                textBox3.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Digite valores válidos");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            double a, b, c;

            try
            {
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);

                c = Math.Pow(a, 1 / b);

                textBox3.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Digite valores válidos");
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            double a, b, c;

            try
            {
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);

                c = Math.Pow(a,b);

                textBox3.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Digite valores válidos");
            }
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
