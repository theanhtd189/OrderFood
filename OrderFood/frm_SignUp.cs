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
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtFullname.Text) )
            {
                if (String.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please fill in all the information !");

                }
                else
                if (String.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Please fill in all the information !");

                }
                else
                if (String.IsNullOrEmpty(txtRepassword.Text))
                {
                    MessageBox.Show("Please fill in all the information !");
                }
                else
                if (txtRepassword.Text != txtPassword.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                }
                else
                {
                    AccountFunction f = new AccountFunction();
                    var stt = f.Signup( txtUsername.Text,txtPassword.Text,txtFullname.Text);
                    if (stt)
                    {
                        MessageBox.Show("Sign Up Success!");
                    }    
                    else
                        MessageBox.Show("This username already exists, please choose another one !");
                }
            }    
            else
            {
                MessageBox.Show("Please fill in all the information !");
            }    
        }
        private void btnCancel_Enter(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
