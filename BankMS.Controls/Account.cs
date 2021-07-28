using System;
using System.Collections.Generic;

namespace BankMS.Model
{
    public abstract class Account
    {
        public string AccountID { get; protected set; }

        public string AccountNumber { get; set; }

        protected decimal _balance;

        protected static int _accountSeed = 31023;

        protected decimal minBalance;
        public AccountType Type { get; protected set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        /// <summary>
        /// Transfer Funds between accounts
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="account"></param>
        public void Tramsfer(decimal amount, Account account)
        {
            if (minBalance <= (_balance - amount))
            {
                Debit(amount);
                Transactions.Add(new Transaction()
                {
                    tAmount = amount.ToString("0.00"),
                    tDate = DateTime.Now,
                    tNote = $"Transfer to {account.AccountNumber}"
                });

                account.Credit(amount);
                account.Transactions.Add(new Transaction()
                {
                    tAmount = amount.ToString("0.00"),
                    tDate = DateTime.Now,
                    tNote = $"Credit from {AccountNumber}"
                });
            }
            throw new Exception("Insufficient Funds");
        }

        /// <summary>
        /// Debits an the account by the specified amount
        /// </summary>
        /// <param name="amount"></param>
        public void WithDraw(decimal amount)
        {
            if (minBalance <= (_balance - amount))
            {
                Debit(amount);
                Transactions.Add(new Transaction()
                {
                    AccountNumber = AccountNumber,
                    tAmount = amount.ToString("0.00"),
                    tDate = DateTime.Now,
                    tNote = $"Withdrawal from ATM"
                }); 
            }
            throw new Exception("Insufficient Funds");
        }

        /// <summary>
        /// Gets account balance of account
        /// </summary>
        /// <returns>account balance</returns>
        public decimal GetBalance()
        {
            return _balance;
        }

        /// <summary>
        /// Deposite money into account
        /// </summary>
        /// <param name="amount"></param>
        public void Deposite(decimal amount)
        {
            Credit(amount);
            Transactions.Add(new Transaction()
            {
                tAmount = amount.ToString("0.00"),
                tDate = DateTime.Now,
                tNote = $"Bank Deposite"
            });
        }

        /// <summary>
        /// adds amount to balance
        /// </summary>
        /// <param name="amount"></param>
        internal void Credit(decimal amount)
        {
            _balance += amount;
        }

        /// <summary>
        /// Reduces amount from balance
        /// </summary>
        /// <param name="amount"></param>
        internal void Debit(decimal amount)
        {
            _balance -= amount;
        }
    }
}
