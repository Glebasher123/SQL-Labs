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
    public partial class Task5_a : Form
    {
        public Task5_a()
        {
            InitializeComponent();

            Database database = new Database();
            SqlCommand command = new SqlCommand("SELECT[Название озера], Район, [Наибольшая глубина] FROM Озёра WHERE[Наибольшая глубина] = (SELECT  MAX([Наибольшая глубина]) FROM Озёра)", database.getConnection());
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

        private void Task5_a_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ozera_Var4DataSet1.Озёра". При необходимости она может быть перемещена или удалена.
            this.озёраTableAdapter.Fill(this.ozera_Var4DataSet1.Озёра);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Task5 task5 = new Task5();
            this.Hide();
            task5.Show();
        }
    }
}
