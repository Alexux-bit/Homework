using System.IO;

namespace Nume {

    public class Basic {

        public void PerformBasicMathOperations()
        {
            int a = 22;
            int b = 4;
            
            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
            
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
            
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
            
            Console.WriteLine($"Division: {a} / {b} = {a / b}");
            
            Console.WriteLine($"Modulus: {a} % {b} = {a % b}");
        }
    }
}