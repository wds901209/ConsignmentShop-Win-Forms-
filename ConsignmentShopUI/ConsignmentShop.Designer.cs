namespace ConsignmentShopUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListBoxlabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.ShoppingCartListBoxLabel = new System.Windows.Forms.Label();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.vendorlistBox = new System.Windows.Forms.ListBox();
            this.StoreProfitLabel = new System.Windows.Forms.Label();
            this.StoreProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(13, 9);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(429, 46);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            this.headerText.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 22;
            this.itemsListBox.Location = new System.Drawing.Point(20, 132);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(366, 268);
            this.itemsListBox.TabIndex = 1;
            // 
            // itemsListBoxlabel
            // 
            this.itemsListBoxlabel.AutoSize = true;
            this.itemsListBoxlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBoxlabel.Location = new System.Drawing.Point(16, 87);
            this.itemsListBoxlabel.Name = "itemsListBoxlabel";
            this.itemsListBoxlabel.Size = new System.Drawing.Size(108, 23);
            this.itemsListBoxlabel.TabIndex = 2;
            this.itemsListBoxlabel.Text = "Store Items";
            this.itemsListBoxlabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(439, 248);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(168, 47);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart   =>";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // ShoppingCartListBoxLabel
            // 
            this.ShoppingCartListBoxLabel.AutoSize = true;
            this.ShoppingCartListBoxLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartListBoxLabel.Location = new System.Drawing.Point(659, 87);
            this.ShoppingCartListBoxLabel.Name = "ShoppingCartListBoxLabel";
            this.ShoppingCartListBoxLabel.Size = new System.Drawing.Size(130, 23);
            this.ShoppingCartListBoxLabel.TabIndex = 5;
            this.ShoppingCartListBoxLabel.Text = "Shopping Cart";
            this.ShoppingCartListBoxLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 22;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(663, 132);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(366, 268);
            this.ShoppingCartListBox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(861, 416);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(168, 47);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.make_Purchase_Click);
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListboxLabel.Location = new System.Drawing.Point(17, 441);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(78, 23);
            this.vendorListboxLabel.TabIndex = 8;
            this.vendorListboxLabel.Text = "Vendors";
            // 
            // vendorlistBox
            // 
            this.vendorlistBox.FormattingEnabled = true;
            this.vendorlistBox.ItemHeight = 22;
            this.vendorlistBox.Location = new System.Drawing.Point(20, 485);
            this.vendorlistBox.Name = "vendorlistBox";
            this.vendorlistBox.Size = new System.Drawing.Size(366, 268);
            this.vendorlistBox.TabIndex = 7;
            // 
            // StoreProfitLabel
            // 
            this.StoreProfitLabel.AutoSize = true;
            this.StoreProfitLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreProfitLabel.Location = new System.Drawing.Point(659, 501);
            this.StoreProfitLabel.Name = "StoreProfitLabel";
            this.StoreProfitLabel.Size = new System.Drawing.Size(122, 23);
            this.StoreProfitLabel.TabIndex = 9;
            this.StoreProfitLabel.Text = "Store Profit :";
            // 
            // StoreProfitValue
            // 
            this.StoreProfitValue.AutoEllipsis = true;
            this.StoreProfitValue.AutoSize = true;
            this.StoreProfitValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreProfitValue.Location = new System.Drawing.Point(809, 501);
            this.StoreProfitValue.Name = "StoreProfitValue";
            this.StoreProfitValue.Size = new System.Drawing.Size(60, 23);
            this.StoreProfitValue.TabIndex = 10;
            this.StoreProfitValue.Text = "$ 0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 862);
            this.Controls.Add(this.StoreProfitValue);
            this.Controls.Add(this.StoreProfitLabel);
            this.Controls.Add(this.vendorListboxLabel);
            this.Controls.Add(this.vendorlistBox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.ShoppingCartListBoxLabel);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListBoxlabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.Load += new System.EventHandler(this.ConsignmentShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListBoxlabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label ShoppingCartListBoxLabel;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.ListBox vendorlistBox;
        private System.Windows.Forms.Label StoreProfitLabel;
        private System.Windows.Forms.Label StoreProfitValue;
    }
}

