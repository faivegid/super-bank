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
            string pattern = @"\d";
            MatchCollection matches = Regex.Matches(pattern, rand);
            string numStr = string.Concat(matches);
            int num = int.Parse(string.Concat(numStr.Take(4))) + int.Parse(string.Concat(numStr.Take(7)));
            return string.Concat(num.ToString().Take(5));
        }

    }
}
