using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class Watchman : Form
    {
        Bd Bd = new Bd();
        int index = 0;
        DateTime Now = DateTime.Now;
        public Watchman()
        {
            InitializeComponent();
        }
        private void CreateColums()
        {
            WatchmanTable.Columns.Add("Last_name", "Фамилия");
            WatchmanTable.Columns.Add("First_name", "Имя");
            WatchmanTable.Columns.Add("Father_name", "Отчество");
            WatchmanTable.Columns.Add("ArrivalTime", "Время прихода");
            WatchmanTable.Columns.Add("CareTime", "Время ухода");
        }
        private void ReadSingleRow(DataGridView WatchmanTable, IDataRecord record)
        {
            
            WatchmanTable.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetDateTime(3), record.GetDateTime(4));
            if (record.GetDateTime(3) > record.GetDateTime(4))
            {
                WatchmanTable.Rows[index].DefaultCellStyle.BackColor = Color.Green;
            }
            else
            {
                WatchmanTable.Rows[index].DefaultCellStyle.BackColor = Color.Red;
            }
            index++;
        }
        //выводит данные в таблицу,
        private void RefDataGrid(DataGridView WatchmanTable)
        {
            WatchmanTable.Rows.Clear();
            string query = $"select Last_name,First_name,Father_name,ArrivalTime,CareTime from FactoryWorker inner join OpeningHours on FactoryWorker.Id_fw=OpeningHours.Id_fw";
            SqlCommand command = new SqlCommand(query, Bd.GetConnection());
            Bd.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(WatchmanTable, read);
            }
            read.Close();
        }
        private void Watchman_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefDataGrid(WatchmanTable);
        }

        private void Came_Click(object sender, EventArgs e)
        {
            int indexRow = WatchmanTable.CurrentCell.RowIndex;
            if(WatchmanTable.Rows[index-1].DefaultCellStyle.BackColor == Color.Green)
            {
                MessageBox.Show("Рабочий уже пришел");
            }
            else
            {
                Bd.openConnection();
                WatchmanTable.Rows[indexRow].Cells[3].Value = Now;
                string query = $"update OpeningHours set ArrivalTime='{Now}' where Id_fw='{indexRow}'";
                SqlCommand command = new SqlCommand(query, Bd.GetConnection());
                command.ExecuteNonQuery();
                WatchmanTable.Rows[index - 1].DefaultCellStyle.BackColor = Color.Green;
            }
        }

        private void Gone_Click(object sender, EventArgs e)
        {
            int indexRow = WatchmanTable.CurrentCell.RowIndex;
            if (WatchmanTable.Rows[index - 1].DefaultCellStyle.BackColor == Color.Red)
            {
                MessageBox.Show("Рабочий еще не пришел");
            }
            else
            {
                Bd.openConnection();
                WatchmanTable.Rows[indexRow].Cells[4].Value = Now;
                string query = $"update OpeningHours set CareTime='{Now}' where Id_fw='{indexRow + 1}'";
                SqlCommand command = new SqlCommand(query, Bd.GetConnection());
                command.ExecuteNonQuery();
                string queryStory = $"insert into  WatchHistory  select * from OpeningHours where Id_fw='{indexRow + 1}' ;";
                SqlCommand commandStory = new SqlCommand(queryStory, Bd.GetConnection());
                commandStory.ExecuteNonQuery();
                WatchmanTable.Rows[index - 1].DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
