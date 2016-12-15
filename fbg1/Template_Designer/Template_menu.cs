using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Template_Designer
{
    public partial class TemplateSelector : Form
    {

        public TemplateSelector()
        {
            InitializeComponent();

            //displays the list of templates
            List<string> templateNames = getTemplateNames();
            foreach (string item in templateNames)
            {
                comboBox1.Items.Add(item);
            }

        }

        static List<string> getTemplateNames()
        {
            //gets the templatenames
            List<string> templateNames = DBConnection.getDBConnectionToInstance().displayTemplateNames(Constants.select);

            return templateNames;
        }


        // When create new template button clicked: open 'CreateTemplate' class
        private void createNewTemplate_button_Click(object sender, EventArgs e)
        {
            CreateTemplate CP = new CreateTemplate();
            CP.ShowDialog();
        }

        public void feedBack_Click(object sender, EventArgs e)
        {
            // launches next window
            SelectTemplateElements sfe = new SelectTemplateElements();
            sfe.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Template T = new Template();
            T.getTName(comboBox1.SelectedItem.ToString());
            T.getTID();
            T.getTReviewer();
            T.getTPosition();
            T.getSecIDs();
            T.getSecTitles();
            T.getOptIDs();
            T.getOptTitles();
            T.getOptComments();
        }

      
    }
}
