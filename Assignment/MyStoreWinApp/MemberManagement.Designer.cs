namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getMemberListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.memberDaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.txtCurrentID = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.getMemberListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMemberListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMemberListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cboCountry);
            this.panel1.Controls.Add(this.cboCity);
            this.panel1.Controls.Add(this.btnSort);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lbCountry);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lbCity);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Location = new System.Drawing.Point(93, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1563, 200);
            this.panel1.TabIndex = 0;
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(740, 117);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(383, 40);
            this.cboCountry.TabIndex = 9;
            this.cboCountry.SelectedValueChanged += new System.EventHandler(this.cboCountry_SelectedValueChanged);
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(157, 118);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(383, 40);
            this.cboCity.TabIndex = 8;
            this.cboCity.SelectedValueChanged += new System.EventHandler(this.cboCity_SelectedValueChanged);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSort.Location = new System.Drawing.Point(1247, 109);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(219, 60);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort by name";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(1247, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(219, 60);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.Location = new System.Drawing.Point(608, 110);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(120, 47);
            this.lbCountry.TabIndex = 5;
            this.lbCountry.Text = "Country";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(608, 28);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(91, 47);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(740, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(383, 39);
            this.txtName.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(157, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(383, 39);
            this.txtId.TabIndex = 2;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCity.Location = new System.Drawing.Point(57, 109);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(69, 47);
            this.lbCity.TabIndex = 1;
            this.lbCity.Text = "City";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbId.Location = new System.Drawing.Point(57, 28);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(44, 47);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.dgvMemberList);
            this.panel2.Controls.Add(this.txtTestName);
            this.panel2.Controls.Add(this.txtCurrentID);
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Controls.Add(this.txtCountry);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Location = new System.Drawing.Point(93, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1557, 484);
            this.panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(1379, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 134);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(1379, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 134);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.AllowUserToOrderColumns = true;
            this.dgvMemberList.AutoGenerateColumns = false;
            this.dgvMemberList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.Email,
            this.Password});
            this.dgvMemberList.DataSource = this.getMemberListBindingSource1;
            this.dgvMemberList.Location = new System.Drawing.Point(42, 39);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 82;
            this.dgvMemberList.RowTemplate.Height = 41;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(1307, 410);
            this.dgvMemberList.TabIndex = 0;
            this.dgvMemberList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 200;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.Width = 200;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 10;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 220;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 10;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 200;
            // 
            // getMemberListBindingSource1
            // 
            this.getMemberListBindingSource1.DataMember = "GetMemberList";
            this.getMemberListBindingSource1.DataSource = this.memberDaoBindingSource;
            // 
            // memberDaoBindingSource
            // 
            this.memberDaoBindingSource.DataSource = typeof(DataAccess.MemberDao);
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(384, 372);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(200, 39);
            this.txtTestName.TabIndex = 3;
            this.txtTestName.TextChanged += new System.EventHandler(this.txtTestName_TextChanged);
            // 
            // txtCurrentID
            // 
            this.txtCurrentID.Location = new System.Drawing.Point(78, 343);
            this.txtCurrentID.Name = "txtCurrentID";
            this.txtCurrentID.Size = new System.Drawing.Size(200, 39);
            this.txtCurrentID.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(694, 372);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 39);
            this.txtCity.TabIndex = 4;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(1052, 362);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 39);
            this.txtCountry.TabIndex = 5;
            // 
            // getMemberListBindingSource
            // 
            this.getMemberListBindingSource.DataMember = "GetMemberList";
            this.getMemberListBindingSource.DataSource = this.memberDaoBindingSource;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1039, 389);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 39);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(740, 389);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 39);
            this.txtPassword.TabIndex = 3;
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 826);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMemberManagement_FormClosed);
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMemberListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMemberListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox cboCountry;
        private ComboBox cboCity;
        private Button btnSort;
        private Button btnSearch;
        private Label lbCountry;
        private Label lbName;
        private TextBox txtName;
        private TextBox txtId;
        private Label lbCity;
        private Label lbId;
        private Panel panel2;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvMemberList;
        private TextBox txtCurrentID;
        private TextBox txtTestName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private BindingSource getMemberListBindingSource;
        private BindingSource memberDaoBindingSource;
        private BindingSource getMemberListBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private TextBox txtEmail;
        private TextBox txtPassword;
    }
}