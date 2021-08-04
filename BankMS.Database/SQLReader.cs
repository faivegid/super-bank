using System.Collections.Generic;
using System.Data.SqlClient;

namespace BankMS.DataAccess
{
    public class SQLReader : IReader
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BankMS.DataBase;Integrated Security=True";
        private SqlCommand sqlCommand = new SqlCommand();

        public IEnumerable<(string AccountId, string AccountNumber, string accountType)>
            GetAccounts()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM Account";
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            var accounts = new List<(string AccountID, string AccountNumberr, string accountType)>();
            while (dataReader.Read())
            {
                accounts.Add((dataReader["UserID"].ToString(), dataReader["AccountNumber"].ToString(),
                    dataReader["AccountType"].ToString()));
            }
            sqlConnection.Close();
            return accounts;
        }

        public IEnumerable<(string AccountNumber, string Amount, string Note, string Date)>
            GetTransactions()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM Transactions";
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            var transactions = new List<(string AccountNumber, string Amount, string Note, string Date)>();
           
            while (dataReader.Read())
            {

                transactions.Add((dataReader["AccountNumber"].ToString(), dataReader["Amount"].ToString(),
                    dataReader["Description"].ToString(), dataReader["Date"].ToString()));
            }
            sqlConnection.Close();
            return transactions;
        }

        public IEnumerable<(string Id, string Email, string Password, string Name)>
            GetUsers()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM Customers";
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            var users = new List<(string Id, string Email, string Password, string Name)>();
            while (dataReader.Read())
            {
                users.Add((dataReader["ID"].ToString(), dataReader["Email"].ToString(),
                    dataReader["PassWord"].ToString(), dataReader["Name"].ToString()));
            }
            sqlConnection.Close();
            return users;
        }
    }
}
