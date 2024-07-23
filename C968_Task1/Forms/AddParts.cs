
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


        public addPartsForm(mainForm mainForm)
        {
            InitializeComponent();
            this.MainForm = mainForm;

            int PartNum = Inventory.AllParts.Count + 1;
            partIDTb.Text = PartNum.ToString();



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            addPartsMachineIDLabel.Text = "Machine ID";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            addPartsMachineIDLabel.Text = "Company Name";
        }     

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();     
        }

        private void partsSaveButton_Click(object sender, EventArgs e)
        {
            Inhouse inhouse1 = new Inhouse();
            
            try
            {
                int partCount = Inventory.AllParts.Count + 1;


                PartName = partNameTB.Text;
                PartInv = int.Parse(partInvTB.Text);
                PartPrice = decimal.Parse(partPriceTB.Text);
                PartMin = int.Parse(partMinTB.Text);
                PartMax = int.Parse(partMaxTB.Text);

                

                    Inhouse inhouse = new Inhouse(partCount, PartName, PartInv, PartPrice, PartMin, PartMax);
                Inventory.addPart(inhouse);

                DialogResult = DialogResult.OK;

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid values", "Incorrect Values Found");
            }

        }
    }
}
