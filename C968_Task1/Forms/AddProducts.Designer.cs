﻿namespace C968_Task1.Forms
{
    partial class addProductsForm
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
            this.prodCancelBTN = new System.Windows.Forms.Button();
            this.prodSaveBTN = new System.Windows.Forms.Button();
            this.headerProd = new System.Windows.Forms.Label();
            this.addProdTB = new System.Windows.Forms.TextBox();
            this.prodSearchBTN = new System.Windows.Forms.Button();
            this.topDataGridView = new System.Windows.Forms.DataGridView();
            this.prodTopLabel = new System.Windows.Forms.Label();
            this.prodAddBTN = new System.Windows.Forms.Button();
            this.prodDeleteBTN = new System.Windows.Forms.Button();
            this.prodBottomLabel = new System.Windows.Forms.Label();
            this.bottomDataGridView = new System.Windows.Forms.DataGridView();
            this.prodIDLabel = new System.Windows.Forms.Label();
            this.prodNameLabel = new System.Windows.Forms.Label();
            this.prodInvLabel = new System.Windows.Forms.Label();
            this.prodPriceLabel = new System.Windows.Forms.Label();
            this.prodMaxLabel = new System.Windows.Forms.Label();
            this.prodMinLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.topDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prodCancelBTN
            // 
            this.prodCancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.prodCancelBTN.Location = new System.Drawing.Point(805, 603);
            this.prodCancelBTN.Name = "prodCancelBTN";
            this.prodCancelBTN.Size = new System.Drawing.Size(75, 23);
            this.prodCancelBTN.TabIndex = 40;
            this.prodCancelBTN.Text = "Cancel";
            this.prodCancelBTN.UseVisualStyleBackColor = true;
            // 
            // prodSaveBTN
            // 
            this.prodSaveBTN.Location = new System.Drawing.Point(715, 603);
            this.prodSaveBTN.Name = "prodSaveBTN";
            this.prodSaveBTN.Size = new System.Drawing.Size(75, 23);
            this.prodSaveBTN.TabIndex = 39;
            this.prodSaveBTN.Text = "Save";
            this.prodSaveBTN.UseVisualStyleBackColor = true;
            // 
            // headerProd
            // 
            this.headerProd.AutoSize = true;
            this.headerProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerProd.Location = new System.Drawing.Point(12, 9);
            this.headerProd.Name = "headerProd";
            this.headerProd.Size = new System.Drawing.Size(141, 25);
            this.headerProd.TabIndex = 22;
            this.headerProd.Text = "Add Products";
            // 
            // addProdTB
            // 
            this.addProdTB.Location = new System.Drawing.Point(709, 34);
            this.addProdTB.Name = "addProdTB";
            this.addProdTB.Size = new System.Drawing.Size(171, 20);
            this.addProdTB.TabIndex = 41;
            // 
            // prodSearchBTN
            // 
            this.prodSearchBTN.Location = new System.Drawing.Point(614, 34);
            this.prodSearchBTN.Name = "prodSearchBTN";
            this.prodSearchBTN.Size = new System.Drawing.Size(75, 23);
            this.prodSearchBTN.TabIndex = 42;
            this.prodSearchBTN.Text = "Search";
            this.prodSearchBTN.UseVisualStyleBackColor = true;
            // 
            // topDataGridView
            // 
            this.topDataGridView.AllowUserToAddRows = false;
            this.topDataGridView.AllowUserToDeleteRows = false;
            this.topDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topDataGridView.Location = new System.Drawing.Point(447, 86);
            this.topDataGridView.Name = "topDataGridView";
            this.topDataGridView.ReadOnly = true;
            this.topDataGridView.RowHeadersVisible = false;
            this.topDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.topDataGridView.Size = new System.Drawing.Size(433, 194);
            this.topDataGridView.TabIndex = 43;
            // 
            // prodTopLabel
            // 
            this.prodTopLabel.AutoSize = true;
            this.prodTopLabel.Location = new System.Drawing.Point(444, 61);
            this.prodTopLabel.Name = "prodTopLabel";
            this.prodTopLabel.Size = new System.Drawing.Size(96, 13);
            this.prodTopLabel.TabIndex = 44;
            this.prodTopLabel.Text = "All Candidate Parts";
            // 
            // prodAddBTN
            // 
            this.prodAddBTN.Location = new System.Drawing.Point(805, 296);
            this.prodAddBTN.Name = "prodAddBTN";
            this.prodAddBTN.Size = new System.Drawing.Size(75, 23);
            this.prodAddBTN.TabIndex = 45;
            this.prodAddBTN.Text = "Add";
            this.prodAddBTN.UseVisualStyleBackColor = true;
            this.prodAddBTN.Click += new System.EventHandler(this.prodAddBTN_Click);
            // 
            // prodDeleteBTN
            // 
            this.prodDeleteBTN.Location = new System.Drawing.Point(805, 558);
            this.prodDeleteBTN.Name = "prodDeleteBTN";
            this.prodDeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.prodDeleteBTN.TabIndex = 48;
            this.prodDeleteBTN.Text = "Delete";
            this.prodDeleteBTN.UseVisualStyleBackColor = true;
            // 
            // prodBottomLabel
            // 
            this.prodBottomLabel.AutoSize = true;
            this.prodBottomLabel.Location = new System.Drawing.Point(444, 324);
            this.prodBottomLabel.Name = "prodBottomLabel";
            this.prodBottomLabel.Size = new System.Drawing.Size(167, 13);
            this.prodBottomLabel.TabIndex = 47;
            this.prodBottomLabel.Text = "Parts Associated with this Product";
            // 
            // bottomDataGridView
            // 
            this.bottomDataGridView.AllowUserToAddRows = false;
            this.bottomDataGridView.AllowUserToDeleteRows = false;
            this.bottomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bottomDataGridView.Location = new System.Drawing.Point(447, 349);
            this.bottomDataGridView.Name = "bottomDataGridView";
            this.bottomDataGridView.ReadOnly = true;
            this.bottomDataGridView.RowHeadersVisible = false;
            this.bottomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bottomDataGridView.Size = new System.Drawing.Size(433, 194);
            this.bottomDataGridView.TabIndex = 46;
            // 
            // prodIDLabel
            // 
            this.prodIDLabel.AutoSize = true;
            this.prodIDLabel.Location = new System.Drawing.Point(95, 89);
            this.prodIDLabel.Name = "prodIDLabel";
            this.prodIDLabel.Size = new System.Drawing.Size(18, 13);
            this.prodIDLabel.TabIndex = 49;
            this.prodIDLabel.Text = "ID";
            // 
            // prodNameLabel
            // 
            this.prodNameLabel.AutoSize = true;
            this.prodNameLabel.Location = new System.Drawing.Point(78, 133);
            this.prodNameLabel.Name = "prodNameLabel";
            this.prodNameLabel.Size = new System.Drawing.Size(35, 13);
            this.prodNameLabel.TabIndex = 50;
            this.prodNameLabel.Text = "Name";
            // 
            // prodInvLabel
            // 
            this.prodInvLabel.AutoSize = true;
            this.prodInvLabel.Location = new System.Drawing.Point(65, 177);
            this.prodInvLabel.Name = "prodInvLabel";
            this.prodInvLabel.Size = new System.Drawing.Size(51, 13);
            this.prodInvLabel.TabIndex = 51;
            this.prodInvLabel.Text = "Inventory";
            // 
            // prodPriceLabel
            // 
            this.prodPriceLabel.AutoSize = true;
            this.prodPriceLabel.Location = new System.Drawing.Point(85, 219);
            this.prodPriceLabel.Name = "prodPriceLabel";
            this.prodPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.prodPriceLabel.TabIndex = 52;
            this.prodPriceLabel.Text = "Price";
            // 
            // prodMaxLabel
            // 
            this.prodMaxLabel.AutoSize = true;
            this.prodMaxLabel.Location = new System.Drawing.Point(89, 260);
            this.prodMaxLabel.Name = "prodMaxLabel";
            this.prodMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.prodMaxLabel.TabIndex = 53;
            this.prodMaxLabel.Text = "Max";
            // 
            // prodMinLabel
            // 
            this.prodMinLabel.AutoSize = true;
            this.prodMinLabel.Location = new System.Drawing.Point(89, 305);
            this.prodMinLabel.Name = "prodMinLabel";
            this.prodMinLabel.Size = new System.Drawing.Size(24, 13);
            this.prodMinLabel.TabIndex = 54;
            this.prodMinLabel.Text = "Min";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 55;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 56;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 20);
            this.textBox3.TabIndex = 57;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 216);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 20);
            this.textBox4.TabIndex = 58;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(122, 257);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 20);
            this.textBox5.TabIndex = 59;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(122, 302);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(171, 20);
            this.textBox6.TabIndex = 60;
            // 
            // addProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 638);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.prodMinLabel);
            this.Controls.Add(this.prodMaxLabel);
            this.Controls.Add(this.prodPriceLabel);
            this.Controls.Add(this.prodInvLabel);
            this.Controls.Add(this.prodNameLabel);
            this.Controls.Add(this.prodIDLabel);
            this.Controls.Add(this.prodDeleteBTN);
            this.Controls.Add(this.prodBottomLabel);
            this.Controls.Add(this.bottomDataGridView);
            this.Controls.Add(this.prodAddBTN);
            this.Controls.Add(this.prodTopLabel);
            this.Controls.Add(this.topDataGridView);
            this.Controls.Add(this.prodSearchBTN);
            this.Controls.Add(this.addProdTB);
            this.Controls.Add(this.prodCancelBTN);
            this.Controls.Add(this.prodSaveBTN);
            this.Controls.Add(this.headerProd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addProductsForm";
            this.Text = "AddProducts";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prodCancelBTN;
        private System.Windows.Forms.Button prodSaveBTN;
        private System.Windows.Forms.Label headerProd;
        private System.Windows.Forms.TextBox addProdTB;
        private System.Windows.Forms.Button prodSearchBTN;
        private System.Windows.Forms.DataGridView topDataGridView;
        private System.Windows.Forms.Label prodTopLabel;
        private System.Windows.Forms.Button prodAddBTN;
        private System.Windows.Forms.Button prodDeleteBTN;
        private System.Windows.Forms.Label prodBottomLabel;
        private System.Windows.Forms.DataGridView bottomDataGridView;
        private System.Windows.Forms.Label prodIDLabel;
        private System.Windows.Forms.Label prodNameLabel;
        private System.Windows.Forms.Label prodInvLabel;
        private System.Windows.Forms.Label prodPriceLabel;
        private System.Windows.Forms.Label prodMaxLabel;
        private System.Windows.Forms.Label prodMinLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}