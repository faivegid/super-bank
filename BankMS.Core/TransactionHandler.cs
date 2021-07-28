using BankMS.DataAccess;
using System;
using BankMS.Model;

namespace BankMS.Core
{
    public class TransactionHandler
    {
        public static void AddTransactions(string amount, string AccountNUmber, string note, IWriter writer)
        {
            writer.SaveTransactions(new Transaction()
            {
                tAmount = amount,
                tDate = DateTime.Now,
                tNote = note
            });
        }
    }
}
