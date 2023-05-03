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
    public partial class TakeKabinet : Form
    {
        DateTime dateNow = DateTime.Now;
        Bd Bd = new Bd();
        public int index;
        int indexTeacher;
        public TakeKabinet()
        {
            InitializeComponent();
        }
        private void CreateColums()
        {
            TeacherTable.Columns.Add("FIOTeacher", "ФИО преподавателя");
        }
        private void ReadSingleRow(DataGridView TeacherTable, IDataRecord record)
        {
            string TeacherFIO = record.GetString(1) + record.GetString(2) + record.GetString(3);
            TeacherTable.Rows.Add(TeacherFIO);
        }
        private void RefDataGrid(DataGridView TeacherTable)
        {
            TeacherTable.Rows.Clear();
            string query = $"select* from Teacher where (Id_teacher>1)";
            SqlCommand command = new SqlCommand(query, Bd.GetConnection());
            Bd.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(TeacherTable, read);
            }
            read.Close();
        }
        private void TakeKabinet_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefDataGrid(TeacherTable);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.indexTeacher = TeacherTable.CurrentCell.RowIndex+2;
            int indexTake = index + 1;
            Bd.openConnection();
            string query = $"update Kabinet set State_kabinet='0',Id_teacher='{indexTeacher}',DataTime_kabinet='{dateNow}' where Id_kabinet='{indexTake}'";
            SqlCommand command = new SqlCommand(query, Bd.GetConnection());
            command.ExecuteNonQuery();
            string queryStory = $"insert into  Story_kabinet    select * from Kabinet where Id_kabinet='{indexTake}' ;";
            SqlCommand commandStory = new SqlCommand(queryStory, Bd.GetConnection());
            commandStory.ExecuteNonQuery();
            MessageBox.Show("Кабинет занят");
            Watchman watchman = new Watchman();
            Hide();
            watchman.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Watchman watchman = new Watchman();
            Hide();
            watchman.Show();
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
    }
}
