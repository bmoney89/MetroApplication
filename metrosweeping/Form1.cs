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
    

    public partial class Form1 : Form
    {
    string Route;
    string JobLocation;
    string Worker; 
    
    
    
        public Form1()
        {
            InitializeComponent();
            
      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (MessageBox.Show("You entered " + RouteBox.Text + " for your route name. Is this correct?" + "", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Route = RouteBox.Text;
            }

            else MessageBox.Show("Please Enter a new Route");
            


          
            
 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("You entered " + textBox2.Text + " for your location. Is this correct?" + "", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                JobLocation = textBox2.Text;
            }

            else MessageBox.Show("Please Enter a new location");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You entered " + textBox3.Text + " as your worker name. Is this correct?" + "", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Worker = textBox3.Text;
            }

            else MessageBox.Show("Please Enter a new worker");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
