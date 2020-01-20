namespace Pizza_Project
{
    partial class frmPizzaProj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTilte = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCustInfo = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblAddr1 = new System.Windows.Forms.Label();
            this.lblAddr2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSt = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.txtaddr2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mskZip = new System.Windows.Forms.MaskedTextBox();
            this.pnlCustInfo = new System.Windows.Forms.Panel();
            this.lblOrderInfo = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblOrderNumVal = new System.Windows.Forms.Label();
            this.pnlOrderInfo = new System.Windows.Forms.Panel();
            this.lblsize = new System.Windows.Forms.Label();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.rbdMed = new System.Windows.Forms.RadioButton();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.pnlSize = new System.Windows.Forms.Panel();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkCanadanBacon = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkGreenOlives = new System.Windows.Forms.CheckBox();
            this.chkBlackOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.pnlQty = new System.Windows.Forms.Panel();
            this.picPizza = new System.Windows.Forms.PictureBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPricing = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.lblActions = new System.Windows.Forms.Label();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlSize1 = new System.Windows.Forms.Panel();
            this.pnlToppings = new System.Windows.Forms.Panel();
            this.pnlCustInfo.SuspendLayout();
            this.pnlOrderInfo.SuspendLayout();
            this.pnlSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.pnlQty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            this.pnlPayment.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlSize1.SuspendLayout();
            this.pnlToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTilte
            // 
            this.lblTilte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilte.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTilte.Location = new System.Drawing.Point(226, 7);
            this.lblTilte.Name = "lblTilte";
            this.lblTilte.Size = new System.Drawing.Size(382, 52);
            this.lblTilte.TabIndex = 0;
            this.lblTilte.Text = "Speedy HOT Pizza";
            this.lblTilte.Click += new System.EventHandler(this.lblTilte_Click);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDate.Location = new System.Drawing.Point(260, 59);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(325, 24);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Today\'s Data and time";
            // 
            // lblCustInfo
            // 
            this.lblCustInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCustInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCustInfo.Location = new System.Drawing.Point(20, 9);
            this.lblCustInfo.Name = "lblCustInfo";
            this.lblCustInfo.Size = new System.Drawing.Size(201, 25);
            this.lblCustInfo.TabIndex = 2;
            this.lblCustInfo.Text = "Customer Infomation";
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPhone.Location = new System.Drawing.Point(20, 54);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(90, 25);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            // 
            // lblCustName
            // 
            this.lblCustName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCustName.Location = new System.Drawing.Point(20, 83);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(90, 25);
            this.lblCustName.TabIndex = 1;
            this.lblCustName.Text = "Customer:";
            // 
            // lblAddr1
            // 
            this.lblAddr1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAddr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAddr1.Location = new System.Drawing.Point(20, 112);
            this.lblAddr1.Name = "lblAddr1";
            this.lblAddr1.Size = new System.Drawing.Size(90, 25);
            this.lblAddr1.TabIndex = 2;
            this.lblAddr1.Text = "Address1:";
            // 
            // lblAddr2
            // 
            this.lblAddr2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAddr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAddr2.Location = new System.Drawing.Point(20, 141);
            this.lblAddr2.Name = "lblAddr2";
            this.lblAddr2.Size = new System.Drawing.Size(90, 26);
            this.lblAddr2.TabIndex = 3;
            this.lblAddr2.Text = "Address2:";
            // 
            // lblCity
            // 
            this.lblCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCity.Location = new System.Drawing.Point(20, 171);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(90, 26);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // lblSt
            // 
            this.lblSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSt.Location = new System.Drawing.Point(20, 201);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(90, 26);
            this.lblSt.TabIndex = 5;
            this.lblSt.Text = "State:";
            // 
            // lblZip
            // 
            this.lblZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblZip.Location = new System.Drawing.Point(20, 233);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(90, 26);
            this.lblZip.TabIndex = 6;
            this.lblZip.Text = "Zipcode:";
            this.lblZip.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCust
            // 
            this.txtCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCust.Location = new System.Drawing.Point(116, 80);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(190, 26);
            this.txtCust.TabIndex = 1;
            // 
            // mskPhone
            // 
            this.mskPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPhone.Location = new System.Drawing.Point(116, 53);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(126, 26);
            this.mskPhone.TabIndex = 0;
            // 
            // txtAddr1
            // 
            this.txtAddr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr1.Location = new System.Drawing.Point(116, 109);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(190, 26);
            this.txtAddr1.TabIndex = 2;
            // 
            // txtaddr2
            // 
            this.txtaddr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddr2.Location = new System.Drawing.Point(116, 138);
            this.txtaddr2.Name = "txtaddr2";
            this.txtaddr2.Size = new System.Drawing.Size(190, 26);
            this.txtaddr2.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(116, 168);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(190, 26);
            this.txtCity.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // mskZip
            // 
            this.mskZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskZip.Location = new System.Drawing.Point(116, 230);
            this.mskZip.Mask = "00000-9999";
            this.mskZip.Name = "mskZip";
            this.mskZip.Size = new System.Drawing.Size(126, 26);
            this.mskZip.TabIndex = 6;
            // 
            // pnlCustInfo
            // 
            this.pnlCustInfo.Controls.Add(this.mskZip);
            this.pnlCustInfo.Controls.Add(this.lblCustInfo);
            this.pnlCustInfo.Controls.Add(this.comboBox1);
            this.pnlCustInfo.Controls.Add(this.txtCity);
            this.pnlCustInfo.Controls.Add(this.txtaddr2);
            this.pnlCustInfo.Controls.Add(this.txtAddr1);
            this.pnlCustInfo.Controls.Add(this.mskPhone);
            this.pnlCustInfo.Controls.Add(this.txtCust);
            this.pnlCustInfo.Controls.Add(this.lblZip);
            this.pnlCustInfo.Controls.Add(this.lblSt);
            this.pnlCustInfo.Controls.Add(this.lblCity);
            this.pnlCustInfo.Controls.Add(this.lblAddr2);
            this.pnlCustInfo.Controls.Add(this.lblAddr1);
            this.pnlCustInfo.Controls.Add(this.lblCustName);
            this.pnlCustInfo.Controls.Add(this.lblPhone);
            this.pnlCustInfo.Location = new System.Drawing.Point(3, 95);
            this.pnlCustInfo.Name = "pnlCustInfo";
            this.pnlCustInfo.Size = new System.Drawing.Size(313, 293);
            this.pnlCustInfo.TabIndex = 0;
            this.pnlCustInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCustInfo_Paint);
            // 
            // lblOrderInfo
            // 
            this.lblOrderInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOrderInfo.Location = new System.Drawing.Point(25, 3);
            this.lblOrderInfo.Name = "lblOrderInfo";
            this.lblOrderInfo.Size = new System.Drawing.Size(170, 25);
            this.lblOrderInfo.TabIndex = 17;
            this.lblOrderInfo.Text = "Order Information";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOrderNum.Location = new System.Drawing.Point(41, 25);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(126, 25);
            this.lblOrderNum.TabIndex = 0;
            this.lblOrderNum.Text = "Order Number:";
            // 
            // lblOrderNumVal
            // 
            this.lblOrderNumVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOrderNumVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumVal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOrderNumVal.Location = new System.Drawing.Point(173, 25);
            this.lblOrderNumVal.Name = "lblOrderNumVal";
            this.lblOrderNumVal.Size = new System.Drawing.Size(83, 25);
            this.lblOrderNumVal.TabIndex = 18;
            this.lblOrderNumVal.Text = "001";
            // 
            // pnlOrderInfo
            // 
            this.pnlOrderInfo.Controls.Add(this.pnlToppings);
            this.pnlOrderInfo.Controls.Add(this.pnlSize);
            this.pnlOrderInfo.Controls.Add(this.lblOrderNumVal);
            this.pnlOrderInfo.Controls.Add(this.lblOrderInfo);
            this.pnlOrderInfo.Controls.Add(this.lblOrderNum);
            this.pnlOrderInfo.Location = new System.Drawing.Point(321, 95);
            this.pnlOrderInfo.Name = "pnlOrderInfo";
            this.pnlOrderInfo.Size = new System.Drawing.Size(287, 293);
            this.pnlOrderInfo.TabIndex = 2;
            this.pnlOrderInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrderInfo_Paint);
            // 
            // lblsize
            // 
            this.lblsize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsize.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblsize.Location = new System.Drawing.Point(42, 4);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(77, 25);
            this.lblsize.TabIndex = 0;
            this.lblsize.Text = "Size:";
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(59, 28);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(50, 17);
            this.rdbSmall.TabIndex = 0;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Text = "&Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            // 
            // rbdMed
            // 
            this.rbdMed.AutoSize = true;
            this.rbdMed.Location = new System.Drawing.Point(59, 51);
            this.rbdMed.Name = "rbdMed";
            this.rbdMed.Size = new System.Drawing.Size(62, 17);
            this.rbdMed.TabIndex = 1;
            this.rbdMed.TabStop = true;
            this.rbdMed.Text = "&Medium";
            this.rbdMed.UseVisualStyleBackColor = true;
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Location = new System.Drawing.Point(59, 74);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(52, 17);
            this.rdbLarge.TabIndex = 2;
            this.rdbLarge.TabStop = true;
            this.rdbLarge.Text = "&Large";
            this.rdbLarge.UseVisualStyleBackColor = true;
            // 
            // pnlSize
            // 
            this.pnlSize.Controls.Add(this.pnlSize1);
            this.pnlSize.Location = new System.Drawing.Point(8, 47);
            this.pnlSize.Name = "pnlSize";
            this.pnlSize.Size = new System.Drawing.Size(287, 102);
            this.pnlSize.TabIndex = 23;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(37, 11);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(77, 17);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "Pepperoni ";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(37, 34);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(37, 57);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(59, 17);
            this.chkOnions.TabIndex = 2;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(37, 80);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(68, 17);
            this.chkSausage.TabIndex = 3;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkCanadanBacon
            // 
            this.chkCanadanBacon.AutoSize = true;
            this.chkCanadanBacon.Location = new System.Drawing.Point(37, 103);
            this.chkCanadanBacon.Name = "chkCanadanBacon";
            this.chkCanadanBacon.Size = new System.Drawing.Size(103, 17);
            this.chkCanadanBacon.TabIndex = 4;
            this.chkCanadanBacon.Text = "Canadan Bacon";
            this.chkCanadanBacon.UseVisualStyleBackColor = true;
            this.chkCanadanBacon.CheckedChanged += new System.EventHandler(this.chkBacon_CheckedChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(159, 103);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(73, 17);
            this.chkPineapple.TabIndex = 9;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkGreenOlives
            // 
            this.chkGreenOlives.AutoSize = true;
            this.chkGreenOlives.Location = new System.Drawing.Point(159, 80);
            this.chkGreenOlives.Name = "chkGreenOlives";
            this.chkGreenOlives.Size = new System.Drawing.Size(87, 17);
            this.chkGreenOlives.TabIndex = 8;
            this.chkGreenOlives.Text = "Green Olives";
            this.chkGreenOlives.UseVisualStyleBackColor = true;
            // 
            // chkBlackOlives
            // 
            this.chkBlackOlives.AutoSize = true;
            this.chkBlackOlives.Location = new System.Drawing.Point(159, 57);
            this.chkBlackOlives.Name = "chkBlackOlives";
            this.chkBlackOlives.Size = new System.Drawing.Size(85, 17);
            this.chkBlackOlives.TabIndex = 7;
            this.chkBlackOlives.Text = "Black Olives";
            this.chkBlackOlives.UseVisualStyleBackColor = true;
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(159, 34);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(100, 17);
            this.chkGreenPeppers.TabIndex = 6;
            this.chkGreenPeppers.Text = "Green Peppers ";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(159, 11);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(89, 17);
            this.chkExtraCheese.TabIndex = 5;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQty.Location = new System.Drawing.Point(23, 38);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(50, 25);
            this.lblQty.TabIndex = 23;
            this.lblQty.Text = "&Qty";
            // 
            // nudQty
            // 
            this.nudQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(73, 32);
            this.nudQty.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(47, 38);
            this.nudQty.TabIndex = 0;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlQty
            // 
            this.pnlQty.Controls.Add(this.nudQty);
            this.pnlQty.Controls.Add(this.lblQty);
            this.pnlQty.Location = new System.Drawing.Point(321, 142);
            this.pnlQty.Name = "pnlQty";
            this.pnlQty.Size = new System.Drawing.Size(127, 102);
            this.pnlQty.TabIndex = 1;
            this.pnlQty.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQty_Paint);
            // 
            // picPizza
            // 
            this.picPizza.BackgroundImage = global::Pizza_Project.Properties.Resources.pizza_animated_gif_31;
            this.picPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPizza.Location = new System.Drawing.Point(615, 95);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(208, 94);
            this.picPizza.TabIndex = 35;
            this.picPizza.TabStop = false;
            this.picPizza.Click += new System.EventHandler(this.picPizza_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPayment.Location = new System.Drawing.Point(15, 9);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(126, 25);
            this.lblPayment.TabIndex = 17;
            this.lblPayment.Text = "&Payment";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Location = new System.Drawing.Point(26, 35);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(168, 24);
            this.cmbPaymentType.TabIndex = 0;
            // 
            // lblPricing
            // 
            this.lblPricing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricing.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPricing.Location = new System.Drawing.Point(15, 65);
            this.lblPricing.Name = "lblPricing";
            this.lblPricing.Size = new System.Drawing.Size(142, 25);
            this.lblPricing.TabIndex = 37;
            this.lblPricing.Text = "&Payment";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSubTotal.Location = new System.Drawing.Point(23, 99);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(90, 26);
            this.lblSubTotal.TabIndex = 17;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTax.Location = new System.Drawing.Point(23, 121);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(90, 26);
            this.lblTax.TabIndex = 38;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Location = new System.Drawing.Point(23, 145);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(90, 26);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(95, 93);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(82, 23);
            this.txtSubTotal.TabIndex = 4;
            this.txtSubTotal.Text = ".01";
            this.txtSubTotal.TextChanged += new System.EventHandler(this.txtSubTotal_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(95, 116);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(82, 23);
            this.txtTax.TabIndex = 5;
            this.txtTax.Text = "10.10";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(95, 139);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(82, 23);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.Text = "111.10";
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.txtTotal);
            this.pnlPayment.Controls.Add(this.lblPricing);
            this.pnlPayment.Controls.Add(this.txtTax);
            this.pnlPayment.Controls.Add(this.lblPayment);
            this.pnlPayment.Controls.Add(this.txtSubTotal);
            this.pnlPayment.Controls.Add(this.lblTotal);
            this.pnlPayment.Controls.Add(this.lblTax);
            this.pnlPayment.Controls.Add(this.lblSubTotal);
            this.pnlPayment.Controls.Add(this.cmbPaymentType);
            this.pnlPayment.Location = new System.Drawing.Point(615, 201);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(208, 187);
            this.pnlPayment.TabIndex = 3;
            this.pnlPayment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPayment_Paint);
            // 
            // lblActions
            // 
            this.lblActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActions.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblActions.Location = new System.Drawing.Point(31, 5);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(130, 25);
            this.lblActions.TabIndex = 17;
            this.lblActions.Text = "Actions";
            // 
            // chkMute
            // 
            this.chkMute.AutoSize = true;
            this.chkMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMute.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chkMute.Location = new System.Drawing.Point(433, 37);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(68, 24);
            this.chkMute.TabIndex = 5;
            this.chkMute.Text = "&Mute";
            this.chkMute.UseVisualStyleBackColor = true;
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.ForeColor = System.Drawing.Color.Yellow;
            this.btnPrice.Location = new System.Drawing.Point(47, 32);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(88, 34);
            this.btnPrice.TabIndex = 43;
            this.btnPrice.Text = "&Price";
            this.btnPrice.UseVisualStyleBackColor = false;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.Yellow;
            this.btnAccept.Location = new System.Drawing.Point(141, 32);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(88, 34);
            this.btnAccept.TabIndex = 44;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Yellow;
            this.btnReset.Location = new System.Drawing.Point(235, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 34);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Yellow;
            this.btnClose.Location = new System.Drawing.Point(329, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 34);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnClose);
            this.pnlActions.Controls.Add(this.btnReset);
            this.pnlActions.Controls.Add(this.btnAccept);
            this.pnlActions.Controls.Add(this.btnPrice);
            this.pnlActions.Controls.Add(this.chkMute);
            this.pnlActions.Controls.Add(this.lblActions);
            this.pnlActions.Location = new System.Drawing.Point(157, 394);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(525, 81);
            this.pnlActions.TabIndex = 4;
            this.pnlActions.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlActions_Paint);
            // 
            // pnlSize1
            // 
            this.pnlSize1.Controls.Add(this.rdbLarge);
            this.pnlSize1.Controls.Add(this.rbdMed);
            this.pnlSize1.Controls.Add(this.rdbSmall);
            this.pnlSize1.Controls.Add(this.lblsize);
            this.pnlSize1.Location = new System.Drawing.Point(118, 1);
            this.pnlSize1.Name = "pnlSize1";
            this.pnlSize1.Size = new System.Drawing.Size(160, 101);
            this.pnlSize1.TabIndex = 0;
            // 
            // pnlToppings
            // 
            this.pnlToppings.Controls.Add(this.chkPineapple);
            this.pnlToppings.Controls.Add(this.chkGreenOlives);
            this.pnlToppings.Controls.Add(this.chkBlackOlives);
            this.pnlToppings.Controls.Add(this.chkGreenPeppers);
            this.pnlToppings.Controls.Add(this.chkExtraCheese);
            this.pnlToppings.Controls.Add(this.chkCanadanBacon);
            this.pnlToppings.Controls.Add(this.chkSausage);
            this.pnlToppings.Controls.Add(this.chkOnions);
            this.pnlToppings.Controls.Add(this.chkMushrooms);
            this.pnlToppings.Controls.Add(this.chkPepperoni);
            this.pnlToppings.Location = new System.Drawing.Point(5, 154);
            this.pnlToppings.Name = "pnlToppings";
            this.pnlToppings.Size = new System.Drawing.Size(264, 122);
            this.pnlToppings.TabIndex = 1;
            // 
            // frmPizzaProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(827, 489);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlPayment);
            this.Controls.Add(this.picPizza);
            this.Controls.Add(this.pnlQty);
            this.Controls.Add(this.pnlOrderInfo);
            this.Controls.Add(this.pnlCustInfo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTilte);
            this.Name = "frmPizzaProj";
            this.Text = "Speedy Hot Pizza Order From";
            this.Load += new System.EventHandler(this.frmPizzaProj_Load);
            this.pnlCustInfo.ResumeLayout(false);
            this.pnlCustInfo.PerformLayout();
            this.pnlOrderInfo.ResumeLayout(false);
            this.pnlSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.pnlQty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.pnlSize1.ResumeLayout(false);
            this.pnlSize1.PerformLayout();
            this.pnlToppings.ResumeLayout(false);
            this.pnlToppings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTilte;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustInfo;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblAddr1;
        private System.Windows.Forms.Label lblAddr2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSt;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtCust;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.TextBox txtaddr2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox mskZip;
        private System.Windows.Forms.Panel pnlCustInfo;
        private System.Windows.Forms.Label lblOrderInfo;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblOrderNumVal;
        private System.Windows.Forms.Panel pnlOrderInfo;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkGreenOlives;
        private System.Windows.Forms.CheckBox chkBlackOlives;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkCanadanBacon;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.Panel pnlSize;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.RadioButton rbdMed;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Panel pnlQty;
        private System.Windows.Forms.PictureBox picPizza;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label lblPricing;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.CheckBox chkMute;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Panel pnlSize1;
        private System.Windows.Forms.Panel pnlToppings;
    }
}

