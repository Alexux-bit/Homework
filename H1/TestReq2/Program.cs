using System;

namespace OriginalNameForNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the book title: ");
                string title = Console.ReadLine();

                Console.Write("Enter the book author: ");
                string author = Console.ReadLine();

                Console.Write("Enter the number of pages: ");
                int pageNumber = int.Parse(Console.ReadLine());

                Book OriginalBookName = new Book
                {
                    Title = title,
                    Author = author,
                    PageNumber = pageNumber
                };
                OriginalBookName.DisplayInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
          
        }
    }
}