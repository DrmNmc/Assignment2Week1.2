﻿using System;
using System.Reflection.Metadata;
using System.Transactions;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {

            book bk1 = new book();
            bk1.SetTrans();
            bk1.Id = 1;
            bk1.Author = ("Miller");
            bk1.Title = ("The Book");
            
            book bk2 = new book();
            bk2.SetTrans();
            Console.WriteLine("Please enter the book ID: ");
            bk2.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the author name: ");
            bk2.Author = Console.ReadLine();
            Console.WriteLine("Please enter the book title: ");
            bk2.Title = Console.ReadLine();

            book bk3 = new book(3, "Flintstone", "Between a rock...");
            bk3.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the author name: ");
            string tempAuthor = Console.ReadLine();
            Console.WriteLine("Please enter the book name: ");
            string tempTitle = Console.ReadLine();
            book bk4 = new book(tempID, tempAuthor, tempTitle);
            bk4.SetTrans();

            displayMembers(bk1);
            displayMembers(bk2);
            displayMembers(bk3);
            displayMembers(bk4);

        }
        static void displayMembers(book item)
        {
            Console.WriteLine($"New Trans: {item.GetTrans()}");
            Console.WriteLine($"Book ID: {item.Id}");
            Console.WriteLine($"Book Author: {item.Author}");
            Console.WriteLine($"Book Title: {item.Title}");

        }
    }
    class book
    {
        private int _Id;
        private string _Author;
        private string _Title;
        private static int _transactions;

        public book() { }

        public book(int id, string author, string title, int transactions = 0)
        {
            _Id = id;
            _Author = author;
            _Title = title;
            _transactions = transactions;
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }
        public void SetTrans()
        {
            _transactions++;
        }

        public int GetTrans()
        {
            return _transactions;
        }
    }
}