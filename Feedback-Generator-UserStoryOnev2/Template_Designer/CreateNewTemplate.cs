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
            DBConnection.getDBConnectionToInstance().insertTemplate(Constants.Insert, templateNameOne, templateReviewerOne, templatePositionOne);
           
        }

    }

    class CreateNewOptions
    {
        private string optionTitleOne;
        private string optionCommentOne;

        public void addOptionTitle(string optionNewTitle)
        {
            optionTitleOne = optionNewTitle;
        }

        public void addOptionComment(string optionNewComment)
        {
            optionCommentOne = optionNewComment;
        }

        public void writeOptionDetailsToDB()
        {
            DBConnection.getDBConnectionToInstance().insertOption(Constants.InsertOption, optionTitleOne,optionCommentOne);

        }

        internal void addOptionTitle(object text)
        {
            throw new NotImplementedException();
        }
    }

    class addToSection
    {
        private string sectionNameOne;

        public void addSectionName(string addSectionName)
        {
            sectionNameOne = addSectionName;
        }
    

        public void writeNameToDB()
        {
            DBConnection test = new DBConnection();
            int temp;
            temp = test.tempTemplateID;
            DBConnection.getDBConnectionToInstance().insertSectionTitle(Constants.InsertSectionName, sectionNameOne, temp);
        }

        public void getLatestTemplateID()
        {

            //DBConnection.getDBConnectionToInstance().insertOption(Constants.InsertOption, optionTitleOne,optionCommentOne);
            DBConnection.getDBConnectionToInstance().getTempTemplateID(Constants.getTempTemplateID);

        }

    }
}
