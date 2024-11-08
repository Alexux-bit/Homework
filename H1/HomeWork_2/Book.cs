using System;
using System.Dynamic;
using System.Reflection;

namespace LibrarySystem
{
    public class Book
    {
       
        private string author;
        public string Author{
            get{return author;}
            set{author = value;}
        }


        private int pages;

        public int Pages{
            get{return pages;}
            set{pages = value;}
        }
        
        
        
        private bool ischeckedout;
        public bool IsCheckedOut{
            get{return ischeckedout;}
            set{ischeckedout = value;}
        }


         private string title;
        public string Title{
            get{return title; }
            set{title = value; }

        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Pages = 100; 
            IsCheckedOut = false;
        }
        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
            IsCheckedOut = false;
        }

        public void CheckOut()
        {
            ischeckedout = true;
        }

        public void ReturnBook()
        {
            ischeckedout = false;
        }

        public override string ToString()
        {
            return $"Title: {title}, Author: {author}, Pages: {pages}, Checked Out: {(ischeckedout ? "Yes" : "No")}";
        }
    }
}