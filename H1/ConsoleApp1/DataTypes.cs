using System.IO;

using System;

namespace Nume
{
    public class Original {


        public void DisplayDataTypes()
        {
            int integerValue = 4;
            
            double doubleValue = 3.14;
            
            decimal decimalValue = 29.99m;
            
            char characterValue = 'C';
            
            string stringValue = "Hello, World!";
            
            bool booleanValue = true;

            Console.WriteLine($"Integer: {integerValue}");
            Console.WriteLine($"Double: {doubleValue}");
            Console.WriteLine($"Decimal: {decimalValue}");
            Console.WriteLine($"Character: {characterValue}");
            Console.WriteLine($"String: {stringValue}");
            Console.WriteLine($"Boolean: {booleanValue}");
        }

    }
}

