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
    public partial class frm_List_of_dishes : Form
    {
        int dong;
        int i;
        Function f = new Function();
        List<Dish> list;
        public frm_List_of_dishes()
        {
            InitializeComponent();
            list = f.ListDish();
        }
        private void DanhSach_Load(object sender, EventArgs e)
        {
            dgv.DataSource = list;
        }

        private void Select(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                if (dong > -1)
                {
                    i = (int)dgv.Rows[dong].Cells["id"].Value;
                    
                }                                
            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception x)
            {
                throw x;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dong >= 0)
            {
                frm_Dish frm = new frm_Dish();
                frm.ShowDialog();
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (i != 0)
            {
                frm_Dish frm = new frm_Dish(i);
                frm.ShowDialog();
            }
        }
    }
}
