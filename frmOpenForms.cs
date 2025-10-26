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
    public partial class frmOpenForms : Form
    {
        public frmOpenForms()
        {
            InitializeComponent();
        }

        private void frmOpenForms_Load(object sender, EventArgs e)
        {
            label1.Text = " يوجــد "+(Application.OpenForms.Count -2)+" شاشـــة مفتوحــة ";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (Form forms in Application.OpenForms)
            {
                if (forms.Name == "frmStart" || forms.Name == "frmMain") continue;
                listBox2.Items.Add(forms.Name); 
                listBox1.Items.Add(forms.Text); 
            }

        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms[listBox2.Items[listBox1.SelectedIndex].ToString()]==null)
                {
                    listBox1.Items.Remove(listBox1.SelectedIndex);
                    listBox2.Items.Remove(listBox1.SelectedIndex);

                }
                else
                {
                    Application.OpenForms[listBox2.Items[listBox1.SelectedIndex].ToString()].WindowState = FormWindowState.Maximized;
                    Application.OpenForms[listBox2.Items[listBox1.SelectedIndex].ToString()].Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
