using System;

namespace appStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal netPrice;
            Book book1 = new Book("C#01", "C# Programming", "Thomas Mathew", "C# Programming for Beginners", "MacMillan Publishers", 450);
            book1.DisplayBookInfo();
            netPrice = book1.GetNetPrice();
            Console.WriteLine($"Net Price {netPrice:C2}");
            Console.ReadKey();

        }
    }

    struct Book
    {
        public string id, title, author, subject, publisher;
        decimal price;

        public Book(string bookId, string bookTitle, string bookAuthor, string bookSubject, string bookPublisher, decimal bookPrice)
        {
            id = bookId;
            title = bookTitle;
            author = bookAuthor;
            subject = bookSubject;
            publisher = bookPublisher;
            price = bookPrice;
        }
        
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Book Id: {id}");
            Console.WriteLine($"Book title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Book Publisher: {publisher}");
            Console.WriteLine($"Book Price: {price:C2}");

        }

        public decimal GetNetPrice()
        {
            decimal tax = price * 13 / 100;
            return (price + tax);

        }
    }
}
