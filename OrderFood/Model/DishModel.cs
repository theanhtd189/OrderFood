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
    class DishModel : DatabaseModel, IDish
    {
        public bool AddDish(Dish d)
        {
            return false;
        }
        public bool AddDish(string name)
        {
            try
            {
                db.DishCategories.Add(new DishCategory
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
        public bool DeleteAllDish()
        {
            throw new NotImplementedException();
        }

        public bool DeleteDish(string Dish_id)
        {
            throw new NotImplementedException();
        }

        public bool EditDish(Dish d)
        {
            throw new NotImplementedException();
        }

        public Dish GetDish(int id)
        {
            return db.Dishes.SingleOrDefault(x => x.id == id);
        }
        public List<Dish> GetListDishByCategory(int id)
        {
            return db.Dishes.Where(x => x.id_category == id).ToList();
        }
        public List<Dish> GetList()
        {
            return db.Dishes;
        }
    }
}
