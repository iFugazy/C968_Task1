
using C968_Task1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
