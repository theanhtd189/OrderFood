using Newtonsoft.Json;
using OrderFood.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Model
{
    /// <summary>
    /// The abstract class contains methods to work with the "User" object in the database
    /// </summary>
    public class UserModel : DatabaseModel, IUser
    {
        
        public bool EditUser(int id, string password, string name)
        {
            try
            {
                if (password != null)
                {
                    ((IUser)this).GetUser(id).password = password;
                }
                if (name != null)
                {
                    ((IUser)this).GetUser(id).name = name;
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
            return ListUser().SingleOrDefault(x => x.id == user_id);
        }

        public int GetMoney(string user_id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string user_name)
        {
            return ListUser().SingleOrDefault(x => x.username == user_name);
        }
        public int Login(string username, string password)
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
        public bool Signup(string username, string password, string name)
        {
            try
            {
                var obj = ((IUser)this).GetUser(username);
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
        public int CreateIDUser()
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

        public bool DeleteAllUser()
        {
            try
            {
                ListUser().Clear();
                var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText(file, c);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool DeleteUser(int user_id)
        {
            try
            {
                var o = ((IUser)this).GetUser(user_id);
                if (o != null)
                {
                    ListUser().Remove(o);
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
    }
}
