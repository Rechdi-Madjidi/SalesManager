using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManager
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            try {
                DB.Open();
                DB.setColorandFont();
                this.Icon = Icon.ExtractAssociatedIcon("SalesManager.exe");
                frmLogin frmlogin = new frmLogin();
                frmlogin.Icon = this.Icon;
                this.Hide();
                frmlogin.Show();
                //frmMain frm = new frmMain();
                //frm.Icon = this.Icon;
                //frm.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
