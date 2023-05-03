using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keys
{
    public partial class Watchman : Form
    {
        //подключение класса
        DateTime dateNow = DateTime.Now;
        Bd Bd = new Bd();
        int index = 0;
        public int indexRow;
        public Watchman()
        {
            InitializeComponent();
        }
        //Вывод данных в форме
        private void CreateColums()
        {
            WatchmanTable.Columns.Add("Name_kabinet", "Название кабинета");
            WatchmanTable.Columns.Add("State_kabinet", "Состояние кабинета");
            WatchmanTable.Columns.Add("Id_teacher", "Учитель");
            WatchmanTable.Columns.Add("Time", "Время взятия/сдачи");
        }
        //чтения строки
        private void ReadSingleRow(DataGridView WatchmanTable, IDataRecord record)
        {
            string StateString;
            if (record.GetBoolean(1) == true)
            {
                StateString = "Свободно";
            }
            else
            {
                StateString = "Занято";
            }
            string TeacherFIO = record.GetString(2) + record.GetString(3) + record.GetString(4);
            WatchmanTable.Rows.Add(record.GetString(0), StateString, TeacherFIO,record.GetDateTime(5));
            if (record.GetBoolean(1) == true)
            {

                WatchmanTable.Rows[index].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (record.GetBoolean(1) == false)
            {
                WatchmanTable.Rows[index].DefaultCellStyle.BackColor = Color.Red;
            }
            index++;

        }
        //выводит данные в таблицу,
        private void RefDataGrid(DataGridView WatchmanTable)
        {
            WatchmanTable.Rows.Clear();
            string query = $"select Name_kabinet,State_kabinet,Last_name,First_name,Patronymic,DataTime_kabinet from Kabinet inner join Teacher on Kabinet.Id_teacher=Teacher.Id_teacher";
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
        public void CurrentCell(int indexRow)
        {
            this.indexRow = WatchmanTable.CurrentCell.RowIndex;
        }
        public void ReleaseButton_Click(object sender, EventArgs e)
        {
            CurrentCell(indexRow);
            if ((String) WatchmanTable.Rows[indexRow].Cells[1].Value == "Свободно")
            {
                MessageBox.Show("Этот кабинет уже свободен");
            }
            else
            {
                ReleaseKabinet releaseKabinet = new ReleaseKabinet();
                releaseKabinet.index = this.indexRow;
                this.Hide();
                releaseKabinet.ShowDialog();
            }
            
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < WatchmanTable.RowCount; i++)
            {
                WatchmanTable.Rows[i].Selected = false;
                for (int j = 0; j < WatchmanTable.ColumnCount; j++)
                    if (WatchmanTable.Rows[i].Cells[j].Value != null)
                        if (WatchmanTable.Rows[i].Cells[j].Value.ToString().Contains(SearchTextBox.Text))
                        {
                            WatchmanTable.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void TakeButton_Click(object sender, EventArgs e)
        {
            CurrentCell(indexRow);
            if ((String)WatchmanTable.Rows[indexRow].Cells[1].Value == "Занято")
            {
                MessageBox.Show("Этот кабинет уже занят");
            }
            else
            {
                TakeKabinet takeKabinet = new TakeKabinet();
                takeKabinet.index = this.indexRow;
                this.Hide();
                takeKabinet.ShowDialog();
            }
        }

        private void Story_Click(object sender, EventArgs e)
        {
            Story_kabinet Story_kabinet = new Story_kabinet();
            this.Hide();
            Story_kabinet.ShowDialog();
            Show();
        }
    }
}

