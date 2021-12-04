using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderFood.Model;
using OrderFood.Properties;

namespace OrderFood
{
    public partial class frm_ViewDish : Form
    {
        Dish current_dish = new Dish();
        DishCategoryFunction f_dc = new DishCategoryFunction();
        DishFunction f_dish = new DishFunction();
        public frm_ViewDish(int id)
        {
            InitializeComponent();
            current_dish = f_dish.GetDish(id);
            this.Text= "Dish infomation: "+ current_dish.name;
            lbDishName.Text = current_dish.name;
            txtPrice.Text = current_dish.price.ToString();
            txtIngre.Text = current_dish.ingredient.ToString();
            txtDesc.Text = current_dish.description.ToString();
            if (f_dc.GetDishCategory(current_dish.id_category) != null)
                txtCategory.Text = f_dc.GetDishCategory(current_dish.id_category).name;
            else
                txtCategory.Text = "Untitled category";
            try
            {
                var avt = current_dish.image;
                pictureBox1.Load(avt);
            }
            catch
            {
                pictureBox1.Image = Resource1.a;
            }
        }
        public frm_ViewDish()
        {
            InitializeComponent();          
        }
    }
}
