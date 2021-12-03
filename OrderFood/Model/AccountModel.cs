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

        public override void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public Role GetRole(int user_id)
        {
            UserModel u = new UserModel();
            var role_id = u.GetUser(user_id).role_id;
            return ListRole().FirstOrDefault(x => x.id == role_id);
        }

        public override int GetRowDataNumber()
        {
            throw new NotImplementedException();
        }
    }
}
