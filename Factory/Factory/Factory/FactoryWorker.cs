using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;

namespace Factory
{
    public partial class FactoryWorker : Form
    {
        Bd Bd = new Bd();
        public int index;
        string First_name;
        string Last_name;
        string Father_name;
        string Foto;
        int AgeF ;
        DateTime Now= DateTime.Now;
        DateTime DataB = new DateTime();
        public FactoryWorker()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColums()
        {
            WorkerTable.Columns.Add("ArrivalTime", "Время прихода");
            WorkerTable.Columns.Add("CareTime", "Время ухода");
            WorkerTable.Columns.Add("HoursPerShift", "Часов за смену");
        }
        private void ReadSingleRow(DataGridView WorkerTable, IDataRecord record)
        {
            var difference = (record.GetDateTime(1) - record.GetDateTime(0)).Duration();
            WorkerTable.Rows.Add(record.GetDateTime(0) , record.GetDateTime(1),difference.Hours);
        }
        //выводит данные в таблицу,
        private void RefDataGrid(DataGridView WorkerTable)
        {
            WorkerTable.Rows.Clear();
            string query = $"select ArrivalTime,CareTime from WatchHistory where Id_fw='{index}'";
            SqlCommand command = new SqlCommand(query, Bd.GetConnection());
            Bd.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(WorkerTable, read);
            }
            read.Close();
        }
        private void FactoryWorker_Load(object sender, EventArgs e)
        { 
            string query = $"select First_name,Last_name,Father_name,Foto_fw,Date_of_Birth from FactoryWorker where Id_fw='{index}'";
            SqlCommand command = new SqlCommand(query, Bd.GetConnection());
            Bd.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                First_name = read.GetString(0);
                Last_name = read.GetString(1);
                Father_name = read.GetString(2);
               // Foto=read.GetString(3);
                DataB = read.GetDateTime(4);
            }
            read.Close();
           // pictureBox1.Image = Image.FromFile(Foto);
            FIO.Text = Last_name + First_name +  Father_name;
            AgeF=Now.Year - DataB.Year;
            if (DataB > Now.AddYears(-AgeF)) AgeF--;
            Age.Text = AgeF + " года";
            CreateColums();
            RefDataGrid(WorkerTable);
        }

    }
}
