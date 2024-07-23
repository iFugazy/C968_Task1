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
        DataTable dataTable = new DataTable();
       
        public mainForm()
        {
            InitializeComponent();
            

        }

        private void partsAddButton_Click(object sender, EventArgs e)
        {
            addPartsForm addParts = new addPartsForm(this);
            addParts.ShowDialog();
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow datarow in partsDataGridView.SelectedRows)
            {
                

                partsDataGridView.Rows.RemoveAt(datarow.Index);
                
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = partsDataGridView.SelectedRows[0].Index;
            ModifyParts modifyParts = new ModifyParts(this);
            DataGridViewRow row = partsDataGridView.Rows[selectedIndex];

            
            
            if (modifyParts.ShowDialog() == DialogResult.OK)
            {
                int partID = modifyParts.PartID;
                string partName = modifyParts.PartName;
                int partInventory = modifyParts.PartInv;
                decimal partPrice = modifyParts.PartPrice;
                int partMin = modifyParts.PartMin;
                int partMax = modifyParts.PartMax;





            }
        }

        private void mainForm_Load_1(object sender, EventArgs e)
        {
            Inventory.ExampleItems();
            Inventory.ExampleItems();
            Inventory.ExampleItems();
            Inventory.ExampleItems();
            Inventory.ExampleItems();
            Inventory.ExampleItems();
            Inventory.ExampleItems();


            var table = new BindingSource();
            table.DataSource = Inventory.AllParts;
            partsDataGridView.DataSource = table;

           

            //this.partsDataGridView.Sort(this.partsDataGridView.Columns[0], ListSortDirection.Ascending);
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
     
        }


    }
}
