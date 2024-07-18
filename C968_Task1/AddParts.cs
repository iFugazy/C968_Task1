using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Task1
{
    public partial class addPartsForm : Form
    {
        private BindingSource bindingSource;
        public addPartsForm(BindingSource sourceName)
        {
            InitializeComponent();
            this.bindingSource = sourceName;
 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            addPartsMachineIDLabel.Text = "Machine ID";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            addPartsMachineIDLabel.Text = "Company Name";
        }
        // Declaring Variables being used


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();  
            mainForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataRowView dataRow = (DataRowView)this.bindingSource.AddNew();
            dataRow[1] = this.textBox1.Text;
            dataRow[2] = this.textBox2.Text;
            dataRow[3] = this.textBox3.Text;
            dataRow[4] = this.textBox4.Text;
            dataRow.EndEdit();


        }

    }
}
