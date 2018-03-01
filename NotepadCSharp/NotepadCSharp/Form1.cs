using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace NotepadCSharp
{
    public partial class frmmain : Form
    {

        string stringPrintText;
        //Переменная, определяющая номер страницы, с которой нужно начать печать
        int StartPage;
        //Переменная, определяющая количество страниц для печати:
        int NumPages;
        //Переменная, определяющая номер текущей страницы:
        int PageNumber;


        public Colon colonFrm = new Colon();



        private int openDocuments = 0;
        public frmmain()
        {
            InitializeComponent();


            //Определяем номер страницы, с которой следует начать печать
            printDialog1.PrinterSettings.FromPage = 1;
            //Определяем максимальный номер печатаемой страницы.
            printDialog1.PrinterSettings.ToPage = printDialog1.PrinterSettings.MaximumPage;



            mnuSave.Enabled = false;
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.DocName = "Документ " + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuArrangeIcons_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
                //Если выбран диалог открытия файла, выполняем условие
    if (openFileDialog1.ShowDialog() == DialogResult.OK) 
    {
      //Создаем новый документ
      blank frm = new blank();
      //Вызываем метод Open формы blank
      frm.Open(openFileDialog1.FileName);
      //Указываем, что родительской формой является форма frmmain
      frm.MdiParent = this;
      //Присваиваем переменной DocName имя открываемого файла
      frm.DocName = openFileDialog1.FileName;
      //Свойству Text формы присваиваем переменную DocName
      frm.Text = frm.DocName;
      //Вызываем форму frm
      frm.Show();
      mnuSave.Enabled = true;
    }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            //Переключаем фокус на данную форму.
            blank frm = (blank)this.ActiveMdiChild;
            //Вызываем метод Save формы blank
            frm.Save(frm.DocName);
            frm.IsSaved = true;


        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
 
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
                //Если выбран диалог открытия файла, выполняем условие

    //Если выбран диалог открытия файла, выполняем условие
    if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
    {
      //Переключаем фокус на данную форму.
      blank frm = (blank)this.ActiveMdiChild;
      //Вызываем метод Save формы blank
      frm.Save(saveFileDialog1.FileName);
      //Указываем, что родительской формой является форма frmmain
      frm.MdiParent = this;
      //Присваиваем переменной FileName имя сохраняемого файла
      frm.DocName = saveFileDialog1.FileName;
      //Свойству Text формы присваиваем переменную DocName
      frm.Text = frm.DocName;
      mnuSave.Enabled = true;
      frm.IsSaved = true;
    }



        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            //Переключаем фокус на данную форму.
            blank frm = (blank)this.ActiveMdiChild;
            //Указываем, что родительской формой является форма frmmain  
            frm.MdiParent = this;
            //Вызываем диалог
            fontDialog1.ShowColor = true;
            //Связываем свойства SelectionFont и SelectionColor элемента RichTextBox 
            //с соответствующими свойствами диалога
            fontDialog1.Font = frm.rtbText.SelectionFont;
            fontDialog1.Color = frm.rtbText.SelectionColor;
            //Если выбран диалог открытия файла, выполняем условие
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.rtbText.SelectionFont = fontDialog1.Font;
                frm.rtbText.SelectionColor = fontDialog1.Color;
            }
            //Показываем форму
            frm.Show();

        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.rtbText.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.rtbText.SelectionColor = colorDialog1.Color;
            }

            frm.Show();

        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();

        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Copy();

        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Paste();

        }

    

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.SelectAll();

        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }

        private void tbNew_Click(object sender, EventArgs e)
        {
            mnuNew.PerformClick();
        }

        private void tbOpen_Click(object sender, EventArgs e)
        {
            mnuOpen.PerformClick();
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            mnuSave.PerformClick();
        }

        private void tbCut_Click(object sender, EventArgs e)
        {
            mnuCut.PerformClick();
        }

        private void tbCopy_Click(object sender, EventArgs e)
        {
            mnuCopy.PerformClick();
        }

        private void tbPaste_Click(object sender, EventArgs e)
        {
            mnuPaste.PerformClick();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();


        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            replacer rep = new replacer();
            rep.prnt = this;
            rep.Show();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }




        
    public int SymbolsInLines(string stringPrintText, int NumLines)
  {
    int index = 0;
    for (int i = 0; i< NumLines; i++)
    {
      index = 1+ stringPrintText.IndexOf('\n', index);
      if(index==0)
        return stringPrintText.Length;
    }
    return index;
  }



        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            Graphics graph = e.Graphics;
            //Создаем объект font, которому устанавливаем 
            // шрифт элемента rtbText
            Font font = frm.rtbText.Font;
            //Получаем значение межстрочного интервала — высоту шрифта 
            float HeightFont = font.GetHeight(graph);
            //Создаем экземпляр strfmt класса StringFormat для определения 
            //дополнительных параметров форматирования текста.
            StringFormat stringformat = new StringFormat();
            //Создаем экземляры  rectanglefFull и rectfText класса RectangleF для 
            //определения областей печати и текста. 
            RectangleF rectanglefFull, rectfText;
            //Создаем переменные для подсчета числа символов и строк.
            int NumberSymbols, NumberLines;



            if (graph.VisibleClipBounds.X<0) rectanglefFull = e.MarginBounds;
