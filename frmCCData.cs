using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frmCCData : Form
    {
        bool blnCCNum = false;
        bool blnCCdate = true;

        public frmCCData()
        {
            InitializeComponent();
            cboYear.SelectedIndexChanged += cboYear_SelectedIndexChanged;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblTest();
            this.Close();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTest();
        }

        private void lblTest()
        {
            this.lblCCErr.Text = "";
            if (Convert.ToInt16(cboYear.SelectedItem) > DateTime.Now.Year)
            {
                Globals.gblValidCC = true;
                blnCCdate = true;

            }
            else  // current year
            {
                if ((cboMonth.SelectedIndex + 1) >= DateTime.Now.Month)
                {
                    Globals.gblValidCC = true;
                    blnCCdate = true;
                    this.btnOK.Enabled = true;
                }
                else
                {
                    Globals.gblValidCC = false;
                    this.btnOK.Enabled = false;
                    this.lblCCErr.Text = "Date Expaired";
                }
            }
        }

        private void frmCCData_Load(object sender, EventArgs e)
        {
            mtbCCNum.Focus();
            this.btnOK.Enabled = false;
            this.lblCCErr.Text = "";
            this.lblCCType.Text = Globals.gblCCTypes;

            int idx;
            int intYear = DateTime.Now.Year;

            for (idx = 0; idx < 10; idx++)
            {
                cboYear.Items.Add(intYear.ToString());
                intYear++;

            }
            cboYear.SelectedIndex = 0;

            for (idx = 1; idx <= 12; idx++)
            {
                cboMonth.Items.Add(idx.ToString("D2"));

            }
            cboMonth.SelectedIndex = DateTime.Now.Month - 1;

            this.cboMonth.SelectedValue = "";


        }

        private void mtbCCNum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtbCCNum.Select(0, 0);
            enableOKButton();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Globals.gblValidCC = false;


        }
        private void enableOKButton()
        {
            if (blnCCNum == true)
            {
                if (blnCCdate == true)
                {
                    this.btnOK.Enabled = true;
                }
                else
                {
                    this.btnOK.Enabled = false;
                }
            }
        }

        private void mtbCCNum_Validating(object sender, CancelEventArgs e)
        {
            string errmsg = null;

            //  e.Handled = true;
            int intCCNum = mtbCCNum.Text.Length;

            if (intCCNum == 16)
            {
                blnCCNum = true;
                enableOKButton();
                this.lblCCErr.Text = "";
                //btnOK_Click.Focus();

            }
            else
            {
                blnCCNum = false;
                this.btnOK.Enabled = false;
                e.Cancel = false;
                errmsg = "Must have 16 numbers for Credit Card Number";
                lblCCErr.Text = errmsg;
            }
            erpCC.SetError((Control)sender, errmsg);
            lblCCErr.Text = errmsg;
        }


        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTest();
        }

        private void mtbCCNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            int intTestCC = mtbCCNum.Text.Length;
            if (intTestCC == 16)
            {
                this.btnOK.Focus();
            }
        }
    }
}
