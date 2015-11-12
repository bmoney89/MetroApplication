using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace metrosweeping
{

  

    public partial class Form2 : Form
    {
       
        string user;
        string password;
        bool success = false;




        public Form2()
        {

            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox3.Text;
            string password = textBox1.Text;

            if (user == "user" && password == "pass")
                {
                    success = true;
                    MessageBox.Show("Login Successful");
                    this.Close();

                }

                if (user != "user" || password != "pass")
                {
                    MessageBox.Show("Please enter a valid username and password");
                }

            

           
        }

    }

}
