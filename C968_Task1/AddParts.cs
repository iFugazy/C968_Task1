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


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             MainForm.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text);
             

        }

    }
}
