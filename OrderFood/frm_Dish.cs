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
    public partial class frm_Dish : Form
    {
        Function f = new Function();
        Dish m = new Dish();
        DishCategoryModel f_dc = new DishCategoryModel();
        public frm_Dish(int id)
        {
            InitializeComponent();
            m = f.GetDish(id);
            this.Text= "Dish infomation: "+ m.name;
        }
        public frm_Dish()
        {
            InitializeComponent();          
        }
        private void Monan_Load(object sender, EventArgs e)
        {
            lbDishName.Text = m.name;
            txtPrice.Text = m.price.ToString();
            if(f_dc.GetDishCategory(m.id_category)!=null)
            txtCategory.Text = f_dc.GetDishCategory(m.id_category).name;
            else
                txtCategory.Text = "Untitled category";
            try
            {
                var avt = m.image;
                pictureBox1.Load(avt);
                
            }
            catch
            {
                pictureBox1.Image = Resource1.a;
                
            }
            PrintInformation();
        }
        public void PrintInformation() // print the description and the ingredient of dish
        {
            // pnlMain
            // 
            System.Windows.Forms.Panel pnlMain = new System.Windows.Forms.Panel();
            pnlMain.SuspendLayout();
            pnlMain.AutoSize = true;
            pnlMain.Location = new System.Drawing.Point(290, 170);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(410, 203);
            pnlMain.TabIndex = 12;


            System.Windows.Forms.Panel pnlItem1 = new System.Windows.Forms.Panel();
            pnlItem1.AutoSize = true;
            pnlItem1.Dock = System.Windows.Forms.DockStyle.Top;
            pnlItem1.Location = new System.Drawing.Point(0, 0);
            pnlItem1.Name = "pnlItem1";
            pnlItem1.Size = new System.Drawing.Size(410, 32);
            pnlItem1.TabIndex = 0;
            pnlItem1.ResumeLayout(false);
            pnlItem1.PerformLayout();
            pnlItem1.SuspendLayout();


            //Create the label text "Ingredient"
            System.Windows.Forms.Label lbThanhPhan = new System.Windows.Forms.Label();
            lbThanhPhan.AutoSize = true;
            lbThanhPhan.BackColor = System.Drawing.SystemColors.Control;
            lbThanhPhan.Dock = System.Windows.Forms.DockStyle.Top;
            lbThanhPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbThanhPhan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lbThanhPhan.Location = new System.Drawing.Point(0, 0);
            lbThanhPhan.Name = "lbThanhPhan";
            lbThanhPhan.Size = new System.Drawing.Size(175, 32);
            lbThanhPhan.TabIndex = 5;
            lbThanhPhan.Text = "Ingredient:";


            pnlItem1.Controls.Add(lbThanhPhan);

            


            //them thanh phan vao panel
            var list_tp = m.description;
            foreach (var item in list_tp)
            {
                // pnlItem
                // 
                System.Windows.Forms.Panel pnlItem = new System.Windows.Forms.Panel();
                pnlItem.AutoSize = true;
                
                pnlItem.Dock = System.Windows.Forms.DockStyle.Top;
                pnlItem.Location = new System.Drawing.Point(0, 0);
                pnlItem.Name = "pnlItem"+item;
                pnlItem.Size = new System.Drawing.Size(410, 32);
                pnlItem.TabIndex = 0;
                pnlItem.ResumeLayout(false);
                pnlItem.PerformLayout();
                pnlItem.SuspendLayout();

                // txtThanhphan
                // 
                txtThanhphan = new System.Windows.Forms.Label();

                txtThanhphan.AutoSize = true;
                txtThanhphan.BackColor = System.Drawing.SystemColors.Control;
                txtThanhphan.Dock = System.Windows.Forms.DockStyle.Top;
                txtThanhphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtThanhphan.ForeColor = System.Drawing.Color.Chocolate;
                txtThanhphan.Location = new System.Drawing.Point(0, 0);
                txtThanhphan.Name = item;
                txtThanhphan.Size = new System.Drawing.Size(31, 32);
                txtThanhphan.TabIndex = 8;
                txtThanhphan.Left = 5;
                txtThanhphan.Text = item;

                pnlItem.Controls.Add(txtThanhphan);
                pnlMain.Controls.Add(pnlItem);
            }           
            pnlMain.Controls.Add(pnlItem1);



            //panel label cach lam 
            System.Windows.Forms.Panel pnlItem2 = new System.Windows.Forms.Panel();
            pnlItem2.AutoSize = true;
            pnlItem2.Dock = System.Windows.Forms.DockStyle.Top;
            pnlItem2.Location = new System.Drawing.Point(0, 0);
            pnlItem2.Name = "pnlItem1";
            pnlItem2.Size = new System.Drawing.Size(410, 32);
            pnlItem2.TabIndex = 0;
            pnlItem2.ResumeLayout(false);
            pnlItem2.PerformLayout();
            pnlItem2.SuspendLayout();


            //Thanh phan label
            System.Windows.Forms.Label lbCachlam = new System.Windows.Forms.Label();
            lbCachlam.AutoSize = true;
            lbCachlam.BackColor = System.Drawing.SystemColors.Control;
            lbCachlam.Dock = System.Windows.Forms.DockStyle.Top;
            lbCachlam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbCachlam.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lbCachlam.Location = new System.Drawing.Point(0, 0);
            lbCachlam.Name = "lbcachlam";
            lbCachlam.Size = new System.Drawing.Size(175, 32);
            lbCachlam.TabIndex = 5;
            lbCachlam.Text = "Description: ";


            pnlItem2.Controls.Add(lbCachlam);




            //them thanh phan vao panel
            var list_cl = m.ingredient;
            foreach (var item in list_cl)
            {
                // pnlItem
                // 
                System.Windows.Forms.Panel pnlItem = new System.Windows.Forms.Panel();
                pnlItem.AutoSize = true;

                pnlItem.Dock = System.Windows.Forms.DockStyle.Top;
                pnlItem.Location = new System.Drawing.Point(0, 0);
                pnlItem.Name = "pnlItem2" + item;
                pnlItem.Size = new System.Drawing.Size(410, 32);
                pnlItem.TabIndex = 0;
                pnlItem.ResumeLayout(false);
                pnlItem.PerformLayout();
                pnlItem.SuspendLayout();

                // txtCah lam
                // 
                txtThanhphan = new System.Windows.Forms.Label();

                txtThanhphan.AutoSize = true;
                txtThanhphan.BackColor = System.Drawing.SystemColors.Control;
                txtThanhphan.Dock = System.Windows.Forms.DockStyle.Top;
                txtThanhphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtThanhphan.ForeColor = System.Drawing.Color.Chocolate;
                txtThanhphan.Location = new System.Drawing.Point(0, 0);
                txtThanhphan.Name = item;
                txtThanhphan.Size = new System.Drawing.Size(31, 32);
                txtThanhphan.TabIndex = 8;
                txtThanhphan.Left = 5;
                txtThanhphan.Text = item;

                pnlItem.Controls.Add(txtThanhphan);
                pnlMain.Controls.Add(pnlItem);
            }
            pnlMain.Controls.Add(pnlItem2);





            Controls.Add(pnlMain);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();


            
        }
    }
}
