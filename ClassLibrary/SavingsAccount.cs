using System;

namespace ClassLibrary
{
    class SavingsAccount : Account
    {
        public decimal LoyaltyBonus { get; set; }

        public SavingsAccount(string iban, decimal balance, DateTime creationdate, decimal interest, decimal loyaltiBonus) : base(iban, balance, creationdate, interest)
        {
            LoyaltyBonus = loyaltiBonus;
        }
    }
}
