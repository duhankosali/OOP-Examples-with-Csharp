using System;
using System.Collections.Generic;

namespace OOP.Interfaces.IComparables_T
{
    class Program
    {
        static void Main(string[] args)
        {
            // IComparables<T> --> Bir nesneye karşılaştırılabilir olma özelliği kazandırmamızı sağlayan Interface'in Generic yapılı hali.

            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FullName = "Duhan Kösali",
                    Salary = 7500
                },

                new Employee()
                {
                    Id = 2,
                    FullName = "Batuhan Kösali",
                    Salary = 16750
                },

                new Employee()
                {
                    Id = 3,
                    FullName = "Arzu Kösali",
                    Salary = 20000
                },

                new Employee()
                {
                    Id = 4,
                    FullName = "Ekrem Kösali",
                    Salary = 9000
                },

            };

            employees.Sort(); // Sort --> Employees sınıfı içindeki CompareTo() methodunu arıyor ve ona göre sıralama işlemi yapıyor.
                              // Biz CompareTo() 'nun Fullname'e göre sıralamasını söyledik.

            Console.WriteLine($"{"Id",-5} {"Full Name",-20} {"Salary",-10}");

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }



            Console.ReadKey();
        }
    }
}
