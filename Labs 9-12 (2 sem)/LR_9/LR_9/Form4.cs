using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_9
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab4DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.lab4DataSet.Товар);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                товарDataGridView.Sort(товарDataGridView.Columns[listBox1.SelectedIndex], ListSortDirection.Ascending);
            }
            else
            {
                товарDataGridView.Sort(товарDataGridView.Columns[listBox1.SelectedIndex], ListSortDirection.Descending);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            товарBindingSource.Filter = "[Название товара] LIKE'" + comboBox1.Text + "%'";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            товарBindingSource.Filter = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < товарDataGridView.RowCount; i++)
            {
                товарDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < товарDataGridView.ColumnCount; j++)
                    if (товарDataGridView.Rows[i].Cells[j].Value != null)
                        if (товарDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            товарDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
