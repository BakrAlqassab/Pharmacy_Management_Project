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
    public partial class CATEGORY_MANAGEMENT : Form
    {
        public CATEGORY_MANAGEMENT()
        {
            InitializeComponent();
            button1_Click(null, null);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           DataTable dt1= CLASS_CATEGORY.SP_SELECTALLCATEGORIES();
            dgv_Categories.DataSource = dt1;

        }
        // event for show id and name of category in text box in category management 
        private void dgv_Categories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                txt_CatID.Text = dgv_Categories.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_CatName.Text = dgv_Categories.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            if(txt_Search.Text==string.Empty)
            {
                MessageBox.Show("SHOULD INSERT THE WORD OR ID FOR CATEGORY TO SEARCH");
                return;

            }
            DataTable dt = CLASS_CATEGORY.SP_SEARCHCATEGORIES(txt_Search.Text);
            dgv_Categories.DataSource = dt;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        { if(txt_CatName.Text==string.Empty)
            {
                MessageBox.Show(" should insert select category to modify");
                return;


            }
            int i = CLASS_CATEGORY.SP_UPDATECATEGORY(int.Parse(txt_CatID.Text), txt_CatName.Text);

            MessageBox.Show(" The Category number " + i + " Has been modified successfully ");
            button1_Click(null, null);

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_CatName.Text == string.Empty)
            {
                MessageBox.Show(" should insert select category to Delete");
                return;


            }

            int i = CLASS_CATEGORY.SPDELETECATEGORY(int.Parse(txt_CatID.Text));
            MessageBox.Show(" The Category number " + i + " deleted successfully ");
            button1_Click(null, null);
            txt_CatID.Text = txt_CatName.Text = string.Empty;
        } 
    }
}
