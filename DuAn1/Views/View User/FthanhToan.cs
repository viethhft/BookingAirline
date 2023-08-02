using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.View_User
{
    public partial class FthanhToan : Form
    {
        public string status = "";
        public FthanhToan()
        {
            InitializeComponent();
        }

        private void btn_acp_Click(object sender, EventArgs e)
        {
            status = "Thanh toán";
            MessageBox.Show("Thanh toán thành công");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
