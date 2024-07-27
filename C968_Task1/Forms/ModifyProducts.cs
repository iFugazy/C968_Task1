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
using C968_Task1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace C968_Task1.Forms
{
    public partial class ModifyProducts : Form
    {
        public int ProductID { get; internal set; }
        public string ProductName { get; internal set; }
        public decimal ProductPrice { get; internal set; }
        public int ProductMin { get; internal set; }
        public int ProductMax { get; internal set; }
        public int ProductInv { get; internal set; }
        public new string CompanyName { get; set; }
        BindingList<Part> partsAdded = new BindingList<Part> ();
       
        public ModifyProducts()
        {
            InitializeComponent();
        }
        public ModifyProducts(Product product)
        {
            InitializeComponent();
            textBox1.Text = product.ProductID.ToString();
            textBox2.Text = product.Name;
            textBox4.Text = product.Price.ToString();
            textBox3.Text = product.InStock.ToString();
            textBox5.Text = product.Min.ToString();
            textBox6.Text = product.Max.ToString();

            BindingSource topTable = new BindingSource();
            topTable.DataSource = Inventory.AllParts;
            topDataGridView.DataSource = topTable;
             
            foreach (Part part in product.AssociatedParts)
            {
                partsAdded.Add(part);
            }
            var botTable = new BindingSource();
            botTable.DataSource = partsAdded;
            bottomDataGridView.DataSource = botTable;

        }

        private void prodAddBTN_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)topDataGridView.CurrentRow.DataBoundItem;
            partsAdded.Add(partToAdd);
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

            string name = textBox2.Text;
            int inventory = int.Parse(textBox3.Text);
            decimal price = decimal.Parse(textBox4.Text);
            int min = int.Parse(textBox5.Text);
            int max = int.Parse(textBox6.Text);
            int productID = int.Parse(textBox1.Text);

            if (min > max)
            {
                MessageBox.Show("Minimum amount of products is greater than the maximum amount", "Min is greater than Max");
                return;
            }

            if (inventory > max)
            {
                MessageBox.Show("Inventory amount is greater than the maxium", "Inventory Error");
                return;
            }

            if (inventory < min)
            {
                MessageBox.Show("Inventory amount is less than the minimum", "Inventory Error");
                return;
            }

            Product product = new Product(productID, name, inventory, price, min, max);
            Inventory.updateProduct(productID, product);

            foreach (Part part in partsAdded)
            {
                product.addAssociatedPart(part);
            }
            
            this.Close();
        }
    }
    
}
