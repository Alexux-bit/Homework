using System;

namespace OriginalNameForNameSpace
{
    public class Book
    {
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be empty.");
                }
                title = value;
            }
        }
        private string author;
        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Author cannot be empty.");
                }
                author = value;
            }
        }
        private int pageNumber;
        public int PageNumber
        {
            get { return pageNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Page number must be a positive integer.");
                }
                pageNumber = value;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine("\nBook Information:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Number of Pages: {PageNumber}");
        }
    }
}