
namespace OrderFood
{
    partial class frm_DishMananger
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
            System.Windows.Forms.Button btnAdd;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button btnA;
            System.Windows.Forms.Button btnDelete;
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAdd = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnA = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.BlueViolet;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnAdd.Location = new System.Drawing.Point(500, 36);
            btnAdd.Margin = new System.Windows.Forms.Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(78, 33);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Black;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            button1.Location = new System.Drawing.Point(9, 36);
            button1.Margin = new System.Windows.Forms.Padding(2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(78, 33);
            button1.TabIndex = 3;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnA
            // 
            btnA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnA.Location = new System.Drawing.Point(418, 36);
            btnA.Margin = new System.Windows.Forms.Padding(2);
            btnA.Name = "btnA";
            btnA.Size = new System.Drawing.Size(78, 33);
            btnA.TabIndex = 4;
            btnA.Text = "Edit";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.id_category,
            this.ingredient,
            this.description,
            this.image,
            this.price});
            this.dgv.Location = new System.Drawing.Point(9, 99);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(569, 323);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Select);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Dish name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // id_category
            // 
            this.id_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_category.DataPropertyName = "id_category";
            this.id_category.HeaderText = "Category";
            this.id_category.MinimumWidth = 6;
            this.id_category.Name = "id_category";
            this.id_category.ReadOnly = true;
            // 
            // ingredient
            // 
            this.ingredient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ingredient.DataPropertyName = "ingredient";
            this.ingredient.HeaderText = "Ingredient";
            this.ingredient.MinimumWidth = 6;
            this.ingredient.Name = "ingredient";
            this.ingredient.ReadOnly = true;
            this.ingredient.Visible = false;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "image";
            this.image.MinimumWidth = 6;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Visible = false;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnDelete.Location = new System.Drawing.Point(336, 36);
            btnDelete.Margin = new System.Windows.Forms.Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(78, 33);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frm_DishMananger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(592, 431);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnA);
            this.Controls.Add(button1);
            this.Controls.Add(btnAdd);
            this.Controls.Add(this.dgv);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_DishMananger";
            this.Text = "Dish manager";
            this.Load += new System.EventHandler(this.DanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}