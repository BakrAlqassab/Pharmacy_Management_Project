using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management.PL
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }

       //check if the user enter the valid user name and password
        public static bool check = false;

        private void TSMLogin_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {
            TSMPRODUCT.Enabled = TSMCOSTUMERS.Enabled = TSMSUPPLIERS.Enabled = TSMUsers.Enabled = TSMBackup.Enabled = TSMRestore.Enabled = check;
        }

        private void TSMAddtype_Click(object sender, EventArgs e)
        {
            //    FRM_ADDCATEGORY ADDCAT = new FRM_ADDCATEGORY();
            //    ADDCAT.ShowDialog();
            new FRM_ADDCATEGORY().ShowDialog();
        }

        private void TSMTypesmanagement_Click(object sender, EventArgs e)
        {
            //CATEGORY_MANAGEMENT CAT = new CATEGORY_MANAGEMENT();
            //CAT.ShowDialog();
            new CATEGORY_MANAGEMENT().ShowDialog();
        }

        private void TSMAddActiveMaterial_Click(object sender, EventArgs e)
        {
            
            new FRM_AddActiveMaterial().ShowDialog();
        }

        private void TSMActiveMaterialManagement_Click(object sender, EventArgs e)
        {
            new FRM_ActiveMaterialManagement().ShowDialog();
        }

        private void TSMAddSCEINTIFICnAME_Click(object sender, EventArgs e)
        {
            new FRM_ADDSCIENTIFICNAME().ShowDialog();
        }

        private void TSMSceintificName_Click(object sender, EventArgs e)
        {
            FRM_SCIENTIFICNAMEMANAGEMENT frm = new FRM_SCIENTIFICNAMEMANAGEMENT();
            frm.ShowDialog();
        }

        private void TSMAddproduct_Click(object sender, EventArgs e)
        {
            new FRM_ADD_NEW_PRODUCT(false).ShowDialog();
        }

        private void TSMPrpductmanagement_Click(object sender, EventArgs e)
        {
            new FRM_PRODUCTMANAEMENT().ShowDialog();
        }

        private void TSMAddsupplier_Click(object sender, EventArgs e)
        {
            new FRM_ADD_NEW_SUPPLIERS(true).ShowDialog();
        }

        private void TSMSuppliersmanagement_Click(object sender, EventArgs e)
        {
            new FRM_SUPPLIERSMANAGEMENT().ShowDialog();
        }

        private void TSMAdduser_Click(object sender, EventArgs e)
        {
            new FRM_ADD_NEW_USER(false).ShowDialog();
        }
    }
}
