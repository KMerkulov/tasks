using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CSVGeneratorTest.Models {
    public class User {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public DateTime Date { get; private set; }
        public string Phone { get; private set; }
        public string City { get; private set; }
        public string Email { get; private set; }

        public User(int id, string name, DateTime date, string phone, string city, string email) {
            ID = id;
            Name = name;
            Date = date;
            Phone = phone;
            City = city;
            Email = email;
        }
        public override string ToString() {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}",
                ID, Name, Phone, Date.ToShortDateString(), City, Email);
        }
    }
}
