namespace Assignment3_4
{
    partial class AddForm
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
            grpOrderInfo = new GroupBox();
            lblTotalPrice = new Label();
            comboSize = new ComboBox();
            lblTotal = new Label();
            btnSubmit = new Button();
            txtCount = new TextBox();
            txtCustName = new TextBox();
            txtCoffeeName = new TextBox();
            txtOrderid = new TextBox();
            lblCount = new Label();
            lblSize = new Label();
            lblCustName = new Label();
            lblCoffeeName = new Label();
            lblOrderid = new Label();
            lblorderidDisplay = new Label();
            grpOrderInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grpOrderInfo
            // 
            grpOrderInfo.Controls.Add(lblorderidDisplay);
            grpOrderInfo.Controls.Add(lblTotalPrice);
            grpOrderInfo.Controls.Add(comboSize);
            grpOrderInfo.Controls.Add(lblTotal);
            grpOrderInfo.Controls.Add(btnSubmit);
            grpOrderInfo.Controls.Add(txtCount);
            grpOrderInfo.Controls.Add(txtCustName);
            grpOrderInfo.Controls.Add(txtCoffeeName);
            grpOrderInfo.Controls.Add(txtOrderid);
            grpOrderInfo.Controls.Add(lblCount);
            grpOrderInfo.Controls.Add(lblSize);
            grpOrderInfo.Controls.Add(lblCustName);
            grpOrderInfo.Controls.Add(lblCoffeeName);
            grpOrderInfo.Controls.Add(lblOrderid);
            grpOrderInfo.Location = new Point(30, 12);
            grpOrderInfo.Name = "grpOrderInfo";
            grpOrderInfo.Size = new Size(308, 426);
            grpOrderInfo.TabIndex = 0;
            grpOrderInfo.TabStop = false;
            grpOrderInfo.Text = "Order Input";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BorderStyle = BorderStyle.FixedSingle;
            lblTotalPrice.Location = new Point(91, 247);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(36, 17);
            lblTotalPrice.TabIndex = 15;
            lblTotalPrice.Text = "$0.00";
            // 
            // comboSize
            // 
            comboSize.FormattingEnabled = true;
            comboSize.Location = new Point(91, 171);
            comboSize.Name = "comboSize";
            comboSize.Size = new Size(190, 23);
            comboSize.TabIndex = 14;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(22, 249);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(106, 318);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(91, 207);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(194, 23);
            txtCount.TabIndex = 11;
            txtCount.TextChanged += txtCount_TextChanged;
            // 
            // txtCustName
            // 
            txtCustName.Location = new Point(91, 129);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(194, 23);
            txtCustName.TabIndex = 9;
            // 
            // txtCoffeeName
            // 
            txtCoffeeName.Location = new Point(91, 90);
            txtCoffeeName.Name = "txtCoffeeName";
            txtCoffeeName.Size = new Size(194, 23);
            txtCoffeeName.TabIndex = 7;
            // 
            // txtOrderid
            // 
            txtOrderid.Location = new Point(91, 51);
            txtOrderid.Name = "txtOrderid";
            txtOrderid.Size = new Size(194, 23);
            txtOrderid.TabIndex = 6;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(20, 215);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(40, 15);
            lblCount.TabIndex = 4;
            lblCount.Text = "Count";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(20, 174);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(50, 15);
            lblSize.TabIndex = 3;
            lblSize.Text = "Bag Size";
            // 
            // lblCustName
            // 
            lblCustName.AutoSize = true;
            lblCustName.Location = new Point(20, 133);
            lblCustName.Name = "lblCustName";
            lblCustName.Size = new Size(59, 15);
            lblCustName.TabIndex = 2;
            lblCustName.Text = "Customer";
            // 
            // lblCoffeeName
            // 
            lblCoffeeName.AutoSize = true;
            lblCoffeeName.Location = new Point(20, 92);
            lblCoffeeName.Name = "lblCoffeeName";
            lblCoffeeName.Size = new Size(42, 15);
            lblCoffeeName.TabIndex = 1;
            lblCoffeeName.Text = "Coffee";
            // 
            // lblOrderid
            // 
            lblOrderid.AutoSize = true;
            lblOrderid.Location = new Point(20, 51);
            lblOrderid.Name = "lblOrderid";
            lblOrderid.Size = new Size(50, 15);
            lblOrderid.TabIndex = 0;
            lblOrderid.Text = "Order Id";
            // 
            // lblorderidDisplay
            // 
            lblorderidDisplay.AutoSize = true;
            lblorderidDisplay.Location = new Point(91, 22);
            lblorderidDisplay.Name = "lblorderidDisplay";
            lblorderidDisplay.Size = new Size(38, 15);
            lblorderidDisplay.TabIndex = 16;
            lblorderidDisplay.Text = "label1";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            Controls.Add(grpOrderInfo);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            grpOrderInfo.ResumeLayout(false);
            grpOrderInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOrderInfo;
        private Label lblOrderid;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lblCount;
        private Label lblSize;
        private Label lblCustName;
        private Label lblCoffeeName;
        private TextBox txtCount;
        private TextBox txtCustName;
        private TextBox txtCoffeeName;
        private TextBox txtOrderid;
        private Button btnSubmit;
        private Label lblTotal;
        private ComboBox comboSize;
        private Label lblTotalPrice;
        private Label lblorderidDisplay;
    }
}