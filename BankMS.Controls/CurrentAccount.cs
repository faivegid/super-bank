using System;
using System.Collections.Generic;
using System.Text;

namespace BankMS.Model
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(string UserId)
        {
            Id = UserId;
            Type = AccountType.Current;
            minBalance = 0.00m;
            _balance = 0;
            AccountNumber = string.Concat(310, _accountSeed, 45);
            Transactions = new List<Transaction>();
            _accountSeed += 45080;
        }

    }
}
