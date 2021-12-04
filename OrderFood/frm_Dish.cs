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

namespace OrderFood
{
    public partial class frm_Dish : Form
    {
        bool add = false, edit = false;
        DishFunction f_dish = new DishFunction();
        DishCategoryFunction f_dc = new DishCategoryFunction();
        Dish current_dish ;
        int current_id = -1;
        public frm_Dish()
        {
            InitializeComponent();
            LoadDefault();
            txtName.Text = "";
            btnOk.Text = "Add";
            add = true;
        }
        public frm_Dish(int dish_id)
        {
            InitializeComponent();
            LoadDefault();
            edit=true;
            current_dish = f_dish.GetDish(dish_id);
           
            if (current_dish != null)
            {
                txtName.Text = current_dish.name;
                current_id = current_dish.id;
                txtNamee.Text = current_dish.name;
                txtDesc.Text = current_dish.description;
                txtIngre.Text = current_dish.ingredient;
                cbCategory.SelectedValue = current_dish.id_category;
            }
            else
            {
                MessageBox.Show("Dish was not exitst or was deleted!");
                DialogResult = DialogResult.Cancel;
            }
        }
        private void LoadDefault()
        {
            pictureBox1.Image = Resource1.a;
            var list = f_dc.GetList();
            cbCategory.ValueMember = "id";
            cbCategory.DisplayMember = "name";
            cbCategory.DataSource = list;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNamee.Text) || string.IsNullOrEmpty(txtIngre.Text) || string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Please enter full information!");
            }
            else
            {
                Dish d = new Dish {
                    id=current_id,
                    name = txtNamee.Text,
                    description=txtDesc.Text,
                    ingredient=txtIngre.Text,
                    id_category=int.Parse(cbCategory.SelectedValue.ToString())
                };
                if (add)
                {
                    var up = f_dish.AddDish(d);
                    if (up)
                    {
                        MessageBox.Show("Insert successful!");
                        DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Failed!");
                }
                else
                if (edit)
                {
                    var up = f_dish.EditDish(d);
                    if (up)
                    {
                        MessageBox.Show("Update successful!");
                        DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Failed!");
                }


            }
        }
    }
}
