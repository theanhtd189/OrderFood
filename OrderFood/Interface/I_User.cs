
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

        //Method to remove all user from database
        /// <summary>
        /// Remove all user from database
        /// </summary>
        /// <returns>True if successful, or not return false</returns>
        bool DeleteAllUser();


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

        //Method to create a new user 
        /// <summary>
        /// Create new account with given parameters
        /// </summary>
        /// <returns>True if successful, false if that username already exists</returns>
        bool Signup(string username, string password, string name);

        /// <summary>
        /// Method to login to program
        /// </summary>
        /// <returns>Return UserID if the information entered is correct, or not return -1</returns>
        int Login(string username, string password);

        //Method to change infomation of user
        /// <summary>
        /// Method to change user's info with given parameters
        /// </summary>
        /// <returns>True if successful, or not return fasle</returns>
        bool EditUser(int id, string password, string name);


    }
}
