namespace SalesManager
{
    partial class frmCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatNum = new System.Windows.Forms.TextBox();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCatDetial = new System.Windows.Forms.TextBox();
            this.lblCatDetial = new System.Windows.Forms.Label();
            this.btnNewCat = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم التصنيف ";
            // 
            // txtCatNum
            // 
            this.txtCatNum.Location = new System.Drawing.Point(157, 37);
            this.txtCatNum.Name = "txtCatNum";
            this.txtCatNum.Size = new System.Drawing.Size(444, 39);
            this.txtCatNum.TabIndex = 1;
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(157, 93);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(612, 39);
            this.txtCatName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم التصنيف ";
            // 
            // txtCatDetial
            // 
            this.txtCatDetial.Location = new System.Drawing.Point(157, 149);
            this.txtCatDetial.Multiline = true;
            this.txtCatDetial.Name = "txtCatDetial";
            this.txtCatDetial.Size = new System.Drawing.Size(612, 163);
            this.txtCatDetial.TabIndex = 5;
            // 
            // lblCatDetial
            // 
            this.lblCatDetial.AutoSize = true;
            this.lblCatDetial.Location = new System.Drawing.Point(16, 157);
            this.lblCatDetial.Name = "lblCatDetial";
            this.lblCatDetial.Size = new System.Drawing.Size(135, 32);
            this.lblCatDetial.TabIndex = 4;
            this.lblCatDetial.Text = "تفاصيل التصنيف ";
            // 
            // btnNewCat
            // 
            this.btnNewCat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNewCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnNewCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCat.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCat.ForeColor = System.Drawing.Color.White;
            this.btnNewCat.Location = new System.Drawing.Point(157, 327);
            this.btnNewCat.Name = "btnNewCat";
            this.btnNewCat.Size = new System.Drawing.Size(126, 40);
            this.btnNewCat.TabIndex = 6;
            this.btnNewCat.Text = "تصنيف  جديد";
            this.btnNewCat.UseVisualStyleBackColor = false;
            this.btnNewCat.Click += new System.EventHandler(this.btnNewCat_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAddCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCat.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.ForeColor = System.Drawing.Color.White;
            this.btnAddCat.Location = new System.Drawing.Point(289, 327);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(126, 40);
            this.btnAddCat.TabIndex = 7;
            this.btnAddCat.Text = "اضافة ";
            this.btnAddCat.UseVisualStyleBackColor = false;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(421, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "اغلاق";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.btnNewCat);
            this.Controls.Add(this.txtCatDetial);
            this.Controls.Add(this.lblCatDetial);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCatNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعريف التصنيفات";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatNum;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatDetial;
        private System.Windows.Forms.Label lblCatDetial;
        private System.Windows.Forms.Button btnNewCat;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button button1;
    }
}