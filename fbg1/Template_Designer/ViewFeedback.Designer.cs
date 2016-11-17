namespace Template_Designer
{
    partial class ViewFeedback
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ViewAllFeedbackRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewAllFeedbackRichTextBox
            // 
            this.ViewAllFeedbackRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.ViewAllFeedbackRichTextBox.Name = "ViewAllFeedbackRichTextBox";
            this.ViewAllFeedbackRichTextBox.ReadOnly = true;
            this.ViewAllFeedbackRichTextBox.Size = new System.Drawing.Size(462, 384);
            this.ViewAllFeedbackRichTextBox.TabIndex = 1;
            this.ViewAllFeedbackRichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewAllFeedbackRichTextBox);
            this.Name = "ViewFeedback";
            this.Text = "ViewFeedback";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ViewAllFeedbackRichTextBox;
        private System.Windows.Forms.Button button1;
    }
}