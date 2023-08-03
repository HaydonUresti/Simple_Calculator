using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    // --------A class that handles the user's input and solves the given operation--------//
    class OutputHandler
    {

        static List<string> FirstNum = new List<string>();
        static List<string> SecondNum = new List<string>();
        static List<string> Operator = new List<string>();

        
        static List<List<string>> OutputList = new List<List<string>>();

        public struct SavedData
        {
            public string CalcNum1;
            public string CaclNum2;
            public string CalcTotal;
        }

       
        //OutputHandler.SavedData SavedDataObject = new OutputHandler.SavedData();
        
        private static void ClearOutputLists()
        {
            FirstNum.Clear();
            SecondNum.Clear();
            Operator.Clear();
        }
        

       
        // A method that takes the input list and sorts it into lists of the parts of the operation
        // Parameters: mainList - A lsit containing the input fron the user
        // Returns: itemList - A list containing the separated parts of the operation
        static List<string> GetLists(List<string> mainList){
            
           List<string> itemsList = new List<string>();
           
            bool operatorFound = false;


            int count = 0;

           
            foreach(var item in mainList)
            {
                
                if(item == "+" || item == "-" || item == "X" || item == "/" || item == "^")
                {
                    Operator.Add(item);
                    operatorFound = true;
                }
                else if (item == "n")
                {
                    if (count == 0)
                    {
                        FirstNum.Add("-");
                    }
                    else { SecondNum.Add("-"); }
                    


                }
                else if(operatorFound)
                {
                    SecondNum.Add(item);
                }
                else
                {
                    FirstNum.Add(item);
                }
                count++;
            }
            itemsList.Add(string.Join("", FirstNum));
            itemsList.Add(string.Join("", Operator));
            itemsList.Add(string.Join("", SecondNum));
            ClearOutputLists();
            return itemsList;
        }

        
        // A method that converts given strings into double types
        // Parameters: originalNum - The string type version of a number
        // Returns: A double type of the given string type
        static double ConvertList(string originalNum)
        {
            return (double.Parse(originalNum));
        }

        // A method that adds the given data
        // Parameters: list - the user's input
        // Returns: A string version of the added data
        static string DoAddition(List<string> list)
        {
            return (ConvertList(list[0]) + ConvertList(list[2])).ToString();
                
        }

        // A method that subtracts the given data
        // Parameters: list - the user's input
        // Returns: A string version of the subtracted data
        static string DoSubtraction(List<string> list)
        {
            return (ConvertList(list[0]) - ConvertList(list[2])).ToString();
        }

        // A method that multiplies the given data
        // Parameters: list - the user's input
        // Returns: A string version of the multiplied data
        static string DoMultiplication(List<string> list)
        {
            return (ConvertList(list[0]) * ConvertList(list[2])).ToString();
        }

        // A method that divides the given data
        // Parameters: list - the user's input
        // Returns: A string version of the divided data
        static string DoDivision(List<string> list)
        {
            return (ConvertList(list[0]) / ConvertList(list[2])).ToString();

        }

        // A method that raises the power of the given data
        // Parameters: list - the user's input
        // Returns: A string version of the new data
        static string DoSquared(List<string> list)
        {
            return Math.Pow(ConvertList(list[0]), ConvertList(list[2])).ToString();
        }



        // A method that looks at the operator value and determines the calculation that will happen.
        // Parameters: list - The sorted version of the user's input
        // Returns: The correct operation based on the sorted list
        private static string ChooseCalcMethod(List<string> list)
        {
            OutputHandler.OutputList.Clear();

            string operation = list[1];

            switch (operation)
            {

                case "+":
                    return (ConvertList(list[0]) + ConvertList(list[2])).ToString();

                case "-":
                    return (ConvertList(list[0]) - ConvertList(list[2])).ToString();

                case "X":
                    return (ConvertList(list[0]) * ConvertList(list[2])).ToString();

                case "/":
                    return (ConvertList(list[0]) / ConvertList(list[2])).ToString();

                case "^":
                    return Math.Pow(ConvertList(list[0]), ConvertList(list[2])).ToString();
            }


            return "ERROR!";
        }

        // A public method that returns the solution to the GUI
        // Parameters: EntryList - The user's input
        // Returns: The answrt of the operation
        public static string SendOutput(List<string> EntryList)
        {   string answer = ChooseCalcMethod(GetLists(EntryList));
            
            return answer;
        }

    }
}
