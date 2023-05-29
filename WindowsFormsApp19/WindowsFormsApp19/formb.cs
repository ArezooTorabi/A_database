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
    public partial class formb : Form
    {
        public formb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba\source\repos\WindowsFormsApp19\WindowsFormsApp19\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " INSERT INTO دانشجو  () VALUES ('" + name + "','" + lastname + "')";
            SqlCommand comand = new SqlCommand(query, sc);
            comand.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("با موفقیت ثبت شد.");
            textBox1.Text = textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            string lastname = textBox4.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba\source\repos\WindowsFormsApp19\WindowsFormsApp19\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " INSERT INTO دانشجو  () VALUES ('" + name + "','" + lastname + "')";
            SqlCommand comand = new SqlCommand(query, sc);
            comand.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("با موفقیت ثبت شد.");
            textBox3.Text = textBox4.Text = "";
        }
    }
}
