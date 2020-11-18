using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] mass1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && Convert.ToInt32(textBox2.Text) > 0)
            {
                textBox1.Text = "";
                mass1 = new int[Convert.ToInt32(textBox2.Text)];
                Random random = new Random();

                for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
                {
                    mass1[i] = random.Next(-10, 10);
                    textBox1.Text += mass1[i] + " ";
                }
            }
            else
                MessageBox.Show("Проверьте введенные данные");
        }

        int count;
        double sum;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox4.Text = "";
                for (int i = 0; i < mass1.Length; i++)
                {
                    if (mass1[i] > 0 && i % 2 == 0)
                    {
                        count++;
                        sum += mass1[i];
                        textBox4.Text += mass1[i] + " ";
                    }
                }

                sum = sum / count;
                textBox3.Text = sum.ToString();
            }
            else
                MessageBox.Show("Вектор пустой");
        }
    }
}
