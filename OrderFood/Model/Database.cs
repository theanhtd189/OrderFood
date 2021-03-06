using System.Collections;
using System.Collections.Generic;
namespace OrderFood
{
    /// <summary>
    ///Class represents the "User" object
    /// </summary>
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public int role_id { get; set; }
        public double money { get; set; }
    }
    /// <summary>
    ///Class represents the "Role" object
    /// </summary>
    public class Role
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    /// <summary>
    ///Class represents the "Dish" object
    /// </summary>
    public class Dish
    {
        public int id { get; set; }
        public string name { get; set; }
        public int id_category { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string ingredient { get; set; }
        public double price { get; set; }
    }
    /// <summary>
    ///Class represents the "DishCategory" object
    /// </summary>
    public class DishCategory
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    /// <summary>
    ///Class represents the "Order" object
    /// </summary>
    public class Order
    {
        public int user_id { get; set; }
        public Dictionary<int, int> item { get; set; }
    }
    /// <summary>
    ///Generic class representing a database
    /// </summary>
    public class Database
    {
        /// <summary>
        /// List containing records of object "User"
        /// </summary>
        public List<User> Users { get; set; }
        /// <summary>
        /// List containing records of object "Dish"
        /// </summary>
        public List<Dish> Dishes { get; set; }
        /// <summary>
        /// List containing records of object "DishCategory"
        /// </summary>
        public List<DishCategory> DishCategories { get; set; }
        /// <summary>
        /// List containing records of object "Order"
        /// </summary>
        public List<Order> Orders { get; set; }
        /// <summary>
        /// List containing records of object "Role"
        /// </summary>
        public List<Role> Roles { get; set; }
    }

}


