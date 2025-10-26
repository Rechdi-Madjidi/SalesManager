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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool PreventClose  = true;
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = PreventClose;    
           // Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            PreventClose = false;
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = DB.GetData("select * from login_program where is_active='True' and username = '" + txtUser.Text.Replace("'", "") + "' and password = '" + txtPass.Text.Replace("'", "") + "'");
            if (dt.Rows.Count > 0)
            {
                frmMain frm = new frmMain();
                frm.Icon = this.Icon;

                PreventClose = false;
                frm.Show();
                this.Close();
            }
            else
            {
                txtPass.Clear(); txtUser.Clear(); txtUser.Select();
                MessageBox.Show("خطأ في اسم  المستخدم  أو كلمة المرور");
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
