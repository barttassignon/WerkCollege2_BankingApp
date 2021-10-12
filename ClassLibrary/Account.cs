﻿using System;

namespace ClassLibrary
{
    class Account
    {
        public string IBAN { get; set; }
        private decimal Balance { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Interest { get; set; }

        public Account(string iban, decimal balance, DateTime creationdate, decimal interest)
        {
            IBAN = iban;
            Balance = balance;
            CreationDate = creationdate;
            Interest = interest;
        }

        /// <summary>
        /// Method to add an amount to the Balance
        /// </summary>
        /// <param name="amount">The ammount to be added</param>
        /// <exception cref="ArgumentException">Thrown when amount = 0</exception>
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                throw new ArgumentException("Deposited amount must be higher than 0!");
            }
        }

        /// <summary>
        /// Method to withdraw from Balance
        /// </summary>
        /// <param name="amount">The amount to substract</param>
        /// <exception cref="ArgumentException">Thrown when amount is 0 or negative.</exception>
        /// <exception cref="InvalidOperationException">Thrown when </exception>
        public void Withdraw(decimal amount)
        {
            decimal minimumBalance = -1000;

            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawn amount must be a positive number!");
            }

            if (Balance - amount >= minimumBalance)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException($"Withdrawal would exceed the minimum balance of {minimumBalance}.");
            }
        }

        public override string ToString()
        {
            return $"IBAN: {IBAN}, Balance: {Balance:C}, Creation Date: {CreationDate:d}, Interest: {Interest}";
        }

    }
}