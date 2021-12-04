using Newtonsoft.Json;
using OrderFood.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Function
{
    /// <summary>
    /// The class contains methods to work with the "User" object in the database
    /// </summary>
    public class UserFunction : DatabaseFunction, IUser
    {
        
        public bool EditUser(int id, string password, string name)
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
        public User GetUser(int user_id)
        {
            RefreshDatabase();
            return db.Users.SingleOrDefault(x => x.id == user_id);
        }

        public bool ChangeMoney(int user_id, double m)
        {
            var u = GetUser(user_id);
            if (u != null)
            {
                u.money = m;
                var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText(file, c);
                return true;
            }
            return false;
        }

        public User GetUser(string user_name)
        {
            return db.Users.SingleOrDefault(x => x.username == user_name);
        }
        public bool AddUser(User u)
        {
            var o = GetUser(u.username);
            if (o == null)
            {
                db.Users.Add(u); 
                SaveChanges();
                return true;
            }
            return false;
        }

        public int CreateIDUser()
        {
            int max = 0;
            var list = db.Users;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id > max)
                    max = list[i].id;
            }
            return max + 1;
        }



        public bool DeleteUser(int user_id)
        {
            try
            {
                var o = GetUser(user_id);
                if (o != null)
                {
                    db.Users.Remove(o);
                    var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                    File.WriteAllText(file, c);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override int GetRowDataNumber()
        {
            return ListUser().Count;
        }

        public override void DeleteAll()
        {
            try
            {
                db.Users.Clear();
                var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText(file, c);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
