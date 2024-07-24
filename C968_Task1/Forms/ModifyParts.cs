using C968_Task1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace C968_Task1
{
    public partial class ModifyParts : Form
    {
        mainForm mainForm;

        public int PartID { get; internal set; }
        public string PartName { get; internal set; }
        public decimal PartPrice { get; internal set; }
        public int PartMin { get; internal set; }
        public int PartMax { get; internal set; }
        public int PartInv { get; internal set; }
        public int MachineID { get; set; }
        public new string CompanyName { get; set; }

        public ModifyParts(mainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

        }

        /// <summary>
        /// This constructor takes in data from the outsourced class and then places them within the textbox inside the form.
        /// This allows the user to see what data they are modifying.
        /// </summary>
        /// <param name="outsourced"></param>
        public ModifyParts(Outsourced outsourced)
        {
            InitializeComponent();
            outsourcedRBTN.Checked = true;
            textBox1.Text = outsourced.PartID.ToString();
            textBox2.Text = outsourced.Name.ToString();
            textBox3.Text = outsourced.InStock.ToString();
            textBox4.Text = outsourced.Price.ToString();
            textBox5.Text = outsourced.Min.ToString();
            textBox6.Text = outsourced.Max.ToString();
            textBox7.Text = outsourced.CompanyName;
        }

        /// <summary>
        /// This constructor takes in data from the inhouse class and then places them within the textbox inside the form.
        /// This allows the user to see what data they are modifying.
        /// </summary>
        /// <param name="part"></param>
        public ModifyParts(Inhouse part)
        {           
            InitializeComponent();
            partsInHouseRBTN.Checked = true;
            textBox1.Text = part.PartID.ToString();
            textBox2.Text = part.Name.ToString();
            textBox3.Text = part.InStock.ToString();
            textBox4.Text = part.Price.ToString();
            textBox5.Text = part.Min.ToString();
            textBox6.Text = part.Max.ToString();
            textBox7.Text = part.MachineID.ToString();
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
        /// This event handlers checks to see if the radio button was changed and changes the text from "Machine ID" to
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
        /// This event handler checks to see if the "Cancel" button is clicked and then closes the form, returning the user
        /// back to the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This event handler listens for the "Save" button to be clicked and then parses the int and decimal variable types.
        /// This then takes the parsed data and places it within the instantiated class that takes in the data as a constructorer.
        /// The method called updatePart is then called from within the Inventory class and takes in the ID and the instantiates list 
        /// data from the class being called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PartID = int.Parse(textBox1.Text);
                PartName = textBox2.Text;
                PartInv = int.Parse(textBox3.Text);
                PartPrice = decimal.Parse(textBox4.Text);
                PartMin = int.Parse(textBox5.Text);
                PartMax = int.Parse(textBox6.Text);

                if (partsInHouseRBTN.Checked)
                { 
                    MachineID = int.Parse(textBox7.Text);

                    Inhouse inhouse = new Inhouse(PartID, PartName, PartInv, PartPrice, PartMin, PartMax, MachineID);
                    Inventory.updatePart(PartID, inhouse);

                    DialogResult = DialogResult.OK;
                }

                else if (outsourcedRBTN.Checked)
                {
                    if (textBox7.Text.Length > 0)
                    {
                        CompanyName = textBox7.Text;

                        Outsourced outsourced = new Outsourced(PartID, PartName, PartInv, PartPrice, PartMin, PartMax, CompanyName);
                        Inventory.updatePart(PartID, outsourced);

                        DialogResult = DialogResult.OK;
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Please enter valid values", "Incorrect Values Found");
            }                       
        }

        /// <summary>
        /// This even handler only allows the user to insert text within the Part Name textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsLetter(e.KeyChar);
        }

        /// <summary>
        /// This event handler only allows the user to insert Digits within the Inventory textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// This event handler only allows the user to insert Digits within the Price textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);

        }

        /// <summary>
        /// This event handler only allows the user to insert Digits within the Min textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);

        }

        /// <summary>
        /// This event handler only allows the user to insert Digits within the Max textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);

        }

        /// <summary>
        /// This event handler only allows the user to insert Digits within the MachineID / Outsourced part textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (partsInHouseRBTN.Checked)
            {
                e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            }
            else
            {
                e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsLetter(e.KeyChar);
            }
        }
    }
}
