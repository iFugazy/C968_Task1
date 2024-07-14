namespace C968_Task1
{
    partial class mainForm
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
            this.mainHeader = new System.Windows.Forms.Label();
            this.headerParts = new System.Windows.Forms.Label();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.partsAddButton = new System.Windows.Forms.Button();
            this.partsModifyButton = new System.Windows.Forms.Button();
            this.partsDeleteButton = new System.Windows.Forms.Button();
            this.productsDeleteButton = new System.Windows.Forms.Button();
            this.productsModifyButton = new System.Windows.Forms.Button();
            this.productsAddButton = new System.Windows.Forms.Button();
            this.productsTextBox = new System.Windows.Forms.TextBox();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.headerProducts = new System.Windows.Forms.Label();
            this.partIdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partsListView = new System.Windows.Forms.ListView();
            this.partInventoryCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partPriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partMinCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partMaxCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productsListView = new System.Windows.Forms.ListView();
            this.productIdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productInvCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productPriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productMinCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productMaxCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainHeader
            // 
            this.mainHeader.AutoSize = true;
            this.mainHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeader.Location = new System.Drawing.Point(12, 9);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(389, 31);
            this.mainHeader.TabIndex = 0;
            this.mainHeader.Text = "Inventory Management System";
            // 
            // headerParts
            // 
            this.headerParts.AutoSize = true;
            this.headerParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerParts.Location = new System.Drawing.Point(13, 68);
            this.headerParts.Name = "headerParts";
            this.headerParts.Size = new System.Drawing.Size(62, 25);
            this.headerParts.TabIndex = 2;
            this.headerParts.Text = "Parts";
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(345, 72);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.partsSearchButton.TabIndex = 4;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(426, 72);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(143, 20);
            this.partsTextBox.TabIndex = 5;
            // 
            // partsAddButton
            // 
            this.partsAddButton.Location = new System.Drawing.Point(308, 345);
            this.partsAddButton.Name = "partsAddButton";
            this.partsAddButton.Size = new System.Drawing.Size(75, 23);
            this.partsAddButton.TabIndex = 6;
            this.partsAddButton.Text = "Add";
            this.partsAddButton.UseVisualStyleBackColor = true;
            this.partsAddButton.Click += new System.EventHandler(this.partsAddButton_Click);
            // 
            // partsModifyButton
            // 
            this.partsModifyButton.Location = new System.Drawing.Point(399, 345);
            this.partsModifyButton.Name = "partsModifyButton";
            this.partsModifyButton.Size = new System.Drawing.Size(75, 23);
            this.partsModifyButton.TabIndex = 7;
            this.partsModifyButton.Text = "Modify";
            this.partsModifyButton.UseVisualStyleBackColor = true;
            // 
            // partsDeleteButton
            // 
            this.partsDeleteButton.Location = new System.Drawing.Point(494, 345);
            this.partsDeleteButton.Name = "partsDeleteButton";
            this.partsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.partsDeleteButton.TabIndex = 8;
            this.partsDeleteButton.Text = "Delete";
            this.partsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // productsDeleteButton
            // 
            this.productsDeleteButton.Location = new System.Drawing.Point(1103, 345);
            this.productsDeleteButton.Name = "productsDeleteButton";
            this.productsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.productsDeleteButton.TabIndex = 15;
            this.productsDeleteButton.Text = "Delete";
            this.productsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // productsModifyButton
            // 
            this.productsModifyButton.Location = new System.Drawing.Point(1008, 345);
            this.productsModifyButton.Name = "productsModifyButton";
            this.productsModifyButton.Size = new System.Drawing.Size(75, 23);
            this.productsModifyButton.TabIndex = 14;
            this.productsModifyButton.Text = "Modify";
            this.productsModifyButton.UseVisualStyleBackColor = true;
            // 
            // productsAddButton
            // 
            this.productsAddButton.Location = new System.Drawing.Point(917, 345);
            this.productsAddButton.Name = "productsAddButton";
            this.productsAddButton.Size = new System.Drawing.Size(75, 23);
            this.productsAddButton.TabIndex = 13;
            this.productsAddButton.Text = "Add";
            this.productsAddButton.UseVisualStyleBackColor = true;
            // 
            // productsTextBox
            // 
            this.productsTextBox.Location = new System.Drawing.Point(1035, 72);
            this.productsTextBox.Name = "productsTextBox";
            this.productsTextBox.Size = new System.Drawing.Size(143, 20);
            this.productsTextBox.TabIndex = 12;
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(954, 72);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.productsSearchButton.TabIndex = 11;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            // 
            // headerProducts
            // 
            this.headerProducts.AutoSize = true;
            this.headerProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerProducts.Location = new System.Drawing.Point(622, 68);
            this.headerProducts.Name = "headerProducts";
            this.headerProducts.Size = new System.Drawing.Size(97, 25);
            this.headerProducts.TabIndex = 9;
            this.headerProducts.Text = "Products";
            // 
            // partIdCol
            // 
            this.partIdCol.DisplayIndex = 1;
            this.partIdCol.Text = "Part ID";
            this.partIdCol.Width = 100;
            // 
            // partNameCol
            // 
            this.partNameCol.Text = "Name";
            this.partNameCol.Width = 100;
            // 
            // partsListView
            // 
            this.partsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.partIdCol,
            this.partNameCol,
            this.partInventoryCol,
            this.partPriceCol,
            this.partMinCol,
            this.partMaxCol});
            this.partsListView.HideSelection = false;
            this.partsListView.Location = new System.Drawing.Point(18, 104);
            this.partsListView.Margin = new System.Windows.Forms.Padding(2);
            this.partsListView.Name = "partsListView";
            this.partsListView.Size = new System.Drawing.Size(551, 233);
            this.partsListView.TabIndex = 16;
            this.partsListView.UseCompatibleStateImageBehavior = false;
            this.partsListView.View = System.Windows.Forms.View.Details;
            // 
            // partInventoryCol
            // 
            this.partInventoryCol.Text = "Inventory";
            this.partInventoryCol.Width = 100;
            // 
            // partPriceCol
            // 
            this.partPriceCol.Text = "Price";
            this.partPriceCol.Width = 100;
            // 
            // partMinCol
            // 
            this.partMinCol.Text = "Min.";
            this.partMinCol.Width = 75;
            // 
            // partMaxCol
            // 
            this.partMaxCol.Text = "Max.";
            this.partMaxCol.Width = 75;
            // 
            // productsListView
            // 
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productIdCol,
            this.productNameCol,
            this.productInvCol,
            this.productPriceCol,
            this.productMinCol,
            this.productMaxCol});
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(627, 104);
            this.productsListView.Margin = new System.Windows.Forms.Padding(2);
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(551, 233);
            this.productsListView.TabIndex = 17;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.View = System.Windows.Forms.View.Details;
            // 
            // productIdCol
            // 
            this.productIdCol.Text = "Product ID";
            this.productIdCol.Width = 100;
            // 
            // productNameCol
            // 
            this.productNameCol.Text = "Name";
            this.productNameCol.Width = 100;
            // 
            // productInvCol
            // 
            this.productInvCol.Text = "Inventory";
            this.productInvCol.Width = 100;
            // 
            // productPriceCol
            // 
            this.productPriceCol.Text = "Price";
            this.productPriceCol.Width = 100;
            // 
            // productMinCol
            // 
            this.productMinCol.Text = "Min.";
            this.productMinCol.Width = 75;
            // 
            // productMaxCol
            // 
            this.productMaxCol.Text = "Max.";
            this.productMaxCol.Width = 75;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1103, 383);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1225, 418);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.productsListView);
            this.Controls.Add(this.partsListView);
            this.Controls.Add(this.productsDeleteButton);
            this.Controls.Add(this.productsModifyButton);
            this.Controls.Add(this.productsAddButton);
            this.Controls.Add(this.productsTextBox);
            this.Controls.Add(this.productsSearchButton);
            this.Controls.Add(this.headerProducts);
            this.Controls.Add(this.partsDeleteButton);
            this.Controls.Add(this.partsModifyButton);
            this.Controls.Add(this.partsAddButton);
            this.Controls.Add(this.partsTextBox);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.headerParts);
            this.Controls.Add(this.mainHeader);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "mainForm";
            this.Text = "Inventory Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainHeader;
        private System.Windows.Forms.Label headerParts;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Button partsAddButton;
        private System.Windows.Forms.Button partsModifyButton;
        private System.Windows.Forms.Button partsDeleteButton;
        private System.Windows.Forms.Button productsDeleteButton;
        private System.Windows.Forms.Button productsModifyButton;
        private System.Windows.Forms.Button productsAddButton;
        private System.Windows.Forms.TextBox productsTextBox;
        private System.Windows.Forms.Button productsSearchButton;
        private System.Windows.Forms.Label headerProducts;
        private System.Windows.Forms.ColumnHeader partIdCol;
        private System.Windows.Forms.ColumnHeader partNameCol;
        private System.Windows.Forms.ListView partsListView;
        private System.Windows.Forms.ColumnHeader partInventoryCol;
        private System.Windows.Forms.ColumnHeader partPriceCol;
        private System.Windows.Forms.ColumnHeader partMinCol;
        private System.Windows.Forms.ColumnHeader partMaxCol;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ColumnHeader productIdCol;
        private System.Windows.Forms.ColumnHeader productNameCol;
        private System.Windows.Forms.ColumnHeader productInvCol;
        private System.Windows.Forms.ColumnHeader productPriceCol;
        private System.Windows.Forms.ColumnHeader productMinCol;
        private System.Windows.Forms.ColumnHeader productMaxCol;
        private System.Windows.Forms.Button exitButton;
    }

    
}

