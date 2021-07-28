using System;
using System.Collections.Generic;
using System.Text;

namespace BankMS.Model
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(string UserId)
        {
            AccountID = UserId;
            Type = AccountType.Savings;
            minBalance = 1000.00m;
            _balance = 0;
            AccountNumber = string.Concat(315, _accountSeed.ToString().Substring(0,3), 34, _accountSeed.ToString().Substring(3, 2));
            _accountSeed += 29081;
        }
        public SavingsAccount(string UserId, string accountNumber)
        {
            AccountID = UserId;
            this.AccountNumber = AccountNumber;
            Type = AccountType.Savings;
        }
    }
}
