using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RideIt
{
    public partial class FormEmInfo : Form
    {
        private DataAccess Da { get; set; }
        public FormEmInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from Table_1;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.DataSource = ds.Tables[0];
        }

        private void btnEmShowInfo_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Table_1 where ename = '" + this.txtEName.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
            
        }



        private void lblESave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                var query = "select * from Table_1 where eid = '" + this.txtEID.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update Table_1 set ename = '" + this.txtEName.Text + "', epass = '" + this.txtPass.Text + "', econtact = '" + this.txtECNo.Text + "'where eid = '" + this.txtEID.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                {
                    //insert
                    var sql = @"insert into Table_1 values ( '"+this.txtEID.Text+"','"+this.txtEName.Text+"','"+this.txtPass.Text+"','"+this.txtECNo.Text+"');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data insertion successfull");
                    else
                        MessageBox.Show("Data insertion failed");
                }

                this.PopulateGridView();
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtEID.Text) || String.IsNullOrEmpty(this.txtEName.Text) ||
                String.IsNullOrEmpty(this.txtPass.Text) || String.IsNullOrEmpty(this.txtECNo.Text) )
            {
                return false;
            }
            else
                return true;
        }

        private void lblEClear_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }

        private void lblEDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvEmployee.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvEmployee.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from Table_1 where eid = '" + this.txtEID.Text + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name + " has been deleted successfully");
                else
                    MessageBox.Show("Data deletion failed");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void AutoIdGenerate()
        {

        }
        private void RefreshContent()
        {
            this.txtEID.Clear();
            this.txtEName.Clear();
            this.txtPass.Clear();
            this.txtECNo.Clear();

            this.txtSearch.Clear();
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.txtEID.Text = this.dgvEmployee.CurrentRow.Cells["eid"].Value.ToString();
            this.txtEName.Text = this.dgvEmployee.CurrentRow.Cells["ename"].Value.ToString();
            this.txtPass.Text = this.dgvEmployee.CurrentRow.Cells["epass"].Value.ToString();
            this.txtECNo.Text = this.dgvEmployee.CurrentRow.Cells["econtact"].Value.ToString();
        }

        private void lblEBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new ManagingForm();
        }
    }
}
