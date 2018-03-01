namespace NotepadCSharp
{
    partial class frmmain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuNew = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.mnuSave = new System.Windows.Forms.MenuItem();
            this.mnuSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuPageSetup = new System.Windows.Forms.MenuItem();
            this.mnuPrintPreview = new System.Windows.Forms.MenuItem();
            this.mnuPrint = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuEdit = new System.Windows.Forms.MenuItem();
            this.mnuCut = new System.Windows.Forms.MenuItem();
            this.mnuCopy = new System.Windows.Forms.MenuItem();
            this.mnuPaste = new System.Windows.Forms.MenuItem();
            this.mnuDelete = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.mnuSelectAll = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuFormat = new System.Windows.Forms.MenuItem();
            this.mnuParagraph = new System.Windows.Forms.MenuItem();
            this.mnuFont = new System.Windows.Forms.MenuItem();
            this.mnuColor = new System.Windows.Forms.MenuItem();
            this.mnuWindow = new System.Windows.Forms.MenuItem();
            this.mnuArrangeIcons = new System.Windows.Forms.MenuItem();
            this.mnuCascade = new System.Windows.Forms.MenuItem();
            this.mnuTileHorizontal = new System.Windows.Forms.MenuItem();
            this.mnuTileVertical = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbNew = new System.Windows.Forms.ToolStripButton();
            this.tbOpen = new System.Windows.Forms.ToolStripButton();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.tbCut = new System.Windows.Forms.ToolStripButton();
            this.tbCopy = new System.Windows.Forms.ToolStripButton();
            this.tbPaste = new System.Windows.Forms.ToolStripButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuFormat,
            this.mnuWindow,
            this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs,
            this.menuItem4,
            this.menuItem3,
            this.mnuPageSetup,
            this.mnuPrintPreview,
            this.mnuPrint,
            this.menuItem9,
            this.mnuExit});
            this.mnuFile.Text = "&Файл";
            // 
            // mnuNew
            // 
            this.mnuNew.Index = 0;
            this.mnuNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.mnuNew.Text = "Созд&ать";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Index = 1;
            this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mnuOpen.Text = "&Открыть";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Index = 2;
            this.mnuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuSave.Text = "&Сохранить";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Index = 3;
            this.mnuSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.mnuSaveAs.Text = "Сохранить &как";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.Text = "-";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 5;
            this.menuItem3.Text = "Настройка колонтитулов";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // mnuPageSetup
            // 
            this.mnuPageSetup.Index = 6;
            this.mnuPageSetup.Text = "Пара&метры страницы";
            this.mnuPageSetup.Click += new System.EventHandler(this.mnuPageSetup_Click);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Index = 7;
            this.mnuPrintPreview.Text = "Пред&варительный просмотр";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Index = 8;
            this.mnuPrint.Text = "&Печать";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 9;
            this.menuItem9.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 10;
            this.mnuExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.mnuExit.Text = "В&ыход";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Index = 1;
            this.mnuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuDelete,
            this.menuItem14,
            this.mnuSelectAll,
            this.menuItem1,
            this.menuItem2});
            this.mnuEdit.Text = "&Правка";
            // 
            // mnuCut
            // 
            this.mnuCut.Index = 0;
            this.mnuCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.mnuCut.Text = "&Вырезать";
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Index = 1;
            this.mnuCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.mnuCopy.Text = "&Копировать";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Index = 2;
            this.mnuPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.mnuPaste.Text = "Вст&авить";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Index = 3;
            this.mnuDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.mnuDelete.Text = "&Удалить";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 4;
            this.menuItem14.Text = "-";
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Index = 5;
            this.mnuSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.mnuSelectAll.Text = "Выделить в&се";
            this.mnuSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 6;
            this.menuItem1.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 7;
            this.menuItem2.Text = "&Заменить...";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.Index = 2;
            this.mnuFormat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuParagraph,
            this.mnuFont,
            this.mnuColor});
            this.mnuFormat.Text = "Фор&мат";
            // 
            // mnuParagraph
            // 
            this.mnuParagraph.Index = 0;
            this.mnuParagraph.Text = "&Абзац...";
            // 
            // mnuFont
            // 
            this.mnuFont.Index = 1;
            this.mnuFont.Text = "&Шрифт...";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // mnuColor
            // 
            this.mnuColor.Index = 2;
            this.mnuColor.Text = "&Цвет...";
            this.mnuColor.Click += new System.EventHandler(this.mnuColor_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.Index = 3;
            this.mnuWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuArrangeIcons,
            this.mnuCascade,
            this.mnuTileHorizontal,
            this.mnuTileVertical});
            this.mnuWindow.Text = "&Окно";
            // 
            // mnuArrangeIcons
            // 
            this.mnuArrangeIcons.Index = 0;
            this.mnuArrangeIcons.MdiList = true;
            this.mnuArrangeIcons.Text = "&Упорядочить все";
            this.mnuArrangeIcons.Click += new System.EventHandler(this.mnuArrangeIcons_Click);
            // 
            // mnuCascade
            // 
            this.mnuCascade.Index = 1;
            this.mnuCascade.Text = "&Каскад";
            this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);
            // 
            // mnuTileHorizontal
            // 
            this.mnuTileHorizontal.Index = 2;
            this.mnuTileHorizontal.Text = "&Горизонтально";
            this.mnuTileHorizontal.Click += new System.EventHandler(this.mnuTileHorizontal_Click);
            // 
            // mnuTileVertical
            // 
            this.mnuTileVertical.Index = 3;
            this.mnuTileVertical.Text = "&Вертикально";
            this.mnuTileVertical.Click += new System.EventHandler(this.mnuTileVertical_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 4;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAbout,
            this.menuItem6});
            this.mnuHelp.Text = "&?";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 0;
            this.mnuAbout.Text = "&О программе";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.* ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNew,
            this.tbOpen,
            this.tbSave,
            this.tbCut,
            this.tbCopy,
            this.tbPaste});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(481, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolBarMain";
            // 
            // tbNew
            // 
            this.tbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNew.Image = ((System.Drawing.Image)(resources.GetObject("tbNew.Image")));
            this.tbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(23, 22);
            this.tbNew.Text = "toolStripButton1";
            this.tbNew.ToolTipText = "Создать";
            this.tbNew.Click += new System.EventHandler(this.tbNew_Click);
            // 
            // tbOpen
            // 
            this.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbOpen.Image")));
            this.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(23, 22);
            this.tbOpen.Text = "toolStripButton1";
            this.tbOpen.ToolTipText = "Открыть";
            this.tbOpen.Click += new System.EventHandler(this.tbOpen_Click);
            // 
            // tbSave
            // 
            this.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSave.Image = ((System.Drawing.Image)(resources.GetObject("tbSave.Image")));
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(23, 22);
            this.tbSave.Text = "toolStripButton1";
            this.tbSave.ToolTipText = "Сохранить";
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // tbCut
            // 
            this.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCut.Image = ((System.Drawing.Image)(resources.GetObject("tbCut.Image")));
            this.tbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCut.Name = "tbCut";
            this.tbCut.Size = new System.Drawing.Size(23, 22);
            this.tbCut.Text = "toolStripButton1";
            this.tbCut.ToolTipText = "Вырезать";
            this.tbCut.Click += new System.EventHandler(this.tbCut_Click);
            // 
            // tbCopy
            // 
            this.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tbCopy.Image")));
            this.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new System.Drawing.Size(23, 22);
            this.tbCopy.Text = "toolStripButton1";
            this.tbCopy.ToolTipText = "Копировать";
            this.tbCopy.Click += new System.EventHandler(this.tbCopy_Click);
            // 
            // tbPaste
            // 
            this.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tbPaste.Image")));
            this.tbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPaste.Name = "tbPaste";
            this.tbPaste.Size = new System.Drawing.Size(23, 22);
            this.tbPaste.Text = "toolStripButton1";
            this.tbPaste.ToolTipText = "Вставить";
            this.tbPaste.Click += new System.EventHandler(this.tbPaste_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Помощь";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 242);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmmain";
            this.Text = "ЛР 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmmain_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuEdit;
        private System.Windows.Forms.MenuItem mnuFormat;
        private System.Windows.Forms.MenuItem mnuWindow;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuNew;
        private System.Windows.Forms.MenuItem mnuOpen;
        private System.Windows.Forms.MenuItem mnuSave;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuCut;
        private System.Windows.Forms.MenuItem mnuCopy;
        private System.Windows.Forms.MenuItem mnuPaste;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem mnuSelectAll;
        private System.Windows.Forms.MenuItem mnuParagraph;
        private System.Windows.Forms.MenuItem mnuFont;
        private System.Windows.Forms.MenuItem mnuColor;
        private System.Windows.Forms.MenuItem mnuArrangeIcons;
        private System.Windows.Forms.MenuItem mnuCascade;
        private System.Windows.Forms.MenuItem mnuTileHorizontal;
        private System.Windows.Forms.MenuItem mnuTileVertical;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuItem mnuSaveAs;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuItem mnuDelete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbNew;
        private System.Windows.Forms.ToolStripButton tbOpen;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.ToolStripButton tbCut;
        private System.Windows.Forms.ToolStripButton tbCopy;
        private System.Windows.Forms.ToolStripButton tbPaste;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem mnuPageSetup;
        private System.Windows.Forms.MenuItem mnuPrintPreview;
        private System.Windows.Forms.MenuItem mnuPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem6;
    }
}

