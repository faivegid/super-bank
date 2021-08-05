using BankMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BankMS.DataAccess
{
    public class SQLWriter : IWriter
    {

        public bool SaveAccount(Account account)
        {
            SqlConnection sqlConnection;
            SqlCommand sqlCommand;
            string storedProcedure = "InsertIntoAccount";
            SetUpCommand(storedProcedure, out sqlConnection, out sqlCommand);

            sqlCommand.Parameters.AddWithValue("@UserId", account.AccountID);
            sqlCommand.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
            sqlCommand.Parameters.AddWithValue("@AccountType", account.Type);
            sqlCommand.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

            ExecuteNonQueryCommand(sqlConnection, sqlCommand);
            return true;
        }

        public bool SaveTransactions(Transaction transaction)
        {
            SqlConnection sqlConnection;
            SqlCommand sqlCommand;
            string storedProcedure = "InsertIntoTransactions";
            SetUpCommand(storedProcedure, out sqlConnection, out sqlCommand);

            sqlCommand.Parameters.AddWithValue("@AccountNumber", transaction.AccountNumber);   
            sqlCommand.Parameters.AddWithValue("@Date", transaction.tDate);
            sqlCommand.Parameters.AddWithValue("@Amount", transaction.tAmount);
            sqlCommand.Parameters.AddWithValue("@Description", transaction.tNote);

            ExecuteNonQueryCommand(sqlConnection, sqlCommand);
            return true;
        }

        public bool SaveUser(UserModel user)
        {
            SqlConnection sqlConnection;
            SqlCommand sqlCommand;
            string storedProcedure = "InsertIntoCustomer";
            SetUpCommand(storedProcedure, out sqlConnection, out sqlCommand);

            sqlCommand.Parameters.AddWithValue("@UserId", user.Id);
            sqlCommand.Parameters.AddWithValue("@@UserName", user.Name);
            sqlCommand.Parameters.AddWithValue("@UserEmail", user.Email);
            sqlCommand.Parameters.AddWithValue("@UserPassword", user.Password);

            ExecuteNonQueryCommand(sqlConnection, sqlCommand);
            return true;
        }

        private static void ExecuteNonQueryCommand(SqlConnection sqlConnection, SqlCommand sqlCommand)
        {
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private static void SetUpCommand(string storedProcedure, out SqlConnection sqlConnection, out SqlCommand sqlCommand)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BankMS.DataBase;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
        }
    }
}
