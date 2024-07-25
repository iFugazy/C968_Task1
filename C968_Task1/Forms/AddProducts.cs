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
        
        BindingList<Part> addedParts = new BindingList<Part>();
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
        }



        private void AddProducts_Load(object sender, EventArgs e)
        {          
            var table = new BindingSource();
            table.DataSource = Inventory.AllParts;
            topDataGridView.DataSource = table;

            var table2 = new BindingSource();
            table2.DataSource = addedParts;
            bottomDataGridView.DataSource = table2;
        }

        private void prodAddBTN_Click(object sender, EventArgs e)
        {
            if (topDataGridView.SelectedRows.Count == 1)
            {
                Part addParts = (Part)topDataGridView.SelectedRows[0].DataBoundItem;
                addedParts.Add(addParts);
            }
            else if (topDataGridView.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow row in topDataGridView.SelectedRows)
                {
                    Part addParts = (Part)topDataGridView.SelectedRows[row.Index].DataBoundItem;
                    addedParts.Add(addParts);
                }
            }
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
            try
            {
                ProdID = Inventory.Products.Count + 1;
                ProdName = textBox2.Text;
                ProdInstock = int.Parse(textBox3.Text);
                ProdPrice = decimal.Parse(textBox4.Text);
                ProdMin = int.Parse(textBox5.Text);
                ProdMax = int.Parse(textBox6.Text);               

                Product product = new Product(ProdID, ProdName, ProdInstock, ProdPrice, ProdMax, ProdMin);
                Inventory.addProduct(product);
                                                  
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Please enter valid values", "Incorrect Values Found");
            }
        }
    }
}
