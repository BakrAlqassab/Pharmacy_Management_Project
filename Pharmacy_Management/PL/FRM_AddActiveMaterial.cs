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
    public partial class FRM_AddActiveMaterial : Form
    {
        public FRM_AddActiveMaterial()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_name.Text==string.Empty)
            {
                MessageBox.Show("sould insert the active material name ");
                return;
            }
            int i = CLASS_ACTIVEMATERIAL.SP_ADDACTIVEMATERIAL(txt_name.Text, txt_Deecraption.Text);
            MessageBox.Show(i + " rows Added Succesfully");
            txt_name.Text = string.Empty;
            txt_Deecraption.Text = string.Empty;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
