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
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewAllFeedbackRichTextBox
            // 
            this.ViewAllFeedbackRichTextBox.Location = new System.Drawing.Point(18, 18);
            this.ViewAllFeedbackRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewAllFeedbackRichTextBox.Name = "ViewAllFeedbackRichTextBox";
            this.ViewAllFeedbackRichTextBox.ReadOnly = true;
            this.ViewAllFeedbackRichTextBox.Size = new System.Drawing.Size(691, 589);
            this.ViewAllFeedbackRichTextBox.TabIndex = 1;
            this.ViewAllFeedbackRichTextBox.Text = "";
            this.ViewAllFeedbackRichTextBox.TextChanged += new System.EventHandler(this.ViewAllFeedbackRichTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 625);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(585, 625);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(109, 37);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 674);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewAllFeedbackRichTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewFeedback";
            this.Text = "ViewFeedback";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ViewAllFeedbackRichTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveButton;
    }
}