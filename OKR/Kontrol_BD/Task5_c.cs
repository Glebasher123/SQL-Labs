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
    public partial class Task5_c : Form
    {
        public Task5_c()
        {
            InitializeComponent();

            //var ot = textBox1.Text;
            //var doo = textBox2.Text;
            //Database database = new Database();
            //SqlCommand command = new SqlCommand($"SELECT [Название озера], Площадь, [Средняя глубина] FROM Озёра WHERE Площадь BETWEEN {ot} AND {doo}", database.getConnection());
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();

            //try
            //{
            //    database.OpenConnection();
            //    adapter.Fill(dataTable);
            //    dataGridView1.DataSource = dataTable.DefaultView;
            //    database.CloseConnection();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    database.CloseConnection();
            //}
        }

        private void Task5_c_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ozera_Var4DataSet.Озёра". При необходимости она может быть перемещена или удалена.
            this.озёраTableAdapter.Fill(this.ozera_Var4DataSet.Озёра);

        }
        
        
        private void Button1_Click(object sender, EventArgs e)
        {

            var ot = textBox1.Text;
            var doo = textBox2.Text;
            Database database = new Database();
            SqlCommand command = new SqlCommand($"SELECT [Название озера], Площадь, [Средняя глубина] FROM Озёра WHERE Площадь BETWEEN {ot} AND {doo}", database.getConnection());
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

        private void DataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Task5 task5 = new Task5();
            this.Hide();
            task5.Show();
        }
    }
}
