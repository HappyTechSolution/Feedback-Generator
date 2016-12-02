namespace Template_Designer
{
    partial class SelectTemplateElements
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
            this.previewReportButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sectionNameLabel = new System.Windows.Forms.Label();
            this.viewCommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.commentsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SkipCommentButton = new System.Windows.Forms.Button();
            this.addCommentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // previewReportButton
            // 
            this.previewReportButton.Location = new System.Drawing.Point(354, 12);
            this.previewReportButton.Name = "previewReportButton";
            this.previewReportButton.Size = new System.Drawing.Size(97, 23);
            this.previewReportButton.TabIndex = 18;
            this.previewReportButton.Text = "Preview Report";
            this.previewReportButton.UseVisualStyleBackColor = true;
            this.previewReportButton.Click += new System.EventHandler(this.previewReportButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "View comment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select comments from template:";
            // 
            // sectionNameLabel
            // 
            this.sectionNameLabel.AutoSize = true;
            this.sectionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionNameLabel.Location = new System.Drawing.Point(13, 13);
            this.sectionNameLabel.Name = "sectionNameLabel";
            this.sectionNameLabel.Size = new System.Drawing.Size(0, 13);
            this.sectionNameLabel.TabIndex = 15;
            // 
            // viewCommentRichTextBox
            // 
            this.viewCommentRichTextBox.Location = new System.Drawing.Point(234, 57);
            this.viewCommentRichTextBox.Name = "viewCommentRichTextBox";
            this.viewCommentRichTextBox.ReadOnly = true;
            this.viewCommentRichTextBox.Size = new System.Drawing.Size(219, 199);
            this.viewCommentRichTextBox.TabIndex = 14;
            this.viewCommentRichTextBox.Text = "";
            this.viewCommentRichTextBox.TextChanged += new System.EventHandler(this.viewCommentRichTextBox_TextChanged_1);
            // 
            // commentsCheckedListBox
            // 
            this.commentsCheckedListBox.FormattingEnabled = true;
            this.commentsCheckedListBox.Location = new System.Drawing.Point(12, 57);
            this.commentsCheckedListBox.Name = "commentsCheckedListBox";
            this.commentsCheckedListBox.Size = new System.Drawing.Size(216, 199);
            this.commentsCheckedListBox.TabIndex = 13;
            this.commentsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.commentsCheckedListBox_SelectedIndexChanged_1);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 278);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SkipCommentButton
            // 
            this.SkipCommentButton.Location = new System.Drawing.Point(248, 278);
            this.SkipCommentButton.Name = "SkipCommentButton";
            this.SkipCommentButton.Size = new System.Drawing.Size(100, 23);
            this.SkipCommentButton.TabIndex = 11;
            this.SkipCommentButton.Text = "Skip Section";
            this.SkipCommentButton.UseVisualStyleBackColor = true;
            // 
            // addCommentsButton
            // 
            this.addCommentsButton.Location = new System.Drawing.Point(354, 278);
            this.addCommentsButton.Name = "addCommentsButton";
            this.addCommentsButton.Size = new System.Drawing.Size(99, 23);
            this.addCommentsButton.TabIndex = 10;
            this.addCommentsButton.Text = "Add Comments";
            this.addCommentsButton.UseVisualStyleBackColor = true;
            this.addCommentsButton.Click += new System.EventHandler(this.addCommentsButton_Click);
            // 
            // SelectTemplateElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 309);
            this.Controls.Add(this.previewReportButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sectionNameLabel);
            this.Controls.Add(this.viewCommentRichTextBox);
            this.Controls.Add(this.commentsCheckedListBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SkipCommentButton);
            this.Controls.Add(this.addCommentsButton);
            this.Name = "SelectTemplateElements";
            this.Text = "SelectTemplateElements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Button previewReportButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sectionNameLabel;
        private System.Windows.Forms.RichTextBox viewCommentRichTextBox;
        private System.Windows.Forms.CheckedListBox commentsCheckedListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button SkipCommentButton;
        private System.Windows.Forms.Button addCommentsButton;
    }
}