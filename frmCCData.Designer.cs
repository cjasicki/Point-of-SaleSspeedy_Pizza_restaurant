namespace Pizza_Project
{
    partial class frmCCData
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
            this.components = new System.ComponentModel.Container();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.mtbCCNum = new System.Windows.Forms.MaskedTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCCErr = new System.Windows.Forms.Label();
            this.lblCCType = new System.Windows.Forms.Label();
            this.lblcct = new System.Windows.Forms.Label();
            this.lblCCNum = new System.Windows.Forms.Label();
            this.erpCC = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpCC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(172, 143);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(45, 18);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(62, 143);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(57, 18);
            this.lblMonth.TabIndex = 12;
            this.lblMonth.Text = "Month";
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(164, 166);
            this.cboYear.Margin = new System.Windows.Forms.Padding(2);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(92, 28);
            this.cboYear.TabIndex = 2;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // cboMonth
            // 
            this.cboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(51, 166);
            this.cboMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(92, 28);
            this.cboMonth.TabIndex = 1;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // mtbCCNum
            // 
            this.mtbCCNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCCNum.Location = new System.Drawing.Point(46, 102);
            this.mtbCCNum.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCCNum.Mask = "0000-0000-0000-0000";
            this.mtbCCNum.Name = "mtbCCNum";
            this.mtbCCNum.ResetOnSpace = false;
            this.mtbCCNum.Size = new System.Drawing.Size(220, 32);
            this.mtbCCNum.TabIndex = 0;
            this.mtbCCNum.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCCNum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCCNum_MaskInputRejected);
            this.mtbCCNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCCNum_KeyPress);
            this.mtbCCNum.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCCNum_Validating);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(56, 232);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 36);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(164, 232);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 36);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(1, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter Credit Card Infomatoin";
            // 
            // lblCCErr
            // 
            this.lblCCErr.BackColor = System.Drawing.Color.Transparent;
            this.lblCCErr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCErr.ForeColor = System.Drawing.Color.Red;
            this.lblCCErr.Location = new System.Drawing.Point(10, 201);
            this.lblCCErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCErr.Name = "lblCCErr";
            this.lblCCErr.Size = new System.Drawing.Size(299, 20);
            this.lblCCErr.TabIndex = 18;
            this.lblCCErr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCCType
            // 
            this.lblCCType.AutoSize = true;
            this.lblCCType.BackColor = System.Drawing.Color.Transparent;
            this.lblCCType.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCType.ForeColor = System.Drawing.Color.Blue;
            this.lblCCType.Location = new System.Drawing.Point(182, 38);
            this.lblCCType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCType.Name = "lblCCType";
            this.lblCCType.Size = new System.Drawing.Size(107, 33);
            this.lblCCType.TabIndex = 19;
            this.lblCCType.Text = "Not Known";
            // 
            // lblcct
            // 
            this.lblcct.AutoSize = true;
            this.lblcct.BackColor = System.Drawing.Color.Transparent;
            this.lblcct.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcct.ForeColor = System.Drawing.Color.Red;
            this.lblcct.Location = new System.Drawing.Point(5, 47);
            this.lblcct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcct.Name = "lblcct";
            this.lblcct.Size = new System.Drawing.Size(173, 22);
            this.lblcct.TabIndex = 20;
            this.lblcct.Text = "Credit Card Type:";
            // 
            // lblCCNum
            // 
            this.lblCCNum.AutoSize = true;
            this.lblCCNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCCNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCNum.Location = new System.Drawing.Point(44, 80);
            this.lblCCNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCNum.Name = "lblCCNum";
            this.lblCCNum.Size = new System.Drawing.Size(215, 18);
            this.lblCCNum.TabIndex = 21;
            this.lblCCNum.Text = "Enter Credit Card Number";
            // 
            // erpCC
            // 
            this.erpCC.ContainerControl = this;
            // 
            // frmCCData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Project.Properties.Resources.cc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 285);
            this.Controls.Add(this.lblCCNum);
            this.Controls.Add(this.lblcct);
            this.Controls.Add(this.lblCCType);
            this.Controls.Add(this.lblCCErr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.mtbCCNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCCData";
            this.Text = "Credit Card From";
            this.Load += new System.EventHandler(this.frmCCData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.MaskedTextBox mtbCCNum;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCCErr;
        private System.Windows.Forms.Label lblCCType;
        private System.Windows.Forms.Label lblcct;
        private System.Windows.Forms.Label lblCCNum;
        private System.Windows.Forms.ErrorProvider erpCC;
    }
}