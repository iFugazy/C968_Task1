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
            if (addParts.ShowDialog() == DialogResult.OK)
            {
                int partID = addParts.PartID;
                string partName = addParts.PartName;
                int partInventory = addParts.PartInv;
                double partPrice = addParts.PartPrice;
                int partMin = addParts.PartMin;
                int partMax = addParts.PartMax;

                dataTable.Rows.Add(partID, partName, partInventory, partPrice, partMin, partMax);
            }
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.RemoveAt(selectedIndex);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            ModifyParts modifyParts = new ModifyParts(this);
            DataGridViewRow row = dataGridView1.Rows[selectedIndex];
            
            
            if (modifyParts.ShowDialog() == DialogResult.OK)
            {
                int partID = modifyParts.PartID;
                string partName = modifyParts.PartName;
                float partPrice = modifyParts.PartPrice;
                int partMin = modifyParts.PartMin;
                int partMax = modifyParts.PartMax;
                int partInventory= modifyParts.PartInv;

                row.Cells[0].Value = modifyParts.textBox1.Text;
                row.Cells[1].Value = modifyParts.textBox2.Text;
                row.Cells[2].Value = modifyParts.textBox3.Text;
                row.Cells[3].Value = modifyParts.textBox4.Text;
                row.Cells[4].Value = modifyParts.textBox5.Text;
                row.Cells[5].Value = modifyParts.textBox6.Text;



            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Part ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Inventory", typeof(int));
            dataTable.Columns.Add("Price", typeof(float));
            dataTable.Columns.Add("Min", typeof(int));
            dataTable.Columns.Add("Max", typeof(int));

            dataTable.Rows.Add(1, "Darren", 1.0, 1.23, 5, 1);
            dataTable.Rows.Add(2, "Fuck", 2.0, 1.23, 2, 1);
            dataTable.Rows.Add(3, "Den", 3.4, 1.12, 1, 1);
            dataTable.Rows.Add(4, "Lol", 1.2, 4.42, 1, 2);


            dataGridView1.DataSource = dataTable;
        }
    }
}
