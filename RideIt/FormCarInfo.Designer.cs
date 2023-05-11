namespace RideIt
{
    partial class FormCarInfo
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCRegiNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cregi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCDelete = new System.Windows.Forms.Label();
            this.lblCSave = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblClr = new System.Windows.Forms.Label();
            this.lblCb = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Registration no  :";
            // 
            // txtCRegiNo
            // 
            this.txtCRegiNo.Location = new System.Drawing.Point(169, 144);
            this.txtCRegiNo.Name = "txtCRegiNo";
            this.txtCRegiNo.Size = new System.Drawing.Size(153, 23);
            this.txtCRegiNo.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Color :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Car Name :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Car ID :";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(169, 183);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(153, 23);
            this.txtColor.TabIndex = 19;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(169, 62);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(153, 23);
            this.txtCID.TabIndex = 17;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowInfo.Location = new System.Drawing.Point(693, 277);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(99, 23);
            this.btnShowInfo.TabIndex = 16;
            this.btnShowInfo.Text = "Show Info >>";
            this.btnShowInfo.UseVisualStyleBackColor = false;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
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
            this.panel2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(330, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Car Information";
            // 
            // dgvCar
            // 
            this.dgvCar.AllowUserToAddRows = false;
            this.dgvCar.AllowUserToDeleteRows = false;
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.cname,
            this.cregi,
            this.color,
            this.status,
            this.price});
            this.dgvCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCar.Location = new System.Drawing.Point(0, 0);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.ReadOnly = true;
            this.dgvCar.RowTemplate.Height = 25;
            this.dgvCar.Size = new System.Drawing.Size(804, 155);
            this.dgvCar.TabIndex = 0;
            this.dgvCar.DoubleClick += new System.EventHandler(this.dgvCar_DoubleClick);
            // 
            // cid
            // 
            this.cid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cid.DataPropertyName = "cid";
            this.cid.HeaderText = "Car Id";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // cname
            // 
            this.cname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cname.DataPropertyName = "cname";
            this.cname.HeaderText = "Car Name";
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            // 
            // cregi
            // 
            this.cregi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cregi.DataPropertyName = "cregi";
            this.cregi.HeaderText = "Registration No";
            this.cregi.Name = "cregi";
            this.cregi.ReadOnly = true;
            // 
            // color
            // 
            this.color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(169, 101);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(153, 23);
            this.txtCName.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 155);
            this.panel1.TabIndex = 14;
            // 
            // lblCDelete
            // 
            this.lblCDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCDelete.Location = new System.Drawing.Point(482, 112);
            this.lblCDelete.Name = "lblCDelete";
            this.lblCDelete.Size = new System.Drawing.Size(75, 23);
            this.lblCDelete.TabIndex = 29;
            this.lblCDelete.Text = "Delete";
            this.lblCDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCDelete.Click += new System.EventHandler(this.lblCDelete_Click);
            // 
            // lblCSave
            // 
            this.lblCSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCSave.Location = new System.Drawing.Point(383, 112);
            this.lblCSave.Name = "lblCSave";
            this.lblCSave.Size = new System.Drawing.Size(75, 23);
            this.lblCSave.TabIndex = 28;
            this.lblCSave.Text = "Save";
            this.lblCSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCSave.Click += new System.EventHandler(this.lblCSave_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Status :";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(169, 222);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(153, 23);
            this.txtStatus.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Price :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(169, 260);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(153, 23);
            this.txtPrice.TabIndex = 33;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(383, 226);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(153, 23);
            this.textSearch.TabIndex = 35;
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearch.Location = new System.Drawing.Point(542, 226);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 23);
            this.lblSearch.TabIndex = 36;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click_1);
            // 
            // lblClr
            // 
            this.lblClr.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClr.Location = new System.Drawing.Point(584, 112);
            this.lblClr.Name = "lblClr";
            this.lblClr.Size = new System.Drawing.Size(75, 23);
            this.lblClr.TabIndex = 30;
            this.lblClr.Text = "Clear";
            this.lblClr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClr.Click += new System.EventHandler(this.lblClr_Click);
            // 
            // lblCb
            // 
            this.lblCb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCb.Location = new System.Drawing.Point(717, 224);
            this.lblCb.Name = "lblCb";
            this.lblCb.Size = new System.Drawing.Size(75, 23);
            this.lblCb.TabIndex = 37;
            this.lblCb.Text = "<< Back";
            this.lblCb.Click += new System.EventHandler(this.lblCb_Click);
            // 
            // FormCarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.lblCb);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblClr);
            this.Controls.Add(this.lblCDelete);
            this.Controls.Add(this.lblCSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCRegiNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.panel1);
            this.Name = "FormCarInfo";
            this.Text = "FormCarInfo";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox txtCRegiNo;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtColor;
        private TextBox txtCID;
        private Button btnShowInfo;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dgvCar;
        private TextBox txtCName;
        private Panel panel1;
        private Label lblCDelete;
        private Label lblCSave;
        private Label label5;
        private TextBox txtStatus;
        private Label label6;
        private TextBox txtPrice;
        private DataGridViewTextBoxColumn cid;
        private DataGridViewTextBoxColumn cname;
        private DataGridViewTextBoxColumn cregi;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn price;
        private TextBox textSearch;
        private Label lblSearch;
        private Label lblClr;
        private Label label7;
        private Label lblCb;
    }
}