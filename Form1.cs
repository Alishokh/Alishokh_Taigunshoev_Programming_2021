using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string path1 = this.textBox1.Text;
            string path = @"E:\Фриланс\Form\ExpenseManager\ExpenseManager\bin\Debug\TextFile.txt";

            double sum = 0;
            List<string> categories = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(path1, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] mas = line.Split('|');
                        
                        if(mas[1]=="Price")
                        {
                            
                        }
                        else
                        {
                            categories.Add(mas[2]);
                            NumberFormatInfo provider = new NumberFormatInfo();

                            string ss = mas[1];
                            double doubleVal = Convert.ToDouble(ss, provider);
                            sum += doubleVal;

                            //MessageBox.Show(mas[1]);


                        }
                       
                    }
                }
   
                int count = categories.Distinct().Count();
                this.textBox2.Text = "Total Expenses " + sum.ToString() + "\r\nNumber of categories: " + count;
            }
            catch
            {
                MessageBox.Show("Error");
            }
           



        }
    }
}
