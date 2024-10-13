using System.IO;

namespace name{

public class Conditionalstatement {

    public void CheckNumber()
    {
             int input;
            string strNumber;
            Console.WriteLine ("choose any number");
            strNumber = Console.ReadLine();
            input = int.Parse(strNumber);

            if (input > 0)
            {
                Console.WriteLine($"{input} is positive.");
            }
            
            else if (input < 0)
            {
                Console.WriteLine($"{input} is negative.");
            }

            else
            {
                Console.WriteLine("The number is zero.");
            }
    }

    }
}