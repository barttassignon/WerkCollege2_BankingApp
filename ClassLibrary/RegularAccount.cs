using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class RegularAccount : Account
    {
        public List<string> CreditCards { get; set; }
        public override string AccountType => GetType().ToString();

        public RegularAccount(string iban, decimal balance, DateTime creationdate, decimal interest, List<string> creditCards = null) : base(iban, balance, creationdate, interest)
        {
            if (creditCards == null)
            {
                CreditCards = new List<string>();
            }
            else
            {
                CreditCards = creditCards;
            }
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
               "Credit Cards: " + string.Join(", ", CreditCards);
        }
    }
}
