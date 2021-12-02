using System.Collections;
using System.Collections.Generic;
namespace OrderFood.Model
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
        public int money { get; set; }
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
        public List<string> description { get; set; }
        public string image { get; set; }
        public List<string> ingredient { get; set; }
        public int price { get; set; }
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
        public int id_user { get; set; }
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
        public List<User> User { get; set; }
        /// <summary>
        /// List containing records of object "Dish"
        /// </summary>
        public List<Dish> Dish { get; set; }
        /// <summary>
        /// List containing records of object "DishCategory"
        /// </summary>
        public List<DishCategory> DishCategory { get; set; }
        /// <summary>
        /// List containing records of object "Order"
        /// </summary>
        public List<Order> Order { get; set; }
        /// <summary>
        /// List containing records of object "Role"
        /// </summary>
        public List<Role> Role { get; set; }
    }

}


