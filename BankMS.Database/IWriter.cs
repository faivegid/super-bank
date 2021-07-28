using BankMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankMS.DataAccess
{
    public interface IWriter
    {
        bool SaveUser(UserModel user);
        bool SaveAccount(Account account);
        bool SaveTransactions(Transaction transaciton);
    }
}
