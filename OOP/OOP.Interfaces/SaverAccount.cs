using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    public class SaverAccount : IBankAccount // Interface üyelerini otomatik olarak Implement eder. Aksi takdirde hata alırız.
    {
        // Arayüzümüzde tanımladığımız methodların iç (gövde) kısımları ilgili sınıflarda yapılır.
        // Birikim hesabı

        private decimal _balance;

        public decimal Balance => _balance; // return _balance --> 'nin bir alternatif gösterimi.

        public void PayIn(decimal amount)
        {
            //_balance = _balance + amount; 
            _balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            //throw new NotImplementedException();
            if (Balance>=amount)
            {
                _balance -= amount;
                return true;
            }

            Console.WriteLine("Yetersiz bakiye.");
            return false;   
        }

        public override string ToString() => $"Bank Saver: Balance = {_balance}"; // Tek satırlık return işlemleri methodlarda bu şekilde gösterilebilir.
        
    }
}
