using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;

namespace KrunkApp
{

    public partial class Form1 : Form
    {
        Network a = new Network();
        /*a is object to use network methods Timofy
         * used in:
         * getData() 
         * buttonNextTo3_Click
         * button3_Click
         */

        //about client
        string name;
        string surname;
        string email;
        string tel;
        string city;
        int quant;
        /*********/

        //about banket
        Boolean bar;
        Boolean vip;
        string banket;//what client selected (type of banket)
        /*********/

        //about rooms
        string comment;//info about ordered rooms
        string AppartamentsTotal = "0";//total info
        int single = 0;//
        int two = 0;//double room @double@
        int triple = 0;
        int hours = 0;
        int RoomTotalPrice = 0;
        int ConfHind = 0;
        int RoomHind = 0;
        string confType;
        string RoomStart;
        DateTime ConfStart;
        /******************/

        //about food
        string[][] Salatid = new string[3][]
        {
            new string[4] { "kana ja Ploomiga","Singi ja Seentega", "Kreeka","\"Caesari\"Salat kanaga"},
            new string[4] { "2","2","2","2,4"},//price
            new string[4] { "0","0", "0", "0" }//quantity
        };//for each category own dishes with next parametors: Name Price Quantity
        string[][] Suupisted = new string[3][]
        {
            new string[7] { "Leivad kuuslaugu kastmega","Juustupallid kuuslaugu kastmega","Kalmaarirongad kuuslaugu kastmega", "Kanatiivad frituurid","Seakorvad\"TCILLI\" kastmega", "Basturma","Suupised neljale"},
            new string[7] { "1,8","1,8","1,8","1,8","1,8","3","1,8"},
            new string[7] { "0","0", "0", "0", "0", "0", "0" }
        };
        string[][] Grillroad = new string[3][]
        {
            new string[5] { "Lamba karree","\"Armeenia\" saslokk","Traditsiooniline saslokk","Kanasaslokk","Kanafilee"},
            new string[5] { "3","2,7" ,"2,7" ,"2,7" ,"1,6" },
            new string[5] { "0" , "0", "0", "0", "0"}
        };
        string[][] Garneering = new string[3][]
        {
            new string[1] { "WOK-koogiviljad"},
            new string[1] { "2,5"},
            new string[1] { "0" }
        };
        string[][] Pasta = new string[3][]
        {
            new string[3] { "Kala ja kreveetidega","Kana ja seentega","Carbonara"},
            new string[3] { "3","3","3"},
            new string[3] { "0", "0", "0"}
        };
        string[][] Kodune = new string[3][]
        {
            new string[5] { "Hinkaalid","Pelmeenid sealihaga","Pelmeenid tursafileega","Pannkoogid singi ja juustuga","Pannkoogid lihaga ja riisiga"},
            new string[5] { "5,5","5","5","3","3"},
            new string[5] { "0", "0", "0", "0", "0" }
        };
        string[][] Magustoitud = new string[3][]
        {
            new string[9] { "Juustujook","Sokolaadi kook","Apelsinimaiseline porgandi kook","Kirsi jook","Jaatise assorted","Pistaatsia jaatis","Jaatisekokteil mahlaga","Piimakoktel","Pannkoogid(3tk)"},
            new string[9] { "1,6","1,2","1,6","1,2","1,8","1,8","3,4","3,4","3"},
            new string[9] { "0", "0", "0", "0", "0", "0", "0", "0", "0" }
        };
        string Category;//which category client picked
        string Dish;//which dish client picked
        double FoodPrice;//how many should client pay for food
        string FoodOrder = "";
        double pricing = 0;
        public Form1()
        {
            InitializeComponent();
            panelMain.BringToFront();
        }
        //
        // PAGE 0
        //
        private void button1_Click(object sender, EventArgs e)
        {
            panelClient.BringToFront();
        }//to page 1
        //
        //PAGE 1
        //
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            getData();
            buttonNextTo3.Enabled = false;
            //собираю информацию и проверяю на валидность и переходим дальше
        }//to page 2
        public void getData()
        {
            name = textBoxName.Text;
            surname = textBoxSurname.Text;
            city = textBoxCity.Text;
            email = textBoxEmail.Text;
            tel = textBoxTel.Text;
            quant = Convert.ToInt32(numericUpDownQuantity.Value);
            if (name != "" && surname != "" && city != "" && email != "" && tel != "")
            {
                a.Registration(name, surname, tel, email, city, quant);
                panelBanket.BringToFront();
                BanketSelect(quant);
            }
            else
            {
                MessageBox.Show("Please fill all boxes!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//checking registration info 
        private void buttonBackToMain_Click_1(object sender, EventArgs e)
        {
            panelMain.BringToFront();
        }//back to page 0
        //
        //PAGE 2
        //
        private void buttonBackTo2_Click(object sender, EventArgs e)
        {
            panelClient.BringToFront();
        }//back to page 1
        private void buttonNextTo3_Click(object sender, EventArgs e)
        {
            panelAppartments.BringToFront();
            a.BanketType(banket);
        }//to page 3
        public void BanketSelect(int quant)
        {
            textBoxQuantInfo.Text = "You will have " + quant + " guests";
            textBoxStandart.BackColor = Color.LightGreen;
            textBoxBar.BackColor = Color.LightGreen;
            textBoxVip.BackColor = Color.LightGreen;
            bar = true;
            vip = true;

            if (quant >= 13)
            {
                textBoxVip.BackColor = Color.Red;
                vip = false;

                if (quant >= 31)
                {
                    textBoxBar.BackColor = Color.Red;
                    bar = false;
                }
            }
        }//banket selecting
        private void textBoxBar_Click(object sender, EventArgs e)
        {
            if (bar == true)
            {
                buttonNextTo3.Enabled = true;
                BanketSelect(quant);
                textBoxBar.BackColor = Color.Yellow;
               
                banket = "BAR";
            }
            else
            {
                buttonNextTo3.Enabled = false;
            }
        }//BAR
        private void textBoxStandart_Click(object sender, EventArgs e)
        {
            buttonNextTo3.Enabled = true;
            BanketSelect(quant);
            textBoxStandart.BackColor = Color.Yellow;

            banket = "STANDART";
        }//STANDART
        private void textBoxVip_Click(object sender, EventArgs e)
        {
            if (vip == true)
            {
                buttonNextTo3.Enabled = true;
                BanketSelect(quant);
                textBoxVip.BackColor = Color.Yellow;
                banket = "VIP";
            }
            else
            {
                buttonNextTo3.Enabled = false;
            }
        }//VIP
        //
        //PAGE 3
        //
        private void SingleRoom_ValueChanged(object sender, EventArgs e)
        {
            RoomInfo();
        }//SINGLE room
        private void DoubleRoom_ValueChanged(object sender, EventArgs e)
        {
            RoomInfo();
        }//DOUBLE room
        private void TripleRoom_ValueChanged(object sender, EventArgs e)
        {
            RoomInfo();
        }//TRIPLE room
        private void RoomsStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            RoomInfo();
        }//Rooms datetime
        private void ConferenceDuration_ValueChanged(object sender, EventArgs e)
        {
            ConferenceInfo();
        }//CONF Duration
        private void DateConference_ValueChanged(object sender, EventArgs e)
        {
            ConferenceInfo();
        }//CONF datetime 
        private void ConferenceType_SelectedValueChanged(object sender, EventArgs e)
        {
            ConferenceInfo();
        }//CONF type
        public void RoomInfo()
        {
            single = Convert.ToInt32(SingleRoom.Value);
            two = Convert.ToInt32(DoubleRoom.Value);
            triple = Convert.ToInt32(TripleRoom.Value);
            RoomHind = single*30 + two*60 + triple*120;
            RoomStart = RoomsStart.SelectionRange.Start.ToShortDateString();
            string result = RoomStart + ":\r\nSingle room(s)" + single * 30 + " EUROS\r\nDouble room(s)" + two * 45 + " EUROS\r\nTriple room(s) " + triple * 60 + " EUROS";
            RoomsData.Text = result;
            AppartTotalInfo.Text = RoomsData.Text + "\r\n" + ConferenceData.Text;
        }//TO collect all information about rooms
        public void ConferenceInfo()
        {
            confType = Convert.ToString(ConferenceType.SelectedItem);
            hours = Convert.ToInt32(ConferenceDuration.Value);
            ConfStart = DateConference.Value;
            int price = 0;//temp value for calculating conf price
            if (confType == "Day(s)")
                price = 90;
            if (confType == "Hour(s)")
                price = 20;
            ConfHind = price * hours;
            string conference = hours + " " + confType + " " + ConfHind + " EUROS " + ConfStart;
            ConferenceData.Text = conference;
            AppartTotalInfo.Text = RoomsData.Text + "\r\n" + ConferenceData.Text;
        }//TO collect all information about CONF
        private void button2_Click(object sender, EventArgs e)
        {
            panelBanket.BringToFront();
        }//back to page 2
        private void button3_Click(object sender, EventArgs e)
        {
            panelFood.BringToFront();
            RoomTotalPrice = RoomHind + ConfHind;
            comment = AppartComment.Text;
            AppartamentsTotal = AppartTotalInfo.Text;
            a.Appartaments(comment, AppartamentsTotal, single, two, triple, hours, RoomTotalPrice, ConfHind, RoomHind, confType, RoomStart, ConfStart);
        }//to page 4
        //
        //PAGE 4
        //
        private void button4_Click(object sender, EventArgs e)
        {
            panelAppartments.BringToFront();
        }//to page 3
        private void button5_Click(object sender, EventArgs e)
        {
            panelCheck.BringToFront();
            a.Food(FoodOrder, FoodPrice);
            ClientInfo.Text = name + " " + surname + " " + tel + " "+quant + "guest(s)";
            BanketInfo.Text = banket;
            HousingInfo.Text = AppartamentsTotal + "\r\n" + comment;
            FoodInfo.Text = FoodOrder;
            pricing = FoodPrice + RoomTotalPrice;
            PriceInfo.Text = ""+pricing;

        }//back to page 5
        private void AddButton_Click(object sender, EventArgs e)
        {
            Dish = Convert.ToString(dishBox.SelectedValue);
            DishAdd(Category, Dish);
        }//to add item

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Dish = Convert.ToString(dishBox.SelectedValue);
            DishRemove(Category, Dish);
        }//to remove item
        public void CategoryPicker(string Category)
        {
            dishBox.DataSource = null;//to clear before change items
            switch (Category)
            {
                case "Salatid":
                    dishBox.DataSource = Salatid[0];
                    break;
                case "Suupisted":
                    dishBox.DataSource = Suupisted[0];
                    break;
                case "Grillroad":
                    dishBox.DataSource = Grillroad[0];
                    break;
                case "Garneering":
                    dishBox.DataSource = Garneering[0];
                    break;
                case "Pasta":
                    dishBox.DataSource = Pasta[0];
                    break;
                case "Kodune":
                    dishBox.DataSource = Kodune[0];
                    break;
                case "Magustoitud":
                    dishBox.DataSource = Magustoitud[0];
                    break;
            }
        }//to change dish menu
        public void DishAdd(string Category, string Dish)
        {
            switch (Category)
            {
                case "Salatid":
                    for (int i = 0; i < Salatid[0].Length; i++)
                    {
                        if (Dish == Salatid[0][i])
                        {
                            int Amount = Convert.ToInt32(Salatid[2][i]);
                            Amount++;
                            Salatid[2][i] = "" + Amount;
                        }
                    }
                    break;
                case "Suupisted":
                    for (int i = 0; i < Suupisted[0].Length; i++)
                    {
                        if (Dish == Suupisted[0][i])
                        {
                            int Amount = Convert.ToInt32(Suupisted[2][i]);
                            Amount++;
                            Suupisted[2][i] = "" + Amount;
                        }
                    }
                    break;
                case "Grillroad":
                    for (int i = 0; i < Grillroad[0].Length; i++)
                    {
                        if (Dish == Grillroad[0][i])
                        {
                            int Amount = Convert.ToInt32(Grillroad[2][i]);
                            Amount++;
                            Grillroad[2][i] = "" + Amount;
                        }
                    }
                    break;
                case "Garneering":
                    for (int i = 0; i < Garneering[0].Length; i++)
                    {
                        if (Dish == Garneering[0][i])
                        {
                            int Amount = Convert.ToInt32(Garneering[2][i]);
                            Amount++;
                            Garneering[2][i] = "" + Amount;
                        }
                    }
                    break;
                case "Pasta":
                    for (int i = 0; i < Pasta[0].Length; i++)
                    {
                        if (Dish == Pasta[0][i])
                        {
                            int Amount = Convert.ToInt32(Pasta[2][i]);
                            Amount++;
                            Pasta[2][i] = "" + Amount;
                        }
                    }
                    break;
                case "Kodune":
                    for (int i = 0; i < Kodune[0].Length; i++)
                    {
                        if (Dish == Kodune[0][i])
                        {
                            int Amount = Convert.ToInt32(Kodune[2][i]);
                            Amount++;
                            Kodune[2][i] = "" + Amount;
                        }
                    }
                    break;
                case "Magustoitud":
                    for (int i = 0; i < Magustoitud[0].Length; i++)
                    {
                        if (Dish == Magustoitud[0][i])
                        {
                            int Amount = Convert.ToInt32(Magustoitud[2][i]);
                            Amount++;
                            Magustoitud[2][i] = "" + Amount;
                        }
                    }
                    break;
            }
            Check();
        }//to add dish
        public void DishRemove(string Category, string Dish)
        {
            switch (Category)
            {
                case "Salatid":
                    for (int i = 0; i < Salatid[0].Length; i++)
                    {
                        if (Dish == Salatid[0][i])
                        {
                            int Amount = Convert.ToInt32(Salatid[2][i]);
                            if (Amount > 0)
                            {
                                Amount--;
                                Salatid[2][i] = "" + Amount;
                            }
                        }
                    }
                    break;
                case "Suupisted":
                    for (int i = 0; i < Suupisted[0].Length; i++)
                    {
                        if (Dish == Suupisted[0][i])
                        {
                            int Amount = Convert.ToInt32(Suupisted[2][i]);
                            if (Amount > 0)
                            {
                                Amount--;
                                Suupisted[2][i] = "" + Amount;
                            }
                        }
                    }
                    break;
                case "Grillroad":
                    for (int i = 0; i < Grillroad[0].Length; i++)
                    {
                        if (Dish == Grillroad[0][i])
                        {
                            int Amount = Convert.ToInt32(Grillroad[2][i]);
                            if (Amount > 0)
                            {
                                Amount--;
                                Grillroad[2][i] = "" + Amount;
                            }
                        }
                    }
                    break;
                case "Garneering":
                    for (int i = 0; i < Garneering[0].Length; i++)
                    {
                        if (Dish == Garneering[0][i])
                        {
                            int Amount = Convert.ToInt32(Garneering[2][i]);
                            if (Amount > 0)
                            {
                                Amount--;
                                Garneering[2][i] = "" + Amount;
                            }
                        }
                    }
                    break;
                case "Pasta":
                    for (int i = 0; i < Pasta[0].Length; i++)
                    {
                        if (Dish == Pasta[0][i])
                        {
                            int Amount = Convert.ToInt32(Pasta[2][i]);
                            if (Amount > 0)
                            {
                                Amount--;
                                Pasta[2][i] = "" + Amount;
                            }
                        }
                    }
                    break;
                case "Kodune":
                    for (int i = 0; i < Kodune[0].Length; i++)
                    {
                        if (Dish == Kodune[0][i])
                        {
                            int Amount = Convert.ToInt32(Kodune[2][i]);
                            if (Amount > 0)
                            {
                                Amount--;
                                Kodune[2][i] = "" + Amount;
                            }
                        }
                    }
                    break;
                case "Magustoitud":
                    for (int i = 0; i < Magustoitud[0].Length; i++)
                    {
                        if (Dish == Magustoitud[0][i])
                        {
                            int Amount = Convert.ToInt32(Magustoitud[2][i]);
                            if (Amount > 0)
                            {
                                Amount--;
                                Magustoitud[2][i] = "" + Amount;
                            }
                        }
                    }
                    break;
            }
            Check();
        }//to remove dish
        public void dishSearch(string Category, string Dish)
        {
            switch (Category)
            {
                case "Salatid":
                    for (int i = 0; i < Salatid[0].Length; i++)
                    {
                        if (Dish == Salatid[0][i])
                        {
                            PriceBox.Text = Salatid[1][i];
                        }
                    }
                    break;
                case "Suupisted":
                    for (int i = 0; i < Suupisted[0].Length; i++)
                    {
                        if (Dish == Suupisted[0][i])
                        {
                            PriceBox.Text = Suupisted[1][i];
                        }
                    }
                    break;
                case "Grillroad":
                    for (int i = 0; i < Grillroad[0].Length; i++)
                    {
                        if (Dish == Grillroad[0][i])
                        {
                            PriceBox.Text = Grillroad[1][i];
                        }
                    }
                    break;
                case "Garneering":
                    for (int i = 0; i < Garneering[0].Length; i++)
                    {
                        if (Dish == Garneering[0][i])
                        {
                            PriceBox.Text = Garneering[1][i];
                        }
                    }
                    break;
                case "Pasta":
                    for (int i = 0; i < Pasta[0].Length; i++)
                    {
                        if (Dish == Pasta[0][i])
                        {
                            PriceBox.Text = Pasta[1][i];
                        }
                    }
                    break;
                case "Kodune":
                    for (int i = 0; i < Kodune[0].Length; i++)
                    {
                        if (Dish == Kodune[0][i])
                        {
                            PriceBox.Text = Kodune[1][i];
                        }
                    }
                    break;
                case "Magustoitud":
                    for (int i = 0; i < Magustoitud[0].Length; i++)
                    {
                        if (Dish == Magustoitud[0][i])
                        {
                            PriceBox.Text = Magustoitud[1][i];
                        }
                    }
                    break;
            }
        }//to display dish price
        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category = Convert.ToString(CategoryBox.SelectedItem);
            CategoryPicker(Category);
        }//to select category
        private void dishBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dish = Convert.ToString(dishBox.SelectedItem);
            dishSearch(Category, Dish);
        }//to select dish
        public void Check()
        {
            FoodCheck.Clear();
            FoodPrice = 0;
            for (int i = 0; i < Magustoitud[0].Length; i++)
            {
                int q = Convert.ToInt32(Magustoitud[2][i]);
                if (q > 0)
                {
                    string DName = Magustoitud[0][i];
                    double DAmon = Convert.ToDouble(Magustoitud[2][i]);
                    double DPrice = Convert.ToDouble(Magustoitud[1][i]) * DAmon;
                    FoodPrice += DPrice;
                    FoodCheck.Text += DName + " " + DAmon + "tk " + DPrice + "EUR" + "\r\n";
                }
            }
            for (int i = 0; i < Salatid[0].Length; i++)
            {
                int q = Convert.ToInt32(Salatid[2][i]);
                if (q > 0)
                {
                    string DName = Salatid[0][i];
                    double DAmon = Convert.ToDouble(Salatid[2][i]);
                    double DPrice = Convert.ToDouble(Salatid[1][i]) * DAmon;
                    FoodPrice += DPrice;
                    FoodCheck.Text += DName + " " + DAmon + "tk " + DPrice + "EUR" + "\r\n";
                }
            }
            for (int i = 0; i < Suupisted[0].Length; i++)
            {
                if (Convert.ToInt32(Suupisted[2][i]) > 0)
                {
                    string DName = Suupisted[0][i];
                    double DAmon = Convert.ToDouble(Suupisted[2][i]);
                    double DPrice = Convert.ToDouble(Suupisted[1][i]) * DAmon;
                    FoodPrice += DPrice;
                    FoodCheck.Text += DName + " " + DAmon + "tk " + DPrice + "EUR" + "\r\n";
                }
            }
            for (int i = 0; i < Grillroad[0].Length; i++)
            {
                if (Convert.ToInt32(Grillroad[2][i]) > 0)
                {
                    string DName = Grillroad[0][i];
                    double DAmon = Convert.ToDouble(Grillroad[2][i]);
                    double DPrice = Convert.ToDouble(Grillroad[1][i]) * DAmon;
                    FoodPrice += DPrice;
                    FoodCheck.Text += DName + " " + DAmon + "tk " + DPrice + "EUR" + "\r\n";
                }
            }
            for (int i = 0; i < Garneering[0].Length; i++)
            {
                if (Convert.ToInt32(Garneering[2][i]) > 0)
                {
                    string DName = Garneering[0][i];
                    double DAmon = Convert.ToDouble(Garneering[2][i]);
                    double DPrice = Convert.ToDouble(Garneering[1][i]) * DAmon;
                    FoodPrice += DPrice;
                    FoodCheck.Text += DName + " " + DAmon + "tk " + DPrice + "EUR" + "\r\n";
                }
            }
            for (int i = 0; i < Pasta[0].Length; i++)
            {
                if (Convert.ToInt32(Pasta[2][i]) > 0)
                {
                    string DName = Pasta[0][i];
                    double DAmon = Convert.ToDouble(Pasta[2][i]);
                    double DPrice = Convert.ToDouble(Pasta[1][i]) * DAmon;
                    FoodPrice += DPrice;
                    FoodCheck.Text += DName + " " + DAmon + "tk " + DPrice + "EUR" + "\r\n";
                }
            }
            for (int i = 0; i < Kodune[0].Length; i++)
            {
                if (Convert.ToInt32(Kodune[2][i]) > 0)
                {
                    string DName = Kodune[0][i];
                    double DAmon = Convert.ToDouble(Kodune[2][i]);
                    double DPrice = Convert.ToDouble(Kodune[1][i]) * DAmon;
                    FoodPrice += DPrice;
                    FoodCheck.Text += DName + " " + DAmon + "tk " + DPrice + "EUR" + "\r\n";
                }
            }
            FoodOrder = FoodCheck.Text;
            FoodCheck.Text += "Total price is " + FoodPrice + " EUR";
        }//to display food order information
        //
        //PAGE 5
        //
        private void button6_Click(object sender, EventArgs e)
        {
            panelFood.BringToFront();
        }//to page 4

        private void button7_Click(object sender, EventArgs e)
        {
            //TODO:I don't know what to do here
            Sending(name, surname, email, tel, quant, banket, AppartamentsTotal, FoodOrder, pricing);
            Process.Start("KrunkApp.exe");
            Application.Exit();
        }//Finsih button restart+sending all info
        public void Sending(string name, string surname, string email, string tel, int quantity, string banket, string AppartamentsTotal, string FoodOrder, double pricing)
        {
            switch (banket)
            {
                case "BAR":
                    banket = "1";
                    break;
                case "VIP":
                    banket = "2";
                    break;
                case "STANDART":
                    banket = "3";
                    break;
            }
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["name"] = name + " " + surname;
                values["tel"] = tel;
                values["email"] = email;
                values["city"] = city;
                values["quantity"] = Convert.ToString(quant);
                values["type"] = banket;
                values["housing_info"] = AppartamentsTotal;
                values["food_info"] = FoodOrder;
                values["total_price"] = Convert.ToString(pricing);

                var response = client.UploadValues("http://show.codesgroup.ru/login-api/api.php?sendInfo", values);
                var responseString = Encoding.Default.GetString(response);
                MessageBox.Show("Order stored to server");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
