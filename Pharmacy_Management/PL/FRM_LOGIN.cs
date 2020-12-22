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
    public partial class FRM_LOGIN : Form
    {
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_usname.Text==string.Empty)
            {
                MessageBox.Show("SHOULD INSERT USER NAME ");
                    return;
            }
            if(txt_uspass.Text==string.Empty)
            {
                MessageBox.Show(" FORGET TO INSERT PASSWORD ");
                return;


            }
            DataTable dt = CLASS_LOGIN.SpLogin(txt_usname.Text, txt_uspass.Text);
            if(dt.Rows.Count>0)
            {
                //FRM_MAIN frm = new FRM_MAIN();
                //frm.ShowDialog();

                FRM_MAIN.check = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(" User Name OR Password Wrong");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
