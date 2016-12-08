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
    public partial class ViewFeedback : Form
    {
        public ViewFeedback()
        {
            InitializeComponent();
            
            for (int i = 0; i < Template.selectedOptionTitle.Count(); i++)
            {
                ViewAllFeedbackRichTextBox.SelectionFont = new Font(ViewAllFeedbackRichTextBox.Font, FontStyle.Bold);
                ViewAllFeedbackRichTextBox.AppendText(Template.sectionTitle[Template.secCount[i]]);
                ViewAllFeedbackRichTextBox.AppendText(Environment.NewLine);
                ViewAllFeedbackRichTextBox.SelectionFont = new Font(ViewAllFeedbackRichTextBox.Font, FontStyle.Regular);
                ViewAllFeedbackRichTextBox.AppendText(Environment.NewLine + Template.selectedOptionTitle[i]);
                ViewAllFeedbackRichTextBox.AppendText(Environment.NewLine + Template.selectedOptionComment[i] + Environment.NewLine);
                ViewAllFeedbackRichTextBox.AppendText(Environment.NewLine);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllFeedbackRichTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
