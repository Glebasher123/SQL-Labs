using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.Mapping;

namespace LR_9
{
    public partial class LINQ : Form
    {
        public LINQ()
        {
            InitializeComponent();
        }

        [Table(Name = "Товар")]
        public class Товар
        {
            [Column(Name = "Название товара")]
            public string НазваниеТовара { get; set; }
            [Column(Name = "Вес товара")]
            public int ВесТовара { get; set; }
            [Column(Name = "Цена")]
            public int Цена { get; set; }
        }

        [Table(Name = "Поставщик")]
        public class Поставщик
        {
            [Column(Name = "Наименование")]
            public string Наименование { get; set; }
            [Column(Name = "Телефон")]
            public string Телефон { get; set; }
        }

        [Table(Name = "Поставка")]
        public class Поставка
        {
            [Column(Name = "Количество")]
            public int Количество { get; set; }
            [Column(Name = "Дата Поставки")]
            public DateTime ДатаПоставки { get; set; }
        }

        [Table(Name = "Продажи")]
        public class Продажи
        {
            [Column(Name = "Дата Продажи")]
            public DateTime ДатаПродажи { get; set; }
            [Column(Name = "Количество")]
            public int Количество { get; set; }
            [Column(Name = "Цена продажи")]
            public int ЦенаПродажи { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            Connect connect = new Connect();
            DataContext db = new DataContext(connect.connection);

            var query = from u in db.GetTable<Товар>()
                            //where u.FirstName == "Арабская"
                            //orderby u.FirstName
                        select u;

            dataGridView1.DataSource = query;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            Connect connect = new Connect();
            DataContext db = new DataContext(connect.connection);

            var query = from u in db.GetTable<Поставщик>()
                            //where u.FirstName == "Арабская"
                            //orderby u.FirstName
                        select u;

            dataGridView1.DataSource = query;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            Connect connect = new Connect();
            DataContext db = new DataContext(connect.connection);

            var query = from u in db.GetTable<Поставка>()
                            //where u.FirstName == "Арабская"
                            //orderby u.FirstName
                        select u;

            dataGridView1.DataSource = query;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            Connect connect = new Connect();
            DataContext db = new DataContext(connect.connection);

            var query = from u in db.GetTable<Продажи>()
                            //where u.FirstName == "Арабская"
                            //orderby u.FirstName
                        select u;

            dataGridView1.DataSource = query;
        }
    }
}
