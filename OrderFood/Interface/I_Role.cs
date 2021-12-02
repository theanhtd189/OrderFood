using OrderFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Interface
{
    /// <summary>
    /// Interface contains methods to work with the "Role" object in the Database (Datasoure of the program)
    /// </summary>
    interface IRole
    {
        //Method to add Role to database
        bool AddRole(Role d);

        //Method to remove a Role from database
        bool DeleteRole(string Role_id);

        //Method to remove all Role from database
        bool DeleteAllRole();

        //Get Role from database with given "Role ID"
        Role GetRole(int Role_id);

        //Method to change infomation of Role
        bool EditRole(Role d);
    }
}
