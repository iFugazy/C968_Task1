using C968_Task1.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

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

        /// <summary>
        /// This constructor takes in the mainform to receive information from that class. It makes the 
        /// backcolor of all the textboxes red initially to indicate that the user needs to enter
        /// information in.
        /// </summary>
        /// <param name="mainForm"></param>
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

        /// <summary>
        /// This method populates the datagridviews for the parts and the parts added table within this form
        /// when it is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProducts_Load(object sender, EventArgs e)
        {
            var table = new BindingSource();
            table.DataSource = Inventory.AllParts;
            topDataGridView.DataSource = table;

            var table2 = new BindingSource();
            table2.DataSource = partsAdded;
            bottomDataGridView.DataSource = table2;
        }

        /// <summary>
        /// This method takes the data from the selected row and adds it the the bottom datagridview allowing the user
        /// to associate the parts to the product.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prodAddBTN_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)topDataGridView.CurrentRow.DataBoundItem;
            partsAdded.Add(partToAdd);

        }

        /// <summary>
        /// This method closes the form and reverts the application to the previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prodCancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This method is used to delete the selected row from the parts added data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prodDeleteBTN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow datarow in bottomDataGridView.SelectedRows)
            {
                bottomDataGridView.Rows.RemoveAt(datarow.Index);
            }
        }

        /// <summary>
        /// This method is used to search the datagridview by characters that are contained within the first
        /// two columns.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method checks to see a few conditions and then parsing the the information which is then 
        /// used to add the data to the list which in return adds the data to the table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this.Close();
        }

        /// <summary>
        /// This event is used to make sure the user only used letters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar);
            prodNameTB.BackColor = Color.White;
        }

        /// <summary>
        /// This event is used to make sure the user only used digits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            prodInvTB.BackColor = Color.White;
        }

        /// <summary>
        /// This event is used to make sure the user only used letters and punctuations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsPunctuation(e.KeyChar);
            prodPriceTB.BackColor = Color.White;
        }

        /// <summary>
        /// This event is used to make sure the user only used digits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            prodMinTB.BackColor = Color.White;
        }

        /// <summary>
        /// This event is used to make sure the user only used digits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            prodMaxTB.BackColor = Color.White;
        }
    }
}