else
//Определяем   объект  rectanglefFull
rectanglefFull = new RectangleF(
e.MarginBounds.Left - (e.PageBounds.Width - graph.VisibleClipBounds.Width)/2,
e.MarginBounds.Top - (e.PageBounds.Height - graph.VisibleClipBounds.Height)/2,
e.MarginBounds.Width,
e.MarginBounds.Height);



            rectfText = new RectangleF();

            rectfText = RectangleF.Inflate(rectanglefFull, 0, -2 * HeightFont);
//Определяем число строк
            int NumDisplayLines = (int)Math.Floor(rectfText.Height / HeightFont);
//Устанавливаем высоту области
rectfText.Height = NumDisplayLines * HeightFont;





if (frm.rtbText.WordWrap)
{
    stringformat.Trimming = StringTrimming.Word;
}
else
{
    stringformat.Trimming = StringTrimming.EllipsisCharacter;
    stringformat.FormatFlags |= StringFormatFlags.NoWrap;
}








            var rectanglefText = rectfText;

            //При печати выбранных страниц переходим к первой стартовой странице
while ((PageNumber<StartPage)&&(stringPrintText.Length>0))
    {
if(frm.rtbText.WordWrap)
//Измеряем текстовые переменные, 
//формирующие печать,  и возвращаем число символов NumberSymbols
//и число строк NumberLines
graph.MeasureString(stringPrintText, font, rectanglefText.Size, stringformat, out NumberSymbols, out NumberLines);
else
    NumberSymbols = SymbolsInLines(stringPrintText, NumDisplayLines);
    stringPrintText = stringPrintText.Substring(NumberSymbols);
    //Увеличиваем число страниц 
    PageNumber++;
  }
//Если длина строки stringPrintText равняется нулю (нет текста для печати),
// останавливаем печать
    if (stringPrintText.Length==0)
      {
        e.Cancel = true;
        return;
      }
//Выводим (рисуем) текст для печати — stringPrintText, используем для этого шрифт font,
//кисть черного цвета  — Brushes.Black, область печати — rectanglefText,
//передаем строку  дополнительного форматирования stringformat
graph.DrawString(stringPrintText, font, Brushes.Black, rectanglefText, stringformat);
//Получаем текст для следующей страницы
  if (frm.rtbText.WordWrap)
  graph.MeasureString(stringPrintText, font, rectanglefText.Size, stringformat, out NumberSymbols, out NumberLines);
  else
  NumberSymbols = SymbolsInLines(stringPrintText, NumDisplayLines);
  stringPrintText = stringPrintText.Substring(NumberSymbols);
//Очищаем объект stringformat, использованный для формирования полей.
    stringformat = new StringFormat();
//Добавляем  вывод на каждую страницу ее номера 
            /*
    stringformat.Alignment = StringAlignment.Far;
    graph.DrawString("Страница" + PageNumber, font, Brushes.Black, rectanglefFull, stringformat);
    PageNumber++;
             * */
//Cнова проверяем, имеется ли текст для печати и номер страницы, заданной для печати
    e.HasMorePages=(stringPrintText.Length>0)&&(PageNumber<StartPage+NumPages);
