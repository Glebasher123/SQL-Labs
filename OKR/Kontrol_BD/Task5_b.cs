using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrol_BD
{
    public partial class Task5_b : Form
    {
        public Task5_b()
        {
            InitializeComponent();

            Database database = new Database();
            SqlCommand command = new SqlCommand("SELECT [Название озера], Район, Площадь FROM Озёра WHERE Район = 'Мядельский'", database.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            try
            {
                database.OpenConnection();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                database.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.CloseConnection();
            }

        }

        private void Task5_b_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ozera_Var4DataSet.Озёра". При необходимости она может быть перемещена или удалена.
            this.озёраTableAdapter.Fill(this.ozera_Var4DataSet.Озёра);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Task5 task5 = new Task5();
            this.Hide();
            task5.Show();
        }
    }
}
