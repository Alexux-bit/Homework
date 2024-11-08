using System;

namespace StringOpp
{
    class Nume
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string: ");
            string FirstString = Console.ReadLine();

            Console.WriteLine("Enter the second string: ");
            string SecondString = Console.ReadLine();

            Console.WriteLine("Choose the operation:");
            Console.WriteLine("1. Concatenation");
            Console.WriteLine("2. Convert first string to Uppercase");
            Console.WriteLine("3. Convert second string to Lowercase");
            Console.WriteLine("4. Display length of the first string");
            Console.WriteLine("Enter your choice (1-4): ");

            string choice = Console.ReadLine();
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    string concatenate = FirstString + SecondString;
                    Console.WriteLine($"The concatenation result is: {concatenate}");
                    break;

                case "2":
                    string upperCase = FirstString.ToUpper();
                    Console.WriteLine($"The first string in uppercase is: {upperCase}");
                    break;

                case "3":
                    string lowerCase = SecondString.ToLower();
                    Console.WriteLine($"The second string in lowercase is: {lowerCase}");
                    break;

                case "4":
                    int length = FirstString.Length;
                    Console.WriteLine($"The length of the first string is: {length}");
                    break;

                default:
                    Console.WriteLine("Not a valid choice, enter a number between 1 and 4.");
                    break;
            }
        }
    }
}
