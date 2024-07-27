using C968_Task1.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace C968_Task1
{
    public partial class addPartsForm : Form
    {
        mainForm MainForm;
        DataTable table = new DataTable();
        Inventory Inventory = new Inventory();
        public int PartID { get; set; }
        public string PartName { get; set; }
        public int PartInv { get; set; }
        public decimal PartPrice { get; set; }
        public int PartMin { get; set; }
        public int PartMax { get; set; }
        public int MachineID { get; set; }
        public new string CompanyName { get; set; }


        /// <summary>
        /// This constructor takes the partID from the binding list and adds one to it so that the user doesn't
        /// have to worry about making sure the partID feild is incrementing correctly. This also allows the user
        /// to see this within the partID textbox
        /// </summary>
        /// <param name="mainForm"></param>      
        public addPartsForm(mainForm mainForm)
        {
            InitializeComponent();
            this.MainForm = mainForm;
            partNameTB.BackColor = Color.IndianRed;
            partInvTB.BackColor = Color.IndianRed;
            partPriceTB.BackColor = Color.IndianRed;
            partMaxTB.BackColor = Color.IndianRed;
            partMinTB.BackColor = Color.IndianRed;
            textBox7.BackColor = Color.IndianRed;

            partsInHouseRTBN.Checked = true;
            int PartNum = Inventory.AllParts.Count + 1;
            partIDTb.Text = PartNum.ToString();

        }

        /// <summary>
        /// This event handler checks to see if the radio button was changed and changes the text from "Company Name" to
        /// "Machine ID".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Text = null;
            addPartsMachineIDLabel.Text = "Machine ID";
        }

        /// <summary>
        /// This event handler checks to see if the radio button was changed and changes the text from "Machine ID" to
        /// "Company Name".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Text = null;
            addPartsMachineIDLabel.Text = "Company Name";
        }

        /// <summary>
        /// This event handler closes this form and reverts the information back to the information available before clicking
        /// this dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This event handler takes the information that has been placed within the form's textboxes and places them within 
        /// variables. These variables are then used within the "inhouse" variable which is a instantiaded variable of the Inhouse
        /// class. This is then added to the binding list using the addPart class from the Inventory class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partsSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                PartID = Inventory.AllParts.Count + 1;
                PartName = partNameTB.Text;
                PartInv = int.Parse(partInvTB.Text);
                PartPrice = decimal.Parse(partPriceTB.Text);
                PartMin = int.Parse(partMinTB.Text);
                PartMax = int.Parse(partMaxTB.Text);

                if (PartMin > PartMax)
                {
                    MessageBox.Show("Minimum amount of parts is greater than the maximum amount", "Min is greater than Max");
                    return;
                }

                if (PartInv > PartMax)
                {
                    MessageBox.Show("Inventory amount is greater than the maxium", "Inventory Error");
                    return;
                }

                if (PartInv < PartMin)
                {
                    MessageBox.Show("Inventory amount is less than the minimum", "Inventory Error");
                    return;
                }

                if (partsInHouseRTBN.Checked)
                {
                    MachineID = int.Parse(textBox7.Text);

                    Inhouse inhouse = new Inhouse(PartID, PartName, PartInv, PartPrice, PartMin, PartMax, MachineID);
                    Inventory.addPart(inhouse);
                }
                else if (partsOutsourcedRBTN.Checked)
                {
                    CompanyName = textBox7.Text;

                    Outsourced outsourced = new Outsourced(PartID, PartName, PartInv, PartPrice, PartMin, PartMax, CompanyName);
                    Inventory.addPart(outsourced);
                }
                else
                {
                    MessageBox.Show("Please check whether the part is Outsourced or Inhouse");
                }

                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Please enter valid values", "Incorrect Values Found");
            }
        }

        /// <summary>
        /// This event handler only allows the user to insert Digits within the Part Name textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar);
            partNameTB.BackColor = Color.White;
        }

        /// <summary>
        /// This event handler only allows the user to insert Digits within the Inventory textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partInvTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsControl(e.KeyChar);
            partInvTB.BackColor = Color.White;
        }

        /// <summary>
        /// This event handler only allows the user to insert Digits within the Price textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partPriceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsPunctuation(e.KeyChar);
            partPriceTB.BackColor = Color.White;
        }

        /// <summary>
        /// This event handler only allows the user to insert Digits within the Max textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partMaxTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            partMaxTB.BackColor = Color.White;
        }

        /// <summary>
        /// This event handler only allows the user to insert Digits within the Min textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partMinTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            partMinTB.BackColor = Color.White;
        }

        /// <summary>
        /// This event handler only allows the user to insert Digits within the Machine ID / Outsourced textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (partsInHouseRTBN.Checked)
            {
                e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            }
            else
            {
                e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsLetter(e.KeyChar);
            }
            textBox7.BackColor = Color.White;
        }
    }
}
