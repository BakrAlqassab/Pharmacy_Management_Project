using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Management.BL;

namespace Pharmacy_Management.PL
{
    public partial class FRM_ADD_NEW_SUPPLIERS: Form
    {
        bool _check;
        public FRM_ADD_NEW_SUPPLIERS(bool check)
        {
            InitializeComponent();
            _check = check;
            if(_check)
            {
                this.Text = "ADD NEW SUPPLIER";
                this.btn_ok.Text = "ADD";
            } else
            {
                this.Text = "MODIFY SUPPLIER DATA";
                this.btn_ok.Text = "MODIFY";
                DataTable DT = CLASS_SUPPLIERS.SP_SUPPLIERSSELECTBYID(FRM_SUPPLIERSMANAGEMENT.ID);
                foreach(DataRow dr in DT.Rows)
                {

                    txt_name.Text = dr["Su_Name"].ToString();
                    txt_mobile.Text = dr["Su_Mobile"].ToString();
                }

            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(_check)
            {

                CLASS_SUPPLIERS.SP_ADDNEWSUPPLIERS(txt_name.Text, txt_mobile.Text);
                MessageBox.Show("SPPLIER ADDED SUCCESSFULLY");
                txt_name.Text = txt_mobile.Text = "";
            } else
            {
                CLASS_SUPPLIERS.SP_SUPPLIERUPDATE(FRM_SUPPLIERSMANAGEMENT.ID, txt_name.Text, txt_mobile.Text);
                MessageBox.Show("SUPPLIER MODIFY SUCESFULLY");

            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ADD_NEW_SUPPLIERS_Load(object sender, EventArgs e)
        {

        }
    }
}
