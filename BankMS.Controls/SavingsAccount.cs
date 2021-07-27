using System;
using System.Collections.Generic;
using System.Text;

namespace BankMS.Model
{
    class SavingsAccount : Account
    {
        public SavingsAccount(string UserId)
        {
            Id = UserId;
            Type = AccountType.Savings;
            minBalance = 1000.00m;
            _balance = 0;
            AccountNumber = string.Concat(315, _accountSeed.ToString().Substring(0,3), 34, _accountSeed.ToString().Substring(3, 2));
            Transactions = new List<Transaction>();
        }       
    }
}
