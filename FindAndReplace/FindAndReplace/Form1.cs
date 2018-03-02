using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndReplace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FinnalText="";
            string Source = textBox3.Text;
            char ToFind = Convert.ToChar(textBox1.Text);
            string ToReplace = textBox2.Text;
            textBox3.Clear();
            for(int i=0; i < Source.Length; i++)
            {
                char testFor = Source[i];
                if (testFor == ToFind)
                {
                    FinnalText += ToReplace;
                }
                else
                {
                    FinnalText += testFor;
                }
            }
            textBox3.Text = FinnalText;
        }
    }
}
