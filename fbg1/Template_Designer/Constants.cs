using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Designer
{
    /// <summary>
    /// Name: Constants
    /// Description: Class to store all required SQL Statements. 
    /// </summary>
    class Constants
    {
        //INSERT SQL Statements
        public static String Insert = "INSERT INTO createTemplate(templateName, templateReviewer, templatePosition) VALUES(@templateNameOne, @templateReviewerOne, @templatePositionOne)";
        public static String InsertOption = "INSERT INTO createTemplateOptions(optionsTitle, optionsComment, sectionsID) VALUES(@optionTitleOne, @optionCommentOne, @secID)";
        public static String InsertSectionName = "INSERT INTO createTemplateSections(sectionTitle, templateID) VALUES(@sectionNameOne, @templateID)";

        //SELECT SQL Statements
        public static String getTempTemplateID = "SELECT templateID FROM createTemplate WHERE templateID IN (SELECT MAX(templateID) FROM createTemplate)";
        public static String getSectionsID = "SELECT sectionID FROM createTemplateSections WHERE sectionID IN (SELECT MAX(sectionID) FROM createTemplateSections)";

        // Display the templates for selection
        public static String select = "Select templateName from createTemplate";

        //search for a template details
        public static string searchTID = "Select templateID from createTemplate where templateName = @tempName";
        public static string searchTRev = "Select templateReviewer from createTemplate where templateID = @tempID";
        public static string searchTPos = "Select templatePosition from createTemplate where templateID = @tempID";

        //search for section details
        public static string searchSecID = "Select sectionID from createTemplateSections where templateID = @tempID";
        public static string searchSecTitle = "Select sectionTitle from createTemplateSections where sectionID = @secID";

        //variables to collect data from database if needed [currently filled with examples]
        public string sectionName;
        public string[] comments = { "Good CV Well written and organised. Couldn't expect better.", "You could have had a slightly better CV. Just a bit muddled-up.", "The CV was not good enough. Maybe seek some support on writing CVs. " };
        public string[] tempNames = { "IT Specialist temp", "Cleaner Temp", "Programmer temp" };

        //list for selected section comments
        //List<string> selectedComments = new List<string>();
        //int n = 0;

        //public void addToComments(string addComments)
        //{
          //   (string s in addComments)
          
                

            //}
        //}


    }
}
