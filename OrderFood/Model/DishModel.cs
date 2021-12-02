using OrderFood.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Model
{
    class DishModel : DatabaseModel, IDish
    {
        public bool AddDish(Dish d)
        {
            throw new NotImplementedException();
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
            return ListDish().SingleOrDefault(x => x.id == id);
        }
        public List<Dish> GetListDishByCategory(int id)
        {
            return ListDish().Where(x => x.id_category == id).ToList();
        }
    }
}
