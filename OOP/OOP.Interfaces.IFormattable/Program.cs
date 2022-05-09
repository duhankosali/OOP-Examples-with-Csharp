using System;
using System.Collections.Generic;

namespace OOP.Interfaces.IFormattables
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("U"));

            var list = new List<Employee>
            {
                new Employee()
            {
                 Id = 1,
                 Title = "Prof. Dr.",
                 FirstName = "Duhan",
                 LastName = "Kösali",
            },

                new Employee()
            {
                 Id = 2,
                 Title = "Doç. Dr.",
                 FirstName = "Taylan",
                 LastName = "Duran",
            },

                new Employee()
            {
                 Id = 3,
                 Title = "Prof. Dr.",
                 FirstName = "Ahmet",
                 LastName = "Çözer",
            }

        };


            foreach (var employee in list)
            {
                Console.WriteLine(employee.ToString());
            }



            Console.ReadKey();
        }
    }
}
