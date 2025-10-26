namespace ResizeImgs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelct = new Button();
            numericUpW = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            numericUpDownH = new NumericUpDown();
            btnConvert = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownH).BeginInit();
            SuspendLayout();
            // 
            // btnSelct
            // 
            btnSelct.Location = new Point(12, 13);
            btnSelct.Name = "btnSelct";
            btnSelct.Size = new Size(117, 29);
            btnSelct.TabIndex = 0;
            btnSelct.Text = "Select Image";
            btnSelct.UseVisualStyleBackColor = true;
            btnSelct.Click += btnSelct_Click;
            // 
            // numericUpW
            // 
            numericUpW.Location = new Point(211, 15);
            numericUpW.Name = "numericUpW";
            numericUpW.Size = new Size(78, 27);
            numericUpW.TabIndex = 1;
            numericUpW.Value = new decimal(new int[] { 75, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 17);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 2;
            label1.Text = "W :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 17);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 4;
            label2.Text = "H :";
            // 
            // numericUpDownH
            // 
            numericUpDownH.Location = new Point(361, 15);
            numericUpDownH.Name = "numericUpDownH";
            numericUpDownH.Size = new Size(78, 27);
            numericUpDownH.TabIndex = 3;
            numericUpDownH.Value = new decimal(new int[] { 75, 0, 0, 0 });
            // 
            // btnConvert
            // 
            btnConvert.Enabled = false;
            btnConvert.Location = new Point(480, 13);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(122, 29);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Convert Image";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(598, 384);
            listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(listBox1);
            Controls.Add(btnConvert);
            Controls.Add(label2);
            Controls.Add(numericUpDownH);
            Controls.Add(label1);
            Controls.Add(numericUpW);
            Controls.Add(btnSelct);
            Name = "Form1";
            Text = "Image Resize";
            ((System.ComponentModel.ISupportInitialize)numericUpW).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelct;
        private NumericUpDown numericUpW;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownH;
        private Button btnConvert;
        private ListBox listBox1;
    }
}