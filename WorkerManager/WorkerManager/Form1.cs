using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkerManager
{
    public partial class Form1 : Form
    {
        enum myEnum { Director, Manager, Researcher, Representative, Engineer, Assistant };
        public struct Workers
        {
            // define struct data
            public string EmployeeName;
            public int EmployeeSalary;
            public string EmployeePosition;
        }
        Workers persone = new Workers();
        Workers[,] Managment=new Workers[3,10];
        int count=0;
        int total = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(myEnum)); 
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            persone.EmployeeName = textBoxName.Text;
            persone.EmployeeSalary = Convert.ToInt32(textBoxSalary.Text);
            persone.EmployeePosition = Convert.ToString(comboBox1.SelectedValue);
            if (count <= 9)
            {
                Managment[0,count].EmployeeName = persone.EmployeeName;
                Managment[1,count].EmployeePosition = persone.EmployeePosition;
                Managment[2,count].EmployeeSalary= persone.EmployeeSalary;
                count++;
                total +=persone.EmployeeSalary;
                textBoxStats.Text ="Total salary is "+total+"\r\nActive members are:"+count;
            }
            if(count==10)
            {
                buttonSave.Enabled = false;
            }
        }
    }
}
