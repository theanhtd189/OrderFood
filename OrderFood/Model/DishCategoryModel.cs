using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderFood.Interface;

namespace OrderFood.Model
{
    public class DishCategoryModel : DatabaseModel, IDishCategory
    {
        public bool AddDishCategory(DishCategoryModel d)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllDishCategory()
        {
            throw new NotImplementedException();
        }

        public bool DeleteDishCategory(int DishCategory_id)
        {
            throw new NotImplementedException();
        }

        public bool EditDishCategory(DishCategoryModel d)
        {
            throw new NotImplementedException();
        }

        public DishCategory GetDishCategory(int id)
        {
            return ListCategory().SingleOrDefault(x => x.id == id);
        }
    }
}
