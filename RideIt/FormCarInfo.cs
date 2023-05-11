using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RideIt
{
    public partial class FormCarInfo : Form
    {
        private DataAccess2 Da2 { get; set; }
        public FormCarInfo()
        {
            InitializeComponent();
            this.Da2 = new DataAccess2();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from Table_2;")
        {
            var ds = this.Da2.ExecuteQuery(sql);

            this.dgvCar.AutoGenerateColumns = false;
            this.dgvCar.DataSource = ds.Tables[0];
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();

        }

        private void lblSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Table_2 where cname = '" + this.txtCName.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }



       

        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtCID.Text) || String.IsNullOrEmpty(this.txtCName.Text) ||
                String.IsNullOrEmpty(this.txtCRegiNo.Text) || String.IsNullOrEmpty(this.txtColor.Text)
                || String.IsNullOrEmpty(this.txtStatus.Text) || String.IsNullOrEmpty(this.txtPrice.Text))
            {
                return false;
            }
            else
                return true;
        }


        private void AutoIdGenerate()
        {

        }
        

        private void lblCSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                var query = "select * from Table_2 where cid = '" + this.txtCID.Text + "';";
                var ds = this.Da2.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update Table_2 set cname = '" + this.txtCName.Text + "', cregi = '" + this.txtCRegiNo.Text + "', color = '" + this.txtColor.Text + "', status = '" + this.txtStatus.Text + "', price = '" + this.txtPrice.Text + "' where cid = '" + this.txtCID + "';";
                    int count = this.Da2.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                {
                    //insert
                    var sql = @"insert into Table_2 values ( '" + this.txtCID.Text + "','" + this.txtCName.Text + "','" + this.txtCRegiNo.Text + "','" + this.txtColor.Text + "','" + this.txtStatus.Text + "','" + this.txtPrice.Text + "');";
                    int count = this.Da2.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data insertion successfull");
                    else
                        MessageBox.Show("Data insertion failed");
                }

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void lblCDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvCar.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvCar.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from Table_2 where cid = '" + this.txtCID.Text + "';";
                int count = this.Da2.ExecuteDMLQuery(sql);

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

        private void lblClr_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }

        private void RefreshContent()
        {
            this.txtCID.Clear();
            this.txtCName.Clear();
            this.txtCRegiNo.Clear();
            this.txtColor.Clear();
            this.txtStatus.Clear();
            this.txtPrice.Clear();


            
        }

        private void dgvCar_DoubleClick(object sender, EventArgs e)
        {
            this.txtCID.Text = this.dgvCar.CurrentRow.Cells["cid"].Value.ToString();
            this.txtCName.Text = this.dgvCar.CurrentRow.Cells["cname"].Value.ToString();
            this.txtCRegiNo.Text = this.dgvCar.CurrentRow.Cells["cregino"].Value.ToString();
            this.txtColor.Text = this.dgvCar.CurrentRow.Cells["color"].Value.ToString();
            this.txtStatus.Text = this.dgvCar.CurrentRow.Cells["status"].Value.ToString();
            this.txtPrice.Text = this.dgvCar.CurrentRow.Cells["price"].Value.ToString();
        }

        private void lblCb_Click(object sender, EventArgs e)
        {
            this.Close();
            new ManagingForm();
        }
    }
}
