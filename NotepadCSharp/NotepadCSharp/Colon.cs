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
    public partial class Colon : Form
    {

        ColorDialog dlg = new ColorDialog();
        public Font fnt = new Font("Arial", 10, FontStyle.Regular);
        public Color col = Color.Black;
        public HorizontalAlignment aln = HorizontalAlignment.Left;
        public Colon()
        {
            InitializeComponent();
            checkBox1.Click += aln_CheckedChanged;
            checkBox2.Click += aln_CheckedChanged;
            checkBox3.Click += aln_CheckedChanged;
            updateColonView(col, aln, fnt);
        }

        private void aln_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = ((CheckBox)sender);
            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = false;
            checkbox.Checked = true;
            switch (checkbox.Tag.ToString())
            {
                case "left":
                    aln = HorizontalAlignment.Left;
                    break;
                case "right":
                    aln = HorizontalAlignment.Right;
                    break;
                case "center":
                    aln = HorizontalAlignment.Center;
                    break;

            }
            updateColonView(col, aln, fnt);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        public void updateColonView(Color color, HorizontalAlignment align, Font fnt)
        {
            textBox1.ForeColor = textBox2.ForeColor = color;
            textBox1.Font = textBox2.Font = fnt;
          //  textBox1.TextAlign = textBox2.TextAlign = align;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                col = dlg.Color;
                updateColonView(col, aln, fnt);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //font select
            // Show the dialog.
            DialogResult result = fontDialog1.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                fnt = fontDialog1.Font;
                updateColonView(col, aln, fnt);
            }
        }


    }
}
