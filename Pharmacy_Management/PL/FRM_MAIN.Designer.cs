namespace Pharmacy_Management.PL
{
    partial class FRM_MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MAIN));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMFILE = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMPRODUCT = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMPrpductmanagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddproduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMTypesmanagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddtype = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMActiveMaterialManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddActiveMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMSceintificName = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddSCEINTIFICnAME = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCOSTUMERS = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCustomersmanagement = new System.Windows.Forms.ToolStripMenuItem();
            this.RSMAddcostumers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMBuymanagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNewbuy = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSUPPLIERS = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSuppliersmanagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddsupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMSalesManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNewPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.usersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAdduser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMFILE,
            this.TSMPRODUCT,
            this.TSMCOSTUMERS,
            this.TSMSUPPLIERS,
            this.TSMUsers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMFILE
            // 
            this.TSMFILE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMLogin,
            this.TSMLogout,
            this.toolStripSeparator2,
            this.TSMBackup,
            this.TSMRestore});
            this.TSMFILE.Name = "TSMFILE";
            this.TSMFILE.Size = new System.Drawing.Size(39, 20);
            this.TSMFILE.Text = "FILE";
            // 
            // TSMLogin
            // 
            this.TSMLogin.Name = "TSMLogin";
            this.TSMLogin.Size = new System.Drawing.Size(121, 22);
            this.TSMLogin.Text = "LOG IN";
            this.TSMLogin.Click += new System.EventHandler(this.TSMLogin_Click);
            // 
            // TSMLogout
            // 
            this.TSMLogout.Name = "TSMLogout";
            this.TSMLogout.Size = new System.Drawing.Size(121, 22);
            this.TSMLogout.Text = "LOG OUT";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
            // 
            // TSMBackup
            // 
            this.TSMBackup.Enabled = false;
            this.TSMBackup.Name = "TSMBackup";
            this.TSMBackup.Size = new System.Drawing.Size(121, 22);
            this.TSMBackup.Text = "Backup";
            // 
            // TSMRestore
            // 
            this.TSMRestore.Enabled = false;
            this.TSMRestore.Name = "TSMRestore";
            this.TSMRestore.Size = new System.Drawing.Size(121, 22);
            this.TSMRestore.Text = "Restore";
            // 
            // TSMPRODUCT
            // 
            this.TSMPRODUCT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMPrpductmanagement,
            this.TSMAddproduct,
            this.toolStripSeparator1,
            this.TSMTypesmanagement,
            this.TSMAddtype,
            this.toolStripSeparator5,
            this.TSMActiveMaterialManagement,
            this.TSMAddActiveMaterial,
            this.toolStripSeparator6,
            this.TSMSceintificName,
            this.TSMAddSCEINTIFICnAME});
            this.TSMPRODUCT.Enabled = false;
            this.TSMPRODUCT.Name = "TSMPRODUCT";
            this.TSMPRODUCT.Size = new System.Drawing.Size(69, 20);
            this.TSMPRODUCT.Text = "PRODUCT";
            // 
            // TSMPrpductmanagement
            // 
            this.TSMPrpductmanagement.Name = "TSMPrpductmanagement";
            this.TSMPrpductmanagement.Size = new System.Drawing.Size(243, 22);
            this.TSMPrpductmanagement.Text = "Products Management";
            this.TSMPrpductmanagement.Click += new System.EventHandler(this.TSMPrpductmanagement_Click);
            // 
            // TSMAddproduct
            // 
            this.TSMAddproduct.Name = "TSMAddproduct";
            this.TSMAddproduct.Size = new System.Drawing.Size(243, 22);
            this.TSMAddproduct.Text = "Add new Product";
            this.TSMAddproduct.Click += new System.EventHandler(this.TSMAddproduct_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(240, 6);
            // 
            // TSMTypesmanagement
            // 
            this.TSMTypesmanagement.Name = "TSMTypesmanagement";
            this.TSMTypesmanagement.Size = new System.Drawing.Size(243, 22);
            this.TSMTypesmanagement.Text = "Product Categories Management";
            this.TSMTypesmanagement.Click += new System.EventHandler(this.TSMTypesmanagement_Click);
            // 
            // TSMAddtype
            // 
            this.TSMAddtype.Name = "TSMAddtype";
            this.TSMAddtype.Size = new System.Drawing.Size(243, 22);
            this.TSMAddtype.Text = "Add New Category";
            this.TSMAddtype.Click += new System.EventHandler(this.TSMAddtype_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(240, 6);
            // 
            // TSMActiveMaterialManagement
            // 
            this.TSMActiveMaterialManagement.Name = "TSMActiveMaterialManagement";
            this.TSMActiveMaterialManagement.Size = new System.Drawing.Size(243, 22);
            this.TSMActiveMaterialManagement.Text = "Active material Management";
            this.TSMActiveMaterialManagement.Click += new System.EventHandler(this.TSMActiveMaterialManagement_Click);
            // 
            // TSMAddActiveMaterial
            // 
            this.TSMAddActiveMaterial.Name = "TSMAddActiveMaterial";
            this.TSMAddActiveMaterial.Size = new System.Drawing.Size(243, 22);
            this.TSMAddActiveMaterial.Text = "Add Active material";
            this.TSMAddActiveMaterial.Click += new System.EventHandler(this.TSMAddActiveMaterial_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(240, 6);
            // 
            // TSMSceintificName
            // 
            this.TSMSceintificName.Name = "TSMSceintificName";
            this.TSMSceintificName.Size = new System.Drawing.Size(243, 22);
            this.TSMSceintificName.Text = "scientificname Management";
            this.TSMSceintificName.Click += new System.EventHandler(this.TSMSceintificName_Click);
            // 
            // TSMAddSCEINTIFICnAME
            // 
            this.TSMAddSCEINTIFICnAME.Name = "TSMAddSCEINTIFICnAME";
            this.TSMAddSCEINTIFICnAME.Size = new System.Drawing.Size(243, 22);
            this.TSMAddSCEINTIFICnAME.Text = "Add sceintific Name";
            this.TSMAddSCEINTIFICnAME.Click += new System.EventHandler(this.TSMAddSCEINTIFICnAME_Click);
            // 
            // TSMCOSTUMERS
            // 
            this.TSMCOSTUMERS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMCustomersmanagement,
            this.RSMAddcostumers,
            this.toolStripSeparator3,
            this.TSMBuymanagement,
            this.TSMNewbuy});
            this.TSMCOSTUMERS.Enabled = false;
            this.TSMCOSTUMERS.Name = "TSMCOSTUMERS";
            this.TSMCOSTUMERS.Size = new System.Drawing.Size(83, 20);
            this.TSMCOSTUMERS.Text = "CUSTOMERS";
            // 
            // TSMCustomersmanagement
            // 
            this.TSMCustomersmanagement.Name = "TSMCustomersmanagement";
            this.TSMCustomersmanagement.Size = new System.Drawing.Size(199, 22);
            this.TSMCustomersmanagement.Text = "Customers Management";
            // 
            // RSMAddcostumers
            // 
            this.RSMAddcostumers.Name = "RSMAddcostumers";
            this.RSMAddcostumers.Size = new System.Drawing.Size(199, 22);
            this.RSMAddcostumers.Text = "Add New Castomer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(196, 6);
            // 
            // TSMBuymanagement
            // 
            this.TSMBuymanagement.Name = "TSMBuymanagement";
            this.TSMBuymanagement.Size = new System.Drawing.Size(199, 22);
            this.TSMBuymanagement.Text = "Sales Administration";
            // 
            // TSMNewbuy
            // 
            this.TSMNewbuy.Name = "TSMNewbuy";
            this.TSMNewbuy.Size = new System.Drawing.Size(199, 22);
            this.TSMNewbuy.Text = "New Sale Process";
            // 
            // TSMSUPPLIERS
            // 
            this.TSMSUPPLIERS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMSuppliersmanagement,
            this.TSMAddsupplier,
            this.toolStripSeparator4,
            this.TSMSalesManagement,
            this.TSMNewPurchase});
            this.TSMSUPPLIERS.Enabled = false;
            this.TSMSUPPLIERS.Name = "TSMSUPPLIERS";
            this.TSMSUPPLIERS.Size = new System.Drawing.Size(72, 20);
            this.TSMSUPPLIERS.Text = "SUPPLIERS";
            // 
            // TSMSuppliersmanagement
            // 
            this.TSMSuppliersmanagement.Name = "TSMSuppliersmanagement";
            this.TSMSuppliersmanagement.Size = new System.Drawing.Size(193, 22);
            this.TSMSuppliersmanagement.Text = "Suppliers Management";
            this.TSMSuppliersmanagement.Click += new System.EventHandler(this.TSMSuppliersmanagement_Click);
            // 
            // TSMAddsupplier
            // 
            this.TSMAddsupplier.Name = "TSMAddsupplier";
            this.TSMAddsupplier.Size = new System.Drawing.Size(193, 22);
            this.TSMAddsupplier.Text = "Add new Suppliers";
            this.TSMAddsupplier.Click += new System.EventHandler(this.TSMAddsupplier_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(190, 6);
            // 
            // TSMSalesManagement
            // 
            this.TSMSalesManagement.Name = "TSMSalesManagement";
            this.TSMSalesManagement.Size = new System.Drawing.Size(193, 22);
            this.TSMSalesManagement.Text = "Purchase Management";
            // 
            // TSMNewPurchase
            // 
            this.TSMNewPurchase.Name = "TSMNewPurchase";
            this.TSMNewPurchase.Size = new System.Drawing.Size(193, 22);
            this.TSMNewPurchase.Text = "New Purchase Process";
            // 
            // TSMUsers
            // 
            this.TSMUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersManagementToolStripMenuItem,
            this.TSMAdduser});
            this.TSMUsers.Enabled = false;
            this.TSMUsers.Name = "TSMUsers";
            this.TSMUsers.Size = new System.Drawing.Size(52, 20);
            this.TSMUsers.Text = "USERS";
            // 
            // usersManagementToolStripMenuItem
            // 
            this.usersManagementToolStripMenuItem.Name = "usersManagementToolStripMenuItem";
            this.usersManagementToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.usersManagementToolStripMenuItem.Text = "Users Management";
            // 
            // TSMAdduser
            // 
            this.TSMAdduser.Name = "TSMAdduser";
            this.TSMAdduser.Size = new System.Drawing.Size(173, 22);
            this.TSMAdduser.Text = "Add new User";
            this.TSMAdduser.Click += new System.EventHandler(this.TSMAdduser_Click);
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 465);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_MAIN";
            this.Text = "Project Management Sales and Purchases Pharmacy";
            this.Activated += new System.EventHandler(this.FRM_MAIN_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMFILE;
        private System.Windows.Forms.ToolStripMenuItem TSMLogin;
        private System.Windows.Forms.ToolStripMenuItem TSMLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMBackup;
        private System.Windows.Forms.ToolStripMenuItem TSMRestore;
        private System.Windows.Forms.ToolStripMenuItem TSMPRODUCT;
        private System.Windows.Forms.ToolStripMenuItem TSMPrpductmanagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddproduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMTypesmanagement;
        private System.Windows.Forms.ToolStripMenuItem TSMCOSTUMERS;
        private System.Windows.Forms.ToolStripMenuItem TSMCustomersmanagement;
        private System.Windows.Forms.ToolStripMenuItem RSMAddcostumers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem TSMBuymanagement;
        private System.Windows.Forms.ToolStripMenuItem TSMNewbuy;
        private System.Windows.Forms.ToolStripMenuItem TSMSUPPLIERS;
        private System.Windows.Forms.ToolStripMenuItem TSMSuppliersmanagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddsupplier;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem TSMSalesManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMNewPurchase;
        private System.Windows.Forms.ToolStripMenuItem TSMUsers;
        private System.Windows.Forms.ToolStripMenuItem usersManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMAdduser;
        private System.Windows.Forms.ToolStripMenuItem TSMAddtype;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem TSMActiveMaterialManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddActiveMaterial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem TSMSceintificName;
        private System.Windows.Forms.ToolStripMenuItem TSMAddSCEINTIFICnAME;
    }
}