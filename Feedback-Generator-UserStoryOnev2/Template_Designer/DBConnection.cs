﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Template_Designer
{
    /// <summary>
    /// Database Connection Class. 
    /// Author: Colin Thorbinson
    /// Reviewer: Kummuda Morla
    /// Code taken from Dr. Christina Luca - Software Engineering Lecture Week 4.
    /// </summary>
    class DBConnection
    {
        //Set Attributes
        private static DBConnection _instance;

        private static string connectionStr;

        private System.Data.SqlClient.SqlConnection connectionToDB;

        private System.Data.SqlClient.SqlDataAdapter dataAdapter;

        public int tempTemplateID;

        //Constructors

        //Properties
        public static string ConnectionStr
        {
            set
            {
                connectionStr = value;
            }
        }

        //Methods
        //Return the connection to the database
        public static DBConnection getDBConnectionToInstance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        //Open the connection
        public void openConnection()
        {
            connectionToDB = new System.Data.SqlClient.SqlConnection(connectionStr);
            connectionToDB.Open();
        }

        public void closeConnection()
        {
            connectionToDB.Close();
        }

        public string instance()
        {
            return connectionStr;
        }

        public void insertTemplate(string sqlQuery, string x, string y, string z)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.Add("templateNameOne", x);
            command.Parameters.Add("templateReviewerOne", y);
            command.Parameters.Add("templatePositionOne", z);
            openConnection();
            command.Connection = connectionToDB;
            int n = command.ExecuteNonQuery();

            //command.Connection.Close();
            closeConnection();

            Console.WriteLine("n-" + n);
        }

        //Insert the Section Name into the Section name Database
        public void insertSectionTitle(string sqlQuery, string x, int y)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@templateID", y);
            command.Parameters.AddWithValue("@sectionNameOne", x);
            openConnection();
            command.Connection = connectionToDB;
            int n = command.ExecuteNonQuery();
            //command.Connection.Close();
            closeConnection();

            Console.WriteLine("n-" + n);
        }

        //Get the latest template ID
        public void getTempTemplateID(string sqlQuery)
        {

            SqlCommand command = new SqlCommand();
            addToSection getID = new addToSection();

            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
           
            //command.Parameters.Add("sectionNameOne", x);
            openConnection();
            command.Connection = connectionToDB;
            int ID = Convert.ToInt32(command.ExecuteScalar().ToString());
            //command.ExecuteNonQuery();
            //tempTemplateID = ID;
            getID.turn_to_ID(ID);
            //command.Connection.Close();
            closeConnection();

            Console.WriteLine("n = " + ID);
        }


        // Get the data set generated by the sqlStatement
        public System.Data.DataSet getDataSet(string sqlStatement)
        {
            openConnection();

            System.Data.DataSet dataSet;

            // create the object dataAdapter to manipulate a table from the database StudentDissertations specified by connectionToDB
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter(sqlStatement, connectionToDB);

            // create the dataset
            dataSet = new System.Data.DataSet();

            dataAdapter.Fill(dataSet);

            closeConnection();

            //return the dataSet
            return dataSet;
        }

        public void insertOption(string sqlQuery, string y, string z)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.Add("optionTitleOne", y);
            command.Parameters.Add("optionCommentOne", z);
            openConnection();
            command.Connection = connectionToDB;
            int n = command.ExecuteNonQuery();

            //command.Connection.Close();
            closeConnection();

            Console.WriteLine("n-" + n);
        }


    }
}
