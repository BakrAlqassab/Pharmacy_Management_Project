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
    public partial class FRM_ActiveMaterialManagement : Form
    {
        public FRM_ActiveMaterialManagement()
        {
            InitializeComponent();
            btn_SelectAll_Click(null, null);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_ACTIVEMATERIAL.SP_SELECTALLACTIVEMATERIAL();
            dgvActiveMaterials.DataSource = dt;
        }

        private void dgvActiveMaterials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvActiveMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        { if(e.RowIndex >=0)
            { 
            txt_AMID.Text = dgvActiveMaterials.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_AMName.Text = dgvActiveMaterials.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_AMDesecription.Text = dgvActiveMaterials.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_ACTIVEMATERIAL.SP_SELECTSEARCHACTIVEMATERIAL(txt_Search.Text);
            dgvActiveMaterials.DataSource = dt;
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        { if(txt_AMName.Text== string.Empty)
            {

                MessageBox.Show("nothing to update");
                return;
            }
            int I = CLASS_ACTIVEMATERIAL.SP_ACTIVEMATERIALUPDATE(int.Parse(txt_AMID.Text), txt_AMName.Text, txt_AMDesecription.Text);
            MessageBox.Show("DATA UPDATED SUCCESEFULLY ");
            txt_AMID.Text = txt_AMName.Text = txt_AMDesecription.Text = string.Empty;
            btn_SelectAll_Click(null, null);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        { if(txt_AMID.Text==string.Empty)
            {
                MessageBox.Show("NOTHING DEFINE TO DELETE");
                return;


            }
           int I = CLASS_ACTIVEMATERIAL.ACTIVEMATERIALDELETE(int.Parse(txt_AMID.Text));
            MessageBox.Show("DELETE ACTIVE MATERIAL DONE");
            btn_SelectAll_Click(null, null);
        }
    }
}
