using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace C968_Task1
{
    public partial class ModifyParts : Form
    {
        mainForm mainForm;
        DataTable DataTable = new DataTable();
        int selectedIndex;

        public int PartID { get; set; }
        public string PartName { get; set; }
        public int PartInv { get; set; }
        public float PartPrice { get; set; }
        public int PartMin { get; set; }
        public int PartMax { get; set; }
        public ModifyParts(mainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            addPartsMachineIDLabel.Text = "Machine ID";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            addPartsMachineIDLabel.Text = "Company Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PartID = int.Parse(textBox1.Text);
                PartName = textBox2.Text;
                PartInv = int.Parse(textBox3.Text);
                PartPrice = float.Parse(textBox4.Text);
                PartMin = int.Parse(textBox5.Text);
                PartMax = int.Parse(textBox6.Text);




                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid values", "Incorrect Values Found");
            }
        }

        private void ModifyParts_Load(object sender, EventArgs e)
        {
            

            int index = mainForm.partsDataGridView.SelectedRows[0].Index; 
            DataGridViewRow selectedRow = mainForm.partsDataGridView.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
            textBox3.Text = selectedRow.Cells[2].Value.ToString();
            textBox4.Text = selectedRow.Cells[3].Value.ToString();
            textBox5.Text = selectedRow.Cells[4].Value.ToString();
            textBox6.Text = selectedRow.Cells[5].Value.ToString();

        }
    }
}
