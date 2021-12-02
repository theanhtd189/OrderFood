
namespace OrderFood
{
    partial class frm_MainMenu
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
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsListDC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDishManager = new System.Windows.Forms.ToolStripMenuItem();
            this.accountManangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.center = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTotal = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.right = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlChinh = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnThaydoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.right.SuspendLayout();
            this.pnlChinh.SuspendLayout();
            this.pnlSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(77, 578);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "Log out";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsListDC,
            this.tsAccount,
            this.tsDeleteAll,
            this.tsDishManager,
            this.accountManangerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(275, 622);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsListDC
            // 
            this.tsListDC.Name = "tsListDC";
            this.tsListDC.Size = new System.Drawing.Size(269, 24);
            this.tsListDC.Text = "Dish Category";
            // 
            // tsAccount
            // 
            this.tsAccount.Name = "tsAccount";
            this.tsAccount.Size = new System.Drawing.Size(269, 24);
            this.tsAccount.Text = "Account Infomation";
            this.tsAccount.Click += new System.EventHandler(this.tsAccountInfo);
            // 
            // tsDeleteAll
            // 
            this.tsDeleteAll.Name = "tsDeleteAll";
            this.tsDeleteAll.Size = new System.Drawing.Size(269, 24);
            this.tsDeleteAll.Text = "Delete All Item ";
            this.tsDeleteAll.Click += new System.EventHandler(this.DeleteAll);
            // 
            // tsDishManager
            // 
            this.tsDishManager.Name = "tsDishManager";
            this.tsDishManager.Size = new System.Drawing.Size(269, 24);
            this.tsDishManager.Text = "Dish Mananger";
            this.tsDishManager.Click += new System.EventHandler(this.tsDishManager_Click);
            // 
            // accountManangerToolStripMenuItem
            // 
            this.accountManangerToolStripMenuItem.Name = "accountManangerToolStripMenuItem";
            this.accountManangerToolStripMenuItem.Size = new System.Drawing.Size(269, 24);
            this.accountManangerToolStripMenuItem.Text = "Account Mananger";
            this.accountManangerToolStripMenuItem.Click += new System.EventHandler(this.accountManangerToolStripMenuItem_Click);
            // 
            // center
            // 
            this.center.AutoScroll = true;
            this.center.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.center.BackColor = System.Drawing.SystemColors.Window;
            this.center.Dock = System.Windows.Forms.DockStyle.Left;
            this.center.Location = new System.Drawing.Point(275, 0);
            this.center.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(637, 622);
            this.center.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotal.Location = new System.Drawing.Point(912, 590);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(126, 32);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.Text = "Total: $0";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb.Location = new System.Drawing.Point(51, 139);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(169, 36);
            this.lb.TabIndex = 0;
            this.lb.Text = "WELCOME";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1323, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 622);
            this.panel1.TabIndex = 9;
            // 
            // right
            // 
            this.right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.right.AutoScroll = true;
            this.right.AutoSize = true;
            this.right.BackColor = System.Drawing.Color.GhostWhite;
            this.right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.right.Controls.Add(this.pnlChinh);
            this.right.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.right.Location = new System.Drawing.Point(911, 39);
            this.right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.right.Name = "right";
            this.right.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.right.Size = new System.Drawing.Size(416, 546);
            this.right.TabIndex = 11;
            // 
            // pnlChinh
            // 
            this.pnlChinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlChinh.AutoSize = true;
            this.pnlChinh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlChinh.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlChinh.Controls.Add(this.pnlSub);
            this.pnlChinh.Location = new System.Drawing.Point(4, 2);
            this.pnlChinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Size = new System.Drawing.Size(405, 54);
            this.pnlChinh.TabIndex = 1;
            // 
            // pnlSub
            // 
            this.pnlSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSub.Controls.Add(this.pnlInfo);
            this.pnlSub.Controls.Add(this.btnThaydoi);
            this.pnlSub.Controls.Add(this.btnXoa);
            this.pnlSub.Location = new System.Drawing.Point(3, 2);
            this.pnlSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(399, 50);
            this.pnlSub.TabIndex = 1;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(60, 0);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(262, 48);
            this.pnlInfo.TabIndex = 2;
            // 
            // btnThaydoi
            // 
            this.btnThaydoi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThaydoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThaydoi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThaydoi.Location = new System.Drawing.Point(322, 0);
            this.btnThaydoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThaydoi.Name = "btnThaydoi";
            this.btnThaydoi.Size = new System.Drawing.Size(75, 48);
            this.btnThaydoi.TabIndex = 1;
            this.btnThaydoi.Text = "Change";
            this.btnThaydoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.CausesValidation = false;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoa.Location = new System.Drawing.Point(0, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 48);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbHeader.Location = new System.Drawing.Point(912, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(411, 39);
            this.lbHeader.TabIndex = 12;
            this.lbHeader.Text = "User\'s Name";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1323, 622);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.right);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.center);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_MainMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.right.ResumeLayout(false);
            this.right.PerformLayout();
            this.pnlChinh.ResumeLayout(false);
            this.pnlSub.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel center;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel right;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.ToolStripMenuItem tsListDC;
        private System.Windows.Forms.ToolStripMenuItem tsAccount;
        private System.Windows.Forms.ToolStripMenuItem tsDeleteAll;
        private System.Windows.Forms.FlowLayoutPanel pnlChinh;
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnThaydoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ToolStripMenuItem tsDishManager;
        private System.Windows.Forms.ToolStripMenuItem accountManangerToolStripMenuItem;
    }
}