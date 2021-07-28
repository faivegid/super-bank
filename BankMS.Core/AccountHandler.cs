using BankMS.Model;
using System;

namespace BankMS.Core
{
    public class AccountHandler
    {
        public Account CreateAccount(string userID, AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Current:
                    return new CurrentAccount(userID);
                case AccountType.Savings:
                    return new SavingsAccount(userID);
                default:
                    throw new ArgumentNullException();
            }
        }

        public static Account CreateAccount(string userID,string AccountNumber, AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Current:
                    return new CurrentAccount(userID, AccountNumber);
                case AccountType.Savings:
                    return new SavingsAccount(userID, AccountNumber);
                default:
                    throw new ArgumentNullException();
            }
        }

        public static Account CreateAccount(string userID, string AccountNumber, string accountType)
        {
            switch (accountType)
            {
                case "Current":
                    return new CurrentAccount(userID, AccountNumber);
                case "Savings":
                    return new SavingsAccount(userID, AccountNumber);
                default:
                    throw new ArgumentNullException();
            }
        }


    }
}
