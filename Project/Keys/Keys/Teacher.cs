using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Keys
{
    public partial class Teacher : Form
    {
        //подключение класса
        Bd Bd = new Bd();
        int index=0;
        public Teacher()
        {
            InitializeComponent();
        }
        //Вывод данных в форме
        private void CreateColums()
        {
            TeacherTable.Columns.Add("Name_kabinet","Название кабинета");
            TeacherTable.Columns.Add("State_kabinet", "Состояние кабинета");
            TeacherTable.Columns.Add("Id_teacher", "Учитель");
        }
        //чтения строки
        private void ReadSingleRow(DataGridView TeacherTable, IDataRecord record) {
            string StateString;
            if (record.GetBoolean(1) == true)
            {
                StateString = "Свободно";
            }
            else 
            {
                StateString = "Занято";
            }
            string TeacherFIO = record.GetString(2)+record.GetString(3)+record.GetString(4) ;
            TeacherTable.Rows.Add(record.GetString(0), StateString,TeacherFIO);
            if (record.GetBoolean(1) == true)
            {
                
                TeacherTable.Rows[index].DefaultCellStyle.BackColor = Color.Green;
            }
            else if(record.GetBoolean(1) == false)
            {
                TeacherTable.Rows[index].DefaultCellStyle.BackColor = Color.Red;
            }
            index++;
        }
        //выводит данные в таблицу,
        private void RefDataGrid(DataGridView TeacherTable)
        {
            TeacherTable.Rows.Clear();
            string query = $"select Name_kabinet,State_kabinet,Last_name,First_name,Patronymic from Kabinet inner join Teacher on Kabinet.Id_teacher=Teacher.Id_teacher";
            SqlCommand command=new SqlCommand(query,Bd.GetConnection());
            Bd.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(TeacherTable,read);
            }
            read.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefDataGrid(TeacherTable);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TeacherTable.RowCount; i++)
            {
                TeacherTable.Rows[i].Selected = false;
                for (int j = 0; j < TeacherTable.ColumnCount; j++)
                    if (TeacherTable.Rows[i].Cells[j].Value != null)
                        if (TeacherTable.Rows[i].Cells[j].Value.ToString().Contains(SearchTextBox.Text))
                        {
                            TeacherTable.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void EntranceButton_Click(object sender, EventArgs e)
        {
            var Login=LoginTextBox.Text;
            var Password=PasswordTextBox.Text;
            if (Login == "admin" && Password == "admin")
            {
            Watchman watchman= new Watchman();
            Hide();
            watchman.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вы ввели непрвильный логин или пароль");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
