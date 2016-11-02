using System;
using System.Data;
using System.Windows.Forms;

namespace Template_Designer
{
    public partial class CreateTemplate : Form
    {
        public CreateTemplate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //fill in the grid 
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Confirm Button Click.
            CreateTemplateSections cts = new CreateTemplateSections();
            CreateNewTemplate input = new CreateNewTemplate();
            input.addTemplateName(textBox1.Text);
            input.addTemplateReviewer(textBox2.Text);
            input.addTemplatePosition(textBox3.Text);
            input.addTemplateFeedbackType(selectFeedbackTypeBox.Text);
            input.writeTemplateDetailsToDB();
            cts.ShowDialog();
        }

        private void CreateTemplate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feedbackGeneratorDBDataSet.createTemplateFeedbackType' table. You can move, or remove it, as needed.
  //          this.createTemplateFeedbackTypeTableAdapter.Fill(this.feedbackGeneratorDBDataSet.createTemplateFeedbackType);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Template Name Box.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //template reviewer box
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //template position box
        }

        private void selectFeedbackTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Template Feedback Input Box.
        }
    }
}
