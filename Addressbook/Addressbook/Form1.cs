using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addressbook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class ContactDB
        {
            
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ContactDB p1 = new ContactDB();
            ContactDB p2 = new ContactDB();
            
            p1.buttonAdd(textBox1.Text, textBox2.Text, textBox3.Text);
        }
    }









