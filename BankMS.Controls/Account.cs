using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BankMS.Model
{
    public abstract class Account
    {
        public string AccountID { get; protected set; }
        public string AccountNumber { get; set; }

        protected decimal minBalance;
        public AccountType Type { get; protected set; }

        protected string GenerateAccountNum()
        {
            string rand = string.Concat(Guid.NewGuid().ToString().Take(20));
            string pattern = @"[0-9]";
            MatchCollection matches = Regex.Matches(rand, pattern);
            string numStr = string.Concat(matches);
            numStr = string.Concat(numStr.Take(5));
            return numStr;
        }

    }
}
