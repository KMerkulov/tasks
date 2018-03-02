using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2

{
    public partial class Form1 : Form
    {

        string FinalResult;//creating global variable for our result
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //  textBox1.Text = textBox1.Text.Replace("a","uaa");

            FinalResult = "";//restarting our result variable
            string text = TextBox1.Text;//coping our text from text box to variable
            for (int i = 0; i < text.Length; i++)//starting loop for each letter in our text box
            {
                char x = text[i];//our X gets separate letter from text box
                char ToFindLetter = TextBox3.Text;
                //if our letter equals 'a' then we summing to RESULT uaa
                {
                    string ToReplaceWith = TextBox1.Text;
                }
            
                else//if our letter doesn't equals 'a' then we summing that letter without changing
                {
                    FinalResult += x;
                }
            }
            TextBox1.Text = FinalResult; //showing what we got
        }
    }
}
