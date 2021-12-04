
namespace OrderFood
{
    partial class frm_AccountManager
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
            System.Windows.Forms.Button btnDelete;
            System.Windows.Forms.Button btnEdit;
            System.Windows.Forms.Button btnCancel;
            System.Windows.Forms.Button btnAdd;
            this.dgv = new System.Windows.Forms.DataGridView();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnDelete.Location = new System.Drawing.Point(590, 78);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(104, 41);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            btnEdit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnEdit.Location = new System.Drawing.Point(699, 78);
            btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(104, 41);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.Black;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnCancel.Location = new System.Drawing.Point(154, 78);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(104, 41);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.BlueViolet;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnAdd.Location = new System.Drawing.Point(809, 78);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(104, 41);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(154, 156);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(759, 398);
            this.dgv.TabIndex = 6;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Select);
            // 
            // frm_AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1066, 632);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnEdit);
            this.Controls.Add(btnCancel);
            this.Controls.Add(btnAdd);
            this.Controls.Add(this.dgv);
            this.Name = "frm_AccountManager";
            this.Text = "Account Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
    }
}