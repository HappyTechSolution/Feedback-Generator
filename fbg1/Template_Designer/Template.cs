using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Designer
{
    class Template
    {
        private int templateID;
        private string templateName;
        private string templateReviewer;
        private string templatePosition;
        private List<Sections> Secs;

        class Sections
        {
            public int sectionID;
            public string sectionTitle;
        }

        public void getTName(string x)
        {
            templateName = x;
        }

        public void getTID()
        {
            templateID = DBConnection.getDBConnectionToInstance().getTempID(Constants.searchTID, templateName);
        }

        public void getTReviewer()
        {
            templateReviewer = DBConnection.getDBConnectionToInstance().getTempReviewer(Constants.searchTRev, templateID);
            
        }


        public void getTPosition()
        {
            templatePosition = DBConnection.getDBConnectionToInstance().getTempPosition(Constants.searchTPos, templateID);
        }
        
        public void getSecs()
        {
            Secs.Add(new Sections { sectionID = DBConnection.getDBConnectionToInstance().getTempSecID(Constants.searchSecID, templateID), sectionTitle = DBConnection.getDBConnectionToInstance().getTempSecTitle(Constants.searchSecTitle, DBConnection.getDBConnectionToInstance().getTempSecID(Constants.searchSecID, templateID)) });
        }

    }
}
