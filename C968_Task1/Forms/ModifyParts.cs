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
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;

            try
            {
                minStock = int.Parse(textBox5.Text);
                maxStock = int.Parse(textBox6.Text);
                invInStock = int.Parse(textBox3.Text);
                price = decimal.Parse(textBox4.Text);



                



                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid values", "Incorrect Values Found");
            }

            int ID = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            price = decimal.Parse(textBox4.Text);
            minStock = int.Parse(textBox5.Text);
            maxStock = int.Parse(textBox6.Text);
            invInStock = int.Parse(textBox3.Text);

            Inhouse inhouse = new Inhouse(ID, name, invInStock, price, minStock, maxStock);
            Inventory.updatePart(ID, inhouse);
        }

/*        private void ModifyParts_Load(object sender, EventArgs e)
        {
            int index = mainForm.partsDataGridView.SelectedRows[0].Index; 
            DataGridViewRow selectedRow = mainForm.partsDataGridView.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
            textBox3.Text = selectedRow.Cells[3].Value.ToString();
            textBox4.Text = selectedRow.Cells[2].Value.ToString();
            textBox5.Text = selectedRow.Cells[4].Value.ToString();
            textBox6.Text = selectedRow.Cells[5].Value.ToString();
        }*/
    }
}
