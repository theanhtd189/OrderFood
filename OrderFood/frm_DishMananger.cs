using OrderFood.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderFood
{
    public partial class frm_DishMananger : Form
    {
        int currrent_row;
        int i = -1;
        DishModel f = new DishModel();
        public frm_DishMananger()
        {
            InitializeComponent();
            this.dgv.DefaultCellStyle.ForeColor = Color.Blue;
        }
        private void DanhSach_Load(object sender, EventArgs e)
        {
            Reload();
        }
        public void Reload()
        {
            dgv.DataSource = f.ListDish();
        }
        private void Select(object sender, DataGridViewCellEventArgs e)
        {
                currrent_row = e.RowIndex;
                if (currrent_row > -1)
                {
                    i = (int)dgv.Rows[currrent_row].Cells["id"].Value;
                }   
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
                frm_Dish frm = new frm_Dish();
                frm.ShowDialog();
                Reload();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (currrent_row >= 0)
            {
                if (i != -1)
                {
                    frm_Dish frm = new frm_Dish(i);
                    frm.ShowDialog();
                    Reload();
                }
            }
            else
                MessageBox.Show("Please select one row at leat");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currrent_row >= 0)
            {
                if (i != -1)
                {
                    var up = f.DeleteDish(i);
                    if (up)
                    {
                        MessageBox.Show("Remove successfuly!");
                        Reload();
                    }
                    else
                        MessageBox.Show("Failed!");
                }
            }
            else
                MessageBox.Show("Please select one row at leat");
        }
    }
}
