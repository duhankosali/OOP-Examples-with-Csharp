using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AddAClass
{
    class Employee
    {
        // Field tanımlamaları
        private string _firstName;
        private string _lastName;
        private List<Employee> _list; // Bir liste field tanımlaması yaptım.



        // Sınıflar arası etkileşim kurmak istediğimizde (Program.cs ve Employee.cs arasında) Property tanımlamamız gerekir.
        // Property içerisinde set ve get methodları ile Kapsülleme (Encapsulation) işlemi yapıyoruz. (set -> atama, yazma , get-> okuma, döndürme)
        public string FirstName 
        { 
            get { return _firstName; } set { _firstName = value; } 
        }
        // Expression bodied property accessors --- Control + NOKTA kullanarak kapsülleme yaptık.
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get; set; }
        public List<Employee> Employees => _list; // Liste property tanımlaması yaptım ---> get => _list
        


        public Employee() // constructor method.
        {
            _list = new List<Employee>();
        }

        public Employee(string firstName, string lastName, int age) // overloading edilmiş constructor method.
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this._list = new List<Employee>();
        }



        // Override (geçersiz kılma) işlemi
        // Generate Overrides menüsünden (CTRL + NOKTA ile açtık) seçerek ToString methodunu override etmek istediğimizi seçtik.
        public override string ToString()
        {
            //return base.ToString(); --> Önceden nesneyi döndürdüğümüzde otomatik bu method çalışıyordu.

            return $"{FirstName,-15} {LastName,-15} {Age}    --> Override"; // --> artık bu çalışacak
        }



        // METHOD OLUŞTURMA

        // Listeye Çalışan ve Çalışanlar ekleyen methodlarım.
       public void AddEmployee(Employee emp) // Method içine Employee türünde bir değişken alıyor. 
        {
            _list.Add(emp);     
        }

        public void AddEmployees(params Employee[] emps) // params --> Birden fazla kaydın doğrudan parametre olarak verilmesine olanak sağlar.
        {
            _list.AddRange(emps);      
        }

        // Çalışanları liste halinde döndüren method
        public List<Employee> GetEmployees() => _list; // return _list --> yazmanın bir alternatif yolu.
        
    }
}
