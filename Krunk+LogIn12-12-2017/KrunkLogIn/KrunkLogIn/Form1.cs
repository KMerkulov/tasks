using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.Diagnostics;

namespace KrunkLogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Pass.Text;
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["username"] = login;
                values["password"] = password;


                var response = client.UploadValues("http://show.codesgroup.ru/login-api/api.php?login", values);
                var responseString = Encoding.Default.GetString(response);
                if (System.Text.Encoding.UTF8.GetString(response) == "1")
                {
                    Process.Start(@"KrunkApp.exe");
                    Application.Exit();
                }
                else {
                    MessageBox.Show("Wrong user data");
                }
            }
        }
    }
}
