using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");

            Space Lib1 = new Space(book1, "A", "7");
            Space Lib2 = new Space(book2, "B", "3");

            Console.WriteLine(Lib1);

            Console.ReadLine();

        }
    }
}