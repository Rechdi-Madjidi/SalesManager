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
    public partial class ChangeColor : Form
    {
        public ChangeColor()
        {
            InitializeComponent();
        }

        private void ChangeColor_Load(object sender, EventArgs e)
        {

        }
        private void button1_DoubleClick(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                this.BackColor = color;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
             DB.Run("update bg_font_Setting set r ="+ this.BackColor.R + ",g="+ this.BackColor.G + ",b="+ this.BackColor.B);
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
