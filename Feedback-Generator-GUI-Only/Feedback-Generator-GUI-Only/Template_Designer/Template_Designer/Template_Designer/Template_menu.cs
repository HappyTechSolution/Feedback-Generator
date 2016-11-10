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
        }
        // When create new template button clicked: open 'CreateTemplate' class
        private void createNewTemplate_button_Click(object sender, EventArgs e)
        {
            CreateTemplate CP = new CreateTemplate();
            CP.ShowDialog();
        }
    }
}
