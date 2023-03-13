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
        

        
        static int Total = 0;

        static int SendOutput()
        {
            return OutputHandler.Total;
        }

       // public void 

        static List<List<string>> GetLists(List<string> mainList){
            
            List<List<string>> itemsList = new List<List<string>>();
            
            bool operatorFound = false;

            foreach(var item in mainList)
            {
                if(item == "+" || item == "-" || item == "X" || item == "/")
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
            itemsList.Add(FirstNum);
            itemsList.Add(Operator);
            itemsList.Add(SecondNum);
            return itemsList;
        }

        

        static float ConvertList(List<string> originalList)
        {
            //List<int> intList = new List<int>();

            

            return (float.Parse(string.Join("", originalList)));
        }


        static string DoAddition(List<List<string>> list)
        {
            return (ConvertList(list[0]) + ConvertList(list[2])).ToString();
                
        }
        
        static void updateFirstNum()
        {

        }

       public static string Main(List<string> mainList)
        {
            
            List<List<string>> fullList = GetLists(mainList);
            //mainList.Clear();
            return DoAddition(fullList);
        }
    }
}
