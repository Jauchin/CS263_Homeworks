using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example03
{
    public partial class Form1 : Form
    {
        private List<Employee> employees;

        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();
            employeeCatagory.SelectedIndex = 0;
            totalSalaryTextBox.Visible = false;
            toalSalaryLabel.Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Employee employee = null;
            if (employeeCatagory.SelectedIndex == 0)
            {
                employee = new Employee(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text);
                totalSalaryTextBox.Text = employee.TotalSalary.ToString();
            }
            else if (employeeCatagory.SelectedIndex == 1)
            {
                employee = new Sales(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text, performanceTextBox.Text);
                baseSalaryTextBox.Text = 22000.ToString();
                totalSalaryTextBox.Text = employee.TotalSalary.ToString();
            }
            else
            {
                employee = new Manager(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text, performanceTextBox.Text);
                totalSalaryTextBox.Text = employee.TotalSalary.ToString();
            }
            totalSalaryTextBox.Visible = true;
            toalSalaryLabel.Visible = true;
            employees.Add(employee);
            UpdateEmployeesInfo();
        }

        private void UpdateEmployeesInfo()
        {
            infoRichTextBox.Text = string.Empty;
            //idTextBox.Text = string.Empty;
            //nameTextBox.Text = string.Empty;
            //baseSalaryTextBox.Text = string.Empty;
            //totalSalaryTextBox.Text = string.Empty;

            foreach (Employee employee in employees)
            {
                infoRichTextBox.Text += string.Format("{0}\n", employee);
            }
        }

        private void employeeCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalSalaryTextBox.Visible = false;
            toalSalaryLabel.Visible = false;
            if (employeeCatagory.SelectedIndex == 0)
            {
                performanceLabel.Visible = false;
                performanceTextBox.Visible = false;
            }
            else
            {
                performanceLabel.Visible = true;
                performanceTextBox.Visible = true;
            }
        }

        private void infoRichTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            infoRichTextBox.Text = string.Empty;
            idTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            baseSalaryTextBox.Text = string.Empty;
            totalSalaryTextBox.Text = string.Empty;
            performanceLabel.Visible = false;
            performanceTextBox.Visible = false;
            totalSalaryTextBox.Visible = false;
            toalSalaryLabel.Visible = false;
            employeeCatagory.SelectedIndex = 0;
            totalSalaryTextBox.Visible = false;
            toalSalaryLabel.Visible = false;
        }
    }
}