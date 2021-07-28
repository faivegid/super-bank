using BankMS.DataAccess;
using BankMS.Model;

namespace BankMS.Core
{
    public class UserHandler
    {
        public static void CreateUser(UserModel user, IWriter writer)
        {            
            writer.SaveUser(user);
        }
       
    }
}
