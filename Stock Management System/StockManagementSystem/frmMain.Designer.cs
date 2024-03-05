namespace StockManagementSystem
{
    partial class frmMain
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            tbProdCode = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbProdName = new TextBox();
            label3 = new Label();
            tbProdSRP = new TextBox();
            dgvList = new DataGridView();
            label4 = new Label();
            gbList = new GroupBox();
            label5 = new Label();
            tbProdDate = new TextBox();
            label6 = new Label();
            tbProdQuantity = new TextBox();
            label7 = new Label();
            tbProdCost = new TextBox();
            lblID = new Label();
            tbSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            gbList.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(51, 155);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Control;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(51, 242);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 37);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Control;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(51, 511);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 37);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(51, 331);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 37);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(51, 418);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 37);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbProdCode
            // 
            tbProdCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbProdCode.Location = new Point(329, 163);
            tbProdCode.Name = "tbProdCode";
            tbProdCode.Size = new Size(164, 29);
            tbProdCode.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(210, 166);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 7;
            label1.Text = "Product Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(203, 237);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 9;
            label2.Text = "Product Name";
            // 
            // tbProdName
            // 
            tbProdName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbProdName.Location = new Point(329, 234);
            tbProdName.Name = "tbProdName";
            tbProdName.Size = new Size(164, 29);
            tbProdName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(220, 308);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 11;
            label3.Text = "Product SRP";
            // 
            // tbProdSRP
            // 
            tbProdSRP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbProdSRP.Location = new Point(329, 305);
            tbProdSRP.Name = "tbProdSRP";
            tbProdSRP.Size = new Size(164, 29);
            tbProdSRP.TabIndex = 10;
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.BackgroundColor = SystemColors.ActiveCaption;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Dock = DockStyle.Fill;
            dgvList.GridColor = SystemColors.InactiveCaptionText;
            dgvList.Location = new Point(3, 19);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.Size = new Size(785, 499);
            dgvList.TabIndex = 12;
            dgvList.Click += dgvList_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Highlight;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(81, 44);
            label4.Name = "label4";
            label4.Size = new Size(364, 37);
            label4.TabIndex = 13;
            label4.Text = "Stock Management System";
            // 
            // gbList
            // 
            gbList.Controls.Add(dgvList);
            gbList.ForeColor = SystemColors.ActiveCaptionText;
            gbList.Location = new Point(523, 81);
            gbList.Name = "gbList";
            gbList.Size = new Size(791, 521);
            gbList.TabIndex = 14;
            gbList.TabStop = false;
            gbList.Text = "List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(208, 527);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 20;
            label5.Text = "Product Date";
            // 
            // tbProdDate
            // 
            tbProdDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbProdDate.Location = new Point(329, 524);
            tbProdDate.Name = "tbProdDate";
            tbProdDate.Size = new Size(164, 29);
            tbProdDate.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(182, 453);
            label6.Name = "label6";
            label6.Size = new Size(141, 21);
            label6.TabIndex = 18;
            label6.Text = "Product Quantity";
            // 
            // tbProdQuantity
            // 
            tbProdQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbProdQuantity.Location = new Point(329, 450);
            tbProdQuantity.Name = "tbProdQuantity";
            tbProdQuantity.Size = new Size(164, 29);
            tbProdQuantity.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(211, 381);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 16;
            label7.Text = "Product Cost";
            // 
            // tbProdCost
            // 
            tbProdCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbProdCost.Location = new Point(329, 378);
            tbProdCost.Name = "tbProdCost";
            tbProdCost.Size = new Size(164, 29);
            tbProdCost.TabIndex = 15;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = SystemColors.Highlight;
            lblID.Location = new Point(416, 107);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 21;
            lblID.Text = "ID";
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(878, 39);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(213, 33);
            tbSearch.TabIndex = 22;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Control;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(757, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 36);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1338, 656);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(lblID);
            Controls.Add(label5);
            Controls.Add(tbProdDate);
            Controls.Add(label6);
            Controls.Add(tbProdQuantity);
            Controls.Add(label7);
            Controls.Add(tbProdCost);
            Controls.Add(gbList);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbProdSRP);
            Controls.Add(label2);
            Controls.Add(tbProdName);
            Controls.Add(label1);
            Controls.Add(tbProdCode);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Management System";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            gbList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbProdCode;
        private Label label1;
        private Label label2;
        private TextBox tbProdName;
        private Label label3;
        private TextBox tbProdSRP;
        private DataGridView dgvList;
        private Label label4;
        private GroupBox gbList;
        private Label label5;
        private TextBox tbProdDate;
        private Label label6;
        private TextBox tbProdQuantity;
        private Label label7;
        private TextBox tbProdCost;
        private Label lblID;
        private TextBox tbSearch;
        private Button btnSearch;
    }
}