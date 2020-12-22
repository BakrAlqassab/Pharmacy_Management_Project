namespace Pharmacy_Management.PL
{
    partial class FRM_PRODUCTEXPIREDATE
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
            this.DGVPROUCTEXPIREDATE = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPROUCTEXPIREDATE)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPROUCTEXPIREDATE
            // 
            this.DGVPROUCTEXPIREDATE.AllowUserToAddRows = false;
            this.DGVPROUCTEXPIREDATE.AllowUserToDeleteRows = false;
            this.DGVPROUCTEXPIREDATE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPROUCTEXPIREDATE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPROUCTEXPIREDATE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPROUCTEXPIREDATE.Location = new System.Drawing.Point(0, 0);
            this.DGVPROUCTEXPIREDATE.MultiSelect = false;
            this.DGVPROUCTEXPIREDATE.Name = "DGVPROUCTEXPIREDATE";
            this.DGVPROUCTEXPIREDATE.RowHeadersVisible = false;
            this.DGVPROUCTEXPIREDATE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVPROUCTEXPIREDATE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPROUCTEXPIREDATE.Size = new System.Drawing.Size(464, 348);
            this.DGVPROUCTEXPIREDATE.TabIndex = 0;
            // 
            // FRM_PRODUCTEXPIREDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 348);
            this.Controls.Add(this.DGVPROUCTEXPIREDATE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FRM_PRODUCTEXPIREDATE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SHOW EXPIRE DATE";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPROUCTEXPIREDATE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVPROUCTEXPIREDATE;
    }
}