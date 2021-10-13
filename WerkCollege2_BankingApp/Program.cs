using ClassLibrary;
using System;
using System.Collections.Generic;

namespace WerkCollege2_BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var cards = new List<string> { "1234", "5678" };
            var regular = new RegularAccount("BE12 3456 7890 1234", 1000M, DateTime.Now, 0.05M, cards);
            Console.WriteLine(regular.ToString());
        }


    }
}
