using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template_Designer
{
    public partial class TemplateSelector : Form
    {
        public TemplateSelector()
        {
            InitializeComponent();
            Constants c = new Constants();
            comboBox1.Items.AddRange(c.tempNames);
        }
        // When create new template button clicked: open 'CreateTemplate' class
        private void createNewTemplate_button_Click(object sender, EventArgs e)
        {
            CreateTemplate CP = new CreateTemplate();
            CP.ShowDialog();
        }

        private void feedBack_Click(object sender, EventArgs e)
        {
            SelectTemplateElements sfe = new SelectTemplateElements();
            sfe.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
