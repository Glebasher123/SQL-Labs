using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrol_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            this.Hide();
            task2.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3();
            this.Hide();
            task3.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Task4 task4 = new Task4();
            this.Hide();
            task4.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Task5 task5 = new Task5();
            this.Hide();
            task5.Show();
        }
    }
}
