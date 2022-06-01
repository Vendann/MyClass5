﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Program
    {
        static void Main()
        {
            Book b4 = new Book("Толстой Л.Н.", "Анна Каренина", "Знание", 1204, 2014, 103, true);
            Book b5 = new Book("Неш Т", "Программирование для профессионалов", "Вильямс", 1200, 2014, 108, true);
            Book.RetSrok += new Book.ProcessBookDelegate(Operation.MetodObrabotchik);
            b4.ReturnSrok = true;
            b5.ReturnSrok = true;
            Console.WriteLine("\nКниги возвращены в срок:");
            b4.ProcessPaperbackBooks(Operation.PrintTitle);
            b5.ProcessPaperbackBooks(Operation.PrintTitle);

            Console.ReadKey();
        }
    }
}
