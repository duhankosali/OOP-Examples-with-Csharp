using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.IComparables
{
    public class Employee : IComparable
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Id,-5} {FullName,-20} {Salary,-10}";

            //return base.ToString();
        }


        // IComparable interface ait olan method.
        public int CompareTo(object obj) 
        {
            //throw new NotImplementedException();
            var other = (Employee)obj; // other Employee türünde bir nesnedir.

            return this.Salary.CompareTo(other.Salary);


            //// YÖNTEM 2:
            //if(this.Salary<other.Salary)
            //    return -1; 

            //else if(this.Salary==other.Salary)
            //    return 0;

            //else
            //    return 1;

        }
    }
}
