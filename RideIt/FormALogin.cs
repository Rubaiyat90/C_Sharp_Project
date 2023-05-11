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
    public partial class FormALogin : Form
    {
        public FormALogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            
            
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-KFP9HDV;Initial Catalog=Manager;Integrated Security=True");
            string query = "select * from Table_3 where username = '" + this.txtUname.Text + "' and password = '" + this.txtPass.Text + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);   
            if(dt.Rows.Count == 1)
            {
                
                ManagingForm mf = new ManagingForm();
                this.Hide();;
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormALogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
