using BankMS.DataAccess;
using System;
using BankMS.Model;

namespace BankMS.Core
{
    public class TransactionRepository
    {
        public static Transaction AddTransactions(string amount, string AccountNum, string note)
        {
            return new Transaction()
                    {
                        tAmount = amount,
                        tDate = DateTime.Now,
                        tNote = note,
                        AccountNumber = AccountNum
                    };
        }
    }
}
