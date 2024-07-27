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
        public int ProdMax { get; set; }
        public int ProdMin { get; set; }

        public addProductsForm(mainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            int ProductNum = Inventory.Products.Count + 1;
            textBox1.Text = ProductNum.ToString();

            prodNameTB.BackColor = Color.IndianRed;
            prodInvTB.BackColor = Color.IndianRed;
            prodPriceTB.BackColor = Color.IndianRed;
            prodMaxTB.BackColor = Color.IndianRed;
            prodMinTB.BackColor = Color.IndianRed;
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

            string name = prodNameTB.Text;
            int inventory = int.Parse(prodInvTB.Text);
            decimal price = decimal.Parse(prodPriceTB.Text);
            int max = int.Parse(prodMinTB.Text);
            int min = int.Parse(prodMaxTB.Text);

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

            Product product = new Product((Inventory.Products.Count + 1), name, inventory, price, min, max);
            Inventory.addProduct(product);

            foreach (Part part in partsAdded)
            {
                product.addAssociatedPart(part);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar);
            prodNameTB.BackColor = Color.White;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsControl(e.KeyChar);
            prodInvTB.BackColor = Color.White;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsControl(e.KeyChar);
            prodPriceTB.BackColor = Color.White;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsControl(e.KeyChar);
            prodMinTB.BackColor = Color.White;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsControl(e.KeyChar);
            prodMaxTB.BackColor = Color.White;
        }
    }
}
