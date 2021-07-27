using System;
using System.Text.RegularExpressions;

namespace BankMS.Common
{
    public class Validation
    {
        public static bool CheckName(string name)
        {
            string strRegex = @"^[A-Z]";

            return PerformRegEx(strRegex, name);
        }

        public static bool CheckEmail(string email)
        {
            string strRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return PerformRegEx(strRegex, email);

        }

        public static bool CheckPassword(string password)
        {
            string strRegex = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$";
            return PerformRegEx(strRegex, password);
        }


        private static bool PerformRegEx(string pattern, string value)
        {
            Regex re = new Regex(pattern);

            return re.IsMatch(value) ? true : false ;
        }

    }
}
