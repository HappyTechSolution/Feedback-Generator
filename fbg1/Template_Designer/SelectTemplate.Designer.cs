namespace Template_Designer
{
    partial class SelectTemplate
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
            this.selectTempCombobox = new System.Windows.Forms.ComboBox();
            this.confirmTempButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectTempCombobox
            // 
            this.selectTempCombobox.FormattingEnabled = true;
            this.selectTempCombobox.Location = new System.Drawing.Point(13, 13);
            this.selectTempCombobox.Name = "selectTempCombobox";
            this.selectTempCombobox.Size = new System.Drawing.Size(259, 21);
            this.selectTempCombobox.TabIndex = 0;
            // 
            // confirmTempButton
            // 
            this.confirmTempButton.Location = new System.Drawing.Point(198, 97);
            this.confirmTempButton.Name = "confirmTempButton";
            this.confirmTempButton.Size = new System.Drawing.Size(75, 23);
            this.confirmTempButton.TabIndex = 1;
            this.confirmTempButton.Text = "Confirm";
            this.confirmTempButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(13, 97);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SelectTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 132);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmTempButton);
            this.Controls.Add(this.selectTempCombobox);
            this.Name = "SelectTemplate";
            this.Text = "SelectTemplate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selectTempCombobox;
        private System.Windows.Forms.Button confirmTempButton;
        private System.Windows.Forms.Button cancelButton;
    }
}