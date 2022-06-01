using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Book : Item
    {
        private String author; // автор
        private String title; // название
        private String publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания

        private static double price = 9;

        public void SetBook(String author, String title, String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        
        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public override void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n Издательство: {3}\n {4} стр.\n Стоимость аренды: {5}", author, title, year, publisher, pages, Book.price);
            base.Show();
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }

        public Book(String author, String title, String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book()
        {
        }

        static Book() //статический конструктор
        {
            price = 10;
        }

        public Book(String author, String title)
        {
            this.author = author;
            this.title = title;
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public Book(String author, String title, String publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public override void Return() // операция "вернуть"
        {
            if (ReturnSrok == true) taken = true;
            else taken = false;
        }
        public delegate void ProcessBookDelegate(Book book);
        public static event ProcessBookDelegate RetSrok;
        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
        {
            if (ReturnSrok) processBook(this);
        }

        private bool returnSrok = false;
        public bool ReturnSrok
        {
            get
            {
                return returnSrok;
            }
            set
            {
                returnSrok = value;
                if (ReturnSrok == true) RetSrok(this);
            }
        }
        public override string ToString()
        {
            return this.title + ", " + this.author + " Инв. номер " + this.invNumber;
        }
    }
}
