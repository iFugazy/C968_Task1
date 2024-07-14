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
            this.headerAddParts = new System.Windows.Forms.Label();
            this.addPartsInHouseButton = new System.Windows.Forms.RadioButton();
            this.addPartsOutsourcedButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addPartIDLabel = new System.Windows.Forms.Label();
            this.addPartNameLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addPartInventoryLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addPartPriceCostLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.addPartMaxLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.addPartMinLabel = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.addPartMachineIDLabel = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.addPartsSaveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerAddParts
            // 
            this.headerAddParts.AutoSize = true;
            this.headerAddParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerAddParts.Location = new System.Drawing.Point(12, 9);
            this.headerAddParts.Name = "headerAddParts";
            this.headerAddParts.Size = new System.Drawing.Size(106, 25);
            this.headerAddParts.TabIndex = 2;
            this.headerAddParts.Text = "Add Parts";
            // 
            // addPartsInHouseButton
            // 
            this.addPartsInHouseButton.AutoSize = true;
            this.addPartsInHouseButton.Location = new System.Drawing.Point(162, 12);
            this.addPartsInHouseButton.Name = "addPartsInHouseButton";
            this.addPartsInHouseButton.Size = new System.Drawing.Size(68, 17);
            this.addPartsInHouseButton.TabIndex = 3;
            this.addPartsInHouseButton.TabStop = true;
            this.addPartsInHouseButton.Text = "In-House";
            this.addPartsInHouseButton.UseVisualStyleBackColor = true;
            this.addPartsInHouseButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // addPartsOutsourcedButton
            // 
            this.addPartsOutsourcedButton.AutoSize = true;
            this.addPartsOutsourcedButton.Location = new System.Drawing.Point(262, 12);
            this.addPartsOutsourcedButton.Name = "addPartsOutsourcedButton";
            this.addPartsOutsourcedButton.Size = new System.Drawing.Size(80, 17);
            this.addPartsOutsourcedButton.TabIndex = 4;
            this.addPartsOutsourcedButton.TabStop = true;
            this.addPartsOutsourcedButton.Text = "Outsourced";
            this.addPartsOutsourcedButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 5;
            // 
            // addPartIDLabel
            // 
            this.addPartIDLabel.AutoSize = true;
            this.addPartIDLabel.Location = new System.Drawing.Point(154, 50);
            this.addPartIDLabel.Name = "addPartIDLabel";
            this.addPartIDLabel.Size = new System.Drawing.Size(18, 13);
            this.addPartIDLabel.TabIndex = 6;
            this.addPartIDLabel.Text = "ID";
            // 
            // addPartNameLabel
            // 
            this.addPartNameLabel.AutoSize = true;
            this.addPartNameLabel.Location = new System.Drawing.Point(137, 97);
            this.addPartNameLabel.Name = "addPartNameLabel";
            this.addPartNameLabel.Size = new System.Drawing.Size(35, 13);
            this.addPartNameLabel.TabIndex = 8;
            this.addPartNameLabel.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 7;
            // 
            // addPartInventoryLabel
            // 
            this.addPartInventoryLabel.AutoSize = true;
            this.addPartInventoryLabel.Location = new System.Drawing.Point(121, 147);
            this.addPartInventoryLabel.Name = "addPartInventoryLabel";
            this.addPartInventoryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addPartInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.addPartInventoryLabel.TabIndex = 10;
            this.addPartInventoryLabel.Text = "Inventory";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 20);
            this.textBox3.TabIndex = 9;
            // 
            // addPartPriceCostLabel
            // 
            this.addPartPriceCostLabel.AutoSize = true;
            this.addPartPriceCostLabel.Location = new System.Drawing.Point(109, 196);
            this.addPartPriceCostLabel.Name = "addPartPriceCostLabel";
            this.addPartPriceCostLabel.Size = new System.Drawing.Size(63, 13);
            this.addPartPriceCostLabel.TabIndex = 12;
            this.addPartPriceCostLabel.Text = "Price / Cost";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(186, 196);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 20);
            this.textBox4.TabIndex = 11;
            // 
            // addPartMaxLabel
            // 
            this.addPartMaxLabel.AutoSize = true;
            this.addPartMaxLabel.Location = new System.Drawing.Point(145, 249);
            this.addPartMaxLabel.Name = "addPartMaxLabel";
            this.addPartMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.addPartMaxLabel.TabIndex = 14;
            this.addPartMaxLabel.Text = "Max";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(186, 249);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(61, 20);
            this.textBox5.TabIndex = 13;
            // 
            // addPartMinLabel
            // 
            this.addPartMinLabel.AutoSize = true;
            this.addPartMinLabel.Location = new System.Drawing.Point(274, 249);
            this.addPartMinLabel.Name = "addPartMinLabel";
            this.addPartMinLabel.Size = new System.Drawing.Size(24, 13);
            this.addPartMinLabel.TabIndex = 16;
            this.addPartMinLabel.Text = "Min";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(304, 249);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(61, 20);
            this.textBox6.TabIndex = 15;
            // 
            // addPartMachineIDLabel
            // 
            this.addPartMachineIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPartMachineIDLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPartMachineIDLabel.Location = new System.Drawing.Point(110, 302);
            this.addPartMachineIDLabel.Name = "addPartMachineIDLabel";
            this.addPartMachineIDLabel.Size = new System.Drawing.Size(62, 13);
            this.addPartMachineIDLabel.TabIndex = 18;
            this.addPartMachineIDLabel.Text = "Machine ID";
            this.addPartMachineIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(186, 299);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(145, 20);
            this.textBox7.TabIndex = 17;
            // 
            // addPartsSaveButton
            // 
            this.addPartsSaveButton.Location = new System.Drawing.Point(326, 371);
            this.addPartsSaveButton.Name = "addPartsSaveButton";
            this.addPartsSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addPartsSaveButton.TabIndex = 19;
            this.addPartsSaveButton.Text = "Save";
            this.addPartsSaveButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(494, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addPartsSaveButton);
            this.Controls.Add(this.addPartMachineIDLabel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.addPartMinLabel);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.addPartMaxLabel);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.addPartPriceCostLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.addPartInventoryLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.addPartNameLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.addPartIDLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addPartsOutsourcedButton);
            this.Controls.Add(this.addPartsInHouseButton);
            this.Controls.Add(this.headerAddParts);
            this.Name = "addPartsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headerAddParts;
        private System.Windows.Forms.RadioButton addPartsInHouseButton;
        private System.Windows.Forms.RadioButton addPartsOutsourcedButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label addPartIDLabel;
        private System.Windows.Forms.Label addPartNameLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label addPartInventoryLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label addPartPriceCostLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label addPartMaxLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label addPartMinLabel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label addPartMachineIDLabel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button addPartsSaveButton;
        private System.Windows.Forms.Button button2;
    }

    
}

