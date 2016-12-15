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

        public void SaveMyFile()
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                ViewAllFeedbackRichTextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllFeedbackRichTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveMyFile();
            this.Close();
        }
    }
}
