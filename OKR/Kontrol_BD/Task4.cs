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
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }
        public void PrintBD(string zapros)
        {
            Database database = new Database();
            SqlCommand command = new SqlCommand(zapros, database.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            try
            {
                database.OpenConnection();
                adapter.Fill(dataTable);
                озёраDataGridView.DataSource = dataTable.DefaultView;
                database.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.CloseConnection();
            }
        }
        private void Task4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ozera_Var4DataSet.Озёра". При необходимости она может быть перемещена или удалена.
            this.озёраTableAdapter.Fill(this.ozera_Var4DataSet.Озёра);

        }
        int id;
        private void Button1_Click(object sender, EventArgs e)
        {
             Database database = new Database();
             SqlCommand command = new SqlCommand($"DELETE FROM Озёра WHERE [ID озера] = {id}", database.getConnection());
                

            database.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Создано!");
            else
                MessageBox.Show("Не удачно! :(");

            PrintBD("Select * FROM Озёра");
            database.CloseConnection();

        }

        private void ОзёраDataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (озёраDataGridView.SelectedRows.Count != 0)
                {
                    for (int i = 0; i < озёраDataGridView.SelectedRows.Count; i++)
                    {
                        DataRowView dataRow = озёраDataGridView.SelectedRows[0].DataBoundItem as DataRowView;

                        id = (int)dataRow[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
