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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }
        public void clearAndAuto()
        {
            txtCatNum.Text = "";
            try {  
                txtCatNum.Text = DB.GetData("select max(category_num)+1 from category ").Rows[0][0].ToString();
            if (txtCatNum.Text.Trim() == "") txtCatNum.Text = "1";
            }
            catch(Exception e) { MessageBox.Show(e.Message); }

            txtCatName.Text = "";
            txtCatName.Select();
            txtCatDetial.Text = "";
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            clearAndAuto();
        }

        private void btnNewCat_Click(object sender, EventArgs e)
        {
            clearAndAuto();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            if (txtCatNum.Text.Trim() == "") { MessageBox.Show(" رقم التصنيف فارغ "); }
            else if (txtCatName.Text.Trim() == "") { MessageBox.Show(" اسم التصنيف فارغ ");txtCatName.Select(); }
            else if (txtCatDetial.Text.Trim() == "") { MessageBox.Show(" تفاصيل التصنيف فارغ ");txtCatDetial.Select(); }
            else
            {
                try
                {
                    DB.Run("insert into category values("+txtCatNum.Text.Replace("'","")+",'"+ 
                        txtCatName.Text.Replace("'", "") + "','"+ txtCatDetial.Text.Replace("'", "") + "')");
                    MessageBox.Show(" تم اضافة التصنيف بنجاح ");
                    clearAndAuto();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }



        }
    }
}
