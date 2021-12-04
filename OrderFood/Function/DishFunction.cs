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
    /// The class contains methods to work with the "Dish" in the database
    /// </summary>
    class DishFunction : DatabaseFunction, IDish
    {
        public bool AddDish(Dish d)
        {
            try
            {
                var o = ListDish().FirstOrDefault(x=>x.name==d.name);
                if (o == null)
                {
                    d.id = CreateIDDish();
                    db.Dishes.Add(d);
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

        public int CreateIDDish()
        {
            int max = 0;
            var list = db.Dishes;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id > max)
                    max = list[i].id;
            }
            return max + 1;
        }


        public bool DeleteDish(int Dish_id)
        {
            try
            {
                var o = GetDish(Dish_id);
                if (o != null)
                {
                    var up = db.Dishes.Remove(o);
                    if (up)
                    {
                        var c = JsonConvert.SerializeObject(db, Formatting.Indented);
                        File.WriteAllText(file, c);
                        return true;
                    }
                    else
                        return false;
                    
                }
                else
                    return false;
                
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool EditDish(Dish d)
        {
            try
            {
                var o = GetDish(d.id);
                if (o != null)
                {
                    o.name = d.name;
                    o.description = d.description;
                    o.ingredient = d.ingredient;
                    o.id_category = d.id_category;
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

        public Dish GetDish(int id)
        {
            return db.Dishes.SingleOrDefault(x => x.id == id);
        }
        public List<Dish> GetListDishByCategory(int id)
        {
            return db.Dishes.Where(x => x.id_category == id).ToList();
        }
        public override int GetRowDataNumber()
        {
            throw new NotImplementedException();
        }

        public override void DeleteAll()
        {
            db.Dishes.Clear();
        }
    }
}
