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

namespace WindowsFormsApp19
{
    public partial class forma : Form
    {
        public forma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba\source\repos\WindowsFormsApp19\WindowsFormsApp19\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT نام , نام خانوادگی FROM دانشجو";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name1 = reader["خانوادگی نام ,نام"].ToString();
                comboBox1.Items.Add(name1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\\Users\toshiba\source\repos\WindowsFormsApp19\WindowsFormsApp19\Database1.mdf; Integrated Security = True");
            sc.Open();
            string query = "SELECT نام , نام حانوادگی FROM استاد";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name2 = reader["خانوادگی نام ,نام"].ToString();
                comboBox1.Items.Add(name2);
            }
            sc.Close();
        }
    }
}
