using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KrunkApp
{
    class Network
    {
        Form2 frm2 = new Form2();
        public void Registration(string name, string surname, string tel, string email, string city, int quant)
        {
            //сюда метод по отправке данных на сервер с данными клиента

            
            frm2.TClient(name, surname, tel, quant);
            frm2.Show();
        }
        public void BanketType(string banket)
        {
            //сюда метод для отправки типа банкета
            frm2.TBanket(banket);
        }
        public void Appartaments(string comment, string AppartamentsTotal, int single, int two, int triple, int hours, int RoomTotalPrice, int ConfHind, int RoomHind, string confType, string RoomStart, DateTime ConfStart)
        {
            //сюда метод для отправки данных о заказанных номерах+комментария от клиента
            frm2.THouse(comment, AppartamentsTotal);
        }
        public void Food(string FoodOrder, double FoodPrice)
        {
            //сюда метод для отправки о заказаной еде
            frm2.TFood(FoodOrder, FoodPrice);
        }
    }
}
