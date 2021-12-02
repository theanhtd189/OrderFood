
namespace OrderFood
{
    partial class frm_Dish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbDishName = new System.Windows.Forms.Label();
            this.lbKcal = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 390);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbDishName
            // 
            this.lbDishName.AutoSize = true;
            this.lbDishName.BackColor = System.Drawing.SystemColors.Control;
            this.lbDishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDishName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbDishName.Location = new System.Drawing.Point(464, 28);
            this.lbDishName.Name = "lbDishName";
            this.lbDishName.Size = new System.Drawing.Size(90, 32);
            this.lbDishName.TabIndex = 3;
            this.lbDishName.Text = "Name";
            // 
            // lbKcal
            // 
            this.lbKcal.AutoSize = true;
            this.lbKcal.BackColor = System.Drawing.SystemColors.Control;
            this.lbKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKcal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbKcal.Location = new System.Drawing.Point(389, 89);
            this.lbKcal.Name = "lbKcal";
            this.lbKcal.Size = new System.Drawing.Size(88, 32);
            this.lbKcal.TabIndex = 4;
            this.lbKcal.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Chocolate;
            this.txtPrice.Location = new System.Drawing.Point(556, 89);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(31, 32);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "0";
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.BackColor = System.Drawing.SystemColors.Control;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.ForeColor = System.Drawing.Color.Chocolate;
            this.txtCategory.Location = new System.Drawing.Point(556, 154);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(31, 32);
            this.txtCategory.TabIndex = 11;
            this.txtCategory.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(389, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 32);
            this.panel1.TabIndex = 1;
            // 
            // frm_Dish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(864, 476);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbKcal);
            this.Controls.Add(this.lbDishName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_Dish";
            this.Text = "Dish Infomation";
            this.Load += new System.EventHandler(this.Monan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbDishName;
        private System.Windows.Forms.Label lbKcal;
        private System.Windows.Forms.Label txtPrice;
      
        private System.Windows.Forms.Label txtThanhphan;
        private System.Windows.Forms.Label txtCategory;
        private System.Windows.Forms.Label label4;
        
        private System.Windows.Forms.Panel panel1;
    }
}