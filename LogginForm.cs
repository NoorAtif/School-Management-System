using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class LogginForm : Form
    {
        public LogginForm()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void LogginForm_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            String admin,user, pass;
            admin = textBox11.Text;
            user = textBox6.Text;
            pass = textBox5.Text;

            if (admin == "123" && user == "admin" && pass == "admin123")
            {
                MessageBox.Show("Loggin Successful");
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid Credentials");

            

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
