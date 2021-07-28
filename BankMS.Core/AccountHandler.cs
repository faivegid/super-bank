using BankMS.DataAccess;
using BankMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankMS.Core
{
    public class AccountHandler
    {
        public static void CreateAccount(string userID, AccountType accountType, IWriter writer)
        {
            switch (accountType)
            {
                case AccountType.Current:
                    writer.SaveAccount(new CurrentAccount(userID));
                    break;
                case AccountType.Savings:
                    writer.SaveAccount(new SavingsAccount(userID));
                    break;
                default:
                    throw new ArgumentNullException();
            }
        }
        /// <summary>
        /// Transfer Funds between accounts
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="account"></param>
        public static void Tramsfer(decimal amount, string AccountNUmberFrom, string AccountNumberTo, IWriter writer)
        {
            TransactionHandler.AddTransactions(amount.ToString("0.00"), AccountNumberTo, $"Credit from {AccountNumberTo}", writer);
        }

        /// <summary>
        /// Debits an the account by the specified amount
        /// </summary>
        /// <param name="amount"></param>
        public static void WithDraw(string amount, string AccountNumber, IWriter writer)
        {
            TransactionHandler.AddTransactions(amount, AccountNumber, $"Withdrawal from ATM", writer);

        }

        /// <summary>
        /// Deposite money into account
        /// </summary>
        /// <param name="amount"></param>
        public static void Deposite(string amount, string AccountNumber, IWriter writer)
        {
            TransactionHandler.AddTransactions(amount, AccountNumber, $"Bank Deposite", writer);
        }

        public static decimal GetBalance(IEnumerable<decimal> Amounts)
        {
            return Amounts.Sum();
        }
        
    }
}
