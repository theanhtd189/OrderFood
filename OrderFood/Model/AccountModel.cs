using OrderFood.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Model
{
    public class AccountModel : DatabaseModel
    {
        /// <summary>
        /// Check given id is admin or not
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
        public Role GetRole(int user_id)
        {
            IUser u = new UserModel();
            return ListRole().FirstOrDefault(x => x.id == u.GetUser(user_id).role_id);
        }

    }
}
