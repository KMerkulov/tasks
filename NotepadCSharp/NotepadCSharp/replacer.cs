using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadCSharp
{
    /// <summary>
    /// Класс замены символов в тексте
    /// </summary>

    public partial class replacer : Form
    {
        private bool caseImp = false;
        private int startpos = 0;
        public Form prnt = null;
        /// <summary>
        /// Инициализация компонента
        /// </summary>

        public replacer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При загрузке компонента
        /// </summary>

        private void replacer_Load(object sender, EventArgs e)
        {
            toggleButtonsState();
        }
        /// <summary>
        /// Переключение активности кнопок поиск-замена в соо-вии с условиями
        /// </summary>

        private void toggleButtonsState()
        {
            if (lookFor.Text == "")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
               button3.Enabled = true;
            }
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lookFor_KeyUp(object sender, KeyEventArgs e)
        {
            toggleButtonsState();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            caseImp = !caseImp;
        }
        /// <summary>
        /// Метод посика текста по нажатию соо-ной кнопки
        /// </summary>

        private void button1_Click(object sender, EventArgs e)
        {
            //find next
            string Txt = lookFor.Text;
            blank frm = (blank)prnt.ActiveMdiChild;
            //Вызываем метод Save формы blank
            int fpos = frm.FindNext(Txt, startpos, caseImp);
            if (fpos < 0)
            {
                startpos = 0;
                MessageBox.Show("Нет такого текста", "Ошибка");
            }
            else
            {
                startpos = fpos;
                prnt.Focus();
            }

            if (frm.hasSelectedText())
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }

        }
        /// <summary>
        /// Замена найденго в очереди 
        /// </summary>

        private void button2_Click(object sender, EventArgs e)
        {
            //replace
            blank frm = (blank)prnt.ActiveMdiChild;
            string Txt = replaceWith.Text;
                frm.replaceSelected(Txt);
        }
        /// <summary>
        /// Замена всего найденого
        /// </summary>

        private void button3_Click(object sender, EventArgs e)
        {
            //replace all
              blank frm = (blank)prnt.ActiveMdiChild;
            string what = lookFor.Text;
            string with = replaceWith.Text;
            frm.replaceAll(what, with, caseImp);
        }
    }
}
