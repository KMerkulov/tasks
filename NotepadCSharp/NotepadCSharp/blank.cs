using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadCSharp
{
    public partial class blank : Form
    {
        public bool IsSaved = false;
        private string BufferText = "";
        public string DocName = "";

        public blank()
        {
            InitializeComponent();
        }

        private void blank_Load(object sender, EventArgs e)
        {
           
        }
        // Вырезание текста
        public void Cut()
        {
            this.BufferText = rtbText.SelectedText;
            rtbText.SelectedText = "";
        }

        // Копирование текста
        public void Copy()
        {
            this.BufferText = rtbText.SelectedText;
        }
        public void SelectAll()
        {
            rtbText.SelectAll();
        }

        // Удаление
        public void Delete()
        {
            rtbText.SelectedText = "";
            this.BufferText = "";
        }

        // Вставка
        public void Paste()
        {
            rtbText.SelectedText = this.BufferText;
        }

        public void Save(string SaveFileName)
        {
            //Если файл не выбран, возвращаемся назад (появится встроенное предупреждение)
            if (SaveFileName == "")
            {
                return;
            }
            else
            {
                //Создаем новый объект StreamWriter и передаем ему переменную //OpenFileName
                StreamWriter sw = new StreamWriter(SaveFileName, false, Encoding.Default);
                //Содержимое richTextBox1 записываем в файл
                sw.WriteLine(rtbText.Text);
                //Закрываем поток
                sw.Close();
                //Устанавливаем в качестве имени документа название сохраненного файла
                DocName = SaveFileName;
            }
        }

        public void Open(string OpenFileName)
        {
            //Если файл не выбран, возвращаемся назад (появится встроенное предупреждение)
            if (OpenFileName == "")
            {
                return;
            }
            else
            {
                //Создаем новый объект StreamReader и передаем ему переменную //OpenFileName
                StreamReader sr = new StreamReader(OpenFileName, Encoding.Default, true);
                //Читаем весь файл и записываем его в richTextBox1
                rtbText.Text = sr.ReadToEnd();
                // Закрываем поток
                sr.Close();
                //Переменной DocName присваиваем адресную строку
                DocName = OpenFileName;
            }
        }

        private void blank_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Если переменная IsSaved имеет значение true, т. е.  новый документ 
            //был сохранен (Save As) или в открытом документе были сохранены изменения (Save), то //выполняется условие
            if (IsSaved == true)
                //Появляется диалоговое окно, предлагающее сохранить документ.
                if (MessageBox.Show("Сохранить изминения в файле " + this.DocName + "?",
                    "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                //Если была нажата  кнопка Yes, вызываем метод Save
                {
                    this.Save(this.DocName);
                }    
     

        }
        public void replaceAll(string word, string replacement, bool caseReg)
        {
            RichTextBox myRtb = rtbText;
            int i = 0;
            int n = 0;
            int a = replacement.Length - word.Length;
            Regex rgx;
            if (caseReg)
            {
                rgx = new Regex(word);
            }else{
                rgx = new Regex(word, RegexOptions.IgnoreCase);
            }

            foreach (Match m in rgx.Matches(myRtb.Text))
            {
                myRtb.Select(m.Index + i, word.Length);
                i += a;
                myRtb.SelectedText = replacement;
                n++;
            }
            MessageBox.Show("Replaced " + n + " matches!");
        }
        public bool hasSelectedText()
        {
            return (rtbText.SelectedText == "") ? false : true;
        }

        public void replaceSelected(string text)
        {

            if (rtbText.SelectedText == "") return;
            rtbText.SelectedText = text;
        }
        public int FindNext(string text, int start, bool caseReg)
        {
   // Initialize the return value to false by default.
   int returnValue = -1;
   int indexToText;
   // Ensure that a search string has been specified and a valid start point.
   if (text.Length > 0 && start >= 0)
   {
       // Obtain the location of the search string in richTextBox1.
       if (caseReg)
       {
            indexToText = rtbText.Find(text, start, RichTextBoxFinds.MatchCase);
       }
       else
       {
           indexToText = rtbText.Find(text, start, RichTextBoxFinds.None);
       }
       // Determine whether the text was found in richTextBox1.
       if (indexToText >= 0)
       {
           returnValue = indexToText + rtbText.SelectedText.Length;

       }
   }
   return returnValue;
  }
        
        private void cmnuCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void cmnuCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void cmnuPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void cmnuSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void cmnuDelete_Click(object sender, EventArgs e)
        {
            Delete();
    }

    }
}
