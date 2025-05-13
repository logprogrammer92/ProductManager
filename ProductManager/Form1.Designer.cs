namespace ProductManager
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
            lbl_productName = new Label();
            textBox1 = new TextBox();
            btn_addProduct = new Button();
            SuspendLayout();
            // 
            // lbl_productName
            // 
            lbl_productName.AutoSize = true;
            lbl_productName.Location = new Point(38, 103);
            lbl_productName.Name = "lbl_productName";
            lbl_productName.Size = new Size(84, 15);
            lbl_productName.TabIndex = 0;
            lbl_productName.Text = "Product Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(86, 23);
            textBox1.TabIndex = 1;
            // 
            // btn_addProduct
            // 
            btn_addProduct.Location = new Point(87, 184);
            btn_addProduct.Name = "btn_addProduct";
            btn_addProduct.Size = new Size(139, 83);
            btn_addProduct.TabIndex = 2;
            btn_addProduct.Text = "Add Product";
            btn_addProduct.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 372);
            Controls.Add(btn_addProduct);
            Controls.Add(textBox1);
            Controls.Add(lbl_productName);
            Name = "Form1";
            Text = "Product Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_productName;
        private TextBox textBox1;
        private Button btn_addProduct;
    }
}
