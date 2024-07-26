namespace C968_Task1.Forms
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
            this.prodCancelBTN.Location = new System.Drawing.Point(1610, 1160);
            this.prodCancelBTN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.prodCancelBTN.Name = "prodCancelBTN";
            this.prodCancelBTN.Size = new System.Drawing.Size(150, 44);
            this.prodCancelBTN.TabIndex = 40;
            this.prodCancelBTN.Text = "Cancel";
            this.prodCancelBTN.UseVisualStyleBackColor = true;
            this.prodCancelBTN.Click += new System.EventHandler(this.prodCancelBTN_Click);
            // 
            // prodSaveBTN
            // 
            this.prodSaveBTN.Location = new System.Drawing.Point(1430, 1160);
            this.prodSaveBTN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.prodSaveBTN.Name = "prodSaveBTN";
            this.prodSaveBTN.Size = new System.Drawing.Size(150, 44);
            this.prodSaveBTN.TabIndex = 39;
            this.prodSaveBTN.Text = "Save";
            this.prodSaveBTN.UseVisualStyleBackColor = true;
            this.prodSaveBTN.Click += new System.EventHandler(this.prodSaveBTN_Click);
            // 
            // headerProd
            // 
            this.headerProd.AutoSize = true;
            this.headerProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerProd.Location = new System.Drawing.Point(24, 17);
            this.headerProd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerProd.Name = "headerProd";
            this.headerProd.Size = new System.Drawing.Size(270, 48);
            this.headerProd.TabIndex = 22;
            this.headerProd.Text = "Add Products";
            // 
            // addProdTB
            // 
            this.addProdTB.Location = new System.Drawing.Point(1390, 69);
            this.addProdTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addProdTB.Name = "addProdTB";
            this.addProdTB.Size = new System.Drawing.Size(366, 31);
            this.addProdTB.TabIndex = 61;
            // 
            // prodSearchBTN
            // 
            this.prodSearchBTN.Location = new System.Drawing.Point(1228, 65);
            this.prodSearchBTN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.prodSearchBTN.Name = "prodSearchBTN";
            this.prodSearchBTN.Size = new System.Drawing.Size(150, 44);
            this.prodSearchBTN.TabIndex = 42;
            this.prodSearchBTN.Text = "Search";
            this.prodSearchBTN.UseVisualStyleBackColor = true;
            this.prodSearchBTN.Click += new System.EventHandler(this.prodSearchBTN_Click);
            // 
            // topDataGridView
            // 
            this.topDataGridView.AllowUserToAddRows = false;
            this.topDataGridView.AllowUserToDeleteRows = false;
            this.topDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topDataGridView.Location = new System.Drawing.Point(894, 165);
            this.topDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.topDataGridView.Name = "topDataGridView";
            this.topDataGridView.ReadOnly = true;
            this.topDataGridView.RowHeadersVisible = false;
            this.topDataGridView.RowHeadersWidth = 82;
            this.topDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.topDataGridView.Size = new System.Drawing.Size(866, 373);
            this.topDataGridView.TabIndex = 43;
            // 
            // prodTopLabel
            // 
            this.prodTopLabel.AutoSize = true;
            this.prodTopLabel.Location = new System.Drawing.Point(888, 117);
            this.prodTopLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodTopLabel.Name = "prodTopLabel";
            this.prodTopLabel.Size = new System.Drawing.Size(196, 25);
            this.prodTopLabel.TabIndex = 44;
            this.prodTopLabel.Text = "All Candidate Parts";
            // 
            // prodAddBTN
            // 
            this.prodAddBTN.Location = new System.Drawing.Point(1610, 569);
            this.prodAddBTN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.prodAddBTN.Name = "prodAddBTN";
            this.prodAddBTN.Size = new System.Drawing.Size(150, 44);
            this.prodAddBTN.TabIndex = 45;
            this.prodAddBTN.Text = "Add";
            this.prodAddBTN.UseVisualStyleBackColor = true;
            this.prodAddBTN.Click += new System.EventHandler(this.prodAddBTN_Click);
            // 
            // prodDeleteBTN
            // 
            this.prodDeleteBTN.Location = new System.Drawing.Point(1610, 1073);
            this.prodDeleteBTN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.prodDeleteBTN.Name = "prodDeleteBTN";
            this.prodDeleteBTN.Size = new System.Drawing.Size(150, 44);
            this.prodDeleteBTN.TabIndex = 48;
            this.prodDeleteBTN.Text = "Delete";
            this.prodDeleteBTN.UseVisualStyleBackColor = true;
            this.prodDeleteBTN.Click += new System.EventHandler(this.prodDeleteBTN_Click);
            // 
            // prodBottomLabel
            // 
            this.prodBottomLabel.AutoSize = true;
            this.prodBottomLabel.Location = new System.Drawing.Point(888, 623);
            this.prodBottomLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodBottomLabel.Name = "prodBottomLabel";
            this.prodBottomLabel.Size = new System.Drawing.Size(338, 25);
            this.prodBottomLabel.TabIndex = 47;
            this.prodBottomLabel.Text = "Parts Associated with this Product";
            // 
            // bottomDataGridView
            // 
            this.bottomDataGridView.AllowUserToAddRows = false;
            this.bottomDataGridView.AllowUserToDeleteRows = false;
            this.bottomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bottomDataGridView.Location = new System.Drawing.Point(894, 671);
            this.bottomDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bottomDataGridView.Name = "bottomDataGridView";
            this.bottomDataGridView.ReadOnly = true;
            this.bottomDataGridView.RowHeadersVisible = false;
            this.bottomDataGridView.RowHeadersWidth = 82;
            this.bottomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bottomDataGridView.Size = new System.Drawing.Size(866, 373);
            this.bottomDataGridView.TabIndex = 46;
            // 
            // prodIDLabel
            // 
            this.prodIDLabel.AutoSize = true;
            this.prodIDLabel.Location = new System.Drawing.Point(190, 171);
            this.prodIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodIDLabel.Name = "prodIDLabel";
            this.prodIDLabel.Size = new System.Drawing.Size(32, 25);
            this.prodIDLabel.TabIndex = 49;
            this.prodIDLabel.Text = "ID";
            // 
            // prodNameLabel
            // 
            this.prodNameLabel.AutoSize = true;
            this.prodNameLabel.Location = new System.Drawing.Point(156, 256);
            this.prodNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodNameLabel.Name = "prodNameLabel";
            this.prodNameLabel.Size = new System.Drawing.Size(68, 25);
            this.prodNameLabel.TabIndex = 50;
            this.prodNameLabel.Text = "Name";
            // 
            // prodInvLabel
            // 
            this.prodInvLabel.AutoSize = true;
            this.prodInvLabel.Location = new System.Drawing.Point(130, 340);
            this.prodInvLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodInvLabel.Name = "prodInvLabel";
            this.prodInvLabel.Size = new System.Drawing.Size(100, 25);
            this.prodInvLabel.TabIndex = 51;
            this.prodInvLabel.Text = "Inventory";
            // 
            // prodPriceLabel
            // 
            this.prodPriceLabel.AutoSize = true;
            this.prodPriceLabel.Location = new System.Drawing.Point(170, 421);
            this.prodPriceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodPriceLabel.Name = "prodPriceLabel";
            this.prodPriceLabel.Size = new System.Drawing.Size(61, 25);
            this.prodPriceLabel.TabIndex = 52;
            this.prodPriceLabel.Text = "Price";
            // 
            // prodMaxLabel
            // 
            this.prodMaxLabel.AutoSize = true;
            this.prodMaxLabel.Location = new System.Drawing.Point(178, 500);
            this.prodMaxLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodMaxLabel.Name = "prodMaxLabel";
            this.prodMaxLabel.Size = new System.Drawing.Size(53, 25);
            this.prodMaxLabel.TabIndex = 53;
            this.prodMaxLabel.Text = "Max";
            // 
            // prodMinLabel
            // 
            this.prodMinLabel.AutoSize = true;
            this.prodMinLabel.Location = new System.Drawing.Point(178, 587);
            this.prodMinLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prodMinLabel.Name = "prodMinLabel";
            this.prodMinLabel.Size = new System.Drawing.Size(47, 25);
            this.prodMinLabel.TabIndex = 54;
            this.prodMinLabel.Text = "Min";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(338, 31);
            this.textBox1.TabIndex = 55;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 250);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 31);
            this.textBox2.TabIndex = 56;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(244, 335);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 31);
            this.textBox3.TabIndex = 57;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(244, 415);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(338, 31);
            this.textBox4.TabIndex = 58;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(244, 494);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(338, 31);
            this.textBox5.TabIndex = 59;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(244, 581);
            this.textBox6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(338, 31);
            this.textBox6.TabIndex = 60;
            // 
            // addProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 1227);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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