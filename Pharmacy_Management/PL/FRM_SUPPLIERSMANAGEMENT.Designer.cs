namespace Pharmacy_Management.PL
{
    partial class FRM_SUPPLIERSMANAGEMENT
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
            this.SUPPLIERS = new System.Windows.Forms.GroupBox();
            this.dgv_suppliers = new System.Windows.Forms.DataGridView();
            this.PROCESSES = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.SUPPLIERS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers)).BeginInit();
            this.PROCESSES.SuspendLayout();
            this.SuspendLayout();
            // 
            // SUPPLIERS
            // 
            this.SUPPLIERS.Controls.Add(this.dgv_suppliers);
            this.SUPPLIERS.Location = new System.Drawing.Point(12, 47);
            this.SUPPLIERS.Name = "SUPPLIERS";
            this.SUPPLIERS.Size = new System.Drawing.Size(547, 253);
            this.SUPPLIERS.TabIndex = 0;
            this.SUPPLIERS.TabStop = false;
            this.SUPPLIERS.Text = "SUPPLIERS";
            // 
            // dgv_suppliers
            // 
            this.dgv_suppliers.AllowUserToAddRows = false;
            this.dgv_suppliers.AllowUserToDeleteRows = false;
            this.dgv_suppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_suppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_suppliers.Location = new System.Drawing.Point(3, 16);
            this.dgv_suppliers.MultiSelect = false;
            this.dgv_suppliers.Name = "dgv_suppliers";
            this.dgv_suppliers.ReadOnly = true;
            this.dgv_suppliers.RowHeadersVisible = false;
            this.dgv_suppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_suppliers.Size = new System.Drawing.Size(541, 234);
            this.dgv_suppliers.TabIndex = 0;
            // 
            // PROCESSES
            // 
            this.PROCESSES.Controls.Add(this.btn_exit);
            this.PROCESSES.Controls.Add(this.btn_delete);
            this.PROCESSES.Controls.Add(this.btn_modify);
            this.PROCESSES.Controls.Add(this.btn_add);
            this.PROCESSES.Controls.Add(this.btn_display);
            this.PROCESSES.Location = new System.Drawing.Point(12, 306);
            this.PROCESSES.Name = "PROCESSES";
            this.PROCESSES.Size = new System.Drawing.Size(562, 77);
            this.PROCESSES.TabIndex = 1;
            this.PROCESSES.TabStop = false;
            this.PROCESSES.Text = "PROCESSES";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(478, 19);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 37);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(342, 18);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(130, 38);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "DELETE SELECTED  SUPPLIER";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(236, 19);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(100, 37);
            this.btn_modify.TabIndex = 2;
            this.btn_modify.Text = "MODIFY SUPPLIER DATA";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(118, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 37);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "ADD NEW  SUPPLIERS";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(6, 19);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(106, 37);
            this.btn_display.TabIndex = 0;
            this.btn_display.Text = "SHOW ALL SUPPLIERS ";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "INSERT WORD TO SEARCH : ";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(174, 18);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(382, 20);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // FRM_SUPPLIERSMANAGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 434);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PROCESSES);
            this.Controls.Add(this.SUPPLIERS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FRM_SUPPLIERSMANAGEMENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUPPLIERS MANAGEMENT ";
            this.Activated += new System.EventHandler(this.FRM_SUPPLIERSMANAGEMENT_Activated);
            this.SUPPLIERS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers)).EndInit();
            this.PROCESSES.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SUPPLIERS;
        private System.Windows.Forms.DataGridView dgv_suppliers;
        private System.Windows.Forms.GroupBox PROCESSES;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
    }
}