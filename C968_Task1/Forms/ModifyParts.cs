using C968_Task1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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


        public ModifyParts(mainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

        }

        /// <summary>
        /// This constructor takes in data from the inhouse class and then places them within the textbox inside the form.
        /// This allows the user to see what data they are modifying.
        /// </summary>
        /// <param name="part"></param>
        public ModifyParts(Inhouse part)
        {
            InitializeComponent();
            textBox1.Text = part.PartID.ToString();
            textBox2.Text = part.Name.ToString();
            textBox3.Text = part.InStock.ToString();
            textBox4.Text = part.Price.ToString();
            textBox5.Text = part.Min.ToString();
            textBox6.Text = part.Max.ToString();

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
        /// This event handlers checks to see if the radio button was changed and changes the text from "Machine ID" to
        /// "Company Name".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
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
                int ID = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                decimal price = decimal.Parse(textBox4.Text);
                int minStock = int.Parse(textBox5.Text);
                int maxStock = int.Parse(textBox6.Text);
                int invInStock = int.Parse(textBox3.Text);

                Inhouse inhouse = new Inhouse(ID, name, invInStock, price, minStock, maxStock);
                Inventory.updatePart(ID, inhouse);

                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Please enter valid values", "Incorrect Values Found");
            }                       
        }
    }
}
