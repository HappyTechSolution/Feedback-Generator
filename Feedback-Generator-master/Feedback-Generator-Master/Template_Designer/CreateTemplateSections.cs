﻿using System;
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
    public partial class CreateTemplateSections : Form
    {     

        public object TitleBox { get; private set; }
        public object CommentsBox { get; private set; }

        public CreateTemplateSections()
        {
            InitializeComponent();
            
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Close();
            enterSectionTitle est = new enterSectionTitle();
            est.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //CreateNewOptions input = new CreateNewOptions();
            //input.addOptionTitle(TitleBox.Text);
            //input.addOptionComment(CommentsBox.Text);
            //input.writeOptionDetailsToDB();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        

        }   // reference [adding multiple text boxes] http://www.c-sharpcorner.com/blogs/generate-textbox-dynamically-at-runtime-in-windows-form-application1

        private void AddCommentButton_Click(object sender, EventArgs e)
        {
            CreateNewOptions input = new CreateNewOptions();
            input.getLatestsectionID();
            input.addOptionTitle(titleTextBox.Text);
            input.addOptionComment(commentTextBox.Text);
            input.writeOptionDetailsToDB();
            Close();
            CreateTemplateSections reOpen = new CreateTemplateSections();
            reOpen.Show();
            
        }
    }

}
