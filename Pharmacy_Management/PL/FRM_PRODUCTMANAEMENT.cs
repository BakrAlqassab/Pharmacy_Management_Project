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
using System.IO;

namespace Pharmacy_Management.PL
{
    public partial class FRM_PRODUCTMANAEMENT : Form
    {
        public FRM_PRODUCTMANAEMENT()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_DispalyAll_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_PRODUCTS.SP_PRODECTSELECT();
            dgvPRODUCTS.Rows.Clear();
            //dgvPRODUCTS.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {
                dgvPRODUCTS.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9]);

            }
        }

        private void FRM_PRODUCTMANAEMENT_Activated(object sender, EventArgs e)
        {
            btn_DispalyAll_Click(null, null);
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = CLASS_PRODUCTS.SP_PRODECTSearch(txt_Search.Text);
            dgvPRODUCTS.Rows.Clear();
            foreach (DataRow dr in DT.Rows)
            {
                dgvPRODUCTS.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9]);

            }
        }

        private void btn_DipalyProductImage_Click(object sender, EventArgs e)
        {
            byte[] arr = CLASS_PRODUCTS.SP_PRODUCTGETIMG(int.Parse(dgvPRODUCTS.SelectedRows[0].Cells[0].Value.ToString()));
            MemoryStream ms = new MemoryStream(arr);
            FRM_PRODUCTIMAGE frm = new FRM_PRODUCTIMAGE();
            frm.PicImg.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void btn_DispalyPrductExpire_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_PRODUCTS.SP_PRODUCTGETEXPIREDATE(int.Parse(dgvPRODUCTS.SelectedRows[0].Cells[0].Value.ToString()));
            if(dt.Rows.Count>0)
            {

                FRM_PRODUCTEXPIREDATE frm = new FRM_PRODUCTEXPIREDATE();
                frm.DGVPROUCTEXPIREDATE.DataSource = dt;
                frm.ShowDialog();
            }else
            {
                MessageBox.Show("Sorry There Is No Expire Date For This Product");

            }
        }
       public static int id;

        private void btn_Delete_Click(object sender, EventArgs e)
        {
           id = int.Parse(dgvPRODUCTS.SelectedRows[0].Cells[0].Value.ToString());
         DialogResult DR = MessageBox.Show(" ARE YOU SURE WANT DELETE SELECTED ITEM ??", " WARNING ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (DR==System.Windows.Forms.DialogResult.Yes)
            {
                CLASS_PRODUCTS.SP_DELETEPRODUCTS(id);
                MessageBox.Show("DELETED SUCCEFULLY");
            } 
        }
        //public static bool isupdate_insert = false;

        private void btn_AddnewProduct_Click(object sender, EventArgs e)
        {
            new FRM_ADD_NEW_PRODUCT(false).ShowDialog();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            new FRM_ADD_NEW_PRODUCT(true).ShowDialog();
            id = int.Parse(dgvPRODUCTS.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}
