using Newtonsoft.Json;
using OrderFood.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace OrderFood.Model
{
    public class OrderModel : DatabaseModel, IOrder
    {
        public bool AddOrder(Order d)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllOrder()
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(int id_user)
        {
            try
            {
                var get = GetOrder(id_user);
                if (get != null)
                {
                    get.item.Clear();
                }
                new UserModel().GetUser(id_user).money = 0;
                CalculateTotalMoney(id_user);
                var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText(file, c);
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool EditOrder(int id_user, int id_food, int sl)
        {
            try
            {
                var o = GetOrder(id_user);
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
            catch (Exception x)
            {
                throw x;
            }
        }


        public bool EditOrder(Order d)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int user_id)
        {
            return ListOrder().FirstOrDefault(x => x.id_user == user_id);
        }
        public bool AddDishToOrder(int id_user, int id_food, int slg = 1)
        {
            try
            {
                var get = GetOrder(id_user);
                if (get != null)
                {
                    if (get.item == null)
                        get.item = new Dictionary<int, int>();

                    if (get.item.Count > 0 && get.item.ContainsKey(id_food))
                    {
                        get.item[id_food] = get.item[id_food] + slg;
                    }
                    else
                        get.item.Add(id_food, slg);
                }
                else
                {
                    var o = new Order();
                    o.id_user = id_user;
                    o.item = new Dictionary<int, int>();
                    o.item.Add(id_food, slg);
                    db.Order.Add(o);
                }
                CalculateTotalMoney(id_user);
                var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText(file, c);
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
        public void CalculateTotalMoney(int id_user)
        {
            try
            {
                var t = 0;
                var td = GetOrder(id_user);

                if (td != null && td.item.Count > 0)
                {
                    foreach (var item in td.item)
                    {
                        var id_food = item.Key;
                        var sl = item.Value;
                        var food = new DishModel().GetDish(item.Key);
                        t = t + food.price * sl;
                    }
                }
                new UserModel().GetUser(id_user).money = t;
                var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText(file, c);
            }
            catch (Exception x)
            {
                throw x;
            }
        }
        public bool DeleteItemInOrder(int id_user, int id_food)
        {
            try
            {
                var o = GetOrder(id_user);
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


    }
}
