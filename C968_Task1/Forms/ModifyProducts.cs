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
            textBox3.Text = product.Price.ToString();
            textBox4.Text = product.Instock.ToString();
            textBox5.Text = product.Max.ToString();
            textBox6.Text = product.Min.ToString();

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
        private void ModifyProducts_Load(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;
            textBox3.BackColor = Color.Red;
            textBox4.BackColor = Color.Red;
            textBox5.BackColor = Color.Red;
            textBox6.BackColor = Color.Red;


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

            //creates new Product and adds it to inventory
            Product product = new Product((Inventory.Products.Count + 1), name, inventory, price, max, min);
            Inventory.updateProduct(Inventory.Products.Count, product);

            foreach (Part part in partsAdded)
            {
                product.addAssociatedPart(part);
            }
        }
    }
    
}
