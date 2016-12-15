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
    public partial class SelectTemplateElements : Form
    {
        int optionCount = 0;
        int sectionCount = 0;

        public SelectTemplateElements()
        {
            InitializeComponent();
            //Constants c = new Constants();
            loadOptions();
             //adds comments to checkedListBox from comment array

          
            sectionNameLabel.Text = Template.sectionTitle[sectionCount];



        }
        public void loadOptions()
        {

            if (optionCount > 0)
            {
                for (int i = Template.optionsCount[optionCount]; i < Template.optionsCount[optionCount] + Template.optionsCount[optionCount]; i++)
                {
                    commentsCheckedListBox.Items.Add(Template.optionTitle[i]);
                }

            }
            else
            {
                for (int i = 0; i < Template.optionsCount[optionCount]; i++)
                {
                    commentsCheckedListBox.Items.Add(Template.optionTitle[i]);
                }
            }
        }

        private void SelectTemplateElements_Load(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void viewCommentRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void commentsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e) // selected comment in checkBox displays in richTextBox
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void previewReportButton_Click(object sender, EventArgs e)
        {
            ViewFeedback VF = new ViewFeedback(); // opens preview window if user wants to preview the feedback
            VF.ShowDialog();
        }

        private void addCommentsButton_Click(object sender, EventArgs e)
        {
            sectionCount++;
            if(sectionCount == Template.sectionID.Count())
            {
                ViewFeedback VF = new ViewFeedback(); // opens preview window if user wants to preview the feedback
                VF.ShowDialog();
                this.Close();
            }
            else
            {
                optionCount++;
                    commentsCheckedListBox.Items.Clear();
                loadOptions();
                sectionNameLabel.Text = Template.sectionTitle[sectionCount];
            }
        }

        private void viewCommentRichTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void commentsCheckedListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Template.x = Convert.ToInt32(commentsCheckedListBox.SelectedIndex);
            if (optionCount == 0)
            {
                viewCommentRichTextBox.Text = Template.optionComment[Template.x].ToString();
                Template.selectedOptionTitle.Add(Template.optionTitle[Template.x]);
                Template.selectedOptionComment.Add(Template.optionComment[Template.x]);
                Template.secCount.Add(sectionCount);
            }
            else
            {
                Template.x = Template.x + Template.optionsCount[optionCount];
                viewCommentRichTextBox.Text = Template.optionComment[Template.x].ToString();
                Template.selectedOptionTitle.Add(Template.optionTitle[Template.x]);
                Template.selectedOptionComment.Add(Template.optionComment[Template.x]);
                Template.secCount.Add(sectionCount);
            }
        }
    }
}

