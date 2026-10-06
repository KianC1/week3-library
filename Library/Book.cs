using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Library
{
    public class Book
    {
        public String Title;
        public String Author;
        public int ISBN;
    

    public void DisplayBookInfo(Book book)
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
        }
    }
}
