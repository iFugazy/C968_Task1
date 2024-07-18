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
           addPartsForm addPartForm = new addPartsForm(this.dataSet1BindingSource);
           addPartForm.ShowDialog();

            this.Validate();
            this.dataSet1BindingSource.EndEdit();
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            this.dataTable1BindingSource.RemoveCurrent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
