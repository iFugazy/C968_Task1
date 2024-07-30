using C968_Task1.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


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

        BindingList<Part> partsAdded = new BindingList<Part>();

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
        /// This method is used to delete the selected row from the parts added data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prodDeleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this associated part?", "Delete Part", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                foreach (DataGridViewRow datarow in bottomDataGridView.SelectedRows)
                {
                    bottomDataGridView.Rows.RemoveAt(datarow.Index);
                }
            }
            else { }           
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

        /// <summary>
        /// This event is used to make sure the user only used letters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsLetter(e.KeyChar);
            textBox2.BackColor = Color.White;
        }

        /// <summary>
        /// This event is used to make sure the user only used digits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            textBox3.BackColor = Color.White;
        }

        /// <summary>
        /// This event is used to make sure the user only used digits and punctuation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsPunctuation(e.KeyChar);
            textBox4.BackColor = Color.White;
        }

        /// <summary>
        /// This event is used to make sure the user only used letters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            textBox5.BackColor = Color.White;
        }

        /// <summary>
        /// This event is used to make sure the user only used letters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            textBox6.BackColor = Color.White;
        }
    }

}
