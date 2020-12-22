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
    public partial class FRM_ADD_NEW_PRODUCT : Form
    {
        bool _isupdate;
        public FRM_ADD_NEW_PRODUCT(bool isupdate)
        {
            InitializeComponent();
            this._isupdate = isupdate;
            DataTable dtcat = CLASS_PRODUCTS.SP_CATFILLCATCMB();
            CMB_CAT.DataSource = dtcat;
            CMB_CAT.DisplayMember = "Cat_name";
            CMB_CAT.ValueMember = "Cat_id";
            DataTable dtam = CLASS_PRODUCTS.SP_CATFILLACM();
            CMB_ACTIVEMATERIAL.DataSource = dtam;
            CMB_ACTIVEMATERIAL.DisplayMember = "Am_name";
            CMB_ACTIVEMATERIAL.ValueMember = "Am_ID";
            DataTable dtscn = CLASS_PRODUCTS.SP_CATFILLSCN();
            CMB_SCIENTIFICNAME.DataSource = dtscn;
            CMB_SCIENTIFICNAME.DisplayMember = "sn_Name";
            CMB_SCIENTIFICNAME.ValueMember = "sn_ID";
            if(_isupdate==true)
            {
                this.Text = "MODIFY PRODUCT DATA";
                BTN_ADD.Text = "MODIFY";
                DataTable DT = CLASS_PRODUCTS.SP_GETSELECTEDPRODUCT(FRM_PRODUCTMANAEMENT.id);
                foreach(DataRow dr in DT.Rows)
                {
                    CMB_CAT.Text = dr["Cat_name"].ToString();
                    TXT_PRODUCTNAME.Text = dr["Pr_Name"].ToString();
                    TXT_PRODUCTDESCRIBE.Text= dr["pr_Description"].ToString();
                    TXT_BUYPRICE.Text= dr["butprice"].ToString();
                    TXT_SAEPRICE.Text= dr["Saleprice"].ToString();
                    CMB_ACTIVEMATERIAL.Text = dr["Am_name"].ToString();
                    CMB_SCIENTIFICNAME.Text = dr["sn_Name"].ToString();
                    txt_barcode.Text= dr["Barcode"].ToString();
                    byte[] arr =(byte[]) dr["Pr_image"];
                    MemoryStream ms = new MemoryStream(arr);
                    PICIMAGE.Image = Image.FromStream(ms);
                }

            } else
            {
                this.Text = "ADD NEW PRODUCT";
                BTN_ADD.Text = "ADD";


            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_CHOOSE_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "All Files|*.*|JPG|*.jpg|PNG|*.png";
            OFD.ShowDialog();
            PICIMAGE.Image = Image.FromFile(OFD.FileName);

        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            PICIMAGE.Image.Save(ms, PICIMAGE.Image.RawFormat);
            byte[] arr = ms.ToArray();
            if (_isupdate == false) {
            
            CLASS_PRODUCTS.SP_ADDNEWPRODUCT(TXT_PRODUCTNAME.Text, TXT_PRODUCTDESCRIBE.Text, arr, TXT_BUYPRICE.Text, TXT_SAEPRICE.Text, (int)CMB_CAT.SelectedValue,
                (int)CMB_ACTIVEMATERIAL.SelectedValue, (int)CMB_SCIENTIFICNAME.SelectedValue, txt_barcode.Text);
            MessageBox.Show("PRODUCT ADD SUCCESFULLY");
            foreach(Control item in groupBox1.Controls)
            { if(item is TextBox)

                item.Text = string.Empty;
            }
            } else
            {
               
                CLASS_PRODUCTS.SP_UPDATEPRODUCT(FRM_PRODUCTMANAEMENT.id, TXT_PRODUCTNAME.Text, TXT_PRODUCTDESCRIBE.Text, arr, TXT_BUYPRICE.Text, TXT_SAEPRICE.Text, (int)CMB_CAT.SelectedValue,
                    (int)CMB_ACTIVEMATERIAL.SelectedValue, (int)CMB_SCIENTIFICNAME.SelectedValue, txt_barcode.Text);
                MessageBox.Show("PRODUCT modified SUCCESFULLY");



            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
