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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ОзёраBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.озёраBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ozera_Var4DataSet);

        }

        private void Task2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ozera_Var4DataSet.Озёра". При необходимости она может быть перемещена или удалена.
            this.озёраTableAdapter.Fill(this.ozera_Var4DataSet.Озёра);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
