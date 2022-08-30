using System;

namespace SRP
{
    public class Space
    {
        public Space(Book book, String x, String y)
        {
            this.Book = book;
            this.X = x;
            this.Y = y;
        }

        public String X
        {
            get; set;
        }

        public String Y
        {
            get; set;
        }

        public Book Book
        {
            get; set;
        }
    }
}