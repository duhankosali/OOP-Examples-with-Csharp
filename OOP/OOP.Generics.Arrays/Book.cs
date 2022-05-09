using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics.Arrays
{
    public class Book
    {
        public Book() // parametresiz ctor, newlenebilir bir yapı belirtir.
        {

        }

        public Book(int id, string title, decimal price) // overloading ctor
        {
           Id = id;
            Title = title;
            Price = price;
        }

        public int Id { get; set; } 
        public string Title { get; set; }
        public decimal Price { get; set; }

        public override string ToString() // override
        {
            return $"{Id,-5} {Title,-20} {Price,-10}"; 
            //return base.ToString();
        }
    }
}
