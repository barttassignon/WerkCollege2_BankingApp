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
            var klanten = new List<Client>();
            klanten.Add(new Client("Bart", "Tassignon"));
            klanten.Add(new Client("Liesbet", "Merens"));


            rekeningen.Add(new RegularAccount("BE123 4567", 1000M, DateTime.Now, 0.02M, klanten[0]));
            rekeningen.Add(new SavingsAccount("BE456 7890", 2500M, DateTime.Now, 0.05M, klanten[1], 0.02M));

            foreach (var rekening in rekeningen)
            {
                Console.WriteLine(rekening);
                Console.WriteLine();
            }
        }
    }
}
