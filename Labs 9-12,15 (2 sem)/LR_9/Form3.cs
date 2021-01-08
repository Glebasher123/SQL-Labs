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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ПоставщикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab4DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab4DataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.lab4DataSet.Поставщик);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.MoveFirst();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.MovePrevious();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.AddNew();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.MoveLast();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.MoveNext();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.RemoveCurrent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab4DataSet);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form4 d = new Form4();
            //d.Show();
        }
    }
}
