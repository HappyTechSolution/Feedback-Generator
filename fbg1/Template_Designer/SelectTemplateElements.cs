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
        int sectionCount = 0;
        int optionCount = 0;

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

            sectionCount++;
            if(sectionCount == Template.sectionID.Count())
            {
                this.Close();
            }
            else
            {
                sectionNameLabel.Text = Template.sectionTitle[sectionCount];
            }
            
            

            
            
            
            
            

        }

        private void viewCommentRichTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void commentsCheckedListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            viewCommentRichTextBox.Text = commentsCheckedListBox.SelectedItem.ToString(); //Add comments from section 
        }
    }
}

