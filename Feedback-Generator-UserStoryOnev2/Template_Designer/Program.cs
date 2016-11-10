using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template_Designer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Set the Database Connection String
            DBConnection.ConnectionStr = Properties.Settings.Default.feedbackGeneratorDBConnection;
            //           DBConnection.ConnectionStr = Properties.Settings.Default.myConn;

            //            DBConnection initialise = new DBConnection();
            //            initialise.openConnection();

            //Opens User Interface.
            addToSection test = new addToSection();
            test.getLatestTemplateID();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TemplateSelector());


        }
    }
}
