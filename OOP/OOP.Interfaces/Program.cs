using System;

namespace OOP.Interfaces
{

    class Program
    {
        static void Main(string[] args)
        {
            var saver = new SaverAccount();

            Console.WriteLine(saver);

            saver.PayIn(500);
            saver.Withdraw(200);

            Console.WriteLine(saver.Balance);


            Console.ReadKey();
        }
    }
}
