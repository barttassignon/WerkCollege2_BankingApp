using System;

namespace ClassLibrary
{
    public class SavingsAccount : Account
    {
        public decimal LoyaltyBonus { get; set; }
        public override string AccountType => GetType().ToString();

        public SavingsAccount(string iban, decimal balance, DateTime creationdate, decimal interest, Client client, decimal loyaltyBonus) : base(iban, balance, creationdate, interest, client)
        {
            LoyaltyBonus = loyaltyBonus;
        }

        public override string ToString()
        {
            return base.ToString() + $", Loyalty Bonus: {LoyaltyBonus:C}.";
        }
    }
}
