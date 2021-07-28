using BankMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankMS.DataAccess
{
    public interface IReader
    {
        IEnumerable<UserModel> GetUsers();
        IEnumerable<Account> GetAccounts();
        IEnumerable<Transaction> GetTransactions();
    }
}
