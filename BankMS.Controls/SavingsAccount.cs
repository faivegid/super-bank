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
            AccountNumber = string.Concat(315, _accountSeed.ToString().Substring(0,3), 34, _accountSeed.ToString().Substring(3, 2));
            _accountSeed += 29081;
        } 
    }
}
