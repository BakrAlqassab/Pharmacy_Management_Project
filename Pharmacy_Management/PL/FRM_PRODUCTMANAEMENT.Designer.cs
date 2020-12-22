namespace Pharmacy_Management.PL
{
    partial class FRM_PRODUCTMANAEMENT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPRODUCTS = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DispalyPrductExpire = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_DispalyAll = new System.Windows.Forms.Button();
            this.btn_AddnewProduct = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_DipalyProductImage = new System.Windows.Forms.Button();
            this.btn_PrintSelectedProdust = new System.Windows.Forms.Button();
            this.btn_PrintAllProducts = new System.Windows.Forms.Button();
            this.btn_SaveToExcel = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPRODUCTS);
            this.groupBox1.Location = new System.Drawing.Point(3, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1231, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUSCTS";
            // 
            // dgvPRODUCTS
            // 
            this.dgvPRODUCTS.AllowUserToAddRows = false;
            this.dgvPRODUCTS.AllowUserToDeleteRows = false;
            this.dgvPRODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUCTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column1});
            this.dgvPRODUCTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPRODUCTS.Location = new System.Drawing.Point(3, 16);
            this.dgvPRODUCTS.MultiSelect = false;
            this.dgvPRODUCTS.Name = "dgvPRODUCTS";
            this.dgvPRODUCTS.ReadOnly = true;
            this.dgvPRODUCTS.RowHeadersVisible = false;
            this.dgvPRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPRODUCTS.Size = new System.Drawing.Size(1225, 270);
            this.dgvPRODUCTS.TabIndex = 0;
            this.dgvPRODUCTS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Product Number";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Category";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Product Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Active Material";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Scientific Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Buy Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sell Price";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Quantity in Stock";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "BarCode";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Desicription";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_DispalyPrductExpire);
            this.groupBox2.Controls.Add(this.btn_Exit);
            this.groupBox2.Controls.Add(this.btn_DispalyAll);
            this.groupBox2.Controls.Add(this.btn_AddnewProduct);
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_DipalyProductImage);
            this.groupBox2.Controls.Add(this.btn_PrintSelectedProdust);
            this.groupBox2.Controls.Add(this.btn_PrintAllProducts);
            this.groupBox2.Controls.Add(this.btn_SaveToExcel);
            this.groupBox2.Location = new System.Drawing.Point(3, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1083, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PROCESSES";
            // 
            // btn_DispalyPrductExpire
            // 
            this.btn_DispalyPrductExpire.Location = new System.Drawing.Point(430, 87);
            this.btn_DispalyPrductExpire.Name = "btn_DispalyPrductExpire";
            this.btn_DispalyPrductExpire.Size = new System.Drawing.Size(139, 29);
            this.btn_DispalyPrductExpire.TabIndex = 9;
            this.btn_DispalyPrductExpire.Text = "Show Product Expire";
            this.btn_DispalyPrductExpire.UseVisualStyleBackColor = true;
            this.btn_DispalyPrductExpire.Click += new System.EventHandler(this.btn_DispalyPrductExpire_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(9, 77);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(122, 39);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_DispalyAll
            // 
            this.btn_DispalyAll.Location = new System.Drawing.Point(9, 41);
            this.btn_DispalyAll.Name = "btn_DispalyAll";
            this.btn_DispalyAll.Size = new System.Drawing.Size(122, 29);
            this.btn_DispalyAll.TabIndex = 7;
            this.btn_DispalyAll.Text = "Show All Produsts";
            this.btn_DispalyAll.UseVisualStyleBackColor = true;
            this.btn_DispalyAll.Click += new System.EventHandler(this.btn_DispalyAll_Click);
            // 
            // btn_AddnewProduct
            // 
            this.btn_AddnewProduct.Location = new System.Drawing.Point(150, 41);
            this.btn_AddnewProduct.Name = "btn_AddnewProduct";
            this.btn_AddnewProduct.Size = new System.Drawing.Size(101, 29);
            this.btn_AddnewProduct.TabIndex = 6;
            this.btn_AddnewProduct.Text = "Add New Product";
            this.btn_AddnewProduct.UseVisualStyleBackColor = true;
            this.btn_AddnewProduct.Click += new System.EventHandler(this.btn_AddnewProduct_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(266, 41);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(141, 29);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Edit te Selected Product";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(430, 41);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(139, 29);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete The Selected Produst";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_DipalyProductImage
            // 
            this.btn_DipalyProductImage.Location = new System.Drawing.Point(594, 41);
            this.btn_DipalyProductImage.Name = "btn_DipalyProductImage";
            this.btn_DipalyProductImage.Size = new System.Drawing.Size(128, 29);
            this.btn_DipalyProductImage.TabIndex = 3;
            this.btn_DipalyProductImage.Text = "Show Product Image";
            this.btn_DipalyProductImage.UseVisualStyleBackColor = true;
            this.btn_DipalyProductImage.Click += new System.EventHandler(this.btn_DipalyProductImage_Click);
            // 
            // btn_PrintSelectedProdust
            // 
            this.btn_PrintSelectedProdust.Location = new System.Drawing.Point(923, 41);
            this.btn_PrintSelectedProdust.Name = "btn_PrintSelectedProdust";
            this.btn_PrintSelectedProdust.Size = new System.Drawing.Size(127, 29);
            this.btn_PrintSelectedProdust.TabIndex = 2;
            this.btn_PrintSelectedProdust.Text = "Print All Products";
            this.btn_PrintSelectedProdust.UseVisualStyleBackColor = true;
            this.btn_PrintSelectedProdust.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_PrintAllProducts
            // 
            this.btn_PrintAllProducts.Location = new System.Drawing.Point(738, 41);
            this.btn_PrintAllProducts.Name = "btn_PrintAllProducts";
            this.btn_PrintAllProducts.Size = new System.Drawing.Size(151, 29);
            this.btn_PrintAllProducts.TabIndex = 1;
            this.btn_PrintAllProducts.Text = "Print the Selected Product";
            this.btn_PrintAllProducts.UseVisualStyleBackColor = true;
            // 
            // btn_SaveToExcel
            // 
            this.btn_SaveToExcel.Location = new System.Drawing.Point(150, 77);
            this.btn_SaveToExcel.Name = "btn_SaveToExcel";
            this.btn_SaveToExcel.Size = new System.Drawing.Size(257, 39);
            this.btn_SaveToExcel.TabIndex = 0;
            this.btn_SaveToExcel.Text = "Save Product List in Excel";
            this.btn_SaveToExcel.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(169, 23);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(648, 20);
            this.txt_Search.TabIndex = 2;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "WORD TO SEARCH : ";
            // 
            // FRM_PRODUCTMANAEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FRM_PRODUCTMANAEMENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PRODUCT MANAGEMENT";
            this.Activated += new System.EventHandler(this.FRM_PRODUCTMANAEMENT_Activated);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPRODUCTS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PrintSelectedProdust;
        private System.Windows.Forms.Button btn_PrintAllProducts;
        private System.Windows.Forms.Button btn_SaveToExcel;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_DispalyAll;
        private System.Windows.Forms.Button btn_AddnewProduct;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_DipalyProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_DispalyPrductExpire;
    }
}