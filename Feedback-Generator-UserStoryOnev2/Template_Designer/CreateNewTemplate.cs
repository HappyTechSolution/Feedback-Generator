using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;

namespace Template_Designer
{
    /// <summary>
    /// Class to be used with the CreateTemplate Form. 
    /// Author: 
    /// Reviewer:
    ///  
    /// </summary>
    class CreateNewTemplate
    {
        private string templateNameOne;
        private string templateReviewerOne;
        private string templatePositionOne;
        private string templateFeedbackTypeOne;

        //Methods

        public void addTemplateName(string templateNewName)
        {
            templateNameOne = templateNewName;
        }

        public void addTemplateReviewer(string templateNewReviewer)
        {
            templateReviewerOne = templateNewReviewer;
        }

        public void addTemplatePosition(string templateNewPosition)
        {
            templatePositionOne = templateNewPosition;
        }

        public void addTemplateFeedbackType(string templateNewFeedbackType)
        {
            templateFeedbackTypeOne = templateNewFeedbackType;
        }

        public void writeTemplateDetailsToDB()
        {
            DBConnection.getDBConnectionToInstance().insert("INSERT INTO createTemplate (templateName, templateReviewer, templatePosition) VALUES ('templateNameOne','templateReviewerOne','templatePositionOne')");
            //DBConnection.getDBConnectionToInstance().insert("INSERT INTO createTemplate (templateName, templateReviewer, templatePosition) VALUES (templateNameOne,templateReviewerOne,templatePositionOne)");
            //            DBConnection.getDBConnectionToInstance().insert("INSERT INTO myTb (field1, field2) VALUES ('11','22')");


        }
    }
}
