using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using CSVGeneratorTest.Forms;

namespace CSVGeneratorTest {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            //CreateFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        static void CreateFile() {
            string[] lines = File.ReadAllLines(@"C:\output(1).csv");
            string[] emails = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++) {
                string[] data=lines[i].Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries);
                emails[i]=data[5];
            }
            File.WriteAllLines("emails.txt", emails);
        }
    }
}
