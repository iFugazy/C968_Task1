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
    public partial class ModifyParts : Form
    {
        mainForm mainForm;
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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm mainForm = new mainForm();

            mainForm.dataGridView1.CurrentRow.Cells[0].Value = this.textBox1.Text;
            mainForm.dataGridView1.CurrentRow.Cells[1].Value = this.textBox2.Text;
            mainForm.dataGridView1.CurrentRow.Cells[2].Value = this.textBox3.Text;
            mainForm.dataGridView1.CurrentRow.Cells[3].Value = this.textBox4.Text;
            mainForm.dataGridView1.CurrentRow.Cells[4].Value = this.textBox5.Text;
            mainForm.dataGridView1.CurrentRow.Cells[5].Value = this.textBox6.Text;
        }
    }
}
