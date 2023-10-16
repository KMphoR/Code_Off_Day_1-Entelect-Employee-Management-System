using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEntelect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            if (user == "HR@admin" && pass == "123456")
            {
                Form1 f1 = new Form1();
                f1.Show();;
            }
            else if (user == "" && pass == "")
            {
                MessageBox.Show($"Please fill in the details");
            }
            else
            {
                MessageBox.Show($"Please enter correct log in details");
            }
        }
    }
}
