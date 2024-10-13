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

            // Check if the number is greater than zero
            if (input > 0)
            {
                Console.WriteLine($"{input} is positive.");
            }
            // Check if the number is less than zero
            else if (input < 0)
            {
                Console.WriteLine($"{input} is negative.");
            }
            // If the number is zero
            else
            {
                Console.WriteLine("The number is zero.");
            }
    }

    }
}