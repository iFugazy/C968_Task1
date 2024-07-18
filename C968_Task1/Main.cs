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
            addPartsForm addPartForm = new addPartsForm(this);
            addPartForm.ShowDialog();


        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            
            addPartsForm _addPartsForm = new addPartsForm(this);
            _addPartsForm.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            _addPartsForm.ShowDialog();
            
        }
    }
}
