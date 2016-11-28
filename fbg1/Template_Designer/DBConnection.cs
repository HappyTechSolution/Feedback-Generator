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
    /// Name: DBConnection
    /// Description: DBConnection links the Database to the program. 
    ///
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

        //Open Database connection
        public void openConnection()
        {
            connectionToDB = new System.Data.SqlClient.SqlConnection(connectionStr);
            connectionToDB.Open();
        }

        //Closes Database Connection
        public void closeConnection()
        {
            connectionToDB.Close();
        }

        //Sets Database Instance to connectionStr Variable.
        public string instance()
        {
            return connectionStr;
        }


        //Inserts the name, position and reviewer of the new template
        public void insertTemplate(string sqlQuery, string x, string y, string z)
        {
            //creates a connection to the sql command, converting the sql as text
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Adds Variables into SQL Statement
            command.Parameters.Add("templateNameOne", x);
            command.Parameters.Add("templateReviewerOne", y);
            command.Parameters.Add("templatePositionOne", z);

            //Opens Connection to the Database.
            openConnection();
            command.Connection = connectionToDB;

            //Executes the sql statement
            command.ExecuteNonQuery();

            //Closes the connection
            closeConnection();
        }

        //A method to insert the section name and the current template ID
        public void insertSectionTitle(string sqlQuery, string x, int y)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Adds Variables into SQL Statement
            command.Parameters.AddWithValue("@templateID", y);
            command.Parameters.AddWithValue("@sectionNameOne", x);

            //Opens Connection to the Database.
            openConnection();
            command.Connection = connectionToDB;

            //Executes the SQL Query.
            command.ExecuteNonQuery();

            //command.Connection.Close();
            closeConnection();
        }

        //A method that gets the lastest Template ID, which will be used as a foriegn key for the section table
        public void getTempTemplateID(string sqlQuery)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            addToSection getID = new addToSection();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Opens Connection to the Database.
            openConnection();
            command.Connection = connectionToDB;

            //executes the sql statement and parses the template ID as a interger
            int ID = Convert.ToInt32(command.ExecuteScalar().ToString());

            //calls the method to pass the ID variable to the secID from createTemplate
            getID.turn_to_ID(ID);

            //Closes the Database Connection.
            closeConnection();
        }

        //A method that gets the lastest section ID to act as a foreign key for options table
        public void getSectioneID(string sqlQuery)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            CreateNewOptions getSecID = new CreateNewOptions();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Opens Connection to the Database.
            openConnection();
            command.Connection = connectionToDB;

            //Executes SQL Query and enters the output into Variable.
            int ID = Convert.ToInt32(command.ExecuteScalar().ToString());

            //calls the method to pass the ID variable to the secID from SectionID.
            getSecID.turn_to_SecID(ID);

            //Closes Database Connection
            closeConnection();
        }

        // Get the data set generated by the sqlStatement
        public System.Data.DataSet getDataSet(string sqlStatement)
        {
            //Opens Connection to the Database.
            openConnection();

            //Creates a new DataSet.
            System.Data.DataSet dataSet;

            // create the object dataAdapter to manipulate a table from the database StudentDissertations specified by connectionToDB
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter(sqlStatement, connectionToDB);

            // create the dataset
            dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);

            //Closes the Connection
            closeConnection();

            //return the dataSet
            return dataSet;
        }

        //A method to Insert Titles and Comments into Database.
        public void insertOption(string sqlQuery, string y, string z, int x)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Adds Options to SQL Query.
            command.Parameters.AddWithValue("@secID", x);
            command.Parameters.Add("optionTitleOne", y);
            command.Parameters.Add("optionCommentOne", z);

            //Opens the Connection to the Database.
            openConnection();

            //Executes the SQL Command.
            command.Connection = connectionToDB;
            command.ExecuteNonQuery();

            //Closes the Connection to the Database.
            closeConnection();
        }


        public List<string> displayTemplateNames(string sqlQuery)
        {
            List<string> templateName = new List<string>();

            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Opens Connection to the Database.
            openConnection();
            command.Connection = connectionToDB;

            //Executes the SQL Query
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                    templateName.Add(reader.GetString(0));
            }


            //command.Connection.Close();
            closeConnection();

            //returns the list
            return templateName;
        }
        public int getTempID(string sqlQuery, string z)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            command.Parameters.AddWithValue("@tempName", z);

            openConnection();
            command.Connection = connectionToDB;

            int temp = Convert.ToInt32(command.ExecuteScalar());

            closeConnection();

            return temp;
        }

        public string getTempReviewer(string sqlQuery, int z)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            command.Parameters.AddWithValue("@tempID", z);

            openConnection();
            command.Connection = connectionToDB;

            string temp1;
            temp1 = (String)command.ExecuteScalar();
            // SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            // temp1  = reader.GetString(0);
            //}

            closeConnection();
            return temp1;
        }

        public string getTempPosition(string sqlQuery, int z)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            command.Parameters.AddWithValue("@tempID", z);

            openConnection();
            command.Connection = connectionToDB;

            string temp1;
            temp1 = (String)command.ExecuteScalar();

            closeConnection();
            return temp1;
        }

        public int getTempSecID(string sqlQuery, int z)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            command.Parameters.AddWithValue("@tempID", z);

            openConnection();
            command.Connection = connectionToDB;

            int temp1 = Convert.ToInt32(command.ExecuteScalar());

            closeConnection();
            return temp1;
        }

        public string getTempSecTitle(string sqlQuery, int z)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            command.Parameters.AddWithValue("@secID", z);

            openConnection();
            command.Connection = connectionToDB;

            string temp1 = (String)command.ExecuteScalar();

            closeConnection();
            return temp1;
        }

    }
}
