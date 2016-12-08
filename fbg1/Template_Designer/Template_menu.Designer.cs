﻿namespace Template_Designer
{
    partial class TemplateSelector
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Remove_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.createNewTemplate_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.feedBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create/Modify templates";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select Template";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(21, 76);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(75, 23);
            this.Remove_button.TabIndex = 2;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = true;
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(103, 76);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(75, 23);
            this.Edit_button.TabIndex = 3;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            // 
            // createNewTemplate_button
            // 
            this.createNewTemplate_button.Location = new System.Drawing.Point(197, 149);
            this.createNewTemplate_button.Name = "createNewTemplate_button";
            this.createNewTemplate_button.Size = new System.Drawing.Size(75, 23);
            this.createNewTemplate_button.TabIndex = 4;
            this.createNewTemplate_button.Text = "Create new";
            this.createNewTemplate_button.UseVisualStyleBackColor = true;
            this.createNewTemplate_button.Click += new System.EventHandler(this.createNewTemplate_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(13, 149);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // feedBack
            // 
            this.feedBack.Location = new System.Drawing.Point(293, 148);
            this.feedBack.Name = "feedBack";
            this.feedBack.Size = new System.Drawing.Size(75, 23);
            this.feedBack.TabIndex = 6;
            this.feedBack.Text = "Feedback";
            this.feedBack.UseVisualStyleBackColor = true;
            this.feedBack.Click += new System.EventHandler(this.feedBack_Click);
            // 
            // TemplateSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 184);
            this.Controls.Add(this.feedBack);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.createNewTemplate_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "TemplateSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button createNewTemplate_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button feedBack;
    }
}
