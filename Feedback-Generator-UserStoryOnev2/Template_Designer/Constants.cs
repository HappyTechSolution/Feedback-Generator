using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Designer
{
    class Constants
    {
        public static String Insert = "INSERT INTO createTemplate(templateName, templateReviewer, templatePosition) VALUES(@templateNameOne, @templateReviewerOne, @templatePositionOne)";
        public static String InsertOption = "INSERT INTO createTemplateOptions(optionsTitle, optionsComment) VALUES(@optionTitleOne, @optionCommentOne)";
        public static String InsertSectionName = "INSERT INTO createTemplateSections(sectionTitle, templateID) VALUES(@sectionNameOne, @templateID)";
        public static String getTempTemplateID = "SELECT templateID FROM createTemplate WHERE templateID IN (SELECT MAX(templateID) FROM createTemplate)";
    }
}
