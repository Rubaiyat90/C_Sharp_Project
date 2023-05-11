namespace RideIt
{
    partial class FormEmInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.eid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.econtact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEmShowInfo = new System.Windows.Forms.Button();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.txtECNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblESave = new System.Windows.Forms.Label();
            this.lblEDelete = new System.Windows.Forms.Label();
            this.lblEBack = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblEClear = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 155);
            this.panel1.TabIndex = 0;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eid,
            this.ename,
            this.epass,
            this.econtact});
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowTemplate.Height = 25;
            this.dgvEmployee.Size = new System.Drawing.Size(804, 155);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.DoubleClick += new System.EventHandler(this.dgvEmployee_DoubleClick);
            // 
            // eid
            // 
            this.eid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eid.DataPropertyName = "eid";
            this.eid.HeaderText = "Employee Id";
            this.eid.Name = "eid";
            this.eid.ReadOnly = true;
            // 
            // ename
            // 
            this.ename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ename.DataPropertyName = "ename";
            this.ename.HeaderText = "Employee Name";
            this.ename.Name = "ename";
            this.ename.ReadOnly = true;
            // 
            // epass
            // 
            this.epass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.epass.DataPropertyName = "epass";
            this.epass.HeaderText = "Password";
            this.epass.Name = "epass";
            this.epass.ReadOnly = true;
            // 
            // econtact
            // 
            this.econtact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.econtact.DataPropertyName = "econtact";
            this.econtact.HeaderText = "Contact";
            this.econtact.Name = "econtact";
            this.econtact.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 46);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(291, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Employee Information";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 82);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 63);
            this.panel3.TabIndex = 0;
            // 
            // btnEmShowInfo
            // 
            this.btnEmShowInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmShowInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmShowInfo.Location = new System.Drawing.Point(693, 277);
            this.btnEmShowInfo.Name = "btnEmShowInfo";
            this.btnEmShowInfo.Size = new System.Drawing.Size(99, 23);
            this.btnEmShowInfo.TabIndex = 2;
            this.btnEmShowInfo.Text = "Show Info >>";
            this.btnEmShowInfo.UseVisualStyleBackColor = false;
            // 
            // txtEID
            // 
            this.txtEID.Location = new System.Drawing.Point(169, 66);
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(153, 23);
            this.txtEID.TabIndex = 3;
            // 
            // txtEName
            // 
            this.txtEName.Location = new System.Drawing.Point(169, 112);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(153, 23);
            this.txtEName.TabIndex = 4;
            // 
            // txtECNo
            // 
            this.txtECNo.Location = new System.Drawing.Point(169, 216);
            this.txtECNo.Name = "txtECNo";
            this.txtECNo.Size = new System.Drawing.Size(153, 23);
            this.txtECNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee ID :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee Name :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contact Number :";
            // 
            // lblESave
            // 
            this.lblESave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblESave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblESave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblESave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblESave.Location = new System.Drawing.Point(370, 66);
            this.lblESave.Name = "lblESave";
            this.lblESave.Size = new System.Drawing.Size(75, 23);
            this.lblESave.TabIndex = 9;
            this.lblESave.Text = "Save";
            this.lblESave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblESave.Click += new System.EventHandler(this.lblESave_Click);
            // 
            // lblEDelete
            // 
            this.lblEDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEDelete.Location = new System.Drawing.Point(451, 66);
            this.lblEDelete.Name = "lblEDelete";
            this.lblEDelete.Size = new System.Drawing.Size(75, 23);
            this.lblEDelete.TabIndex = 10;
            this.lblEDelete.Text = "Delete";
            this.lblEDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEDelete.Click += new System.EventHandler(this.lblEDelete_Click);
            // 
            // lblEBack
            // 
            this.lblEBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEBack.Location = new System.Drawing.Point(717, 227);
            this.lblEBack.Name = "lblEBack";
            this.lblEBack.Size = new System.Drawing.Size(75, 23);
            this.lblEBack.TabIndex = 11;
            this.lblEBack.Text = "<<Back";
            this.lblEBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEBack.Click += new System.EventHandler(this.lblEBack_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password  :";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(169, 163);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(153, 23);
            this.txtPass.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(17, 264);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(153, 23);
            this.txtSearch.TabIndex = 14;
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(176, 264);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 23);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search ";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // lblEClear
            // 
            this.lblEClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEClear.Location = new System.Drawing.Point(370, 112);
            this.lblEClear.Name = "lblEClear";
            this.lblEClear.Size = new System.Drawing.Size(75, 23);
            this.lblEClear.TabIndex = 16;
            this.lblEClear.Text = "Clear";
            this.lblEClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEClear.Click += new System.EventHandler(this.lblEClear_Click);
            // 
            // FormEmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.lblEClear);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblEBack);
            this.Controls.Add(this.lblEDelete);
            this.Controls.Add(this.lblESave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtECNo);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.txtEID);
            this.Controls.Add(this.btnEmShowInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmInfo";
            this.Text = "FormEmInfo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private DataGridView dgvEmployee;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnEmShowInfo;
        private TextBox txtEID;
        private TextBox txtEName;
        private TextBox txtECNo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblESave;
        private Label lblEDelete;
        private Label lblEBack;
        private Label label4;
        private TextBox txtPass;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblEClear;
        private DataGridViewTextBoxColumn eid;
        private DataGridViewTextBoxColumn ename;
        private DataGridViewTextBoxColumn epass;
        private DataGridViewTextBoxColumn econtact;
        private Label label7;
    }
}