namespace Pharmacy_Management.PL
{
    partial class FRM_ADD_NEW_PRODUCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADD_NEW_PRODUCT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_CHOOSE = new System.Windows.Forms.Button();
            this.PICIMAGE = new System.Windows.Forms.PictureBox();
            this.TXT_SAEPRICE = new System.Windows.Forms.TextBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.TXT_BUYPRICE = new System.Windows.Forms.TextBox();
            this.TXT_PRODUCTDESCRIBE = new System.Windows.Forms.TextBox();
            this.TXT_PRODUCTNAME = new System.Windows.Forms.TextBox();
            this.CMB_SCIENTIFICNAME = new System.Windows.Forms.ComboBox();
            this.CMB_ACTIVEMATERIAL = new System.Windows.Forms.ComboBox();
            this.CMB_CAT = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICIMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_ADD);
            this.groupBox1.Controls.Add(this.BTN_CANCEL);
            this.groupBox1.Controls.Add(this.BTN_CHOOSE);
            this.groupBox1.Controls.Add(this.PICIMAGE);
            this.groupBox1.Controls.Add(this.TXT_SAEPRICE);
            this.groupBox1.Controls.Add(this.txt_barcode);
            this.groupBox1.Controls.Add(this.TXT_BUYPRICE);
            this.groupBox1.Controls.Add(this.TXT_PRODUCTDESCRIBE);
            this.groupBox1.Controls.Add(this.TXT_PRODUCTNAME);
            this.groupBox1.Controls.Add(this.CMB_SCIENTIFICNAME);
            this.groupBox1.Controls.Add(this.CMB_ACTIVEMATERIAL);
            this.groupBox1.Controls.Add(this.CMB_CAT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCT DATA";
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Location = new System.Drawing.Point(254, 425);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(75, 23);
            this.BTN_ADD.TabIndex = 20;
            this.BTN_ADD.Text = "ADD";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Location = new System.Drawing.Point(100, 425);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.BTN_CANCEL.TabIndex = 19;
            this.BTN_CANCEL.Text = "CANCEL";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_CHOOSE
            // 
            this.BTN_CHOOSE.Location = new System.Drawing.Point(98, 389);
            this.BTN_CHOOSE.Name = "BTN_CHOOSE";
            this.BTN_CHOOSE.Size = new System.Drawing.Size(245, 23);
            this.BTN_CHOOSE.TabIndex = 18;
            this.BTN_CHOOSE.Text = "Choose Product Name";
            this.BTN_CHOOSE.UseVisualStyleBackColor = true;
            this.BTN_CHOOSE.Click += new System.EventHandler(this.BTN_CHOOSE_Click);
            // 
            // PICIMAGE
            // 
            this.PICIMAGE.Image = ((System.Drawing.Image)(resources.GetObject("PICIMAGE.Image")));
            this.PICIMAGE.Location = new System.Drawing.Point(98, 285);
            this.PICIMAGE.Name = "PICIMAGE";
            this.PICIMAGE.Size = new System.Drawing.Size(245, 98);
            this.PICIMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICIMAGE.TabIndex = 17;
            this.PICIMAGE.TabStop = false;
            // 
            // TXT_SAEPRICE
            // 
            this.TXT_SAEPRICE.Location = new System.Drawing.Point(100, 167);
            this.TXT_SAEPRICE.Name = "TXT_SAEPRICE";
            this.TXT_SAEPRICE.Size = new System.Drawing.Size(245, 20);
            this.TXT_SAEPRICE.TabIndex = 16;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(100, 259);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(243, 20);
            this.txt_barcode.TabIndex = 15;
            // 
            // TXT_BUYPRICE
            // 
            this.TXT_BUYPRICE.Location = new System.Drawing.Point(100, 138);
            this.TXT_BUYPRICE.Name = "TXT_BUYPRICE";
            this.TXT_BUYPRICE.Size = new System.Drawing.Size(245, 20);
            this.TXT_BUYPRICE.TabIndex = 14;
            // 
            // TXT_PRODUCTDESCRIBE
            // 
            this.TXT_PRODUCTDESCRIBE.Location = new System.Drawing.Point(100, 87);
            this.TXT_PRODUCTDESCRIBE.Multiline = true;
            this.TXT_PRODUCTDESCRIBE.Name = "TXT_PRODUCTDESCRIBE";
            this.TXT_PRODUCTDESCRIBE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_PRODUCTDESCRIBE.Size = new System.Drawing.Size(243, 43);
            this.TXT_PRODUCTDESCRIBE.TabIndex = 13;
            this.TXT_PRODUCTDESCRIBE.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TXT_PRODUCTNAME
            // 
            this.TXT_PRODUCTNAME.Location = new System.Drawing.Point(100, 57);
            this.TXT_PRODUCTNAME.Name = "TXT_PRODUCTNAME";
            this.TXT_PRODUCTNAME.Size = new System.Drawing.Size(245, 20);
            this.TXT_PRODUCTNAME.TabIndex = 12;
            // 
            // CMB_SCIENTIFICNAME
            // 
            this.CMB_SCIENTIFICNAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_SCIENTIFICNAME.FormattingEnabled = true;
            this.CMB_SCIENTIFICNAME.Location = new System.Drawing.Point(100, 227);
            this.CMB_SCIENTIFICNAME.Name = "CMB_SCIENTIFICNAME";
            this.CMB_SCIENTIFICNAME.Size = new System.Drawing.Size(245, 21);
            this.CMB_SCIENTIFICNAME.TabIndex = 11;
            // 
            // CMB_ACTIVEMATERIAL
            // 
            this.CMB_ACTIVEMATERIAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_ACTIVEMATERIAL.FormattingEnabled = true;
            this.CMB_ACTIVEMATERIAL.Location = new System.Drawing.Point(100, 198);
            this.CMB_ACTIVEMATERIAL.Name = "CMB_ACTIVEMATERIAL";
            this.CMB_ACTIVEMATERIAL.Size = new System.Drawing.Size(247, 21);
            this.CMB_ACTIVEMATERIAL.TabIndex = 10;
            // 
            // CMB_CAT
            // 
            this.CMB_CAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_CAT.FormattingEnabled = true;
            this.CMB_CAT.Location = new System.Drawing.Point(100, 29);
            this.CMB_CAT.Name = "CMB_CAT";
            this.CMB_CAT.Size = new System.Drawing.Size(245, 21);
            this.CMB_CAT.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Product Image : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bar Code :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Scientific Name : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Active Material : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Price : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Desecribe : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category  Name :";
            // 
            // FRM_ADD_NEW_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 460);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FRM_ADD_NEW_PRODUCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ADD_NEW_PRODUCT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICIMAGE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_CHOOSE;
        private System.Windows.Forms.PictureBox PICIMAGE;
        private System.Windows.Forms.TextBox TXT_SAEPRICE;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.TextBox TXT_BUYPRICE;
        private System.Windows.Forms.TextBox TXT_PRODUCTDESCRIBE;
        private System.Windows.Forms.TextBox TXT_PRODUCTNAME;
        private System.Windows.Forms.ComboBox CMB_SCIENTIFICNAME;
        private System.Windows.Forms.ComboBox CMB_ACTIVEMATERIAL;
        private System.Windows.Forms.ComboBox CMB_CAT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_ADD;
    }
}