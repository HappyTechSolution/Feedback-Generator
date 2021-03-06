﻿using System;
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
        public static List<int> sectionID;
        public static List<string> sectionTitle;
        private List<int> optionID = new List<int>();
        public static List<string> optionTitle = new List<string>();
        public static List<string> optionComment = new List<string>();
        public static List<int> optionsCount = new List<int>();
        public static int x = 0;
        public static List<string> selectedOptionTitle = new List<string>();
        public static List<string> selectedOptionComment = new List<string>();
        public static List<int> secCount = new List<int>();

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

        public void getSecIDs()
        {
            sectionID = DBConnection.getDBConnectionToInstance().getTempSecID(Constants.searchSecID, templateID);
        }

        public void getSecTitles()
        {
            sectionTitle = DBConnection.getDBConnectionToInstance().getTempSecTitle(Constants.searchSecTitle, templateID);
        }

        public void getOptIDs()
        {
            List<int> a = new List<int>();
            int count = sectionID.Count();
            for (int i = 0; i < count; i++)
            {
                a = DBConnection.getDBConnectionToInstance().getTempOptID(Constants.searchOptID, sectionID[i]);
                optionsCount.Add(a.Count());
                optionID.AddRange(a);
            }
        }

        public void getOptTitles()
        {
            int count = optionID.Count;
            for (int i = 0; i < count; i++)
            {
                optionTitle.Add( DBConnection.getDBConnectionToInstance().getTempOptTitle(Constants.searchOptTitle, optionID[i]));
            }
        }

        public void getOptComments()
        {
            int count = optionID.Count();
            for (int i = 0; i < count; i++)
            {
                optionComment.Add(DBConnection.getDBConnectionToInstance().getTempOptComment(Constants.searchOptComment, optionID[i]));
            } 
        }

    }
}
