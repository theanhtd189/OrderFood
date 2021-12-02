using OrderFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Interface
{
    /// <summary>
    /// Interface contains methods to work with the "Order" object in the Database (Datasoure of the program)
    /// </summary>
    interface IOrder
    {
        //Method to add Order to database
        bool AddOrder(Order d);

        //Method to remove a Order from database
        void DeleteOrder(int user_id);

        //Method to remove all Order from database
        bool DeleteAllOrder();

        //Get Order from database with given "Order ID"
        Order GetOrder(int user_id);

        //Method to change infomation of Order
        bool EditOrder(Order d);
    }
}
