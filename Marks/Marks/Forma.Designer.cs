namespace Marks
{
    partial class Forma
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
            this.ConvertMarks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EnterText = new System.Windows.Forms.TextBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConvertMarks
            // 
            this.ConvertMarks.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConvertMarks.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ConvertMarks.FlatAppearance.BorderSize = 2;
            this.ConvertMarks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ConvertMarks.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConvertMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertMarks.Location = new System.Drawing.Point(12, 137);
            this.ConvertMarks.Name = "ConvertMarks";
            this.ConvertMarks.Size = new System.Drawing.Size(269, 36);
            this.ConvertMarks.TabIndex = 0;
            this.ConvertMarks.TabStop = false;
            this.ConvertMarks.Text = "Конвертировать";
            this.ConvertMarks.UseVisualStyleBackColor = false;
            this.ConvertMarks.Click += new System.EventHandler(this.ConvertMarks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Я хочу перевести:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Оценки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите очки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Результат в баллах:";
            // 
            // EnterText
            // 
            this.EnterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterText.Location = new System.Drawing.Point(178, 103);
            this.EnterText.Name = "EnterText";
            this.EnterText.Size = new System.Drawing.Size(70, 21);
            this.EnterText.TabIndex = 5;
            this.EnterText.TabStop = false;
            // 
            // ResultText
            // 
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultText.Location = new System.Drawing.Point(178, 184);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(70, 21);
            this.ResultText.TabIndex = 5;
            this.ResultText.TabStop = false;
            // 
            // Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(293, 221);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.EnterText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertMarks);
            this.Name = "Forma";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertMarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EnterText;
        private System.Windows.Forms.TextBox ResultText;
    }
}

