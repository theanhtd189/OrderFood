﻿using Newtonsoft.Json;
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

        public void DeleteOrder(int user_id)
        {
            try
            {
                var get = GetOrder(user_id);
                if (get != null)
                {
                    get.item.Clear();
                }
                new UserModel().GetUser(user_id).money = 0;
                CalculateTotalMoney(user_id);
                var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText(file, c);
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool EditOrder(int user_id, int id_food, int sl)
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
            return db.Orders.FirstOrDefault(x => x.user_id == user_id);
        }
        public bool AddDishToOrder(int user_id, int id_food, int slg = 1)
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
                        get.item.Add(id_food, slg);
                }
                else
                {
                    var o = new Order();
                    o.user_id = user_id;
                    o.item = new Dictionary<int, int>();
                    o.item.Add(id_food, slg);
                    db.Orders.Add(o);
                }
                var up = CalculateTotalMoney(user_id);
                if (up)
                {
                    var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                    File.WriteAllText(file, c);
                    return true;
                }
                else
                return false;
                
            }
            catch (Exception x)
            {
                throw x;
            }
        }
        public bool CalculateTotalMoney(int user_id)
        {
            try
            {
                double t = 0;
                var td = GetOrder(user_id);

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

                var up = new UserModel().ChangeMoney(user_id,t);
                return up;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
        public bool DeleteItemInOrder(int user_id, int id_food)
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


    }
}
