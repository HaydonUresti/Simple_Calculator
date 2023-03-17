using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    public partial class Form1 : Form
    {
        // The list that contains the input from the user
        public List<string> EntryList = new List<string>();


        // A structure that contains the previous answer.
        // It is made a Union by the line following and third from that, which sets the variable to the same space in memory
        [System.Runtime.InteropServices.StructLayout(LayoutKind.Explicit)]
        struct PreviousAnswer
        {
            [System.Runtime.InteropServices.FieldOffset(0)]
            public string Answer;
        }

     
        // Creating an instance PreviousAnswer object
        PreviousAnswer LastAnswer = new PreviousAnswer();

        public Form1()
        {
            InitializeComponent();
        }

        public struct SavedData
        {
            public string CalcNum1;
            public string CaclNum2;
            public string CalcTotal;
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

        // The - button
        private void button11_Click(object sender, EventArgs e)
        {
            
            string buttonSub = "-";

            if (EntryList.Contains("+") || EntryList.Contains("-") || EntryList.Contains("X") || EntryList.Contains("/") || EntryList.Contains("^"))
            {
                MessageBox.Show("Only one operation can be done at a time!");
            }
            else
            {
    
                EntryList.Add(buttonSub);
            }

            
            textBox1.Text = string.Join("", EntryList);
        }

        // The X (multiplication) button
        private void button12_Click(object sender, EventArgs e)
        {
           
            string buttonMult = "X";

            if (EntryList.Contains("+") || EntryList.Contains("-") || EntryList.Contains("X") || EntryList.Contains("/") || EntryList.Contains("^"))
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
            if (EntryList.Contains("+") || EntryList.Contains("-") || EntryList.Contains("X") || EntryList.Contains("/") || EntryList.Contains("^"))
            {
                MessageBox.Show("Only one operation can be done at a time!");
            }
            else
            {
               
                EntryList.Add(buttonDiv);
            }
         
            textBox1.Text = string.Join("", EntryList);
        }

        // The ^ (Squared) button
        private void button17_Click(object sender, EventArgs e)
        {
            string buttonSquared = "^";
            if (EntryList.Contains("+") || EntryList.Contains("-") || EntryList.Contains("X") || EntryList.Contains("/") || EntryList.Contains("^"))
            {
                MessageBox.Show("Only one operation can be done at a time!");
            }
            else
            {

                EntryList.Add(buttonSquared);
            }

            textBox1.Text = string.Join("", EntryList);
        }

        // The Clear button
        // Clears the input characters
        private void button14_Click(object sender, EventArgs e)
        {
            EntryList.Clear();
            textBox1.Text = string.Join("", EntryList);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }


        // The Calculate button
        // Sends the user's input to the OutputHandler
        private void button16_Click(object sender, EventArgs e)
        {
            
            // A for loop to ensure that there in not an unmatched n symbol
            for (int i = 1; i < EntryList.Count(); i++)
            {
                string currItem = EntryList[i];
                string prevItem = EntryList[i - 1];

                if (prevItem == "n" && int.TryParse(currItem, out int value) == false)
                {
                    MessageBox.Show("You have an unmatched 'n' symbole");
                    return;
                }
            }

            // Ensure there is not an unmatched operation character at the beggining or end of the user's input
            if (EntryList[0] == "+" || EntryList[0] == "-" || EntryList[0] == "X" || EntryList[0] == "/" || EntryList[0] == "^")
            {
                MessageBox.Show("The first thing you enter may not be an operation symbole.");
            } else if (EntryList[0] == "+" || EntryList[0] == "-" || EntryList[0] == "X" || EntryList[0] == "/" || EntryList[0] == "^")
            {
                MessageBox.Show("The last thing you enter may not be an operation symbole.");
            } 
            else
            {
                string value = OutputHandler.SendOutput(EntryList);
                LastAnswer.Answer = value;
                textBox1.Text = value;
                EntryList.Clear();
            }
           
        }



        // The ANS button (ANS)
        // Changes and sets the current input to the last generated answer 
        private void button18_Click(object sender, EventArgs e)
        {
            // The if statement ensures that there is a previous answer in order to avoid an error
           if (LastAnswer.Equals(default(PreviousAnswer))){
                MessageBox.Show("You must have completed an operation in order to use this.");
            } else {
                EntryList.Clear();
                EntryList.Add(LastAnswer.Answer);
                textBox1.Text = string.Join("", EntryList);
            }     
        }

        // The DELETE button (Deletes the last given element)
        // Deletes the last input character
        private void button19_Click(object sender, EventArgs e)
        {
            // The if statement ensures the input list is not empty
            if (EntryList.Count == 0) {
                MessageBox.Show("You must have entered input in order to use this.");
            }
            else
            {
                EntryList.RemoveAt(EntryList.Count - 1);
                textBox1.Text = string.Join("", EntryList);
            }
        }

        // The negative button ( NEG )
        private void button20_Click(object sender, EventArgs e)
        {   
            string button5 = "n";

            EntryList.Add(button5);
            textBox1.Text = string.Join("", EntryList);
        }

        // The decimal button
        private void button21_Click(object sender, EventArgs e)
        {
            string button5 = ".";

            EntryList.Add(button5);
            textBox1.Text = string.Join("", EntryList);
        }
    }
}
