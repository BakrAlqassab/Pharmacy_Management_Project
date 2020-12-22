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
    public partial class FRM_ADD_NEW_USER : Form
    {
        bool isupdate;
        public FRM_ADD_NEW_USER(bool _isupdate)
        {
            InitializeComponent();
            this.isupdate = _isupdate;
            cmb_premission.DataSource = CLASS_USER.SP_PREMISSION();
            cmb_premission.DisplayMember = "Per_Name";
            cmb_premission.ValueMember = "Per_ID";
            if (isupdate)
            {

                this.Text = "MODIFY USER DATA ";
                btn_ok.Text = "MODIFY";

            }
            else
            {
                this.Text = "INSERT NEW USER  ";
                btn_ok.Text = "INSERT";



            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text == "")
                {

                    MessageBox.Show("SHOULD INSERT USER NAME ");
                    return;
                }
                else
                if (txt_userpassword.Text == "")
                {

                    MessageBox.Show("SHOULD INSERT USER PASSWORD ");
                    return;
                }
                else

                if (txt_confirmpass.Text != txt_userpassword.Text)
                {

                    MessageBox.Show("SORRY,PASSWORD INSERT NOT MATCH");
                    return;
                }
                else
                 if (txt_fullname.Text == "")
                {

                    MessageBox.Show("SHOULD INSERT USER FULL NAME ");
                    return;
                }

                if (isupdate)
                {



                }
                else
                {

                    CLASS_USER.SP_INSERT_USER(txt_username.Text, txt_userpassword.Text, txt_fullname.Text, int.Parse(cmb_premission.SelectedValue.ToString()));
                    MessageBox.Show("NEW USER ADDED SUCCESFULLY");
                    foreach (Control ctr in groupBox1.Controls)
                    {
                        if (ctr is TextBox)
                            ctr.Text = "";

                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
