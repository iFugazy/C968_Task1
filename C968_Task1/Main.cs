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


        private void partsAddButton_Click(object sender, EventArgs e)
        {
            addPartsForm addParts = new addPartsForm(this);
            addParts.ShowDialog();
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Part ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Inventory", typeof(int));
            table.Columns.Add("Price", typeof(float));
            table.Columns.Add("Min", typeof(int));
            table.Columns.Add("Max", typeof(int));

            dataGridView1.DataSource = table;
        }
    }
}
