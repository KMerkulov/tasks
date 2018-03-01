namespace NotepadCSharp
{
    partial class replacer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lookFor = new System.Windows.Forms.TextBox();
            this.replaceWith = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Что:";
            // 
            // lookFor
            // 
            this.lookFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpProvider1.SetHelpString(this.lookFor, "Text to be found");
            this.lookFor.Location = new System.Drawing.Point(54, 10);
            this.lookFor.Name = "lookFor";
            this.helpProvider1.SetShowHelp(this.lookFor, true);
            this.lookFor.Size = new System.Drawing.Size(211, 22);
            this.lookFor.TabIndex = 1;
            this.lookFor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lookFor_KeyUp);
            // 
            // replaceWith
            // 
            this.replaceWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpProvider1.SetHelpString(this.replaceWith, "Text to be replaced with");
            this.replaceWith.Location = new System.Drawing.Point(54, 38);
            this.replaceWith.Name = "replaceWith";
            this.helpProvider1.SetShowHelp(this.replaceWith, true);
            this.replaceWith.Size = new System.Drawing.Size(211, 22);
            this.replaceWith.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Чем:";
            // 
            // button1
            // 
            this.helpProvider1.SetHelpString(this.button1, "Find next occurence");
            this.button1.Location = new System.Drawing.Point(286, 13);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Найти далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.helpProvider1.SetHelpString(this.button2, "Replace current occurence");
            this.button2.Location = new System.Drawing.Point(286, 42);
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Заменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.helpProvider1.SetHelpString(this.button3, "Replace all found occurences");
            this.button3.Location = new System.Drawing.Point(286, 71);
            this.button3.Name = "button3";
            this.helpProvider1.SetShowHelp(this.button3, true);
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Заменить все";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.helpProvider1.SetHelpString(this.button4, "Cancel recent action");
            this.button4.Location = new System.Drawing.Point(286, 100);
            this.button4.Name = "button4";
            this.helpProvider1.SetShowHelp(this.button4, true);
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.helpProvider1.SetHelpString(this.checkBox1, "Use case-sensetive search");
            this.checkBox1.Location = new System.Drawing.Point(17, 104);
            this.checkBox1.Name = "checkBox1";
            this.helpProvider1.SetShowHelp(this.checkBox1, true);
            this.checkBox1.Size = new System.Drawing.Size(120, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "С учетом регистра";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // replacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 151);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.replaceWith);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookFor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "replacer";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Заменить";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.replacer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lookFor;
        private System.Windows.Forms.TextBox replaceWith;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}