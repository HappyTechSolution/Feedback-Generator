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

        public void insert(string sqlQuery)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
             
            openConnection();
            command.Connection = connectionToDB;
            int n = command.ExecuteNonQuery();

            closeConnection();

            Console.WriteLine("n-" + n);
        }



    }
}
