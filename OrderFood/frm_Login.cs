using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using System.Windows.Forms;
using System.Configuration;
using OrderFood.Model;
using OrderFood.Interface;

namespace OrderFood
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }   
        private void Form1_Load(object sender, EventArgs e)
        {
            /* 
             Check if the file containing the data exists or if the configuration information is correct when form is loaded
            */
            try
            {
                string filename = ConfigurationManager.AppSettings.Get("DataSourceFile");
                string file = new Function().GetDataSourcePath(filename);
                if (file == null || filename==null)
                {
                    MessageBox.Show("The Json file is not found in the project or the configuration is not correct, please check again!");
                }
            }
            catch
            {
                MessageBox.Show("Your configuration is not correct, please check in 'app.config' file or contact admin for support!");
            }
        }

        /* When the login button is clicked, Check if the username and password entered is correct */
        private void btnLogin_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Username or password is incorrect");
                }
                else
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Username or password is incorrect");
                }
                else
                {
                    AccountFunction f = new AccountFunction(); //Call method to manipulate with the data of the "User" object
                    int stt = f.Login(txtUsername.Text, txtPassword.Text);
                
                    if (stt != -1)
                    {
                        frm_MainMenu frm = new frm_MainMenu(stt);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    else
                        MessageBox.Show("Username or password is incorrect");
                }
            }

        //Open sign up form 
        private void btnSignup_Click(object sender, EventArgs e)
        {
            frm_SignUp f = new frm_SignUp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
