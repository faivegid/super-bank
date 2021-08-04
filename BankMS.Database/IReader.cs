using BankMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankMS.DataAccess
{
    public interface IReader
    {
        IEnumerable<(string Id, string Email, string Password, string Name)> GetUsers();
        IEnumerable<(string AccountId, string AccountNumber, string accountType)> GetAccounts();
        IEnumerable<(string AccountNumber, string Amount, string Note, string Date)>  GetTransactions();
    }
}
