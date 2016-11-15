namespace Template_Designer
{
    partial class CreateTemplate
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectFeedbackTypeBox = new System.Windows.Forms.ComboBox();
            this.createTemplateFeedbackTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackGeneratorDBDataSet = new Template_Designer.feedbackGeneratorDBDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.createTemplateFeedbackTypeTableAdapter = new Template_Designer.feedbackGeneratorDBDataSetTableAdapters.createTemplateFeedbackTypeTableAdapter();
            this.viewDatabase = new System.Windows.Forms.Button();
            this.createTemplateFeedbackTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateFeedbackTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGeneratorDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateFeedbackTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Template Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reviewer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 62);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(326, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 102);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(326, 26);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Position:";
            // 
            // selectFeedbackTypeBox
            // 
            this.selectFeedbackTypeBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.createTemplateFeedbackTypeBindingSource, "feedbackType", true));
            this.selectFeedbackTypeBox.DataSource = this.createTemplateFeedbackTypeBindingSource;
            this.selectFeedbackTypeBox.DisplayMember = "feedbackType";
            this.selectFeedbackTypeBox.FormattingEnabled = true;
            this.selectFeedbackTypeBox.Location = new System.Drawing.Point(158, 143);
            this.selectFeedbackTypeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectFeedbackTypeBox.Name = "selectFeedbackTypeBox";
            this.selectFeedbackTypeBox.Size = new System.Drawing.Size(326, 28);
            this.selectFeedbackTypeBox.TabIndex = 6;
            this.selectFeedbackTypeBox.ValueMember = "feedbackType";
            this.selectFeedbackTypeBox.SelectedIndexChanged += new System.EventHandler(this.selectFeedbackTypeBox_SelectedIndexChanged);
            // 
            // createTemplateFeedbackTypeBindingSource
            // 
            this.createTemplateFeedbackTypeBindingSource.DataMember = "createTemplateFeedbackType";
            this.createTemplateFeedbackTypeBindingSource.DataSource = this.feedbackGeneratorDBDataSet;
            // 
            // feedbackGeneratorDBDataSet
            // 
            this.feedbackGeneratorDBDataSet.DataSetName = "feedbackGeneratorDBDataSet";
            this.feedbackGeneratorDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Feedback Type:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // createTemplateFeedbackTypeTableAdapter
            // 
            this.createTemplateFeedbackTypeTableAdapter.ClearBeforeFill = true;
            // 
            // viewDatabase
            // 
            this.viewDatabase.Location = new System.Drawing.Point(339, 246);
            this.viewDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewDatabase.Name = "viewDatabase";
            this.viewDatabase.Size = new System.Drawing.Size(112, 35);
            this.viewDatabase.TabIndex = 11;
            this.viewDatabase.Text = "View Database";
            this.viewDatabase.UseVisualStyleBackColor = true;
            this.viewDatabase.Click += new System.EventHandler(this.viewDatabase_Click);
            // 
            // createTemplateFeedbackTypeBindingSource1
            // 
            this.createTemplateFeedbackTypeBindingSource1.DataMember = "createTemplateFeedbackType";
            this.createTemplateFeedbackTypeBindingSource1.DataSource = this.feedbackGeneratorDBDataSet;
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 303);
            this.Controls.Add(this.viewDatabase);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectFeedbackTypeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateTemplate";
            this.Text = "CreateTemplate";
            this.Load += new System.EventHandler(this.CreateTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateFeedbackTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGeneratorDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateFeedbackTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectFeedbackTypeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private feedbackGeneratorDBDataSet feedbackGeneratorDBDataSet;
        private System.Windows.Forms.BindingSource createTemplateFeedbackTypeBindingSource;
        private feedbackGeneratorDBDataSetTableAdapters.createTemplateFeedbackTypeTableAdapter createTemplateFeedbackTypeTableAdapter;
        private System.Windows.Forms.Button viewDatabase;
        private System.Windows.Forms.BindingSource createTemplateFeedbackTypeBindingSource1;
    }
}