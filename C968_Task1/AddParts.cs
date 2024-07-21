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
        mainForm MainForm;
       
        public addPartsForm(mainForm mF)
        {
            InitializeComponent();
            this.MainForm = mF;



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
        DataTable table = new DataTable();


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                MainForm.dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid values", "Incorrect Values Found");
            }
           


            


             

        }

        private void addPartsForm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Part ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Inventory", typeof(int));
            table.Columns.Add("Price", typeof(float));
            table.Columns.Add("Min", typeof(int));
            table.Columns.Add("Max", typeof(int));

            MainForm.dataGridView1.DataSource = table;
        }
    }
}
