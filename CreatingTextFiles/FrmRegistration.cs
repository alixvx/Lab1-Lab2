using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreatingTextFiles
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getInput1 = textBox1.Text;
            string getInput2 = textBox2.Text;
            string getInput3 = textBox3.Text;
            string getInput4 = dateTimePicker1.Text;
            string getInput5 = comboBox1.Text;
            string getInput6 = textBox4.Text;
            string getInput7 = textBox5.Text;
            string getInput8 = comboBox2.Text;
            string getInput9 = textBox6.Text;

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            getInput1 + ".txt")))

            {
                outputFile.WriteLine("Student No: " + getInput1);
                outputFile.WriteLine("Full Name: " + getInput2 + "," + getInput6 + getInput7);
                outputFile.WriteLine("Program: " + getInput5);
                outputFile.WriteLine("Gender: " + getInput8);
                outputFile.WriteLine("Age: " + getInput3);
                outputFile.WriteLine("Birthday: " + getInput4);
                outputFile.WriteLine("Contact No.: " + getInput9);
            }
            this.Close();




        }
    }
}
