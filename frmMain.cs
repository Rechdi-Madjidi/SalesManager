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
    public partial class frmMain : Form
    {
        private object frm;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void OpenForm(Form frm)
        {
            if (Application.OpenForms[frm.Name] == null)
            {
                frm.BackColor = Color.FromArgb(variables.r, variables.g, variables.b);
                frm.Icon = this.Icon;
                frm.MdiParent = this;
                frm.WindowState = variables.curentFormState;
                frm.Show();
            }
            else
            {
                Application.OpenForms[frm.Name].WindowState = variables.curentFormState;
                Application.OpenForms[frm.Name].Activate();
            }
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Top = 0;
           
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.DarkCyan;
            Color c = Color.FromArgb(variables.r, variables.g, variables.b);
            foreach (TabPage tp in tabControl.TabPages)
            {
                foreach (Control ctrl in tp.Controls)
                    ctrl.BackColor = c;
                tp.BackColor = c;
            }
            this.BackColor = c;

        }

        private void toolStripButton44_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton47_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton45_Click(object sender, EventArgs e)
        {
            OpenForm(new ChangeColor());
        }

        private void tsBtnCatigory_Click(object sender, EventArgs e)
        {
            OpenForm(new frmCategory());
        }

        private void toolStripButton49_Click(object sender, EventArgs e)
        {
            //OpenForm(new frmOpenForms());
            if (Application.OpenForms["frmOpenForms"] != null)
            {
                Application.OpenForms["frmOpenForms"].Close();
                frmOpenForms frmof = new frmOpenForms();
                frmof.BackColor = Color.FromArgb(variables.r, variables.g, variables.b);
                frmof.Icon = this.Icon;
                frmof.MdiParent = this;
                frmof.WindowState = FormWindowState.Maximized;
                frmof.Show();
            }
            else {
                frmOpenForms frmof = new frmOpenForms();
                frmof.BackColor = Color.FromArgb(variables.r, variables.g, variables.b);
                frmof.Icon = this.Icon;
                frmof.MdiParent = this;
                frmof.WindowState = FormWindowState.Maximized;
                frmof.Show();
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            variables.curentFormState= FormWindowState.Maximized;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            variables.curentFormState = FormWindowState.Normal;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            variables.curentFormState = FormWindowState.Minimized;
        }

        private void tsBtnEmployee_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }
}
