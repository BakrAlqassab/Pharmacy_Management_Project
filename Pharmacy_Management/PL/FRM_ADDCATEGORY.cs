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
    public partial class FRM_ADDCATEGORY : Form
    {
        public FRM_ADDCATEGORY()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txt_Category.Text==string.Empty)
            {
                MessageBox.Show("SHOULD INSERT CATEGORT NAME");
                return;

            }

           int I=  CLASS_CATEGORY.SP_ADDCATEGORY(txt_Category.Text);

            MessageBox.Show(I + " NUMBER OF ROWS WAS ADDED ");
            txt_Category.Text = string.Empty;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
