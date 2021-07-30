using BankMS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace BankMS.DataAccess
{
    public class CSVReader : IReader
    {
        string accountFilePath = @"C:\Users\hp\Documents\Projects\BankMS\DataBase\Accounts\AccountsDataBase.csv";
        string transactionFilePath = @"C:\Users\hp\Documents\Projects\BankMS\DataBase\Transactions\Transactions.csv";
        string userFilePath = @"C:\Users\hp\Documents\Projects\BankMS\DataBase\Users\UserDataBase.csv";

        public IEnumerable<(string AccountId, string AccountNumber, string accountType)> GetAccounts()
        {
            string[] accountArray = File.ReadAllLines(accountFilePath);
            IEnumerable<(string AccountId, string AccountNumber, string accountType)>
                accountList = from line in accountArray
                              where line != ""
                              select (AccountId: line.Split(',')[0], AccountNumber: line.Split(',')[1], accountType: line.Split(',')[2]);
            return accountList;
        }
        public IEnumerable<(string AccountNumber, string Amount, string Note, string Date)>
            GetTransactions()
        {
            string[] transactionArray = File.ReadAllLines(transactionFilePath);
            var transcation = from line in transactionArray
                              where line != ""                              
                              select (AccountNumber: line.Split(',')[0], Amount: line.Split(',')[1], Note: line.Split(',')[2], Date: line.Split(',')[3]);
            return transcation;
        }

        public IEnumerable<(string Id, string Email, string Password, string FirstName, string LastName)> GetUsers()
        {
            string[] userArray = File.ReadAllLines(userFilePath);
            IEnumerable<(string Id, string Email, string Password, string FirstName, string LastName)>
                userList = from line in userArray
                           where line != ""
                           select (Id: line.Split(',')[0], Email: line.Split(',')[1],
                           Password: line.Split(',')[2], FirstName: line.Split(',')[3], LastName: line.Split(',')[4]);
            return userList;
        }
    }
}
