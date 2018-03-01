using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CSVGeneratorTest.Models;
using CSVGeneratorTest.Creators;
using CSVGeneratorTest.Interfaces;

namespace CSVGeneratorTest.Forms {
    public partial class MainForm : Form {
        User[] users = null;

        public MainForm() {
            InitializeComponent();
            btnGenerate.Click += new EventHandler(btnGenerate_Click);
            btnSave.Click += new EventHandler(btnSave_Click);
        }

        void btnSave_Click(object sender, EventArgs e) {
            if (users == null) {
                return;
            }
            File.WriteAllLines("output.csv", users.Select(u => u.ToString()));
        }

        void btnGenerate_Click(object sender, EventArgs e) {
            int rowCount;
            if (!int.TryParse(txtRows.Text, out rowCount)) {
                txtRows.Clear();
                return;
            }
            CSVCreator creator = new CSVCreator(new FileNameCreator(), new FileDateCreator(), 
                    new FilePhoneCreator(), new FileCityCreator(), new FileEmailCreator());
            users = creator.CreateUsers(rowCount);
            usersGridView.DataSource = null;
            usersGridView.DataSource = users;

            usersListBox.Items.Clear();
            usersListBox.Items.AddRange(users.Select(u => u.ToString()).ToArray());
        }
    }
}
