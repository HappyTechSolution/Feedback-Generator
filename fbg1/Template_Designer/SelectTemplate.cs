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
    public partial class SelectTemplate : Form
    {
        public SelectTemplate()
        {
            InitializeComponent();
            //adds range to comboBox  - template names from tempNames array.
            Constants c = new Constants();
            selectTempCombobox.Items.AddRange(c.tempNames);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // makes current window dissappear before opening SelectTemplateElements.

            SelectTemplateElements st = new SelectTemplateElements(); // shows select temp. elements. 
            st.Show();



        }

        private void selectTempCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
