using System.Windows.Forms;

namespace ResizeImgs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelct_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                // openFileDialog.Filter = "Image Files|*.png ;*.jpg";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var file in openFileDialog.FileNames)
                    {
                        listBox1.Items.Add(file);
                    }
                    if (listBox1.Items.Count > 0) btnConvert.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("NewImages")) Directory.CreateDirectory("NewImages");
            foreach (var item in listBox1.Items)
            {
                Bitmap pmb = new Bitmap(Image.FromFile("" + item),
                new Size(Convert.ToInt32(numericUpW.Value),
                Convert.ToInt32(numericUpDownH.Value)));
                pmb.Save("NewImages\\" + Path.GetFileName(item + ""));

            }

        }
    }
}