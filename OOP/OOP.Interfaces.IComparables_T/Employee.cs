using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.IComparables_T
{
    public class Employee : IComparable<Employee> // IComparable<T> interface --> Normal IComparable'den farkı bir nesneden türüyor olması (Generic yapıda olması)
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Id,-5} {FullName,-20} {Salary,-10}";

            //return base.ToString();
        }


        // IComparable<T> interface ile gelen method. 
        public int CompareTo(Employee other)
        {
            //throw new NotImplementedException();

            return this.FullName.CompareTo(other.FullName); // İsme göre sıralama yapıyoruz.
        }
    }
}
