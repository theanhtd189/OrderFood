using Newtonsoft.Json;
using OrderFood.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Function
{
    /// <summary>
    /// The class contains methods to work with the accounts in the database
    /// </summary>
    public class AccountFunction : DatabaseFunction
    {
        /// <summary>
        /// Check given user id is admin or not
        /// </summary>
        /// <returns>True if admin or not return false</returns>
        public bool CheckIsAdmin(int user_id)
        {
            if (GetRole(user_id).name == "adminstrator")
            {
                return true;
            }
            return false;
        }
        public bool DeleteAccount(int user_id)
        {
            var u = new UserFunction().GetUser(user_id);
            if (u!=null)
            {
                var up1 = new UserFunction().DeleteUser(user_id);
                var up2 = new OrderFunction().DeleteOrder(user_id);
                if (up1 && up2)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }
        public override void DeleteAll()
        {
            try
            {
                new UserFunction().DeleteAll();
                new OrderFunction().DeleteAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Method to login to program
        /// </summary>
        /// <returns>Return UserID if the information entered is correct, or not return -1</returns>
        public int Login(string username, string password)
        {
            var o = db.Users.SingleOrDefault(x => x.username == username);
            if (o != null)
            {
                if (o.password == password)
                {
                    return o.id;
                }
            }
            return -1;
        }
        /// <summary>
        /// Create new account with given parameters (The type value determines whether the account type is admin or customer)
        /// </summary>
        /// <returns>True if successful, false if that username already exists</returns>
        public bool Signup(string username, string password, string name, string type="customer")
        {
            try
            {
                var rid = 0;
                if (type == "customer")
                    rid = 1;
                var f = new UserFunction();
                var u = new User
                    {
                        id = f.CreateIDUser(),
                        name = name,
                        username = username,
                        password = password,
                        role_id = rid
                    };
                var up = f.AddUser(u);
                if (up)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Role GetRole(int user_id)
        {
            UserFunction u = new UserFunction();
            var role_id = u.GetUser(user_id).role_id;
            return ListRole().FirstOrDefault(x => x.id == role_id);
        }
        public override int GetRowDataNumber()
        {
            return db.Users.Count;
        }
    }
}
