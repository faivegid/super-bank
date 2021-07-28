using System;
using System.Collections.Generic;

namespace BankMS.Model
{
    public abstract class Account
    {
        public string AccountID { get; protected set; }
        public string AccountNumber { get; set; }

        protected static int _accountSeed = 31023;

        protected decimal minBalance;
        public AccountType Type { get; protected set; }

    }
}
