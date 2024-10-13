using System.ComponentModel.Design;
using System.Threading.Tasks.Dataflow;
using name;

namespace Nume{
    class Progam {
        static void Main (string[]args){

             int input;
            string strNumber;

            Console.WriteLine("Applications");
            Console.WriteLine("Select an option");
            Console.WriteLine("1 Basic Math applications");
            Console.WriteLine("2 Data Types");
            Console.WriteLine("3 Loop demonstrations");
            Console.WriteLine("4 Conditional Statements");
            Console.WriteLine("5 Exit Applications");
            Console.WriteLine("Please choose an obtion from 1 to 5");
            
            strNumber = Console.ReadLine();
            input = int.Parse(strNumber);

                if(input == 1) {
                    Basic Maths = new Basic();
                    Maths.PerformBasicMathOperations();
                }

                if(input == 2) {
                    Original myOriginal = new Original();
                    myOriginal.DisplayDataTypes();                    
                }

                if(input == 3) {
                    Loops y = new Loops();
                    y.demonstrations();
                }
             
                if(input == 4) {
                    Conditionalstatement x = new Conditionalstatement();
                 x.CheckNumber();
                }

                if(input == 5){
                    Console.WriteLine("Goodbye");
                }

                if(input < 1 || input > 5) {
                    Console.WriteLine ("Not a valid option");
                }

            }
        }
    }
