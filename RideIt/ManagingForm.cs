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
    public partial class ManagingForm : Form
    {
        public ManagingForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormEmInfo().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormCarInfo().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
