using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSVGeneratorTest.Models;
using CSVGeneratorTest.Interfaces;

namespace CSVGeneratorTest.Creators {
    class CSVCreator {
        INameCreator nameCreator;
        IDateCreator dateCreator;
        IPhoneCreator phoneCreator;
        ICityCreator cityCreator;
        IEmailCreator emailCreator;

        public CSVCreator(INameCreator nc, IDateCreator dc, IPhoneCreator pc, ICityCreator cc, IEmailCreator ec) {
            nameCreator = nc;
            dateCreator = dc;
            phoneCreator = pc;
            cityCreator = cc;
            emailCreator = ec;
        }
        public User[] CreateUsers(int userCount) {
            List<User> users = new List<User>();
            for (int i = 0; i < userCount; i++) {
                users.Add(new User(i, nameCreator.CreateName(),
                    dateCreator.CreateDate(), phoneCreator.CreatePnone(),
                    cityCreator.CreateCity(), emailCreator.CreateEmail()));
            }
            return users.ToArray();
        }
    }
}
