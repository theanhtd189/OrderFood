using OrderFood.Interface;
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
    public partial class frm_Account : Form
    {
        int id_user;
        IUser f = new UserModel();
        bool edit = false;
        public frm_Account(int id)
        {
            InitializeComponent();
            pictureBox1.Image = Resource1.images;
            this.id_user = id;
            LoadUserName();
        }
        public void LoadUserName()
        {
            txtNamee.Text = txtName.Text = f.GetUser(id_user).name;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                if(!string.IsNullOrEmpty(txtPass.Text) && !string.IsNullOrEmpty(txtRepass.Text))
                {
                    if(txtRepass.Text!=txtPass.Text)
                    {
                        MessageBox.Show("Passwords do not match!");
                    }    
                    else
                    {
                        f.EditUser(id_user,txtPass.Text,txtNamee.Text);
                        MessageBox.Show("Changed successfully!");
                        LoadUserName();
                    }    
                }
                else
                    MessageBox.Show("Passwords do not match!");

            }
            else
            {
                f.EditUser(id_user, null, txtNamee.Text);
                MessageBox.Show("Changed successfully!");
                LoadUserName();
            }    
        }
        private void Select(object sender, EventArgs e)
        {
            edit = true;
        }
    }
}
