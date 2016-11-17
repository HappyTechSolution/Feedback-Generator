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
        public SelectTemplateElements()
        {
            InitializeComponent();
            Constants c = new Constants();

            commentsCheckedListBox.Items.AddRange(c.comments); //adds comments to checkedListBox from comment array



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
            Constants c = new Constants();
            foreach (string s in commentsCheckedListBox.CheckedItems.ToString())
            {
                c.addToComments(s);
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
