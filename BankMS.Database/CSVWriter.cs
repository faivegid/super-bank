using BankMS.Model;
using System.Collections.Generic;
using System.IO;

namespace BankMS.DataAccess
{
    public class CSVWriter : IWriter
    {
        string accountFilePath = @"C:\Users\hp\Documents\Projects\BankMS\DataBase\Accounts\AccountsDataBase.csv";
        string transactionFilePath = @"C:\Users\hp\Documents\Projects\BankMS\DataBase\Transactions\Transactions.csv";
        string userFilePath = @"C:\Users\hp\Documents\Projects\BankMS\DataBase\Users\UserDataBase.csv";

        public bool SaveAccount(Account account)
        {
            File.AppendAllText(accountFilePath, $"{account.AccountID},{account.AccountNumber},{account.Type}\n");
            return true;
        }

        public bool SaveTransactions(Transaction transaciton)
        {
            File.AppendAllText(transactionFilePath, $"{transaciton.AccountNumber}, {transaciton.tAmount},{transaciton.tNote},{transaciton.tDate.ToShortDateString()}\n");            
            return true;
        }

        public bool SaveUser(UserModel user)
        {
            File.AppendAllLines(userFilePath, new List<string>(){ $"{user.Id},{user.Email},{user.Password},{user.FirstName},{user.LastName}\n"});
            return true;
        }
    }
}
