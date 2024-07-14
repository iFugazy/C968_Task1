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
           this.Hide();
           addPartsForm addPartForm = new addPartsForm();
           addPartForm.ShowDialog();
        }


    }
}
