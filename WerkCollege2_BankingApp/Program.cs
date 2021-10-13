using ClassLibrary;
using System;
using System.Collections.Generic;

namespace WerkCollege2_BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var rekeningen = new List<Account>();

            rekeningen.Add(new RegularAccount("BE123 4567", 1000M, DateTime.Now, 0.02M));
            rekeningen.Add(new SavingsAccount("BE456 7890", 2500M, DateTime.Now, 0.05M, 0.02M));

            foreach (var rekening in rekeningen)
            {
                Console.WriteLine(rekening);
                Console.WriteLine();
            }
        }


    }
}
