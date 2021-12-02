using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using OrderFood.Model;

namespace OrderFood
{
    public class Function
    {
        public string json;
        public string file;
        Database db = null;
        public Function()
        {
            string filename = ConfigurationManager.AppSettings.Get("DataSourceFile");// Get the file containing the data from the "app.config" file
            file = GetDataSourcePath(filename); //Find the file's path in the project
            db = JsonConvert.DeserializeObject<Database>(File.ReadAllText(file)); //Convert json data to executable data for the program
        }
        public string GetDataSourcePath(string filename)
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(
                Path.GetFullPath(Path.Combine(currentDir, @"..\..\" + filename)));
            return directory.ToString();
        }
        // nguoi dung
/*        public List<User> ListUser()
        {
            return db.Users;           
        }*/
/*        public User GetUser(int id)
        {
            return ListUser().SingleOrDefault(x => x.id == id);
        }
        public User GetUser(string username)
        {
            return ListUser().SingleOrDefault(x => x.username==username);
        }*/
/*        public int CreateIDUser()
        {
            int max = 0;
            var list = ListUser();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id > max)
                    max = list[i].id;
            }
            return max + 1;
        }
*/
        /// <summary>
        /// Method to login to program
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Return UserID if the information entered is correct, or not return -1</returns>
/*        public int Login(string username, string password)
        {
            var o = ListUser().SingleOrDefault(x => x.username == username);
            if (o != null)
            {
                if (o.password == password)
                {
                    return o.id;
                }
            }
            return -1;
        }
        public bool EditUser(int id, string password = null, string name = null)
        {
            try
            {
                if (password != null)
                {
                    GetUser(id).password = password;

                }
                if (name != null)
                {
                    GetUser(id).name = name;
                }
                var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText(file, c);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
*/        
/*        public void CalculateTotalMoney(int user_id)
        {
            try
            {
                var t = 0;
                var td = GetOrder(user_id);

                if (td!=null && td.item.Count>0)
                {
                    foreach (var item in td.item)
                    {
                        var id_food = item.Key;
                        var sl = item.Value;
                        var food = GetDish(item.Key);
                        t = t + food.price * sl;
                    }
                }
                GetUser(user_id).money = t;
                var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText(file, c);
            }
            catch (Exception x)
            {
                throw x;
            }
        }
*/        /// <summary>
        /// Create new account with given parameters
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <returns>Return true if successful, false if that username already exists</returns>
/*        public bool Signup(string username, string password, string name)
        {
            try
            {
                var obj = GetUser(username);
                if (obj == null)
                {
                    db.User.Add(new User
                    {
                        id = CreateIDUser(),
                        name = name,
                        username = username,
                        password = password
                    });
                    var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                    File.WriteAllText(file, c);
                    return true;
                }
                else
                    return false;              
            }
            catch (Exception e)
            {
                throw e;
            }
        }
*/        //hang muc
/*        public List<DishCategory> ListCategory()
        {
            return db.DishCategory;
        }
        public List<Dish> ListDish()
        {
            return db.Dish;
        }*/
        /// món
/*        public bool InsertDish(string name)
        {
            try
            {
                db.DishCategory.Add(new DishCategory
                {
                    id = CreateIDDish(),
                    name = name
                });
                var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText(file, c);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int CreateIDDish()
        {
            int max = 0;
            var list = ListDish();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id > max)
                    max = list[i].id;
            }
            return max + 1;
        }
        public Dish GetDish(int id)
        {
            return ListDish().SingleOrDefault(x => x.id == id);
        }*/
        /*public List<Dish> GetDishByCategory(int id)
        {
            return ListDish().Where(x => x.id_category == id).ToList();
        }*/
/*        public bool AddDish(int user_id, int id_food, int slg = 1)
        {
            try
            {
                var get = GetOrder(user_id);
                if (get != null)
                {
                    if (get.item == null)
                        get.item = new Dictionary<int, int>();

                    if (get.item.Count > 0 && get.item.ContainsKey(id_food))
                    {
                        get.item[id_food] = get.item[id_food] + slg;
                    }
                    else
                        get.item.Add(id_food,slg);
                }
                else
                {
                    var o = new Order();
                    o.user_id = user_id;
                    o.item = new Dictionary<int, int>();
                    o.item.Add(id_food, slg);
                    db.Order.Add(o);
                }
                CalculateTotalMoney(user_id);
                var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText(file, c);
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
*/
        ///thực đơn
/*        public List<Order> ListOrder()
        {
            return db.Order;
        }      
        public Order GetOrder(int user_id)
        {
            return ListOrder().FirstOrDefault(x => x.user_id == user_id);
        }*/
/*        public void XoaThucDon(int user_id)
        {
            try
            {
                var get = GetOrder(user_id);
                if (get != null)
                {
                    get.item.Clear();
                }
                GetUser(user_id).money = 0;
                CalculateTotalMoney(user_id);
                var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText(file, c);
            }
            catch (Exception x)
            {
                throw x;
            }
        }
*/        
/*        public bool ChangeQuantity(int user_id, int id_food, int sl)
        {
            try
            {
                var o = GetOrder(user_id);
                if (o != null)
                {
                    if (o.item.ContainsKey(id_food))
                    {
                        o.item[id_food] = sl;
                        var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                        File.WriteAllText(file, c);
                        return true;
                    }
                    else
                        return false;
                }
                return false;
            }
            catch(Exception x)
            {
                throw x;
            }
        }
*/        
/*        public bool DeleteDishInOrder(int user_id, int id_food)
        {
            try
            {
                var o = GetOrder(user_id);
                if (o != null)
                {
                    if (o.item.ContainsKey(id_food))
                    {
                        if (o.item.Remove(id_food))
                        {
                            var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                            File.WriteAllText(file, c);
                            return true;
                        }
                        else
                            return false;
                        
                    }
                }
                return false;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
*/        // hạng mục món ăn
/*        public DishCategory GetCategory(int id)
        {
            return ListCategory().SingleOrDefault(x => x.id == id);
        }*/
        /*public int CreateIDCategory()
        {
            int max = 0;
            var list = ListCategory();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id > max)
                    max = list[i].id;
            }
            return max + 1;

        }     */ 
    }
}
