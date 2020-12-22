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
    public partial class FRM_SCIENTIFICNAMEMANAGEMENT : Form
    {
        public FRM_SCIENTIFICNAMEMANAGEMENT()
        {
            InitializeComponent();
            btnSelectAll_Click(null, null);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_SCIENTIFICNAME.SP_SELECTALLSCIENTIFICNAME();
            dgv_scientificname.DataSource = dt;
        }

        private void dgv_scientificname_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                txt_scID.Text = dgv_scientificname.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_scName.Text = dgv_scientificname.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {if(txt_Search.Text==string.Empty)
            {
                MessageBox.Show("no thing to Search");

            }
            DataTable dt = CLASS_SCIENTIFICNAME.SP_SEARCHSCIENTIFICNAME(txt_Search.Text);
            dgv_scientificname.DataSource = dt;
            


        }

        private void btn_Update_Click(object sender, EventArgs e)
        { if(txt_scID.Text==string.Empty)
            {
                MessageBox.Show("NOTHING TO MODIFY!");

            }
            CLASS_SCIENTIFICNAME.SP_UPDATESCIENTIFICNAME(int.Parse(txt_scID.Text), txt_scName.Text);
            MessageBox.Show("updated succefully");
            btnSelectAll_Click(null, null);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_scID.Text == string.Empty)
            {
                MessageBox.Show("NOTHING TO DELETE!");

            }
            CLASS_SCIENTIFICNAME.SP_DELETESCIENTIFICNAME(int.Parse(txt_scID.Text));
            MessageBox.Show("Deleted Succefully");
            btnSelectAll_Click(null, null);
        }
    }
}
