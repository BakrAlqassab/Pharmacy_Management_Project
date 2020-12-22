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
    public partial class FRM_SUPPLIERSMANAGEMENT : Form
    {
        public FRM_SUPPLIERSMANAGEMENT()
        {
            InitializeComponent();
            btn_display_Click(null, null);
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_SUPPLIERS.SP_SUPPLIERSELECT();
            dgv_suppliers.DataSource = dt;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = CLASS_SUPPLIERS.SP_SUPPLIERSEARCH(txt_search.Text);
            dgv_suppliers.DataSource = DT;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            new FRM_ADD_NEW_SUPPLIERS(true).ShowDialog();
            btn_display_Click(null, null);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static int ID;
        private void btn_modify_Click(object sender, EventArgs e)
        {
            ID = int.Parse(dgv_suppliers.SelectedRows[0].Cells[0].Value.ToString());
            new FRM_ADD_NEW_SUPPLIERS(false).ShowDialog();
            

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ID = int.Parse(dgv_suppliers.SelectedRows[0].Cells[0].Value.ToString());
            CLASS_SUPPLIERS.SP_SUPPLIERDELETE(ID);
            MessageBox.Show("SUPPLIER DATA DELETED SUCCESFULLY");
            


        }

        private void FRM_SUPPLIERSMANAGEMENT_Activated(object sender, EventArgs e)
        {
            btn_display_Click(null, null);
        }
    }
}
