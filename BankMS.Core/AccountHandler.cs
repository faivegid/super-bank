using BankMS.DataAccess;
using BankMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankMS.Core
{
    public class AccountHandler
    {
        public static Account CreateAccount(string userID, string accountType)
        {
            switch (accountType)
            {
                case "Current":
                    return new CurrentAccount(userID);
                case "Savings":
                    return new SavingsAccount(userID);
                default:
                    throw new ArgumentNullException();
            }
        }
        /// <summary>
        /// Transfer Funds between accounts
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="account"></param>
        public static List<Transaction> Tramsfer(string amount, string AccountNUmberFrom, string AccountNumberTo)
        {
            return new List<Transaction>(){
                TransactionHandler.AddTransactions("-"+amount, AccountNUmberFrom, $"Transfer to {AccountNumberTo}"),
                TransactionHandler.AddTransactions(amount, AccountNumberTo, $"Credit from {AccountNUmberFrom}")
                };
        }

        /// <summary>
        /// Debits an the account by the specified amount
        /// </summary>
        /// <param name="amount"></param>
        public static Transaction WithDraw(string amount, string AccountNumber)
        {
            return TransactionHandler.AddTransactions("-" + amount, AccountNumber, $"Withdrawal from ATM");
        }

        /// <summary>
        /// Deposite money into account
        /// </summary>
        /// <param name="amount"></param>
        public static Transaction Deposite(string amount, string AccountNumber)
        {
            return TransactionHandler.AddTransactions(amount, AccountNumber, $"Bank Deposite");
        }

        public static decimal GetBalance(IEnumerable<decimal> Amounts)
        {
            return Amounts.Sum();
        }

    }
}
