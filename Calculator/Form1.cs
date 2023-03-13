using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        // The list that contains the input from the user
        public List<string> EntryList = new List<string>();
        OutputHandler Controler = new OutputHandler();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // The number 1 button
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You clicked button 1!");
            string button1 = "1";
            EntryList.Add(button1);
            textBox1.Text = string.Join("",EntryList);
        }

        // The number 2 button
        private void button2_Click(object sender, EventArgs e)
        {
            
            string button2 = "2";
  
            EntryList.Add(button2);
            textBox1.Text = string.Join("", EntryList);
        }

        // The number 3 button
        private void button3_Click(object sender, EventArgs e)
        {
           
            string button3 = "3";

            EntryList.Add(button3);
            textBox1.Text = string.Join("", EntryList);
        }


        // The number 4 button
        private void button4_Click(object sender, EventArgs e)
        {
            
            string button4 = "4";

            EntryList.Add(button4);
            textBox1.Text = string.Join("", EntryList);
        }

        // The number 5 button
        private void button5_Click(object sender, EventArgs e)
        {
            
            string button5 = "5";

            EntryList.Add(button5);
            textBox1.Text = string.Join("", EntryList);
        }

        // The number 6 button
        private void button6_Click(object sender, EventArgs e)
        {
            
            string button6 = "6";

            EntryList.Add(button6);
            textBox1.Text = string.Join("", EntryList);
        }


        // The number 7 button
        private void button7_Click(object sender, EventArgs e)
        {
           
            string button7 = "7";

            EntryList.Add(button7);
            textBox1.Text = string.Join("", EntryList);
        }

        // The number 8 button
        private void button8_Click(object sender, EventArgs e)
        {
           
            string button8 = "8";

            EntryList.Add(button8);
            textBox1.Text = string.Join("", EntryList);
        }


        // The number 9 button
        private void button9_Click(object sender, EventArgs e)
        {
            
            string button9 = "9";

            EntryList.Add(button9);
            textBox1.Text = string.Join("", EntryList);
        }

        // The number 0 button
        private void button15_Click(object sender, EventArgs e)
        {
            
            string button0 = "0";

            EntryList.Add(button0);
            textBox1.Text = string.Join("", EntryList);
        }

        // The + button
        private void button10_Click(object sender, EventArgs e)
        {
            
            string buttonAdd = "+";

            if (EntryList.Contains("+") || EntryList.Contains("-") || EntryList.Contains("X") || EntryList.Contains("/"))
            {
                
                MessageBox.Show("Only one operation can be done at a time!");
            } else
            {
                EntryList.Add(buttonAdd);
            }

            textBox1.Text = string.Join("", EntryList);
        }

        // The number - button
        private void button11_Click(object sender, EventArgs e)
        {
            
            string buttonSub = "-";

            if (EntryList.Contains("+") || EntryList.Contains("-") || EntryList.Contains("X") || EntryList.Contains("/"))
            {
                MessageBox.Show("Only one operation can be done at a time!");
            }
            else
            {
    
                EntryList.Add(buttonSub);
            }

            
            textBox1.Text = string.Join("", EntryList);
        }

        // The number X (multiplication) button
        private void button12_Click(object sender, EventArgs e)
        {
           
            string buttonMult = "X";

            if (EntryList.Contains("+") || EntryList.Contains("-") || EntryList.Contains("X") || EntryList.Contains("/"))
            {
                
                MessageBox.Show("Only one operation can be done at a time!");
            }
            else
            {
                EntryList.Add(buttonMult);
            }
            textBox1.Text = string.Join("", EntryList);
        }

        // The number / (divide) button
        private void button13_Click(object sender, EventArgs e)
        {
            
            string buttonDiv = "/";
            if (EntryList.Contains("+") || EntryList.Contains("-") || EntryList.Contains("X") || EntryList.Contains("/"))
            {
                MessageBox.Show("Only one operation can be done at a time!");
            }
            else
            {
               
                EntryList.Add(buttonDiv);
            }
         
            textBox1.Text = string.Join("", EntryList);
        }

        // The Clear button
        private void button14_Click(object sender, EventArgs e)
        {
            EntryList.Clear();
            textBox1.Text = string.Join("", EntryList);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // The Calculate button
        private void button16_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("You clicked button Calculate button!");
            string value = OutputHandler.Main(EntryList);
            textBox1.Text = value;
            EntryList.Clear();
            value = "0";
        }
    }
}
