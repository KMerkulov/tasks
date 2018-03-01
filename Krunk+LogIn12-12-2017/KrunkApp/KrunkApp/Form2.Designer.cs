namespace KrunkApp
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.House = new System.Windows.Forms.TextBox();
            this.Food = new System.Windows.Forms.TextBox();
            this.Banket = new System.Windows.Forms.TextBox();
            this.Client = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.House);
            this.panel1.Controls.Add(this.Food);
            this.panel1.Controls.Add(this.Banket);
            this.panel1.Controls.Add(this.Client);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 455);
            this.panel1.TabIndex = 0;
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(98, 245);
            this.House.Multiline = true;
            this.House.Name = "House";
            this.House.ReadOnly = true;
            this.House.Size = new System.Drawing.Size(643, 196);
            this.House.TabIndex = 4;
            // 
            // Food
            // 
            this.Food.Location = new System.Drawing.Point(98, 61);
            this.Food.Multiline = true;
            this.Food.Name = "Food";
            this.Food.ReadOnly = true;
            this.Food.Size = new System.Drawing.Size(643, 178);
            this.Food.TabIndex = 4;
            // 
            // Banket
            // 
            this.Banket.Location = new System.Drawing.Point(98, 37);
            this.Banket.Name = "Banket";
            this.Banket.ReadOnly = true;
            this.Banket.Size = new System.Drawing.Size(643, 20);
            this.Banket.TabIndex = 4;
            // 
            // Client
            // 
            this.Client.Location = new System.Drawing.Point(98, 9);
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Size = new System.Drawing.Size(643, 20);
            this.Client.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 245);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(70, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Housing \r\ninformation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klient";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KrunkApp.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 455);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Klient order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox House;
        private System.Windows.Forms.TextBox Food;
        private System.Windows.Forms.TextBox Banket;
        private System.Windows.Forms.TextBox Client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}