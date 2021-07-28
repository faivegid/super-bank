using System;
using System.Collections.Generic;
using System.Text;

namespace BankMS.Model
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(string UserId)
        {
            AccountID = UserId;
            Type = AccountType.Current;
            minBalance = 0.00m;
            _balance = 0;
            AccountNumber = string.Concat(310, _accountSeed, 45);
            _accountSeed += 45080;
        }
        public CurrentAccount(string userID, string AccountNumber)
        {
            AccountID = userID;
            this.AccountNumber = AccountNumber;
            Type = AccountType.Current;
        }

    }
}
