using C968_Task1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968_Task1.Forms
{
    public partial class addProductsForm : Form
    {
        mainForm MainForm = new mainForm();
        
        BindingList<Part> partsAdded = new BindingList<Part>();
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public int ProdInstock { get; set; }
        public decimal ProdPrice { get; set; }
        public int ProdMin { get; set; }
        public int ProdMax { get; set; }

        public addProductsForm(mainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            int ProductNum = Inventory.Products.Count + 1;
            textBox1.Text = ProductNum.ToString();
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {          
            var table = new BindingSource();
            table.DataSource = Inventory.AllParts;
            topDataGridView.DataSource = table;

            var table2 = new BindingSource();
            table2.DataSource = partsAdded;
            bottomDataGridView.DataSource = table2;
        }

        private void prodAddBTN_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)topDataGridView.CurrentRow.DataBoundItem;
            partsAdded.Add(partToAdd);

        }

        private void prodCancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prodDeleteBTN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow datarow in bottomDataGridView.SelectedRows)
            {
                bottomDataGridView.Rows.RemoveAt(datarow.Index);
            }
        }

        private void prodSearchBTN_Click(object sender, EventArgs e)
        {
            topDataGridView.ClearSelection();
            string searchValue = addProdTB.Text;
            topDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            bool valueResult = false;
            foreach (DataGridViewRow row in topDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower() != null && row.Cells[0].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                {
                    int rowIndex = row.Index;
                    topDataGridView.Rows[rowIndex].Selected = true;
                    valueResult = true;
                    break;
                }
                else if (row.Cells[1].Value.ToString().ToLower() != null && row.Cells[1].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                {
                    int rowIndex = row.Index;
                    topDataGridView.Rows[rowIndex].Selected = true;
                    valueResult = true;
                    break;
                }
            }
            if (!valueResult)
            {
                if (addProdTB.Text == "")
                {
                    MessageBox.Show("TextBox is blank", "Search Failed");
                }
                else
                {
                    MessageBox.Show($"{addProdTB.Text} is not a value in the list ", "Search Failed");
                }
            }
        }

        private void prodSaveBTN_Click(object sender, EventArgs e)
        {
            int inventory;
            int min;
            int max;
            decimal price;

            try
            {
                min = int.Parse(textBox5.Text);
                max = int.Parse(textBox6.Text);
                inventory = int.Parse(textBox3.Text);
                price = decimal.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }

            string name = textBox2.Text;
            inventory = int.Parse(textBox3.Text);
            price = decimal.Parse(textBox4.Text);
            min = int.Parse(textBox6.Text);
            max = int.Parse(textBox5.Text);

            if (min > max)
            {
                MessageBox.Show("Minimum amount of products is greater than the maximum amount", "Min is greater than Max");
            }

            if (inventory > max)
            {
                MessageBox.Show("Inventory amount is greater than the maxium", "Inventory Error");
            }

            if (inventory < min)
            {
                MessageBox.Show("Inventory amount is less than the minimum", "Inventory Error");
            }

            Product product = new Product((Inventory.Products.Count + 1), name, inventory, price, max, min);
            Inventory.addProduct(product);

            foreach (Part part in partsAdded)
            {
                product.addAssociatedPart(part);
            }
        }
    }
}
