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
        public string json;
        public string file;
        public Database db;
        public DatabaseModel()
        {
            string filename = ConfigurationManager.AppSettings.Get("DataSourceFile");// Get the file containing the data from the "app.config" file
            file = GetDataSourcePath(filename); //Find the file's path in the project
            db = JsonConvert.DeserializeObject<Database>(File.ReadAllText(file)); //Convert json data to executable data for the program
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
            return db.User;
        }
        public List<DishCategory> ListCategory()
        {
            return db.DishCategory;
        }
        public List<Dish> ListDish()
        {
            return db.Dish;
        }
        public List<Role> ListRole()
        {
            return db.Role;
        }
        public List<Order> ListOrder()
        {
            return db.Order;
        }
    }
}
