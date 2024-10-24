using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Salary_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = Fname1.Text;
            string lastName = Lname1.Text;
            string department = Department1.Text;
            string jobTitle = Jtitle1.Text;
            int hoursWorked = int.Parse(Rate1.Text);
            double ratePerHour = double.Parse(Tworked1.Text);

            PartTimeEmployee employee = new PartTimeEmployee(firstName, lastName, department, jobTitle);
            employee.ComputeSalary(hoursWorked, ratePerHour);

            Fname2.Text = firstName;
            Lname2.Text = lastName;
            Bsalary1.Text = employee.GetSalary().ToString("C2");

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
