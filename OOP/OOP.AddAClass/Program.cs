

using System;
using System.Collections.Generic;

namespace OOP.AddAClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();

            Console.WriteLine("Liste yapısı: ");

            // Nesneleri bir liste üzerinde tutalım --> System.Collections.Generic
            var employees = new List<Employee>()
            {
                // Listemize elemanlar ekliyoruz.

                new Employee // Normal constructor method kullanarak eleman tanımlama
                {
                    FirstName = "Duhan",
                    LastName = "Kösali",
                    Age = 21
                },

                new Employee
                {
                    FirstName = "Batuhan",
                    LastName = "Kösali",
                    Age = 28
                },
                
                new Employee("Ekrem", "Kösali", 57), // Overloading edilmiş Constructor method kullanarak nesne tanımlaması yapıyoruz.
                new Employee("Arzu", "Kösali", 49),
            };

            // Listelerle ilgili daha fazla bilgi --> https://www.yazilimkodlama.com/programlama/c-liste-list-kullanimi/
            //employees.Add(employee5); --> Listeye eleman ekler
            //employees.Remove(employee2); --> Listeden eleman çıkarır       
            //Console.WriteLine(employees.Count); --> Listenin uzunluğunu verir.

            foreach (var item in employees) // employees isimli nesnemin itemleri
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------------------------");

            //Console.WriteLine(employees[2]);


            // METHOD İLE ELEMAN İŞLEMLERİ

            var emp = new Employee();
            emp.AddEmployee(
                new Employee 
                { FirstName = "Taylan", 
                    LastName = "Duran", 
                    Age = 21 
                }); // Tekli eleman ekleme fonksiyonu
            emp.AddEmployee(new Employee("Ata", "Kocaer", 22));

            emp.AddEmployees(
                new Employee { FirstName = "Eren", LastName = "Boğatepe", Age = 21 },
                new Employee("Selin", "Öksüz", 22),
                new Employee("Mine", "Evren", 28)
                ); // Çoklu eleman ekleme fonksiyonu (params parametresi ile sınırsız kayıt ekleyebiliyoruz.)

            var list = emp.GetEmployees();
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }




            Console.ReadLine();
        }
    }
}
