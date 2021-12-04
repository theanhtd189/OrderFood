
using OrderFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Interface
{
    /// <summary>
    /// Interface contains methods to work with the "User" object in the Database (Datasoure of the program)
    /// </summary>
    interface IUser
    {
        //Method to remove a user from database
        /// <summary>
        /// Remove a user from database with given ID
        /// </summary>
        /// <returns>True if successful, or not return false</returns>
        bool DeleteUser(int user_id);

        //
        /// <summary>
        /// Get user from database with given "User ID"
        /// </summary>
        /// <returns>Return that user if found or not return null</returns>
        User GetUser(int user_id);

        //
        /// <summary>
        /// Get user from database with given "User Name"
        /// </summary>
        /// <returns>Return that user if found or not return null</returns>
        User GetUser(string user_name);

        


        bool AddUser(User u);

        //Method to change infomation of user
        /// <summary>
        /// Method to change user's info with given parameters
        /// </summary>
        /// <returns>True if successful, or not return fasle</returns>
        bool EditUser(int id, string password, string name);


    }
}
