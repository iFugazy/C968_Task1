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
        public addPartsForm()
        {
            InitializeComponent();
 
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

        // list to store input
        List<string> addPartList = new List< string >();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog();
            
        }
    }
}
