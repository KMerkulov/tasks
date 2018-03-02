using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Translator
{
    public partial class Form1 : Form
    {
        // creating enum languages and all are for all languages (dictionery)
        enum languages {French,German,Italian,Spanish,Latin,Portuguese,Estonian};
        // string creating as path
        string path;
        // string searcher as making it to result
        List<string> result;
        // string creating a key
        string key;

        public Form1()
        {
            InitializeComponent();
            // data source create for combobox and equals to enum values.
            comboBox1.DataSource = Enum.GetValues(typeof(languages));
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            // key string equal to textboxkey
            // LOWER - For Text to Regonize BIG or small text in word Translation from .txt files..
            key = textBoxKey.Text.ToLower();
            
            // read all lines...
            string[] lines = File.ReadAllLines(path);
            // creating a new dictionary
            var dict = new Dictionary<string, List<string>>();
            // we are using foreach for string s in the lines
            foreach (string s in lines)
            {
                // split for the substring
                string[] temp = s.Split('\t');
                // new list string
                List<string> tempList = new List<string>();
                // determination for dictionary key values
                if (dict.ContainsKey(temp[0]))
                {
                    // trying to get value with a key
                    dict.TryGetValue(temp[0], out tempList);
                    // adds an object end to the list t
                    tempList.Add(temp[1]);
                    
                    continue;
                } 
                // adds an object
                tempList.Add(temp[1]);
                // adding dictionary key values
                dict.Add(temp[0], tempList);
            }
            // gets a value from key, result
            dict.TryGetValue(key, out result);
            // output create and it is as ""
            string output = "";
            if (result == null)
               output = "Word "+key+" was not found in the dictionary";
            if (result != null)
            {

            
                // foreach for string s in result
                foreach (string s in result)

            {
               
                // calculation...output - equals s value with " " 
                output += s + "  ";
            }
            }
            // we want results to textboxresult box
            textBoxResult.Text = output;
            
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // path equals with combobox1 and use as .txt, so it converts to string
            path = Convert.ToString(comboBox1.SelectedValue) + ".txt";
            // Write a path
            Console.WriteLine(path);
           
        }
    }
}
