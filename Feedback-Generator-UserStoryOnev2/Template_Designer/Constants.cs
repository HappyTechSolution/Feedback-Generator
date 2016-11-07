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
        public static String InsertOption = "INSERT INTO createTemplateOptions(optionTitle, optionComment) VALUES(@optionTitleOne, @optionCommentOne)";
    }
}
