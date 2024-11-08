namespace WinFormsClient
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
            components = new System.ComponentModel.Container();
            txtPrice = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtBrand = new TextBox();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            btnAddProduct = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnGetProduct = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(152, 53);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(445, 53);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(100, 23);
            txtBrand.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(303, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddProduct);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtBrand);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 111);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(12, 52);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(134, 23);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Text = "افزودن کالا";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 26);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 6;
            label3.Text = "برند";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 26);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 5;
            label2.Text = "نام";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 26);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "قیمت";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(12, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(542, 150);
            dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // btnGetProduct
            // 
            btnGetProduct.Location = new Point(167, 273);
            btnGetProduct.Name = "btnGetProduct";
            btnGetProduct.Size = new Size(270, 33);
            btnGetProduct.TabIndex = 6;
            btnGetProduct.Text = "دریافت محصولات";
            btnGetProduct.UseVisualStyleBackColor = true;
            btnGetProduct.Click += btnGetProduct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 336);
            Controls.Add(btnGetProduct);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPrice;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtBrand;
        private TextBox txtName;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btnAddProduct;
        private DataGridView dataGridView1;
        private Button btnGetProduct;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
