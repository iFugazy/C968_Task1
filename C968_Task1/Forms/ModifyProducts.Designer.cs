namespace C968_Task1.Forms
{
    partial class ModifyProducts
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prodMinLabel = new System.Windows.Forms.Label();
            this.prodMaxLabel = new System.Windows.Forms.Label();
            this.prodPriceLabel = new System.Windows.Forms.Label();
            this.prodInvLabel = new System.Windows.Forms.Label();
            this.prodNameLabel = new System.Windows.Forms.Label();
            this.prodIDLabel = new System.Windows.Forms.Label();
            this.prodDeleteBTN = new System.Windows.Forms.Button();
            this.prodBottomLabel = new System.Windows.Forms.Label();
            this.bottomDataGridView = new System.Windows.Forms.DataGridView();
            this.prodAddBTN = new System.Windows.Forms.Button();
            this.prodTopLabel = new System.Windows.Forms.Label();
            this.topDataGridView = new System.Windows.Forms.DataGridView();
            this.prodSearchBTN = new System.Windows.Forms.Button();
            this.addProdTB = new System.Windows.Forms.TextBox();
            this.prodCancelBTN = new System.Windows.Forms.Button();
            this.prodSaveBTN = new System.Windows.Forms.Button();
            this.headerProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bottomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(238, 579);
            this.textBox6.Margin = new System.Windows.Forms.Padding(6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(338, 31);
            this.textBox6.TabIndex = 83;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(238, 492);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(338, 31);
            this.textBox5.TabIndex = 82;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(238, 413);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(338, 31);
            this.textBox4.TabIndex = 81;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(238, 333);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 31);
            this.textBox3.TabIndex = 80;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 248);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 31);
            this.textBox2.TabIndex = 79;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(338, 31);
            this.textBox1.TabIndex = 86;
            // 
            // prodMinLabel
            // 
            this.prodMinLabel.AutoSize = true;
            this.prodMinLabel.Location = new System.Drawing.Point(172, 585);
            this.prodMinLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodMinLabel.Name = "prodMinLabel";
            this.prodMinLabel.Size = new System.Drawing.Size(47, 25);
            this.prodMinLabel.TabIndex = 77;
            this.prodMinLabel.Text = "Min";
            // 
            // prodMaxLabel
            // 
            this.prodMaxLabel.AutoSize = true;
            this.prodMaxLabel.Location = new System.Drawing.Point(172, 498);
            this.prodMaxLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodMaxLabel.Name = "prodMaxLabel";
            this.prodMaxLabel.Size = new System.Drawing.Size(53, 25);
            this.prodMaxLabel.TabIndex = 76;
            this.prodMaxLabel.Text = "Max";
            // 
            // prodPriceLabel
            // 
            this.prodPriceLabel.AutoSize = true;
            this.prodPriceLabel.Location = new System.Drawing.Point(164, 419);
            this.prodPriceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodPriceLabel.Name = "prodPriceLabel";
            this.prodPriceLabel.Size = new System.Drawing.Size(61, 25);
            this.prodPriceLabel.TabIndex = 75;
            this.prodPriceLabel.Text = "Price";
            // 
            // prodInvLabel
            // 
            this.prodInvLabel.AutoSize = true;
            this.prodInvLabel.Location = new System.Drawing.Point(124, 338);
            this.prodInvLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodInvLabel.Name = "prodInvLabel";
            this.prodInvLabel.Size = new System.Drawing.Size(100, 25);
            this.prodInvLabel.TabIndex = 74;
            this.prodInvLabel.Text = "Inventory";
            // 
            // prodNameLabel
            // 
            this.prodNameLabel.AutoSize = true;
            this.prodNameLabel.Location = new System.Drawing.Point(150, 254);
            this.prodNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodNameLabel.Name = "prodNameLabel";
            this.prodNameLabel.Size = new System.Drawing.Size(68, 25);
            this.prodNameLabel.TabIndex = 73;
            this.prodNameLabel.Text = "Name";
            // 
            // prodIDLabel
            // 
            this.prodIDLabel.AutoSize = true;
            this.prodIDLabel.Location = new System.Drawing.Point(184, 169);
            this.prodIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodIDLabel.Name = "prodIDLabel";
            this.prodIDLabel.Size = new System.Drawing.Size(32, 25);
            this.prodIDLabel.TabIndex = 72;
            this.prodIDLabel.Text = "ID";
            // 
            // prodDeleteBTN
            // 
            this.prodDeleteBTN.Location = new System.Drawing.Point(1604, 1071);
            this.prodDeleteBTN.Margin = new System.Windows.Forms.Padding(6);
            this.prodDeleteBTN.Name = "prodDeleteBTN";
            this.prodDeleteBTN.Size = new System.Drawing.Size(150, 44);
            this.prodDeleteBTN.TabIndex = 71;
            this.prodDeleteBTN.Text = "Delete";
            this.prodDeleteBTN.UseVisualStyleBackColor = true;
            this.prodDeleteBTN.Click += new System.EventHandler(this.prodDeleteBTN_Click);
            // 
            // prodBottomLabel
            // 
            this.prodBottomLabel.AutoSize = true;
            this.prodBottomLabel.Location = new System.Drawing.Point(882, 621);
            this.prodBottomLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodBottomLabel.Name = "prodBottomLabel";
            this.prodBottomLabel.Size = new System.Drawing.Size(338, 25);
            this.prodBottomLabel.TabIndex = 70;
            this.prodBottomLabel.Text = "Parts Associated with this Product";
            // 
            // bottomDataGridView
            // 
            this.bottomDataGridView.AllowUserToAddRows = false;
            this.bottomDataGridView.AllowUserToDeleteRows = false;
            this.bottomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bottomDataGridView.Location = new System.Drawing.Point(888, 669);
            this.bottomDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.bottomDataGridView.Name = "bottomDataGridView";
            this.bottomDataGridView.ReadOnly = true;
            this.bottomDataGridView.RowHeadersVisible = false;
            this.bottomDataGridView.RowHeadersWidth = 82;
            this.bottomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bottomDataGridView.Size = new System.Drawing.Size(866, 373);
            this.bottomDataGridView.TabIndex = 69;
            // 
            // prodAddBTN
            // 
            this.prodAddBTN.Location = new System.Drawing.Point(1604, 567);
            this.prodAddBTN.Margin = new System.Windows.Forms.Padding(6);
            this.prodAddBTN.Name = "prodAddBTN";
            this.prodAddBTN.Size = new System.Drawing.Size(150, 44);
            this.prodAddBTN.TabIndex = 68;
            this.prodAddBTN.Text = "Add";
            this.prodAddBTN.UseVisualStyleBackColor = true;
            this.prodAddBTN.Click += new System.EventHandler(this.prodAddBTN_Click);
            // 
            // prodTopLabel
            // 
            this.prodTopLabel.AutoSize = true;
            this.prodTopLabel.Location = new System.Drawing.Point(882, 115);
            this.prodTopLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodTopLabel.Name = "prodTopLabel";
            this.prodTopLabel.Size = new System.Drawing.Size(196, 25);
            this.prodTopLabel.TabIndex = 67;
            this.prodTopLabel.Text = "All Candidate Parts";
            // 
            // topDataGridView
            // 
            this.topDataGridView.AllowUserToAddRows = false;
            this.topDataGridView.AllowUserToDeleteRows = false;
            this.topDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topDataGridView.Location = new System.Drawing.Point(888, 163);
            this.topDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.topDataGridView.Name = "topDataGridView";
            this.topDataGridView.ReadOnly = true;
            this.topDataGridView.RowHeadersVisible = false;
            this.topDataGridView.RowHeadersWidth = 82;
            this.topDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.topDataGridView.Size = new System.Drawing.Size(866, 373);
            this.topDataGridView.TabIndex = 66;
            // 
            // prodSearchBTN
            // 
            this.prodSearchBTN.Location = new System.Drawing.Point(1222, 63);
            this.prodSearchBTN.Margin = new System.Windows.Forms.Padding(6);
            this.prodSearchBTN.Name = "prodSearchBTN";
            this.prodSearchBTN.Size = new System.Drawing.Size(150, 44);
            this.prodSearchBTN.TabIndex = 65;
            this.prodSearchBTN.Text = "Search";
            this.prodSearchBTN.UseVisualStyleBackColor = true;
            this.prodSearchBTN.Click += new System.EventHandler(this.prodSearchBTN_Click);
            // 
            // addProdTB
            // 
            this.addProdTB.Location = new System.Drawing.Point(1384, 67);
            this.addProdTB.Margin = new System.Windows.Forms.Padding(6);
            this.addProdTB.Name = "addProdTB";
            this.addProdTB.Size = new System.Drawing.Size(366, 31);
            this.addProdTB.TabIndex = 84;
            // 
            // prodCancelBTN
            // 
            this.prodCancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.prodCancelBTN.Location = new System.Drawing.Point(1604, 1158);
            this.prodCancelBTN.Margin = new System.Windows.Forms.Padding(6);
            this.prodCancelBTN.Name = "prodCancelBTN";
            this.prodCancelBTN.Size = new System.Drawing.Size(150, 44);
            this.prodCancelBTN.TabIndex = 64;
            this.prodCancelBTN.Text = "Cancel";
            this.prodCancelBTN.UseVisualStyleBackColor = true;
            // 
            // prodSaveBTN
            // 
            this.prodSaveBTN.Location = new System.Drawing.Point(1424, 1158);
            this.prodSaveBTN.Margin = new System.Windows.Forms.Padding(6);
            this.prodSaveBTN.Name = "prodSaveBTN";
            this.prodSaveBTN.Size = new System.Drawing.Size(150, 44);
            this.prodSaveBTN.TabIndex = 63;
            this.prodSaveBTN.Text = "Save";
            this.prodSaveBTN.UseVisualStyleBackColor = true;
            this.prodSaveBTN.Click += new System.EventHandler(this.prodSaveBTN_Click);
            // 
            // headerProd
            // 
            this.headerProd.AutoSize = true;
            this.headerProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerProd.Location = new System.Drawing.Point(15, 9);
            this.headerProd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerProd.Name = "headerProd";
            this.headerProd.Size = new System.Drawing.Size(270, 48);
            this.headerProd.TabIndex = 85;
            this.headerProd.Text = "Add Products";
            // 
            // ModifyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 1227);
            this.Controls.Add(this.headerProd);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ModifyProducts";
            this.Text = "ModifyProducts";
            this.Load += new System.EventHandler(this.ModifyProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bottomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label prodMinLabel;
        private System.Windows.Forms.Label prodMaxLabel;
        private System.Windows.Forms.Label prodPriceLabel;
        private System.Windows.Forms.Label prodInvLabel;
        private System.Windows.Forms.Label prodNameLabel;
        private System.Windows.Forms.Label prodIDLabel;
        private System.Windows.Forms.Button prodDeleteBTN;
        private System.Windows.Forms.Label prodBottomLabel;
        private System.Windows.Forms.DataGridView bottomDataGridView;
        private System.Windows.Forms.Button prodAddBTN;
        private System.Windows.Forms.Label prodTopLabel;
        private System.Windows.Forms.DataGridView topDataGridView;
        private System.Windows.Forms.Button prodSearchBTN;
        private System.Windows.Forms.TextBox addProdTB;
        private System.Windows.Forms.Button prodCancelBTN;
        private System.Windows.Forms.Button prodSaveBTN;
        private System.Windows.Forms.Label headerProd;
    }
}