//Для печати из окна предварительного просмотра  снова инициализируем переменные
    if(!e.HasMorePages)
    {
      stringPrintText = frm.rtbText.Text;
      StartPage = 1;
      NumPages = printDialog1.PrinterSettings.MaximumPage;
      PageNumber = 1;
      }

      






            //COLONTITULES
    var leftMargin = e.MarginBounds.Left -20;
    var printFont = frm.rtbText.Font;
    var printBrush = new SolidBrush(Color.Black);
    // Печать колонтитулов страницы

    // Номер текущей страницы
    string sPageNumber = colonFrm.textBox1.Text.ToString(); //"Страница " + PageNumber.ToString();

    // Вычисляем размеры прямоугольной области, занимаемой верхним 
    // колонтитулом страницы
    SizeF stringSize = new SizeF();
    stringSize = e.Graphics.MeasureString(sPageNumber, printFont,
       e.MarginBounds.Right - e.MarginBounds.Left);


    printFont = colonFrm.textBox1.Font;
    printBrush.Color = colonFrm.textBox1.ForeColor;

             

    e.Graphics.DrawString(sPageNumber, printFont, printBrush,
       e.MarginBounds.Right - stringSize.Width, e.MarginBounds.Top,
       new StringFormat());




    // Кисть для рисования горизонтальной линии, 
    // отделяющей верхний колонтитул
    Pen colontitulPen = new Pen(Color.Black);
    colontitulPen.Width = 2;

    // Рисуем верхнюю линию
    e.Graphics.DrawLine(colontitulPen,
       leftMargin,
       e.MarginBounds.Top + printFont.GetHeight(e.Graphics) + 3,
       e.MarginBounds.Right, e.MarginBounds.Top +
       printFont.GetHeight(e.Graphics) + 3);

    // Рисуем линию, отделяющую нижний колонтитул документа
    e.Graphics.DrawLine(colontitulPen,
       leftMargin, e.MarginBounds.Bottom - 3,
       e.MarginBounds.Right, e.MarginBounds.Bottom - 3);

    // Печатаем текст нижнего колонтитула


            /*
            IEnumerable<string> words = frm.rtbText.Text.Split().Take(10);
            List<string> customString = words.ToList();
            var txt = String.Join(" ", customString);
            */


    string txt = colonFrm.textBox2.Text.ToString();

    e.Graphics.DrawString(
    txt,
       printFont, printBrush,
       e.MarginBounds.Left, e.MarginBounds.Bottom, new StringFormat());











    }

        private void mnuPageSetup_Click(object sender, EventArgs e)
        {
            //Показываем диалог
            pageSetupDialog1.ShowDialog();

        }

        private void mnuPrintPreview_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            //Инициализируем переменные
            printDocument1.DocumentName = Text;
            stringPrintText = frm.rtbText.Text;
            StartPage = 1;
            NumPages = printDialog1.PrinterSettings.MaximumPage;
            PageNumber = 1;
            //Показываем диалог
            printPreviewDialog1.ShowDialog();

        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            printDialog1.AllowSelection =frm.rtbText.SelectionLength > 0;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DocumentName = Text;
                //Определяем диапазон страниц для печати
                switch (printDialog1.PrinterSettings.PrintRange)
                {
                    //Выбраны все страницы
                    case PrintRange.AllPages:
                        stringPrintText = frm.rtbText.Text;
                        StartPage = 1;
                        NumPages = printDialog1.PrinterSettings.MaximumPage;
                        break;
                    //Выбрана выделенная область
                    case PrintRange.Selection:
                        stringPrintText = frm.rtbText.SelectedText;
                        StartPage = 1;
                        NumPages = printDialog1.PrinterSettings.MaximumPage;
                        break;
                    //Выбран ряд страниц
                    case PrintRange.SomePages:
                        stringPrintText = frm.rtbText.Text;
                        StartPage = printDialog1.PrinterSettings.FromPage;
                        NumPages = printDialog1.PrinterSettings.ToPage - StartPage + 1;
                        break;
                }
                PageNumber = 1;
                //Вызываем встроенный метод для начала печати
                printDocument1.Print();
            }
    

        }

        private void menuItem3_Click(object sender, EventArgs e)
        {

            colonFrm.ShowDialog();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            //show help chm
            Help.ShowHelp(this, "HelpEdit.chm");
        }

        private void frmmain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, "HelpEdit.chm");
            }
        }








        }






    
    }
