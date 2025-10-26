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
    public partial class Phones : UserControl
    {
        public Phones()
        {
            InitializeComponent();
        }
        private DataTable tblphones = new DataTable();

        private string FilterPhone(string phone)
        {
            string phoneAfter = "";
            foreach(char c in phone)
            {
                if(char.IsDigit(c))
                    phoneAfter += c;
            }
            return phoneAfter;
        }
        
        private void AddPhones(string phone)
        {
            if (tblphones.Columns.Count < 1) tblphones.Columns.Add("phone");
            tblphones.Rows.Add(FilterPhone(phone));
            dataGridView1.DataSource = tblphones;

        }
        private void cleareTxt()
        {
            txtPhone.Text = "";
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            txtPhone.Select();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cleareTxt(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtPhone.Text.Trim() != "")
            {
                AddPhones(txtPhone.Text);
                cleareTxt();

            }

        }

        private void Phones_Load(object sender, EventArgs e)
        {
            cleareTxt();
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && button2.Enabled)
            {

                button2.PerformClick();
            }
        }
    }
}
