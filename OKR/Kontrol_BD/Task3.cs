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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Database dataBase = new Database();
            SqlCommand command = new SqlCommand("INSERT INTO Озёра ([Название озера], Район, Площадь, [Наибольшая глубина], [Средняя глубина]) VALUES (@name, @raion, @square, @max, @aver)", dataBase.getConnection());
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = NameBox.Text;
            command.Parameters.Add("@raion", SqlDbType.VarChar).Value = RaionBox.Text;
            command.Parameters.Add("@square", SqlDbType.VarChar).Value = SquareBox.Text;
            command.Parameters.Add("@max", SqlDbType.VarChar).Value = MaxDepthBox.Text;
            command.Parameters.Add("@aver", SqlDbType.VarChar).Value = AverageDepthBox.Text;

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Создано!");
            else
                MessageBox.Show("Не удачно! :(");

            dataBase.CloseConnection();

            Form1 mainWindow = new Form1();
            this.Hide();
            mainWindow.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
