using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrunkApp
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
        public string TClient(string name, string surname, string tel, int quant)
        {
            string info = name + " " + surname + "" + " " + tel + " " + quant + " guests";
            return Client.Text = info;
        }
        public string TBanket(string banket)
        {
            return Banket.Text = banket;
        }
        public string TFood(string FoodOrder, double FoodPrice)
        {
            return Food.Text = FoodOrder + "\r\n" + FoodPrice+"EUR";
        }
        public string THouse(string comment, string AppartamentsTotal)
        {
            string info = comment+"\r\n"+ AppartamentsTotal;
            return House.Text=info;
        }
        public void Response(string ans)
        {
            MessageBox.Show(ans);
        }

    }
}
