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
using C968_Task1;

namespace C968_Task1
{
    public partial class mainForm : Form
    {
        addPartsForm addPartForm = new addPartsForm();
        

       
        
        public mainForm()
        {
            addPartsForm addPartForm2 = new addPartsForm();

            InitializeComponent();

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = "Darren";
            listViewItem.SubItems.Add("Add");
            listViewItem.SubItems.Add("Add");
            listViewItem.SubItems.Add("Add");
            listViewItem.SubItems.Add("Add");
            listViewItem.SubItems.Add("Add");
            partsListView.Items.Add(listViewItem);

        }

        private void partsAddButton_Click(object sender, EventArgs e)
        {
           this.Hide();
           addPartForm.ShowDialog();
        }


    }
}
