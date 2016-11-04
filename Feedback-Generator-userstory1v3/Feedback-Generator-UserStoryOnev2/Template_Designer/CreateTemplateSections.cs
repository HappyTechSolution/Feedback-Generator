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
    public partial class CreateTemplateSections : Form
    {
        int pointX = 50;
        int pointY = 20;
        int count1 = 0;
        int panelSize = 0;
        int windowSize = 0;

        public CreateTemplateSections()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateTemplateSections CTS = new CreateTemplateSections();
            CTS.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //  Label Title = new Label();
            //  Title.Text = "Title:";
            // label1.Location = new Point(10, pointY);

            TextBox TitleBox = new TextBox();
            TitleBox.Text = "Title";
            TitleBox.Location = new Point(pointX, pointY);
            //  panel1.Controls.Add(Title);
            TextBox CommentsBox = new TextBox();
            CommentsBox.Text = "Comment";
            CommentsBox.Location = new Point(200, pointY);
            CommentsBox.Size = new Size(200, 23);
            panel1.Controls.Add(TitleBox);
            panel1.Controls.Add(CommentsBox);
            panel1.Show();
            pointY += 23;
            count1 += 1;
            if (count1 > 6)
            {
                panelSize += 23;
                windowSize += 23;
                panel1.Size = new Size(467, 175 + panelSize);
                this.Size = new Size(508, 297 + windowSize);

            }

        }   // reference http://www.c-sharpcorner.com/blogs/generate-textbox-dynamically-at-runtime-in-windows-form-application1

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
