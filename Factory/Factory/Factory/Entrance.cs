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

namespace Factory
{
    public partial class Entrance : Form
    {
        public int indexRow;
        Bd Bd = new Bd();
        public Entrance()
        {
            InitializeComponent();
            StartPosition=FormStartPosition.CenterScreen;
        }
        private void Entrance_Load(object sender, EventArgs e)
        {

        }
        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void EntranceButton_Click(object sender, EventArgs e)
        {
            var loginUser=LoginTextBox.Text;
            this.indexRow =Int32.Parse(loginUser);
            var passUser=PasswordTextBox.Text;
            if(loginUser=="1" && passUser == "admin")
            {
                MessageBox.Show("Успешных вход");
                Watchman watchman = new Watchman();
                Hide();
                watchman.ShowDialog();
                Show();
            }
            else { 
            SqlDataAdapter adapter= new SqlDataAdapter();
            DataTable table= new DataTable();
            string querestring = $"select Id_fw,Password_fw from FactoryWorker where Id_fw='{loginUser}' and Password_fw='{passUser}'";
            SqlCommand command = new SqlCommand(querestring, Bd.GetConnection());
            adapter.SelectCommand= command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Успешных вход");
                FactoryWorker factoryWorker=new FactoryWorker();
                factoryWorker.index = this.indexRow;
                Hide();
                factoryWorker.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
            }
        }
    }
}
