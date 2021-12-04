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
    public partial class frm_AccountManager : Form
    {
        int currrent_row;
        int i = -1;
        AccountFunction f = new AccountFunction();
        public frm_AccountManager()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public void Reload()
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currrent_row >= 0)
            {
                if (i != -1)
                {
                    var up = f.DeleteAccount(i);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        private void Select(object sender, DataGridViewCellEventArgs e)
        {
            currrent_row = e.RowIndex;
            if (currrent_row > -1)
            {
                i = (int)dgv.Rows[currrent_row].Cells["id"].Value;
            }

        }
    }
}
