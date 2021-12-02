using OrderFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Interface
{
    /// <summary>
    /// Interface contains methods to work with the "Dish" object in the Database (Datasoure of the program)
    /// </summary>
    interface IDish
    {
        //Method to add Dish to database
        bool AddDish(Dish d);

        //Method to remove a Dish from database
        bool DeleteDish(string Dish_id);

        //Method to remove all Dish from database
        bool DeleteAllDish();

        //Get Dish from database with given "Dish ID"
        Dish GetDish(int Dish_id);

        //Method to change infomation of Dish
        bool EditDish(Dish d);
    }
}
