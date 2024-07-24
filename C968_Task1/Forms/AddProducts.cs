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

namespace C968_Task1.Forms
{
    public partial class addProductsForm : Form
    {
        mainForm MainForm = new mainForm();
        Product Product = new Product();
        BindingList<Part> addedParts = new BindingList<Part>();
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
                Part addParts = (Part)topDataGridView.CurrentRow.DataBoundItem;
                addedParts.Add(addParts);
            }
            else
            {
                foreach (DataGridViewRow row in topDataGridView.SelectedRows)
                {
                    Part addParts = (Part)topDataGridView.SelectedRows[row.Index].DataBoundItem;
                    addedParts.Add(addParts);
                }
            }
        }
    }
}
