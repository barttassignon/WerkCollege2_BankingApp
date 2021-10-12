using System;

namespace ClassLibrary
{
    class SavingsAccount : Account
    {
        public decimal LoyaltyBonus { get; set; }

        public SavingsAccount(string iban, decimal balance, DateTime creationdate, decimal interest, decimal loyaltyBonus) : base(iban, balance, creationdate, interest)
        {
            LoyaltyBonus = loyaltyBonus;
        }

        public override string ToString()
        {
            return base.ToString() + $", Loyalty Bonus: {LoyaltyBonus:C}.";
        }
    }
}
