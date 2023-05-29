using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        forma fa = new forma();
        formb fb = new formb();
        formc fc = new formc();
        formd fd = new formd();
        private void button1_Click(object sender, EventArgs e)
        {
            fa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fd.Show();
        }
    }
}
