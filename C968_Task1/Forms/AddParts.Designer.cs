namespace C968_Task1
{
    partial class addPartsForm
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
            this.headerParts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.partIDTb = new System.Windows.Forms.TextBox();
            this.partsInHouseRTBN = new System.Windows.Forms.RadioButton();
            this.partsOutsourcedRBTN = new System.Windows.Forms.RadioButton();
            this.partNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partInvTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partPriceTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.partMaxTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.partMinTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.addPartsMachineIDLabel = new System.Windows.Forms.Label();
            this.partsSaveButton = new System.Windows.Forms.Button();
            this.partsCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerParts
            // 
            this.headerParts.AutoSize = true;
            this.headerParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerParts.Location = new System.Drawing.Point(24, 17);
            this.headerParts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerParts.Name = "headerParts";
            this.headerParts.Size = new System.Drawing.Size(203, 48);
            this.headerParts.TabIndex = 3;
            this.headerParts.Text = "Add Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // partIDTb
            // 
            this.partIDTb.Location = new System.Drawing.Point(314, 108);
            this.partIDTb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partIDTb.Name = "partIDTb";
            this.partIDTb.Size = new System.Drawing.Size(364, 31);
            this.partIDTb.TabIndex = 5;
            // 
            // partsInHouseRTBN
            // 
            this.partsInHouseRTBN.AutoSize = true;
            this.partsInHouseRTBN.Location = new System.Drawing.Point(314, 23);
            this.partsInHouseRTBN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partsInHouseRTBN.Name = "partsInHouseRTBN";
            this.partsInHouseRTBN.Size = new System.Drawing.Size(129, 29);
            this.partsInHouseRTBN.TabIndex = 6;
            this.partsInHouseRTBN.TabStop = true;
            this.partsInHouseRTBN.Text = "In-House";
            this.partsInHouseRTBN.UseVisualStyleBackColor = true;
            this.partsInHouseRTBN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // partsOutsourcedRBTN
            // 
            this.partsOutsourcedRBTN.AutoSize = true;
            this.partsOutsourcedRBTN.Location = new System.Drawing.Point(548, 23);
            this.partsOutsourcedRBTN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partsOutsourcedRBTN.Name = "partsOutsourcedRBTN";
            this.partsOutsourcedRBTN.Size = new System.Drawing.Size(154, 29);
            this.partsOutsourcedRBTN.TabIndex = 7;
            this.partsOutsourcedRBTN.TabStop = true;
            this.partsOutsourcedRBTN.Text = "Outsourced";
            this.partsOutsourcedRBTN.UseVisualStyleBackColor = true;
            this.partsOutsourcedRBTN.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // partNameTB
            // 
            this.partNameTB.Location = new System.Drawing.Point(314, 188);
            this.partNameTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partNameTB.Name = "partNameTB";
            this.partNameTB.Size = new System.Drawing.Size(364, 31);
            this.partNameTB.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // partInvTB
            // 
            this.partInvTB.Location = new System.Drawing.Point(314, 271);
            this.partInvTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partInvTB.Name = "partInvTB";
            this.partInvTB.Size = new System.Drawing.Size(364, 31);
            this.partInvTB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Inventory";
            // 
            // partPriceTB
            // 
            this.partPriceTB.Location = new System.Drawing.Point(314, 356);
            this.partPriceTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partPriceTB.Name = "partPriceTB";
            this.partPriceTB.Size = new System.Drawing.Size(364, 31);
            this.partPriceTB.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price / Cost";
            // 
            // partMaxTB
            // 
            this.partMaxTB.Location = new System.Drawing.Point(312, 444);
            this.partMaxTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partMaxTB.Name = "partMaxTB";
            this.partMaxTB.Size = new System.Drawing.Size(124, 31);
            this.partMaxTB.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Max";
            // 
            // partMinTB
            // 
            this.partMinTB.Location = new System.Drawing.Point(554, 444);
            this.partMinTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partMinTB.Name = "partMinTB";
            this.partMinTB.Size = new System.Drawing.Size(124, 31);
            this.partMinTB.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 452);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Min";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(312, 531);
            this.textBox7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(364, 31);
            this.textBox7.TabIndex = 19;
            // 
            // addPartsMachineIDLabel
            // 
            this.addPartsMachineIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPartsMachineIDLabel.Location = new System.Drawing.Point(178, 537);
            this.addPartsMachineIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.addPartsMachineIDLabel.Name = "addPartsMachineIDLabel";
            this.addPartsMachineIDLabel.Size = new System.Drawing.Size(124, 25);
            this.addPartsMachineIDLabel.TabIndex = 18;
            this.addPartsMachineIDLabel.Text = "Machine ID";
            this.addPartsMachineIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // partsSaveButton
            // 
            this.partsSaveButton.Location = new System.Drawing.Point(532, 621);
            this.partsSaveButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partsSaveButton.Name = "partsSaveButton";
            this.partsSaveButton.Size = new System.Drawing.Size(150, 44);
            this.partsSaveButton.TabIndex = 20;
            this.partsSaveButton.Text = "Save";
            this.partsSaveButton.UseVisualStyleBackColor = true;
            this.partsSaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // partsCancelButton
            // 
            this.partsCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.partsCancelButton.Location = new System.Drawing.Point(712, 621);
            this.partsCancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partsCancelButton.Name = "partsCancelButton";
            this.partsCancelButton.Size = new System.Drawing.Size(150, 44);
            this.partsCancelButton.TabIndex = 21;
            this.partsCancelButton.Text = "Cancel";
            this.partsCancelButton.UseVisualStyleBackColor = true;
            this.partsCancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addPartsForm
            // 
            this.AcceptButton = this.partsSaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.partsCancelButton;
            this.ClientSize = new System.Drawing.Size(910, 712);
            this.Controls.Add(this.partsCancelButton);
            this.Controls.Add(this.partsSaveButton);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.addPartsMachineIDLabel);
            this.Controls.Add(this.partMinTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.partMaxTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.partPriceTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.partInvTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.partNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partsOutsourcedRBTN);
            this.Controls.Add(this.partsInHouseRTBN);
            this.Controls.Add(this.partIDTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerParts);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "addPartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headerParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton partsInHouseRTBN;
        private System.Windows.Forms.RadioButton partsOutsourcedRBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label addPartsMachineIDLabel;
        private System.Windows.Forms.Button partsSaveButton;
        private System.Windows.Forms.Button partsCancelButton;
        public System.Windows.Forms.TextBox partIDTb;
        public System.Windows.Forms.TextBox partNameTB;
        public System.Windows.Forms.TextBox partInvTB;
        public System.Windows.Forms.TextBox partPriceTB;
        public System.Windows.Forms.TextBox partMaxTB;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.TextBox partMinTB;
    }
}