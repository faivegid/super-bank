using BankMS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BankMS.DataAccess
{
    public class CSVWriter : IWriter
    {
        string accountFilePath = @"C:\Users\hp\Documents\Projects\BankMS\DataBase\Accounts\AccountsDataBase.csv";
        string transactionFilePath = @"C:\Users\hp\Documents\Projects\BankMS\DataBase\Transactions";
        string userFilePath = @"C:\Users\hp\Documents\Projects\BankMS\DataBase\Users\UserDataBase.csv";

        public bool SaveAccount(Account account)
        {
            File.AppendAllText(accountFilePath, $"{account.AccountID},{account.AccountNumber},{account.Type}");
            return true;
        }

        public bool SaveTransactions(Transaction transaciton)
        {
            File.AppendAllText(Path.Combine(transactionFilePath, $"{transaciton.AccountNumber}"), $"{transaciton.AccountNumber},{transaciton.tAmount},{transaciton.tNote},{transaciton.tDate}");
            return true;
        }

        public bool SaveUser(UserModel user)
        {
            File.AppendAllText(userFilePath, $"{user.Id},{user.Email},{user.Password},{user.FirstName},{user.LastName}");
            return true;
        }
    }
}
