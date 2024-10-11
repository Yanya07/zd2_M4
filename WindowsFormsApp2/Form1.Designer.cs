namespace WindowsFormsApp2
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonSellProduct;

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonSellProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSellQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(175, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(175, 59);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 22);
            this.textBoxPrice.TabIndex = 1;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(175, 89);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(200, 22);
            this.textBoxStock.TabIndex = 2;
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductType.Items.AddRange(new object[] {
            "Штучный товар",
            "Весовой товар"});
            this.comboBoxProductType.Location = new System.Drawing.Point(175, 149);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(200, 24);
            this.comboBoxProductType.TabIndex = 4;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(409, 30);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(250, 244);
            this.listBoxProducts.TabIndex = 5;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(175, 199);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(200, 30);
            this.buttonAddProduct.TabIndex = 6;
            this.buttonAddProduct.Text = "Добавить товар";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonSellProduct
            // 
            this.buttonSellProduct.Location = new System.Drawing.Point(175, 239);
            this.buttonSellProduct.Name = "buttonSellProduct";
            this.buttonSellProduct.Size = new System.Drawing.Size(200, 30);
            this.buttonSellProduct.TabIndex = 7;
            this.buttonSellProduct.Text = "Продать товар";
            this.buttonSellProduct.UseVisualStyleBackColor = true;
            this.buttonSellProduct.Click += new System.EventHandler(this.buttonSellProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Количество на складе";
            // 
            // textBoxSellQuantity
            // 
            this.textBoxSellQuantity.Location = new System.Drawing.Point(175, 119);
            this.textBoxSellQuantity.Name = "textBoxSellQuantity";
            this.textBoxSellQuantity.Size = new System.Drawing.Size(200, 22);
            this.textBoxSellQuantity.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Вес партии";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(698, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxSellQuantity);
            this.Controls.Add(this.comboBoxProductType);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.buttonSellProduct);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSellQuantity;
        private System.Windows.Forms.Label label4;
    }
}

