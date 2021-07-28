using BankMS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BankMS.Core;
namespace BankMS.DataAccess
{
    public class CSVReader : IReader
    {
        string accountFilePath = @"C:\Users\hp\Documents\Projects\BankMS\DataBase\Accounts\AccountsDataBase.csv";
        string transactionFilePath = @"C:\Users\hp\Documents\Projects\BankMS\DataBase\Transactions";
        string userFilePath = @"C:\Users\hp\Documents\Projects\BankMS\DataBase\Users\UserDataBase.csv";

        public IEnumerable<Account> GetAccounts()
        {
            string[] accountArray = File.ReadAllLines(accountFilePath);
            IEnumerable<(string AccountId, string AccountNumber, string accountType)> accountList = from line in accountArray
                              select (AccountId: line.Split(' ')[0], AccountNumber: line.Split(' ')[1], accountType: line.Split(' ')[2]);
            return (IEnumerable<Account>)accountList;
        }
        public IEnumerable<Transaction> GetTransactions()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetUsers()
        {
            string[] userArray = File.ReadAllLines(userFilePath);
            var userList = from line in userArray
                           select (Id: line.Split(',')[0], Email: line.Split(',')[1],
                           Password: line.Split(',')[2], FirstName: line.Split(',')[3], LastName: line.Split(',')[4]);
            return (IEnumerable<UserModel>)userList;
        }
    }
}
