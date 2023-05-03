using Microsoft.Office.Interop.Excel;
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
using MOIE = Microsoft.Office.Interop.Excel;


namespace Keys
{
    public partial class Story_kabinet : Form
    {
        Bd Bd = new Bd();
        int index = 0;
        public Story_kabinet()
        {
            InitializeComponent();
        }
        private void CreateColums()
        {
            StoryTable.Columns.Add("Name_kabinet", "Название кабинета");
            StoryTable.Columns.Add("State_kabinet", "Состояние кабинета");
            StoryTable.Columns.Add("Id_teacher", "Учитель");
            StoryTable.Columns.Add("Time", "Время взятия/сдачи");
        }
        //чтения строки
        private void ReadSingleRow(DataGridView StoryTable, IDataRecord record)
        {
            string StateString;
            if (record.GetBoolean(1) == true)
            {
                StateString = "Освободили";
            }
            else
            {
                StateString = "Заняли";
            }
            string TeacherFIO = record.GetString(2) + record.GetString(3) + record.GetString(4);
            StoryTable.Rows.Add(record.GetString(0), StateString, TeacherFIO, record.GetDateTime(5));
            if (record.GetBoolean(1) == true)
            {

                StoryTable.Rows[index].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (record.GetBoolean(1) == false)
            {
                StoryTable.Rows[index].DefaultCellStyle.BackColor = Color.Red;
            }
            index++;

        }
        //выводит данные в таблицу,
        private void RefDataGrid(DataGridView StoryTable)
        {
            StoryTable.Rows.Clear();
            string query = $"select Name_kabinet,State_kabinet,Last_name,First_name,Patronymic,DataTime_kabinet from Story_kabinet inner join Teacher on Story_kabinet.Id_teacher=Teacher.Id_teacher";
            SqlCommand command = new SqlCommand(query, Bd.GetConnection());
            Bd.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(StoryTable, read);
            }
            read.Close();
        }
        private void Story_kabinet_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefDataGrid(StoryTable);
            StoryTable.Sort(StoryTable.Columns[3], ListSortDirection.Ascending);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            MOIE.Application exApp = new MOIE.Application();
            exApp.Workbooks.Add();
            MOIE.Worksheet wsh = (MOIE.Worksheet)exApp.ActiveSheet;
            wsh.Cells[1, 1] = "Название кабинета";
            wsh.Cells[1, 2] = "Состояние кабинета";
            wsh.Cells[1, 3] = "Учитель";
            wsh.Cells[1, 4] = "Время взятия/сдачи";
            int rowExcel = 2;
            int indexExel = 0;
            wsh.Columns.AutoFit();
            MOIE.Range range = wsh.Range["C1", System.Type.Missing];
            range.EntireColumn.ColumnWidth = 35;
            for (int i = 0; i < StoryTable.Rows.Count; i++)
            {
                wsh.Cells[rowExcel, "1"] = StoryTable.Rows[i].Cells["Name_kabinet"].Value;
                wsh.Cells[rowExcel, "2"] = StoryTable.Rows[i].Cells["State_kabinet"].Value;
                wsh.Cells[rowExcel, "3"] = StoryTable.Rows[i].Cells["Id_teacher"].Value;
                wsh.Cells[rowExcel, "4"] = StoryTable.Rows[i].Cells["Time"].Value;
                ++rowExcel;
                indexExel++;
            }
            MOIE.Range tRange = exApp.get_Range("A1", "D"+ indexExel.ToString());
            tRange.Borders.LineStyle = MOIE.XlLineStyle.xlContinuous;
            tRange.Borders.Weight = MOIE.XlBorderWeight.xlThin;
            wsh.SaveAs("MyFile.xls");
            exApp.Visible = true;
        }  
        
    }
}
