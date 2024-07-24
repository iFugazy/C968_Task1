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

namespace C968_Task1.Forms
{
    public partial class addProductsForm : Form
    {
        mainForm MainForm = new mainForm();
        public addProductsForm(mainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {          
            var table = new BindingSource();
            table.DataSource = Inventory.AllParts;
            prodPartsDataGridView.DataSource = table;
        }
    }
}
