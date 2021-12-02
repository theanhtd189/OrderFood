using OrderFood.Interface;
using OrderFood.Model;
using OrderFood.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace OrderFood
{
    public partial class frm_MainMenu : Form
    {
        AccountModel f_account = new AccountModel();
        UserModel f_user = new UserModel();
        OrderModel f_order = new OrderModel();
        DishModel f_dish = new DishModel();
        DishCategoryModel f_dc = new DishCategoryModel();
        int user_id;

        public frm_MainMenu(int id)
        {
            InitializeComponent();
            user_id = id;
            lbHeader.Text = f_user.GetUser(user_id).name;
            ReLoad();
            Show_List_Food();
            Create_Order_Detail();
            Load_List_Dish_Category_To_Menu();
            if(!f_account.CheckIsAdmin(user_id)) //Check if the logged in user is "Admin" or "Customer"
            {
                tsDishManager.Visible = false;
                tsAccount.Visible = false;
            }
        }
        public frm_MainMenu()
        {
            InitializeComponent();
        }
        public void Create_Order_Detail()
        {
            try
            {
                right.Controls.Clear();
                var cart = f_order.GetOrder(user_id);
                if (cart != null && cart.item != null)
                    foreach (var item in cart.item)
                    {
                        var food = f_dish.GetDish(item.Key);

                        //draw a main panel to containing other child element
                        FlowLayoutPanel pnlMain = new System.Windows.Forms.FlowLayoutPanel();
                        pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                        //pnlMain.AutoSize = true;
                        pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        pnlMain.BackColor = System.Drawing.Color.DarkViolet;
                        pnlMain.Location = new System.Drawing.Point(3, 2);
                        pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                        pnlMain.Name = "pnlMain";
                        pnlMain.Size = new System.Drawing.Size(304, 45);
                        pnlMain.TabIndex = 1;

                        // draw a subpanel 
                        Panel SubPanel = new System.Windows.Forms.Panel();
                        SubPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        SubPanel.Location = new System.Drawing.Point(2, 2);
                        SubPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                        SubPanel.Name = "pnlSub";
                        //SubPanel.AutoSize = true;
                        SubPanel.Size = new System.Drawing.Size(300, 41);
                        SubPanel.TabIndex = 1;

                        //panel containing dish information
                        Panel InfoPanel = new System.Windows.Forms.Panel();
                        InfoPanel.BackColor = System.Drawing.Color.GhostWhite;
                        InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                        InfoPanel.Location = new System.Drawing.Point(45, 0);
                        InfoPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                        InfoPanel.Name = "pnlInfo";
                        //InfoPanel.AutoSize = true;
                        InfoPanel.Size = new System.Drawing.Size(197, 39);
                        InfoPanel.TabIndex = 2;


                        //draw a button to change the quantity of the item in the cart
                        Button btnChangeQuantityItem = new System.Windows.Forms.Button();
                        btnChangeQuantityItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
                        btnChangeQuantityItem.Dock = System.Windows.Forms.DockStyle.Right;
                        btnChangeQuantityItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                        btnChangeQuantityItem.Location = new System.Drawing.Point(242, 0);
                        btnChangeQuantityItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                        btnChangeQuantityItem.Name = item.Value.ToString();
                        btnChangeQuantityItem.Size = new System.Drawing.Size(56, 39);
                        btnChangeQuantityItem.TabIndex = 1;
                        btnChangeQuantityItem.Text = "Change";
                        List<int> l = new List<int>();
                        l.Add(item.Key); 
                        l.Add(item.Value);
                        btnChangeQuantityItem.Tag = l;
                        btnChangeQuantityItem.UseVisualStyleBackColor = false;
                        btnChangeQuantityItem.Click += new System.EventHandler(this.btnChangeQuantity_Click);

                        //button to delete item that is clicked
                        Button btnRemoveDishItem = new System.Windows.Forms.Button();
                        btnRemoveDishItem.BackColor = System.Drawing.Color.DodgerBlue;
                        btnRemoveDishItem.CausesValidation = false;
                        btnRemoveDishItem.Dock = System.Windows.Forms.DockStyle.Left;
                        btnRemoveDishItem.ForeColor = System.Drawing.SystemColors.ControlLight;
                        btnRemoveDishItem.Location = new System.Drawing.Point(0, 0);
                        btnRemoveDishItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                        btnRemoveDishItem.Name = item.Key.ToString();
                        btnRemoveDishItem.Size = new System.Drawing.Size(45, 39);
                        btnRemoveDishItem.TabIndex = 0;
                        btnRemoveDishItem.Text = "Remove";
                        btnRemoveDishItem.AutoSize = true;
                        btnRemoveDishItem.UseVisualStyleBackColor = false;
                        btnRemoveDishItem.Click += new System.EventHandler(this.btnRemoveSingleItem);

                        // print single dish infomation as a text
                        Label lb = new Label();
                        lb.Text = food.name + " - "+item.Value +" x $"+ food.price;
                        lb.Top = InfoPanel.Height / 3;
                        lb.Left = InfoPanel.Width / 5;
                        lb.AutoSize = true;
                        lb.TextAlign = ContentAlignment.MiddleCenter;



                        pnlMain.Controls.Add(SubPanel);
                        SubPanel.Controls.Add(InfoPanel);
                        InfoPanel.Controls.Add(lb);
                        SubPanel.Controls.Add(btnChangeQuantityItem);
                        SubPanel.Controls.Add(btnRemoveDishItem);
                        right.Controls.Add(pnlMain);
                    }
            }
            catch(Exception x)
            {
                MessageBox.Show("Some error occured!\n"+x);
            }
        }
        public void Load_List_Dish_Category_To_Menu()
        {
            var list = f_dc.ListDishCategory();
            if (list != null)
            {
                foreach (var item in list)
                {
                    var ob = f_dc.GetDishCategory(item.id);
                    ToolStripItem it = new ToolStripMenuItem();
                    it.Text = item.name;
                    it.Name = item.id.ToString();
                    it.Click += new System.EventHandler(loai_Clicked);
                    tsListDC.DropDownItems.Add(it);
                }
            }
        }

        private void loai_Clicked(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = (ToolStripMenuItem)sender;
            center.Controls.Clear();
            Show_List_Food(int.Parse(obj.Name));
        }

        private void Show_List_Food(int loai = -1)//Load a list of food by category id to the center of the program
        {
            var list = new List<Dish>();
            if (loai <= 0)
            {
                list = f_dish.ListDish();
            }
            else
                list = f_dish.GetListDishByCategory(loai);

            for (int i = 0; i < list.Count; i++)
            {
                Panel pnl = new Panel();
                pnl.Size = new System.Drawing.Size(150, 155);
                pnl.Location = new Point(380, 260);
                pnl.BorderStyle = BorderStyle.FixedSingle;

                PictureBox pic = new PictureBox();
                pic.SizeMode = PictureBoxSizeMode.Zoom;


                pic.Location = new Point(3, 15);
                pic.Size = new Size(130, 120);
                try
                {
                    if (list[i].image != null)
                        pic.Load(list[i].image);
                    else
                        pic.Image = Resource1.a;
                }
                catch
                {
                    pic.Image = Resource1.a;
                }

                pic.Dock = DockStyle.Top;
                pic.Click += new System.EventHandler(pic_Clicked);
                pic.Name = list[i].id.ToString();
                Button button = new Button();
                button.Tag = i;
                button.Anchor = AnchorStyles.None;
                button.Text = list[i].name + " -- " + list[i].price + " KCAL";
                button.Dock = DockStyle.Bottom;
                button.ForeColor = Color.Blue;
                button.Click += new System.EventHandler(this.btnAddItem_Clicked);
                button.Name = list[i].id.ToString();
                pnl.Controls.Add(pic);
                pnl.Controls.Add(button);
                center.Controls.Add(pnl);
            }
        }
        public void CreateCart()
        {
            try
            {
                right.Controls.Clear();
                var cart = f_order.GetOrder(user_id);
                if (cart != null && cart.item != null)
                    foreach (var item in cart.item)
                    {
                        Panel pnl = new Panel();
                        var food = f_dish.GetDish(item.Key);
                        pnl.Size = new System.Drawing.Size(350, 100);
                        pnl.Height = 100;
                        pnl.Dock = DockStyle.Top;
                        pnl.BackColor = Color.Pink;
                        pnl.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
                        pnl.AutoSize = false;
                        pnl.Location = new Point(380, 260);
                        pnl.BorderStyle = BorderStyle.FixedSingle;
                        Label lb = new Label();
                        lb.Text = food.price + "Kcal x" + item.Value + " - " + food.name;
                        //lb.Left = 50;                     
                        lb.Width = 250;
                        lb.Top = pnl.Height / 5;
                        lb.AutoSize = false;
                        lb.TextAlign = ContentAlignment.MiddleCenter;
                        lb.BackColor = Color.Red;
                        //lb.Anchor =  AnchorStyles.Right;
                        //button xoa 
                        Button button = new Button();
                        button.AutoSize = false;
                        button.Anchor = AnchorStyles.None;
                        button.Text = "Xóa";
                        button.Dock = DockStyle.None;
                        //button.Height = pnl.Height;
                        //button.Width = 50;
                        button.ForeColor = Color.Blue;
                        button.Click += new System.EventHandler(this.btnAddItem_Clicked);
                        button.Name = item.Key.ToString();
                        //button.Width = 50;
                        //btn thay doi so luong 
                        Button change = new Button();
                        //button.Tag = i;
                        change.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                        change.Text = "^";
                        change.Dock = DockStyle.Top;
                        //change.Height = pnl.Height;
                        change.Width = 50;
                        change.ForeColor = Color.Blue;
                        change.Click += new System.EventHandler(this.change_Clicked);
                        change.Name = item.Key.ToString();
                        pnl.Controls.Add(button);
                        pnl.Controls.Add(lb);
                        pnl.Controls.Add(change);
                        right.Controls.Add(pnl);
                    }
            }
            catch
            {

            }

        }

        private void change_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Remove element from order list in UI
        public void DeleteCard()
        {
            right.Controls.Clear();
            ReLoad();
        }

        // When the button add dish is clicked, add that dish to the order list
        private void btnAddItem_Clicked(object sender, EventArgs e)
        {
            Button triggeredButton = (Button)sender;
            var up = f_order.AddDishToOrder(user_id, int.Parse(triggeredButton.Name));
            if (!up)
                MessageBox.Show("Failed");
            else
            {
                Create_Order_Detail();
                ReLoad();
            }
        }
        private void pic_Clicked(object sender, EventArgs e)
        {
            PictureBox triggered = (PictureBox)sender;

            frm_Dish fm = new frm_Dish(int.Parse(triggered.Name));
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }
        public void ReLoad()
        {
            var up = f_order.CalculateTotalMoney(user_id);
            if (up)
                txtTotal.Text = "Total: " + "$" + f_user.GetUser(user_id).money.ToString();
            else
                MessageBox.Show("Some error occured!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            using (frm_Account frm = new frm_Account(user_id))
            {
                frm.ShowDialog();
            }
            this.Show();
        }
/*
        private void button3_Click(object sender, EventArgs e)
        {
            DeleteCard();
            f_order.DeleteOrder(user_id);
            CreateCart();
            ReLoad();
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            using (frm_DishMananger frm = new frm_DishMananger())
            {
                frm.ShowDialog();
            }
            ReLoad();

        }

        //Remove an item from order list in UI
        private void btnRemoveSingleItem(object sender, EventArgs e)
        {
            Button triggeredButton = (Button)sender;
            var up = f_order.DeleteItemInOrder(user_id, int.Parse(triggeredButton.Name));
            if (!up)
                MessageBox.Show("Failed");
            else
            {
                Create_Order_Detail();
                ReLoad();
            }
        }
        private void btnChangeQuantity_Click(object sender, EventArgs e)
        {
            Button triggeredButton = (Button)sender;
            List<int> l = (List<int>)triggeredButton.Tag;
            try
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(f_dish.GetDish(l[0]).name,
                       "Change the number of the item",
                       triggeredButton.Name,
                       0,
                       0);
                if (string.IsNullOrEmpty(input) || int.Parse(input) <= 0)
                {
                    //When the user enters the number 0
                }
                else
                {
                    var up = f_order.EditOrder(user_id, l[0], int.Parse(input));
                    if (!up)
                        MessageBox.Show("Failed!");
                    else
                    {
                        Create_Order_Detail();
                        ReLoad();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid number!");
            }
        }
        private void tsDishManager_Click(object sender, EventArgs e)
        {
            frm_DishMananger frm = new frm_DishMananger();
            frm.ShowDialog();
        }

        private void accountManangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AccountManager frm = new frm_AccountManager();
            frm.ShowDialog();
        }

        private void tsAccountInfo(object sender, EventArgs e)
        {
            frm_Account frm = new frm_Account(user_id);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
        private void DeleteAll(object sender, EventArgs e)
        {
            DeleteCard();
            f_order.DeleteOrder(user_id);
            CreateCart();
            ReLoad();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
