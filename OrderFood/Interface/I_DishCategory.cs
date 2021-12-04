using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderFood;

namespace OrderFood.Interface
{
    /// <summary>
    /// Interface contains methods to work with the "DishCategory" object in the Database (Datasoure of the program)
    /// </summary>
    interface IDishCategory
    {
        //Method to add DishCategory to database
        bool AddDishCategory(DishCategory d);

        //Method to remove a DishCategory from database
        bool DeleteDishCategory(int DishCategory_id);

        //Method to remove all DishCategory from database
        bool DeleteAllDishCategory();

        //Get DishCategory from database with given "DishCategory ID"
        DishCategory GetDishCategory(int DishCategory_id);

        //Method to change infomation of DishCategory
        bool EditDishCategory(DishCategory d);
    }
}
