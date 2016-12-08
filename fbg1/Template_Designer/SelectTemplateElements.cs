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
<<<<<<< HEAD
        int optionCount = 0;
        int sectionCount = 0;
=======
        int sectionCount = 0;
        int optionCount = 0;
>>>>>>> 8f7e52aa6e8de6edf4cc874015767d490a90d89b

        public SelectTemplateElements()
        {
            InitializeComponent();
            //Constants c = new Constants();
            loadOptions();
             //adds comments to checkedListBox from comment array
<<<<<<< HEAD

          
            sectionNameLabel.Text = Template.sectionTitle[sectionCount];

=======

          
            sectionNameLabel.Text = Template.sectionTitle[sectionCount];
>>>>>>> 8f7e52aa6e8de6edf4cc874015767d490a90d89b


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
        public void loadOptions()
        {
            //Template.optionsCount[optionCount];
            for(int i = 0; i < Template.optionsCount[optionCount]; i++)
            {
                commentsCheckedListBox.Items.Add(Template.optionTitle[i]);
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
<<<<<<< HEAD
=======

>>>>>>> 8f7e52aa6e8de6edf4cc874015767d490a90d89b
            sectionCount++;
            if(sectionCount == Template.sectionID.Count())
            {
                this.Close();
            }
            else
            {
<<<<<<< HEAD
                optionCount++;
                    commentsCheckedListBox.Items.Clear();
                loadOptions();
                sectionNameLabel.Text = Template.sectionTitle[sectionCount];
            }
=======
                sectionNameLabel.Text = Template.sectionTitle[sectionCount];
            }
            
            

            
            
            
            
            

>>>>>>> 8f7e52aa6e8de6edf4cc874015767d490a90d89b
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

