namespace Pharmacy_Management.PL
{
    partial class FRM_ActiveMaterialManagement
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
            this.dgvActiveMaterials = new System.Windows.Forms.DataGridView();
            this.btn_Display = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AMDesecription = new System.Windows.Forms.TextBox();
            this.txt_AMName = new System.Windows.Forms.TextBox();
            this.txt_AMID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveMaterials)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvActiveMaterials);
            this.groupBox1.Location = new System.Drawing.Point(35, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACTIVE MATERIAL";
            // 
            // dgvActiveMaterials
            // 
            this.dgvActiveMaterials.AllowUserToAddRows = false;
            this.dgvActiveMaterials.AllowUserToDeleteRows = false;
            this.dgvActiveMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveMaterials.Location = new System.Drawing.Point(3, 16);
            this.dgvActiveMaterials.Name = "dgvActiveMaterials";
            this.dgvActiveMaterials.ReadOnly = true;
            this.dgvActiveMaterials.RowHeadersVisible = false;
            this.dgvActiveMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveMaterials.Size = new System.Drawing.Size(455, 328);
            this.dgvActiveMaterials.TabIndex = 0;
            this.dgvActiveMaterials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveMaterials_CellClick);
            this.dgvActiveMaterials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveMaterials_CellContentClick);
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(570, 28);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(172, 23);
            this.btn_Display.TabIndex = 1;
            this.btn_Display.Text = "SHOW SEARCH RESULT";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_AMDesecription);
            this.groupBox2.Controls.Add(this.txt_AMName);
            this.groupBox2.Controls.Add(this.txt_AMID);
            this.groupBox2.Location = new System.Drawing.Point(502, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 172);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATA ACTIVE MATERIAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Desecription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Active Material Name : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Active Material ID :";
            // 
            // txt_AMDesecription
            // 
            this.txt_AMDesecription.Location = new System.Drawing.Point(123, 87);
            this.txt_AMDesecription.Multiline = true;
            this.txt_AMDesecription.Name = "txt_AMDesecription";
            this.txt_AMDesecription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_AMDesecription.Size = new System.Drawing.Size(178, 79);
            this.txt_AMDesecription.TabIndex = 2;
            // 
            // txt_AMName
            // 
            this.txt_AMName.Location = new System.Drawing.Point(123, 51);
            this.txt_AMName.Name = "txt_AMName";
            this.txt_AMName.Size = new System.Drawing.Size(178, 20);
            this.txt_AMName.TabIndex = 1;
            // 
            // txt_AMID
            // 
            this.txt_AMID.Location = new System.Drawing.Point(123, 17);
            this.txt_AMID.Name = "txt_AMID";
            this.txt_AMID.ReadOnly = true;
            this.txt_AMID.Size = new System.Drawing.Size(178, 20);
            this.txt_AMID.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Print);
            this.groupBox3.Controls.Add(this.btn_Delete);
            this.groupBox3.Controls.Add(this.btn_Update);
            this.groupBox3.Controls.Add(this.btn_SelectAll);
            this.groupBox3.Location = new System.Drawing.Point(502, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 148);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OPERATION OF ACTIVE MATERIAL";
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(14, 97);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(114, 23);
            this.btn_Print.TabIndex = 3;
            this.btn_Print.Text = "Print  the Active Material";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(199, 97);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(131, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete the Active Material";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(14, 30);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(114, 41);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Modify the Active Material";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.Location = new System.Drawing.Point(199, 30);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(131, 41);
            this.btn_SelectAll.TabIndex = 0;
            this.btn_SelectAll.Text = "Show All Active Material";
            this.btn_SelectAll.UseVisualStyleBackColor = true;
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(295, 30);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(239, 20);
            this.txt_Search.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SEARCH WORD :";
            // 
            // FRM_ActiveMaterialManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FRM_ActiveMaterialManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OPERATION OF ACTIVE MATERIAL";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveMaterials)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvActiveMaterials;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AMDesecription;
        private System.Windows.Forms.TextBox txt_AMName;
        private System.Windows.Forms.TextBox txt_AMID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_SelectAll;
    }
}