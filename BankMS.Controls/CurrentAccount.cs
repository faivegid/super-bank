using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BankMS.Model
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(string UserId)
        {
            AccountID = UserId;
            Type = AccountType.Current;
            minBalance = 0.00m;
            AccountNumber = string.Concat(310, GenerateAccountNum(), 45);
        }
        public CurrentAccount(string userID, string AccountNumber)
        {
            AccountID = userID;
            this.AccountNumber = AccountNumber;
            Type = AccountType.Current;
        }

    }
}
