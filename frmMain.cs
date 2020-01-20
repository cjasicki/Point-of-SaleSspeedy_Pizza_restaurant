using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pizza_Project
{
    public partial class frmPizzaProj : Form
    {
        const Single sngSmall = 8.0f;
        const Single sngMed = 10.0f;
        const Single sngLarge = 12.0f;
        const Single sngTop = 1.0f;
        const Single sngTax = .07f;
        int intCnt = 1;
        int intPiznum = 1;
        int inttxtPizNu = 1;
        bool blnPhone = false;
        bool blnCustN = false;
        bool blnAdd1 = false;
        bool blnCity = false;
        bool blnZip = false;
        bool blnState = false;
        bool bolExistingCust = false;
        int intOrdNum;
        int PaymentTypes = 6;

        // ADO.NET to connect to PIZZA.mdf
        //string strPathOrder = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Pizza.mdf;";
        SqlConnection cnCust;
        SqlDataAdapter daCust;
        DataTable dtCust = new DataTable();
        SqlConnection cnOrder;
    
        SqlDataAdapter daOrder;
        DataTable dtOrder = new DataTable();


        string strDataSrc = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=";
        string strParms = "Integrated Security=True; Connect Timeout=5";
        SqlConnection cnOrder1;

        public frmPizzaProj()
        {
            InitializeComponent();
            rabMed.CheckedChanged += rabSmall_CheckedChanged;
            rabLarge.CheckedChanged += rabSmall_CheckedChanged;
            //clbToppings.SelectedIndexChanged += rabSmall_CheckedChanged;
            //chkPepperoni.CheckedChanged += rabSmall_CheckedChanged;
            //chkMushrooms.CheckedChanged += rabSmall_CheckedChanged;
            //chkOnions.CheckedChanged += rabSmall_CheckedChanged;
            //chkSausage.CheckedChanged += rabSmall_CheckedChanged;
            //chkCanadanBacon.CheckedChanged += rabSmall_CheckedChanged;
            //chkExtraCheese.CheckedChanged += rabSmall_CheckedChanged;
            //chkGreenOlives.CheckedChanged += rabSmall_CheckedChanged;
            //chkBlackOlives.CheckedChanged += rabSmall_CheckedChanged;
            //chkGreenPeppers.CheckedChanged += rabSmall_CheckedChanged;
            //chkPineapple.CheckedChanged += rabSmall_CheckedChanged;
            txtQt.TextChanged += rabSmall_CheckedChanged;
        }

        private void frmPizzaProj_Load(object sender, EventArgs e)
        {
            Music();
            clearAllToolStripMenuItem.Enabled = false;
            playToolStripMenuItem.Enabled = false;
            resetBackGroundToolStripMenuItem.Enabled = false;
            string strPath = Application.StartupPath + "\\Pizza.mdf;";
            string strConn = strDataSrc + strPath + strParms;
            string strMaxOrd = "SELECT MAX(OrderNumber) FROM Orders;";
            cnOrder1 = new SqlConnection(strConn);
            cnOrder1.Open();
            SqlDataAdapter daOrder = new SqlDataAdapter(strMaxOrd, cnOrder1);
            DataTable dtOrder = new DataTable();
            daOrder.Fill(dtOrder);
            intOrdNum = Convert.ToInt32(dtOrder.Rows[0][0]);
            intOrdNum = intOrdNum + 1;
            lblOrderNumVal.Text = intOrdNum.ToString();

            this.rabMed.Checked = true;
            //this.lblOrderNumVal.Text = intCnt.ToString();
            this.btnAccept.Enabled = false;

            string strStPath = Application.StartupPath + "/StateAbbrev.txt";
            FileStream fsState = new FileStream(strStPath, FileMode.Open, FileAccess.Read);
            StreamReader srState = new StreamReader(fsState);

            string strState;
            while (!srState.EndOfStream)
            {
                strState = srState.ReadLine();
                cboState.Items.Add(strState);
            }
            srState.Close();
            cboState.SelectedItem = "MN";

            cboPaymentType.Items.Add("Cash");
            cboPaymentType.Items.Add("MasterCard");
            cboPaymentType.Items.Add("Visa");
            cboPaymentType.Items.Add("Discover");
            cboPaymentType.Items.Add("Amex");
            cboPaymentType.Items.Add("Dinners Card");

            var items = clbToppings.Items;
            items.Add("Pepperoni");
            items.Add("Mushrooms");
            items.Add("Onions");
            items.Add("Sausage");
            items.Add("CN Bacon");
            items.Add("Extra Cheese");
            items.Add("Green Peppers");
            items.Add("Black Olives");
            items.Add("Green Olives");
            items.Add("Pineapple");

            Pricing();
            this.mskPhone.Focus();
        }

        private void EnableAccept()
        {
            if (blnPhone == true)
                if (blnCustN == true)
                    if (blnAdd1 == true)
                        if (blnCity == true)
                            if (blnZip == true)
                                if(Globals.gblValidCC == true)
                            {
                                this.btnAccept.Enabled = true;
                                    //this.btnAccept.Cursor = Cursors.Hand;
                                }
                            else
                            {
                                this.btnAccept.Enabled = false;
                                    //this.btnAccept.Cursor = Cursors.No;
                            }
        }

        private void Reset()
        {
            clearAllToolStripMenuItem.Enabled = false;
            this.btnAccept.Enabled = false;
            this.mskPhone.Clear();
            this.txtCust.Clear();
            this.txtAddr1.Clear();
            this.txtaddr2.Clear();
            this.txtCity.Clear();
            this.cboState.Text = "";
            this.mskZip.Clear();
            this.rabSmall.Checked = false;
            this.rabMed.Checked = true;
            this.rabLarge.Checked = false;
            this.mskZip.Clear();
            this.txtPizNu.Text = "1";
            this.txtSubTotal.Clear();
            this.txtTax.Clear();
            this.txtTotal.Clear();
            this.cboPaymentType.Text = "Select Payment Type";
            this.mskPhone.Focus();
            this.txtQt.Text = "1";
            Globals.gblValidCC = false;

            for (int i = 0; i < clbToppings.Items.Count; i++)
            {
                clbToppings.SetItemChecked(i, false);

            }
                Pricing();
        }
  
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Custermer objCust = new Custermer(
                phone: mskPhone.Text,
                cust: txtCust.Text,
                add1: txtAddr1.Text,
                add2: txtaddr2.Text,
                city: txtCity.Text,
                state: cboState.Text,
                zip: mskZip.Text,
                qty: txtPizNu.Text,
                ordernu: lblOrderNumVal.Text,
                total: txtTotal.Text);

            if (!File.Exists("TransactionLog.txt"))
            {
                using (StreamWriter swlog = File.CreateText("TransactionLog.txt"))
                {
                    //swlog.WriteLine("New file created: {0}", DateTime.Now.ToString());
                    swlog.WriteLine("#,Phone,Customer Name,Total");
                    swlog.Close();
                }
            }

            string strLog = Application.StartupPath + "/TransactionLog.txt";
            FileStream fsLog = new FileStream(strLog, FileMode.Append, FileAccess.Write);
            StreamWriter swLog = new StreamWriter(fsLog);
            swLog.WriteLine(objCust.Ordernu + "," + objCust.Custphone + "," + objCust.Custname + "," + objCust.Total);
            swLog.Close();

           // intCnt++;
           // this.lblOrderNumVal.Text = intCnt.ToString();

            try
            {
                dtCust = new DataTable();
                string strCustSQL = "select * from Customers;";
                daCust = new SqlDataAdapter(strCustSQL, cnCust);
                daCust.FillSchema(dtCust, SchemaType.Source);
                DataRow newCust;
                newCust = dtCust.NewRow();  //NEW CUSTOMER ROW (EMPTY) 
                newCust["custphone"] = mskPhone.Text;
                newCust["custname"] = txtCust.Text;
                newCust["custaddress1"] = txtAddr1.Text;
                newCust["custaddress2"] = txtaddr2.Text;
                newCust["custcity"] = txtCity.Text;
                newCust["custstate"] = cboState.Text;
                newCust["custzip"] = mskZip.Text;

                dtCust.Rows.Add(newCust);
               
                SqlCommandBuilder cmbBldr = new SqlCommandBuilder(daCust);
                cmbBldr.GetUpdateCommand();

                daCust.Update(dtCust);
                //MessageBox.Show("customer add successful!");
            }
            catch
            {
                if (dtCust.Rows.Count > 0)
                {
                }
                else
                {
                    if (bolExistingCust == false)
                    {
                        MessageBox.Show("customer add failed!");
                    }
                }
            }

            // order update
            try
            {
                //dtOrder = new DataTable();
                string strOrderSQL = "select * from Orders;";
                SqlDataAdapter daOrder = new SqlDataAdapter(strOrderSQL, cnCust);
                DataTable dtOrder = new DataTable();
                daOrder.FillSchema(dtOrder, SchemaType.Source);
                DataRow newOrder;
                newOrder = dtOrder.NewRow();
                newOrder["OrderNumber"] = Convert.ToInt16(lblOrderNumVal.Text);
                newOrder["CustPhone"] = mskPhone.Text;
                newOrder["OrderDate"] = DateTime.Now;

                if (rabSmall.Checked)
                    newOrder["OrderSize"] = "S";
                else if (rabMed.Checked)
                    newOrder["OrderSize"] = "M";
                else
                    newOrder["OrderSize"] = "L";

                newOrder["Qty"] = Convert.ToInt16(txtQt.Text);
                newOrder["Top1"] = Convert.ToBoolean(clbToppings.GetItemChecked(0));
                newOrder["Top2"] = Convert.ToBoolean(clbToppings.GetItemChecked(1));
                newOrder["Top3"] = Convert.ToBoolean(clbToppings.GetItemChecked(2));
                newOrder["Top4"] = Convert.ToBoolean(clbToppings.GetItemChecked(3));
                newOrder["Top5"] = Convert.ToBoolean(clbToppings.GetItemChecked(4));
                newOrder["Top6"] = Convert.ToBoolean(clbToppings.GetItemChecked(5));
                newOrder["Top7"] = Convert.ToBoolean(clbToppings.GetItemChecked(6));
                newOrder["Top8"] = Convert.ToBoolean(clbToppings.GetItemChecked(7));
                newOrder["Top9"] = Convert.ToBoolean(clbToppings.GetItemChecked(8));
                newOrder["Top10"] = Convert.ToBoolean(clbToppings.GetItemChecked(9));

                dtOrder.Rows.Add(newOrder);

                SqlCommandBuilder cmbBldr = new SqlCommandBuilder(daOrder);
                cmbBldr.GetUpdateCommand();
                daOrder.Update(dtOrder);
                MessageBox.Show("Order add successful!");
            }
            catch
            {
                MessageBox.Show("Order add failed!");
            }


            Reset();
        }


        private void txtCust_Validating(object sender, CancelEventArgs e)
        {
            string errmsg = null;
            {
                if (txtCust.Text.Length < 5)
                {
                    errmsg = "Must be 5 or more Characters";
                    e.Cancel = false;
                }
                else
                {
                    string custname = txtCust.Text.Trim();
                    for (int i = 0; i < custname.Length; i++)
                    {
                        if (char.IsNumber(custname[i]))
                        {
                            errmsg = "Numbers not alowed";
                            e.Cancel = false;
                            blnCustN = false;
                            EnableAccept();
                        }
                        else
                        {
                            this.lblErrCust.Text = "";
                            blnCustN = true;
                            EnableAccept();
                        }
                    }
                }
                erpCusttxb.SetError((Control)sender, errmsg);
                lblErrCust.Text = errmsg;
            }
        }
        private void txtCust_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (char.IsNumber(e.KeyChar))

                {
                    this.lblErrCust.Text = "Numbers not alowed";
                    e.Handled = true;
                    blnCustN = false;
                    EnableAccept();
                }
                else
                {
                    this.lblErrCust.Text = "";
                    blnCustN = true;
                    EnableAccept();
                }
            
        }

            private void txtAddr1_Validating(object sender, CancelEventArgs e)
        {
            string errmsg = null;
            if (txtAddr1.Text.Length < 5)
            {
                errmsg = "Must be 5 or more Characters";
                e.Cancel = false;
                this.lblErrAdd1.Text = errmsg;
                blnAdd1 = false;
                EnableAccept();
            }
            else
            {
                this.lblErrAdd1.Text = "";
                blnAdd1 = true;
                EnableAccept();
            }
            erpCusttxb.SetError((Control)sender, errmsg);
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            string errmsg = null;
            if (txtCity.Text.Length < 2)
            {
                errmsg = "Must be 2 or more Characters";
                e.Cancel = false;
                this.lblCityErr.Text = errmsg;
                blnCity = false;
                EnableAccept();
            }
            else
            {
                this.lblCityErr.Text = "";
                blnCity = true;
                EnableAccept();
            }
            erpCusttxb.SetError((Control)sender, errmsg);
        }
        private void mskZip_Validating(object sender, CancelEventArgs e)
        {
            string errmsg = null;
            int intTestZip = mskZip.Text.Length;
            if (intTestZip == 5)
            {
                this.lblZipErr.Text = "";
                blnZip = true;
                EnableAccept();
            }
            else if (intTestZip == 9)
            {
                this.lblZipErr.Text = "";
                blnZip = true;
                EnableAccept();
            }
            else
            {
                errmsg = "Must be 5 or 9 Characters";
                e.Cancel = false;
                lblZipErr.Text = errmsg;
                blnZip = false;
                EnableAccept();
            }
            erpCusttxb.SetError((Control)sender, errmsg);
        }

        private void mskPhone_Validating(object sender, CancelEventArgs e)
        {
            string errmsg = null;
            int intTestPhone = mskPhone.Text.Length;

            if (ActiveControl.Name == "btnClose")
            {
                e.Cancel = false;
            }
            else if (ActiveControl.Name == "chkMute")
            {
                e.Cancel = false;
            }
            else if (intTestPhone == 10)
            {
                this.lblErrPhone.Text = "";
                blnPhone = true;
                EnableAccept();
            }
            else
            {
                errmsg = "Must enter complete phone number";
                e.Cancel = true;
                this.lblErrPhone.Text = errmsg;
            }
            erpCusttxb.SetError((Control)sender, errmsg);
        }

        private void Music()
        {

            if (chkMute.Checked == false) 
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "ChillingMusic.wav";
                player.PlayLooping();
                muteToolStripMenuItem.Enabled = true;
            }
            else
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "ChillingMusic.wav";
                player.Stop();
            }
                
        }
        private void Pricing()
        {
            Single sngPrice = 0.0f;
            Single intQty = Convert.ToSingle(txtPizNu.Text);


            if (rabSmall.Checked == true)
            {
                sngPrice += sngSmall * intQty;
            }
            else if (rabMed.Checked == true)
            {
                sngPrice += sngMed * intQty;
            }
            else
            {
                sngPrice += sngLarge * intQty;
            }

            // Toppings

            for (int i = 0; i < clbToppings.Items.Count; i++)
            {
                if (clbToppings.GetItemChecked(i) == true)
                {
                    sngPrice += sngTop;
                }
            }

            string strPrice = sngPrice.ToString ("C2");
            txtSubTotal.Text = strPrice;
            string strTax = $"{sngPrice * sngTax:C2}";
            txtTax.Text =  strTax;
            string strTotol = $"{(sngPrice + (sngPrice * sngTax)):C2}";
            txtTotal.Text = strTotol;

        }
        private void btnPrice_Click(object sender, EventArgs e)
        {
            Pricing();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rabSmall_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void cboState_Validating(object sender, CancelEventArgs e)
        {
            string errmsg = null;
            if (cboState.Text.Length < 2)
            {
                errmsg = "Must be 2 or more Characters";
                e.Cancel = false;
                this.lblCityErr.Text = errmsg;
                blnState = false;
                EnableAccept();
            }
            else
            {
                this.lblCityErr.Text = "";
                blnState = true;
                EnableAccept();
            }
            erpCusttxb.SetError((Control)sender, errmsg);
        }

        private void chkMute_CheckedChanged(object sender, EventArgs e)
        {
            Music();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inttxtPizNu == intPiznum)
            {
                inttxtPizNu++;
                this.txtQt.Text = inttxtPizNu.ToString();
            }

            intPiznum++;
            this.txtPizNu.Text = intPiznum.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtPizNu.Text) > 1)
            {
                intPiznum = Convert.ToInt16(txtPizNu.Text);
            }
            if (intPiznum > 1)
            {
                intPiznum--;
                this.txtPizNu.Text = intPiznum.ToString();
            } 
            else
            {
                MessageBox.Show("Can't be Less then 1");
            }
        }
        private void CustSearch()
        {
            try
            {
                string strPath = Application.StartupPath + "\\Pizza.mdf;";
                string strConn = strDataSrc + strPath + strParms;
                string strCustSQL = "select * from Customers where custphone = '" + mskPhone.Text + "';";
                cnCust = new SqlConnection(strConn);
                cnCust.Open();
                daCust = new SqlDataAdapter(strCustSQL, cnCust);

            }
            catch
            {
                MessageBox.Show("Connection open failed!");
                bolExistingCust = false; 
            }
            daCust.Fill(dtCust);
            if (dtCust.Rows.Count > 0)  // was there a cusstomer match?
            {
                txtCust.Text = dtCust.Rows[0]["custname"].ToString();
                txtAddr1.Text = dtCust.Rows[0]["custaddress1"].ToString();
                txtaddr2.Text = dtCust.Rows[0]["custaddress2"].ToString();
                txtCity.Text = dtCust.Rows[0]["custcity"].ToString();
                cboState.Text = dtCust.Rows[0]["custstate"].ToString();
                mskZip.Text = dtCust.Rows[0]["custzip"].ToString();
                dtCust.Clear();

                blnPhone = true;
                blnCustN = true;
                blnAdd1 = true;
                blnCity = true;
                blnZip = true;
                this.cboPaymentType.Focus();
            }
            else
            {
                this.txtCust.Focus();
                bolExistingCust = false;
            }

            try
            {
                string strSQLO = "select * from Orders where CustPhone ='" + mskPhone.Text + "';";
                SqlDataAdapter daOrder = new SqlDataAdapter(strSQLO, cnCust);
                DataTable dtOrder = new DataTable();
                daOrder.Fill(dtOrder);

                if (dtOrder.Rows.Count >0)
                {
                    if (MessageBox.Show("Upate pizza options from customers last order?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        //MessageBox.Show(dtOrder.Rows.Count.ToString());
                        int idx = dtOrder.Rows.Count - 1;
                        txtPizNu.Text = Convert.ToString(dtOrder.Rows[idx]["Qty"]);
                        txtQt.Text = Convert.ToString(dtOrder.Rows[idx]["Qty"]);
                        string strSize = dtOrder.Rows[idx]["OrderSize"].ToString();
                        if (strSize == "S")
                        {
                            rabSmall.Checked = true;
                        }
                        else if (strSize == "M")
                        {
                            rabMed.Checked = true;
                        }
                        else
                        {
                            rabLarge.Checked = true;
                        }
                        clearAllToolStripMenuItem.Enabled = true;
                        clbToppings.SetItemChecked(0, Convert.ToBoolean(dtOrder.Rows[idx]["Top1"]));
                        clbToppings.SetItemChecked(1, Convert.ToBoolean(dtOrder.Rows[idx]["Top2"]));
                        clbToppings.SetItemChecked(2, Convert.ToBoolean(dtOrder.Rows[idx]["Top3"]));
                        clbToppings.SetItemChecked(3, Convert.ToBoolean(dtOrder.Rows[idx]["Top4"]));
                        clbToppings.SetItemChecked(4, Convert.ToBoolean(dtOrder.Rows[idx]["Top5"]));
                        clbToppings.SetItemChecked(5, Convert.ToBoolean(dtOrder.Rows[idx]["Top6"]));
                        clbToppings.SetItemChecked(6, Convert.ToBoolean(dtOrder.Rows[idx]["Top7"]));
                        clbToppings.SetItemChecked(7, Convert.ToBoolean(dtOrder.Rows[idx]["Top8"]));
                        clbToppings.SetItemChecked(8, Convert.ToBoolean(dtOrder.Rows[idx]["Top9"]));
                        clbToppings.SetItemChecked(9, Convert.ToBoolean(dtOrder.Rows[idx]["Top10"]));
                        
                    }
                    else
                    {

                    }
                }
            }
            catch
            {
                
            }
   
        }

        private void clbsec(CheckedListBox clbToppings, string text)
        {
            for (int i = 0; i < clbToppings.Items.Count; i++)
            {
                if (text == clbToppings.Items[i].ToString())
                {
                    clbToppings.SetItemChecked(i, true);
                }
            }
        }
        private void mskPhone_TextChanged(object sender, EventArgs e)
        {
            if (mskPhone.Text.Length == 10)
            {
                CustSearch();
            }
        }

        private void frmPizzaProj_FormClosing(object sender, FormClosingEventArgs e)
        {
         
            if (MessageBox.Show("    Are you Sure you want to Close", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
                this.mskPhone.Focus();
            }
            else
            {
                e.Cancel = false;
            }

        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clbToppings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pricing();
            clearAllToolStripMenuItem.Enabled = true;
        }

        private void muteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "ChillingMusic.wav";
            player.Stop();
            this.chkMute.Checked = true;
            muteToolStripMenuItem.Enabled = false;
            muteToolStripMenuItem1.Enabled = false;
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))

            {
                this.lblCityErr.Text = "Numbers not alowed";
                e.Handled = true;
                blnCustN = false;
                EnableAccept();
            }
            else
            {
                this.lblCityErr.Text = "";
                blnCustN = true;
                EnableAccept();
            }
        }

        private void mskPhone_Click(object sender, EventArgs e)
        {
            mskPhone.Select(0, 0);
        }

        private void MenuStripcheck (int intIndex, bool strTF)
        {
            cboPaymentType.SelectedIndex = intIndex;
            int i = 0;
            foreach (ToolStripItem toolItem in mnuPayment.DropDownItems)
            {
                if (i != intIndex)
                {
                    ((ToolStripMenuItem)mnuPayment.DropDownItems[i]).Checked = strTF; 
                }
                else
                {
                    ((ToolStripMenuItem)mnuPayment.DropDownItems[i]).Checked = true;
                }
                i++;
            }
        }

        private void cboPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intIndex = cboPaymentType.SelectedIndex;

            MenuStripcheck(intIndex, false);

            Globals.gblValidCC = false;  
            Globals.gblCCTypes = cboPaymentType.Text;

            if (cboPaymentType.SelectedIndex >= 1)
            {
                frmCCData F2 = new frmCCData();
                F2.ShowDialog();
                EnableAccept();
                if (Globals.gblValidCC == false)
                {
                    cboPaymentType.SelectedIndex = 0;
                }

            }
            else
            {
                //Globals.gblValidCC = true;
            }
            EnableAccept();
        }

        private void cashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int intIndex = 0;
            MenuStripcheck(intIndex, false);
        }

        private void masterCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int intIndex = 1;
            MenuStripcheck(intIndex, false);
        }

        private void visaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int intIndex = 2;
            MenuStripcheck(intIndex, false);
        }

        private void discoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int intIndex = 3;
            MenuStripcheck(intIndex, false);
        }

        private void amexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int intIndex = 4;
            MenuStripcheck(intIndex, false);
        }

        private void dinnersCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int intIndex = 5;
            MenuStripcheck(intIndex, false);
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if(cd.ShowDialog()== DialogResult.OK)
                {
                    this.BackColor = cd.Color;
                    this.clbToppings.BackColor = cd.Color;
                    this.txtSubTotal.BackColor = cd.Color;
                    this.txtTax.BackColor = cd.Color;
                    this.txtTotal.BackColor = cd.Color;
                    resetBackGroundToolStripMenuItem.Enabled = true;

                    if (MessageBox.Show("Keep BackGround Color", "BackGround Color", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                            this.BackColor = Color.FromArgb(192, 255, 192);
                            this.clbToppings.BackColor = Color.FromArgb(192, 255, 192);
                            this.txtSubTotal.BackColor = Color.FromArgb(192, 255, 192);
                            this.txtTax.BackColor = Color.FromArgb(192, 255, 192);
                            this.txtTotal.BackColor = Color.FromArgb(192, 255, 192);
                            resetBackGroundToolStripMenuItem.Enabled = false;
                    }
                    

                }

            }
        }

        private void resetBackGroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(192, 255, 192);
            this.clbToppings.BackColor = Color.FromArgb(192, 255, 192);
            this.txtSubTotal.BackColor = Color.FromArgb(192, 255, 192);
            this.txtTax.BackColor = Color.FromArgb(192, 255, 192);
            this.txtTotal.BackColor = Color.FromArgb(192, 255, 192);
            resetBackGroundToolStripMenuItem.Enabled = false;
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Music();
            this.chkMute.Checked = false;
            muteToolStripMenuItem.Enabled = true;
            playToolStripMenuItem.Enabled = false;
            muteToolStripMenuItem1.Enabled = true;
        }

        private void muteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "ChillingMusic.wav";
            player.Stop();
            this.chkMute.Checked = true;
            muteToolStripMenuItem.Enabled = false;
            muteToolStripMenuItem1.Enabled = false;
            playToolStripMenuItem.Enabled = true;


        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(mskPhone.Text);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(mskPhone.Text);
            mskPhone.Text = string.Empty;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string xx = Clipboard.GetText();
            mskPhone.Text = mskPhone.Text.Insert(mskPhone.SelectionStart, xx);
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCust.Text);
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCust.Text);
            txtCust.Text = string.Empty;
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string xx = Clipboard.GetText();
            txtCust.Text = txtCust.Text.Insert(txtCust.SelectionStart, xx);
        }

        private void copyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtAddr1.Text);
        }

        private void cutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtAddr1.Text);
            txtAddr1.Text = string.Empty;
        }

        private void pasteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string xx = Clipboard.GetText();
            txtAddr1.Text = txtAddr1.Text.Insert(txtAddr1.SelectionStart, xx);
        }

        private void copyToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtaddr2.Text);
        }

        private void cutToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtaddr2.Text);
            txtaddr2.Text = string.Empty;

        }

        private void pasteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string xx = Clipboard.GetText();
            txtaddr2.Text = txtaddr2.Text.Insert(txtaddr2.SelectionStart, xx);
        }

        private void copyToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCity.Text);
        }

        private void cutToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCity.Text);
            txtCity.Text = string.Empty;
        }

        private void pasteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string xx = Clipboard.GetText();
            txtCity.Text = txtCity.Text.Insert(txtCity.SelectionStart, xx);
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbToppings.Items.Count; i++)
            {
                clbToppings.SetItemChecked(i, false);
                clearAllToolStripMenuItem.Enabled = false;
            }
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbToppings.Items.Count; i++)
            {
                clbToppings.SetItemChecked(i, true);
                clearAllToolStripMenuItem.Enabled = true;

            }
        }

        private void cboPaymentType_Validating(object sender, CancelEventArgs e)
        {
            if(cboPaymentType.Text == "Cash")
            {
                btnAccept.Enabled = true;
            }
        }
    }
}
