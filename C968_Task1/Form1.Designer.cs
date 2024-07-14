namespace C968_Task1
{
    partial class Form1
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
            this.partIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partsListView = new System.Windows.Forms.ListView();
            this.inventoryCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // mainHeader
            // 
            this.mainHeader.AutoSize = true;
            this.mainHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeader.Location = new System.Drawing.Point(24, 17);
            this.mainHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(772, 63);
            this.mainHeader.TabIndex = 0;
            this.mainHeader.Text = "Inventory Management System";
            // 
            // headerParts
            // 
            this.headerParts.AutoSize = true;
            this.headerParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerParts.Location = new System.Drawing.Point(26, 131);
            this.headerParts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerParts.Name = "headerParts";
            this.headerParts.Size = new System.Drawing.Size(118, 48);
            this.headerParts.TabIndex = 2;
            this.headerParts.Text = "Parts";
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(690, 138);
            this.partsSearchButton.Margin = new System.Windows.Forms.Padding(6);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(150, 44);
            this.partsSearchButton.TabIndex = 4;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(852, 138);
            this.partsTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(282, 31);
            this.partsTextBox.TabIndex = 5;
            // 
            // partsAddButton
            // 
            this.partsAddButton.Location = new System.Drawing.Point(616, 663);
            this.partsAddButton.Margin = new System.Windows.Forms.Padding(6);
            this.partsAddButton.Name = "partsAddButton";
            this.partsAddButton.Size = new System.Drawing.Size(150, 44);
            this.partsAddButton.TabIndex = 6;
            this.partsAddButton.Text = "Add";
            this.partsAddButton.UseVisualStyleBackColor = true;
            // 
            // partsModifyButton
            // 
            this.partsModifyButton.Location = new System.Drawing.Point(798, 663);
            this.partsModifyButton.Margin = new System.Windows.Forms.Padding(6);
            this.partsModifyButton.Name = "partsModifyButton";
            this.partsModifyButton.Size = new System.Drawing.Size(150, 44);
            this.partsModifyButton.TabIndex = 7;
            this.partsModifyButton.Text = "Modify";
            this.partsModifyButton.UseVisualStyleBackColor = true;
            // 
            // partsDeleteButton
            // 
            this.partsDeleteButton.Location = new System.Drawing.Point(988, 663);
            this.partsDeleteButton.Margin = new System.Windows.Forms.Padding(6);
            this.partsDeleteButton.Name = "partsDeleteButton";
            this.partsDeleteButton.Size = new System.Drawing.Size(150, 44);
            this.partsDeleteButton.TabIndex = 8;
            this.partsDeleteButton.Text = "Delete";
            this.partsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // productsDeleteButton
            // 
            this.productsDeleteButton.Location = new System.Drawing.Point(2206, 663);
            this.productsDeleteButton.Margin = new System.Windows.Forms.Padding(6);
            this.productsDeleteButton.Name = "productsDeleteButton";
            this.productsDeleteButton.Size = new System.Drawing.Size(150, 44);
            this.productsDeleteButton.TabIndex = 15;
            this.productsDeleteButton.Text = "Delete";
            this.productsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // productsModifyButton
            // 
            this.productsModifyButton.Location = new System.Drawing.Point(2016, 663);
            this.productsModifyButton.Margin = new System.Windows.Forms.Padding(6);
            this.productsModifyButton.Name = "productsModifyButton";
            this.productsModifyButton.Size = new System.Drawing.Size(150, 44);
            this.productsModifyButton.TabIndex = 14;
            this.productsModifyButton.Text = "Modify";
            this.productsModifyButton.UseVisualStyleBackColor = true;
            // 
            // productsAddButton
            // 
            this.productsAddButton.Location = new System.Drawing.Point(1834, 663);
            this.productsAddButton.Margin = new System.Windows.Forms.Padding(6);
            this.productsAddButton.Name = "productsAddButton";
            this.productsAddButton.Size = new System.Drawing.Size(150, 44);
            this.productsAddButton.TabIndex = 13;
            this.productsAddButton.Text = "Add";
            this.productsAddButton.UseVisualStyleBackColor = true;
            // 
            // productsTextBox
            // 
            this.productsTextBox.Location = new System.Drawing.Point(2070, 138);
            this.productsTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.productsTextBox.Name = "productsTextBox";
            this.productsTextBox.Size = new System.Drawing.Size(282, 31);
            this.productsTextBox.TabIndex = 12;
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(1908, 138);
            this.productsSearchButton.Margin = new System.Windows.Forms.Padding(6);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(150, 44);
            this.productsSearchButton.TabIndex = 11;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            // 
            // headerProducts
            // 
            this.headerProducts.AutoSize = true;
            this.headerProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerProducts.Location = new System.Drawing.Point(1244, 131);
            this.headerProducts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerProducts.Name = "headerProducts";
            this.headerProducts.Size = new System.Drawing.Size(185, 48);
            this.headerProducts.TabIndex = 9;
            this.headerProducts.Text = "Products";
            // 
            // partIDCol
            // 
            this.partIDCol.Text = "Part ID";
            this.partIDCol.Width = 100;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Name";
            this.nameCol.Width = 100;
            // 
            // partsListView
            // 
            this.partsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.partIDCol,
            this.nameCol,
            this.inventoryCol,
            this.priceCol,
            this.minCol,
            this.maxCol});
            this.partsListView.HideSelection = false;
            this.partsListView.Location = new System.Drawing.Point(36, 210);
            this.partsListView.Name = "partsListView";
            this.partsListView.Size = new System.Drawing.Size(1102, 444);
            this.partsListView.TabIndex = 16;
            this.partsListView.UseCompatibleStateImageBehavior = false;
            this.partsListView.View = System.Windows.Forms.View.Details;
            // 
            // inventoryCol
            // 
            this.inventoryCol.Text = "Inventory";
            this.inventoryCol.Width = 100;
            // 
            // priceCol
            // 
            this.priceCol.Text = "Price";
            this.priceCol.Width = 100;
            // 
            // minCol
            // 
            this.minCol.Text = "Min.";
            this.minCol.Width = 50;
            // 
            // maxCol
            // 
            this.maxCol.Text = "Max.";
            this.maxCol.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2450, 804);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ColumnHeader partIDCol;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ListView partsListView;
        private System.Windows.Forms.ColumnHeader inventoryCol;
        private System.Windows.Forms.ColumnHeader priceCol;
        private System.Windows.Forms.ColumnHeader minCol;
        private System.Windows.Forms.ColumnHeader maxCol;
    }

    
}

