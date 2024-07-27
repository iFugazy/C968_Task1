using C968_Task1.Forms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace C968_Task1
{
    public partial class mainForm : Form
    {      
        public mainForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// This event handler listens for the add button to be clicked and then opens the addParts form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partsAddButton_Click(object sender, EventArgs e)
        {
            addPartsForm addParts = new addPartsForm(this);
            addParts.ShowDialog();
        }

        /// <summary>
        /// This event handler listens for the delete button to be clicked and then takes the selected row of data and removes it based off its 
        /// index within the datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
               
                foreach (DataGridViewRow datarow in partsDataGridView.SelectedRows)
                {
                    partsDataGridView.Rows.RemoveAt(datarow.Index);
                }
            }
            else { }            
        }

        /// <summary>
        /// This event handler listens for the exit button to be clicked and then closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This event handler listens for the the modify button to be clicked and then pulls up the modifyParts form. After the form's save button
        /// is clicked, the partID text box is compared to the datagridview row that is selected. The selected row is then removed and replaced with 
        /// the data that was added within the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(C968_Task1.Models.Inhouse))
            {
                Inhouse inhouse = (Inhouse)partsDataGridView.CurrentRow.DataBoundItem;
                new ModifyParts(inhouse).ShowDialog();
            }
            else
            {
                Outsourced outsourced = (Outsourced)partsDataGridView.CurrentRow.DataBoundItem;
                new ModifyParts(outsourced).ShowDialog();
            }
        }

        /// <summary>
        /// This event handler listens for the form to be loaded an then loads the data from the bindinglist within the Inventory class into the datagrid 
        /// view for the parts and the products. This also loads the data from the example in the GUI and places it into the datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_Load_1(object sender, EventArgs e)
        {
            Inventory.GUIExampleItems();

            var table = new BindingSource();
            table.DataSource = Inventory.AllParts;
            partsDataGridView.DataSource = table;

            var table2 = new BindingSource();
            table2.DataSource = Inventory.Products;
            productsDataGridView.DataSource = table2;
        }

        /// <summary>
        /// This event handler is used for the search function. It works by taking the search text box that is correlating with the products datagridview 
        /// and comparing it to the value in the first cell of of all the rows and the 2nd sell of all the rows. It then checks to see
        /// if the value is null or if it is equal to the textbox and then highlghts the row in the datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            partsDataGridView.ClearSelection();
            string searchValue = partsTextBox.Text;
            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            
            bool valueResult = false;
            foreach (DataGridViewRow row in partsDataGridView.Rows)
            {               
                    if (row.Cells[0].Value.ToString().ToLower() != null && row.Cells[0].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                    {
                        int rowIndex = row.Index;
                        partsDataGridView.Rows[rowIndex].Selected = true;
                        valueResult = true;
                        break;
                    }
                    else if (row.Cells[1].Value.ToString().ToLower() != null && row.Cells[1].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                    {
                        int rowIndex = row.Index;
                        partsDataGridView.Rows[rowIndex].Selected = true;
                        valueResult = true;
                        break;
                    }                   
            }
            if (!valueResult)
            {
                if (partsTextBox.Text == null)
                {
                    MessageBox.Show("TextBox is blank", "Search Failed");
                }
                else
                {
                    MessageBox.Show($"{partsTextBox.Text} is not a value in the list ", "Search Failed");
                }                
            }           
        }

        /// <summary>
        /// This event handler listens for the add button to be clicked and then opens the addProducts form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productsAddButton_Click(object sender, EventArgs e)
        {
            addProductsForm addProducts = new addProductsForm(this);
            addProducts.ShowDialog();
        }

        /// <summary>
        /// This event handler listens for the the modify button to be clicked and then pulls up the modifyProducts form. After the form's save button
        /// is clicked, the productID text box is compared to the datagridview row that is selected. The selected row is then removed and replaced with 
        /// the data that was added within the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productsModifyButton_Click(object sender, EventArgs e)
        {
            Product product = (Product)productsDataGridView.CurrentRow.DataBoundItem;
            new ModifyProducts(product).ShowDialog();
        }

        /// <summary>
        /// This event handler is used for the search function. It works by taking the search text box that is correlating with the products datagridview 
        /// and comparing it to the value in the first cell of of all the rows and the 2nd sell of all the rows. It then checks to see
        /// if the value is null or if it is equal to the textbox and then highlghts the row in the datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            productsDataGridView.ClearSelection();
            string searchValue = productsTextBox.Text;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            bool valueResult = false;
            foreach (DataGridViewRow row in productsDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower() != null && row.Cells[0].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                {
                    int rowIndex = row.Index;
                    productsDataGridView.Rows[rowIndex].Selected = true;
                    valueResult = true;
                    break;
                }
                else if (row.Cells[1].Value.ToString().ToLower() != null && row.Cells[1].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                {
                    int rowIndex = row.Index;
                    productsDataGridView.Rows[rowIndex].Selected = true;
                    valueResult = true;
                    break;
                }
            }
            if (!valueResult)
            {
                if (productsTextBox.Text == null)
                {
                    MessageBox.Show("TextBox is blank", "Search Failed");
                }
                else
                {
                    MessageBox.Show($"{productsTextBox.Text} is not a value in the list ", "Search Failed");
                }
            }
        }

        /// <summary>
        /// This event handler listens for the delete button to be clicked and then takes the selected row of data and removes it based off its 
        /// index within the datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow datarow in productsDataGridView.SelectedRows)
                {
                    productsDataGridView.Rows.RemoveAt(datarow.Index);
                }
            }
            else { }
        }
    }
}
