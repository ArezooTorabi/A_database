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
    public partial class formd : Form
    {
        public formd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba\source\repos\WindowsFormsApp19\WindowsFormsApp19\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "DELETE FROM دانشجو WHERE نام,نام خانوادگی ='" + name + "";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba\source\repos\WindowsFormsApp19\WindowsFormsApp19\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "DELETE FROM استاد WHERE نام,نام خانوادگی ='" + name + "";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
        }
    }
}
