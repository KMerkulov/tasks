using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marks
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
        }

        private void ConvertMarks_Click(object sender, EventArgs e)
        {
            int points = 0, ball = 0;
            if (EnterText.Text != "")
            {
                string text = EnterText.Text;
                try
                {
                    points = Int32.Parse(text);
                    if (points >= 0 && points <= 39) { ball = 1; }
                    else if (points >= 40 && points <= 59) { ball = 2; }
                    else if (points >= 60 && points <= 73) { ball = 3; }
                    else if (points >= 74 && points <= 89) { ball = 4; }
                    else if (points >= 90 && points <= 100) { ball = 5; }
                    ResultText.Text = ball.ToString();
                }
                catch
                {
                    MessageBox.Show("Неверные данные. Попробуйте изменить введенные значения", "Ошибка");
                }
            }
            else { MessageBox.Show("Нет данных", "Ошибка"); }
        }
    }
}
