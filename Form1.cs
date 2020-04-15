using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationFormMobile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                MessageBox.Show("Enter your data");
                return;
            }
            if(textBox2.Text != textBox3.Text)
            {
                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
                MessageBox.Show("Passwords do not match");
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }
    }
}
