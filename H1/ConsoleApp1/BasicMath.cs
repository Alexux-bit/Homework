using System.IO;

namespace Nume {

    public class Basic {

        public void PerformBasicMathOperations()
        {
            // Declare and initialize two integers
            int a = 10;
            int b = 5;
            
            // Perform and display addition
            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
            
            // Perform and display subtraction
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
            
            // Perform and display multiplication
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
            
            // Perform and display division
            Console.WriteLine($"Division: {a} / {b} = {a / b}");
            
            // Perform and display modulus (remainder)
            Console.WriteLine($"Modulus: {a} % {b} = {a % b}");
        }
    }
}