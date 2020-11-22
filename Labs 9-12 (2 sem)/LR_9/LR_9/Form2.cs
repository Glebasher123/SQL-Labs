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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ПоставщикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab4DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab4DataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.lab4DataSet.Поставщик);

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                поставщикDataGridView.Sort(поставщикDataGridView.Columns[listBox1.SelectedIndex], ListSortDirection.Ascending);
            }
            else
            {
                поставщикDataGridView.Sort(поставщикDataGridView.Columns[listBox1.SelectedIndex], ListSortDirection.Descending);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.Filter = "[Наименование] LIKE'" + comboBox1.Text + "%'";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.Filter = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < поставщикDataGridView.RowCount; i++)
            {
                поставщикDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < поставщикDataGridView.ColumnCount; j++)
                    if (поставщикDataGridView.Rows[i].Cells[j].Value != null)
                        if (поставщикDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            поставщикDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
 
