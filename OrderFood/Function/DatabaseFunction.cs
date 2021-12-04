using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Function
{
    /// <summary>
    /// Abstract class contains methods for manipulating the Database and the objects within it
    /// </summary>
    abstract public class DatabaseFunction
    {
        public string file;
        public Database db;
        public DatabaseFunction()
        {
            string filename = ConfigurationManager.AppSettings.Get("DataSourceFile");// Get the file containing the data from the "app.config" file
            file = GetDataSourcePath(filename); //Find the file's path in the project
            db = JsonConvert.DeserializeObject<Database>(File.ReadAllText(file)); //Convert json data to executable data for the program
        }
        /// <summary>
        /// Refresh database changes
        /// </summary>
        public void RefreshDatabase()
        {
            db = JsonConvert.DeserializeObject<Database>(File.ReadAllText(file)); 
        }
        /// <summary>
        /// Save everything was changed to database 
        /// </summary>
        public void SaveChanges()
        {
            var c = JsonConvert.SerializeObject(db, Formatting.Indented);
            File.WriteAllText(file, c);
        }    
        public string GetDataSourcePath(string filename) //Get file's path in the solution
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
        /// <summary>
        /// Returns the number of data rows that exist in the list
        /// </summary>
        /// <returns></returns>
        abstract public int GetRowDataNumber();
        /// <summary>
        // Remove all elements in the list 
        /// </summary>
        abstract public void DeleteAll();

    }
}
