using System;
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

        /// <summary>
        /// Inserts the name, position and reviewer of the new template
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public void insertTemplate(string sqlQuery, string x, string y, string z)
        {
            //creates a connection to the sql command, converting the sql as text
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.Add("templateNameOne", x);
            command.Parameters.Add("templateReviewerOne", y);
            command.Parameters.Add("templatePositionOne", z);
            openConnection();
            command.Connection = connectionToDB;
            //Executes the sql statement
            command.ExecuteNonQuery();

            //Closes the connection
            closeConnection();           
        }

        /// <summary>
        /// A method to insert the section name and the current template ID
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void insertSectionTitle(string sqlQuery, string x, int y)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@templateID", y);
            command.Parameters.AddWithValue("@sectionNameOne", x);
            openConnection();
            command.Connection = connectionToDB;
            command.ExecuteNonQuery();
            //command.Connection.Close();
            closeConnection();
        }

        /// <summary>
        /// A method that gets the lastest Template ID, which will be used as a foriegn key for the section table
        /// </summary>
        /// <param name="sqlQuery"></param>
        public void getTempTemplateID(string sqlQuery)
        {

            SqlCommand command = new SqlCommand();
            addToSection getID = new addToSection();

            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
           
            openConnection();
            command.Connection = connectionToDB;
            //executes the sql statement and parses the template ID as a interger
            int ID = Convert.ToInt32(command.ExecuteScalar().ToString());
            //calls the method to pass the ID variable to the secID from createTemplate
            getID.turn_to_ID(ID);
            closeConnection();
        }
        /// <summary>
        /// A mehtod that gets the lastest section ID to act as a foreign key for options table
        /// </summary>
        /// <param name="sqlQuery"></param>
        public void getSectioneID(string sqlQuery)
        {
            SqlCommand command = new SqlCommand();
            CreateNewOptions getSecID = new CreateNewOptions();

            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            openConnection();
            command.Connection = connectionToDB;
            int ID = Convert.ToInt32(command.ExecuteScalar().ToString());
            getSecID.turn_to_SecID(ID);
            closeConnection();
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

        public void insertOption(string sqlQuery, string y, string z, int x)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@secID", x);
            command.Parameters.Add("optionTitleOne", y);
            command.Parameters.Add("optionCommentOne", z);
            openConnection();
            command.Connection = connectionToDB;
            command.ExecuteNonQuery();

            closeConnection();
        }


    }
}
