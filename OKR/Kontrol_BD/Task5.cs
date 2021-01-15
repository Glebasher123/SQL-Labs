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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Task5_a task5a = new Task5_a();
            this.Hide();
            task5a.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Task5_a task5a = new Task5_a();
            this.Hide();
            task5a.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Task5_c task5c = new Task5_c();
            this.Hide();
            task5c.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
