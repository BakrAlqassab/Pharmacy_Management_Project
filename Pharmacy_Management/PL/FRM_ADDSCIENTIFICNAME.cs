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
    public partial class FRM_ADDSCIENTIFICNAME : Form
    {
        public FRM_ADDSCIENTIFICNAME()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_name.Text==string.Empty)
            {
                MessageBox.Show("should insert scientific name to add ");
                return;

            }
            CLASS_SCIENTIFICNAME.SP_ADDSCIENTIFICNAME(txt_name.Text);
            MessageBox.Show("Scientific Name add Succesfully ");
            txt_name.Text = string.Empty;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
