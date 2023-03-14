using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

     class OutputHandler
    {

        static List<string> FirstNum = new List<string>();
        static List<string> SecondNum = new List<string>();
        static List<string> Operator = new List<string>();

        static List<string> OperationsList = new List<string>();
        
        static List<List<string>> OutputList = new List<List<string>>();

        private static void ClearOutputLists()
        {
            FirstNum.Clear();
            SecondNum.Clear();
            Operator.Clear();
        }
        
        static int Total = 0;

       
       // public void 

        static List<string> GetLists(List<string> mainList){
            
           List<string> itemsList = new List<string>();
            //List<List<List<string>>> ListOfLists = new List<List<List<string>>>();
            bool operatorFound = false;

            foreach(var item in mainList)
            {
                if(item == "+" || item == "-" || item == "X" || item == "/" || item == "^")
                {
                    Operator.Add(item);
                    operatorFound = true;
                }
                else if(operatorFound)
                {
                    SecondNum.Add(item);
                }
                else
                {
                    FirstNum.Add(item);
                }
            }
            itemsList.Add(string.Join("", FirstNum));
            itemsList.Add(string.Join("", Operator));
            itemsList.Add(string.Join("", SecondNum));
            ClearOutputLists();
           // ListOfLists.Add(itemsList);
            return itemsList;
        }

        

        static double ConvertList(string originalNum)
        {
            //List<int> intList = new List<int>();

            

            return (double.Parse(originalNum));
        }


        static string DoAddition(List<string> list)
        {
            return (ConvertList(list[0]) + ConvertList(list[2])).ToString();
                
        }


        static string DoSubtraction(List<string> list)
        {
            return (ConvertList(list[0]) - ConvertList(list[2])).ToString();
        }


        static string DoMultiplication(List<string> list)
        {
            return (ConvertList(list[0]) * ConvertList(list[2])).ToString();
        }

        static string DoDivision(List<string> list)
        {
            return (ConvertList(list[0]) / ConvertList(list[2])).ToString();

        }

        static string DoSquared(List<string> list)
        {
            return Math.Pow(ConvertList(list[0]), ConvertList(list[2])).ToString();
        }


        static void updateFirstNum()
        {

        }

      
        // A method that looks at the operator value and determines the calculation that will happen.
        private static string ChooseCalcMethod(List<string> list)
        {
            OutputHandler.OutputList.Clear();
            //OutputHandler.OutputList.Add(GetLists(mainList));

            if (list[1] == "+")
            {
                return DoAddition(list);
            } else if (list[1] == "-")
            {
                return DoSubtraction(list);
            } else if (list[1] == "X") {
                return DoMultiplication(list);
            } else if (list[1] == "/") {
                return DoDivision(list);
            } else if (list[1] == "^")
            {
                return DoSquared(list);
            }
            return "ERROR!";
        }

        // A public method that returns the solution to the GUI
        public static string SendOutput(List<string> EntryList)
        {
            return ChooseCalcMethod(GetLists(EntryList));
        }

    }
}
