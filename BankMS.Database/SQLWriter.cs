using BankMS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BankMS.DataAccess
{
    public class SQLWriter : IWriter
    {

        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BankMS.DataBase;Integrated Security=True";
        SqlCommand sqlCommand = new SqlCommand();

        public bool SaveAccount(Account account)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $" INSERT INTO Account VALUES ('{account.AccountID}', '{account.AccountNumber}', '{account.Type}', '{DateTime.Now}' );";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }

        public bool SaveTransactions(Transaction transaciton)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $"INSERT INTO Transactions VALUES ('{transaciton.AccountNumber}', '{transaciton.tDate}','{transaciton.tAmount}', '{transaciton.tNote}' );";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }

        public bool SaveUser(UserModel user)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $"INSERT INTO Customers VALUES ('{user.Id}','{user.Name}','{user.Email}','{user.Password}');";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }

    }
}
