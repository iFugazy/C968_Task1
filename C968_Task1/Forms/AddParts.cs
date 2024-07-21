using C968_Task1.Calculations;
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
        public int PartID { get; set; }
        public string PartName { get; set; }
        public int PartInv { get; set; }
        public double PartPrice { get; set; }
        public int PartMin { get; set; }
        public int PartMax { get; set; }


        public addPartsForm(mainForm mF)
        {
            InitializeComponent();
            this.MainForm = mF;



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            addPartsMachineIDLabel.Text = "Machine ID";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            addPartsMachineIDLabel.Text = "Company Name";
        }
        // Declaring Variables being used
        DataTable table = new DataTable();


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float.TryParse(partPriceTB.Text, out float FloatPartPrice);
            try
            {

                PartID = int.Parse(partIDTb.Text);
                PartName = partNameTB.Text;
                PartInv = int.Parse(partInvTB.Text);
                PartPrice = FloatPartPrice;
                PartMin = int.Parse(partMinTB.Text);
                PartMax = int.Parse(partMaxTB.Text);

                DialogResult = DialogResult.OK;







            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid values", "Incorrect Values Found");
            }

        }

    }
}
