using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Generator
{
    public partial class Form1 : Form
    {
        List<String> generatedFirstNames, generatedSecondNames;

        public Form1()
        {
            InitializeComponent();
            comboBoxGender.SelectedItem = comboBoxGender.Items[0];
            comboBoxRaces.SelectedItem = comboBoxRaces.Items[0];
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] fileFirstname = File.ReadAllLines(comboBoxRaces.Text + " " + comboBoxGender.Text + " FirstName.txt");
                string[] fileSecondname = File.ReadAllLines(comboBoxRaces.Text + " " + "Secondname.txt");
                generatedFirstNames = new List<string>(fileFirstname);
                generatedSecondNames = new List<string>(fileSecondname);

                labelPrevGenName.Text = labelGenName.Text;
                string generatedName = GenerateFullName(generatedFirstNames, generatedSecondNames);

                labelGenName.Text = generatedName;
                listBoxGenNames.Items.Add(generatedName);
                listBoxNamesUnsorted.Items.Add(generatedName);

                labelError.Text = "";

            }
            catch (IOException s)
            {
                labelError.Text = "Error: No file with this combo of Race and Gender could be found";


                Console.WriteLine("The file could not be read:");
                Console.WriteLine(s.Message);
            }

        }
       
        string GenerateFullName(List<String> firstName, List<String> secondName)
        {
            Random rnd = new Random();
            string name = secondName[rnd.Next(0, secondName.Count - 1)] + ", " + firstName[rnd.Next(0, firstName.Count - 1)];

            return name;
        }
    }
}
