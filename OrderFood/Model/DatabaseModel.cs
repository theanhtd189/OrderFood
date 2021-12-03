using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Model
{
    /// <summary>
    /// Abstract class represents the database class and the objects inside
    /// </summary>
    abstract public class DatabaseModel
    {
        public string file;
        public Database db;
        public DatabaseModel()
        {
            string filename = ConfigurationManager.AppSettings.Get("DataSourceFile");// Get the file containing the data from the "app.config" file
            file = GetDataSourcePath(filename); //Find the file's path in the project
            db = JsonConvert.DeserializeObject<Database>(File.ReadAllText(file)); //Convert json data to executable data for the program
        }
        /// <summary>
        /// Refresh and update database changes
        /// </summary>
        public void RefreshDatabase()
        {
            db = JsonConvert.DeserializeObject<Database>(File.ReadAllText(file)); 
        }
        // A method to get file's path in the solution 
        public string GetDataSourcePath(string filename)
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(
            Path.GetFullPath(Path.Combine(currentDir, @"..\..\" + filename)));
            return directory.ToString();
        }
        public List<User> ListUser()
        {
            RefreshDatabase();
            return db.Users;
        }
        public List<DishCategory> ListDishCategory()
        {
            RefreshDatabase();
            return db.DishCategories;
        }
        public List<Dish> ListDish()
        {
            RefreshDatabase();
            return db.Dishes;
        }
        public List<Role> ListRole()
        {
            RefreshDatabase();
            return db.Roles;
        }
        public List<Order> ListOrder()
        {
            RefreshDatabase();
            return db.Orders;
        }
        abstract public int GetRowDataNumber();
        abstract public void DeleteAll();
    }
}
