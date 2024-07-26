using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C968_Task1.Models;


namespace C968_Task1.Forms
{
    public partial class ModifyProducts : Form
    {
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
            
        }
    }
}
