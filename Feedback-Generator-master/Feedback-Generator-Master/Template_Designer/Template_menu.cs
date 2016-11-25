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

        private void TemplateSelector_Load(object sender, EventArgs e)
        {
            DataSet clDs = DBConnection.getDBConnectionToInstance().getDataSet("SELECT templateName FROM createTemplate");
            cbCl.DataSource = clDs.Tables[0];
            cbCl.DisplayMember = "templateName";
            // TODO: This line of code loads data into the 'templateNameDataSet.createTemplate' table. You can move, or remove it, as needed.
            this.createTemplateTableAdapter.Fill(this.templateNameDataSet.createTemplate);

        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            editTemplate edit = new editTemplate();
            editMenu fillEdit = new editMenu();
            edit.addEditTemplateName(comboBox1.Text);
            edit.getLatestEditTemplateID();
            edit.getLatestEditSectionID();
            edit.getLastestEditOptionsID();
            fillEdit.createTBEditTemplate();
            fillEdit.fillEditTemplate();
            fillEdit.fillEditSection();
            fillEdit.fillEditOption();
            fillEdit.fillEditOptionComment();
            fillEdit.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                ctl.ResetBindings();
            }
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            removeTemplate remove = new removeTemplate();
            removeTemplateWarning removeWarning = new removeTemplateWarning();
            remove.addTemplateName(comboBox1.Text);
            removeWarning.ShowDialog();
        }

        private void TemplateSelector_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Focus");
            DataSet clDs = DBConnection.getDBConnectionToInstance().getDataSet("SELECT TemplateName FROM CreateTemplate");
            cbCl.DataSource = clDs.Tables[0];
            cbCl.DisplayMember = "templateName";

         }
    }
}
