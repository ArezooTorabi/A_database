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
using System.Xml.Linq;

namespace WindowsFormsApp19
{
    public partial class formc : Form
    {
        public formc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            string phone = textBox2.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba\source\repos\WindowsFormsApp19\WindowsFormsApp19\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "UPDATE  دانشجو SET شماره موبایل ='"+phone +"'WHERE نام ,نام خانوادگی =گ"+name+"' ";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("تغییر با موفقیت انجام شد.");
            textBox2.Text = textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba\source\repos\WindowsFormsApp19\WindowsFormsApp19\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT شماره موبایل FROM دانشجو WHERE کد دانشجویی ='" + code + "'";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader read = command.ExecuteReader();
            string phone = read["شماره موبایل "].ToString();
            label3.Text = phone;
            sc.Close();

        }
    }
}
