namespace Assignment3_4
{
    partial class CoffeeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            orderGrid = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            lblCoffeeSystem = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)orderGrid).BeginInit();
            SuspendLayout();
            // 
            // orderGrid
            // 
            orderGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderGrid.Location = new Point(12, 61);
            orderGrid.Name = "orderGrid";
            orderGrid.Size = new Size(959, 254);
            orderGrid.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(87, 357);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(87, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblCoffeeSystem
            // 
            lblCoffeeSystem.AutoSize = true;
            lblCoffeeSystem.Location = new Point(104, 14);
            lblCoffeeSystem.Name = "lblCoffeeSystem";
            lblCoffeeSystem.Size = new Size(83, 15);
            lblCoffeeSystem.TabIndex = 3;
            lblCoffeeSystem.Text = "Coffee System";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(785, 359);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // CoffeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 572);
            Controls.Add(btnRefresh);
            Controls.Add(lblCoffeeSystem);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(orderGrid);
            Name = "CoffeeForm";
            Text = "Coffee Beverage Form";
            Load += CoffeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)orderGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView orderGrid;
        private Button btnAdd;
        private Button btnDelete;
        private Label lblCoffeeSystem;
        private Button btnRefresh;
    }
}
