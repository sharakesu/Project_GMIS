using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GMIS
{
    public class STGConnection
    {
        private const string db = "gmis";
        private const string user = "gmis";
        private const string pass = "gmis";
        private const string server = "alacritas.cis.utas.edu.au";

        static MySqlConnection? conn;

        public static MySqlConnection GetConnection()
        {
            if (conn == null)
            {
                string connectionString = String.Format("Database={0};Data Source={1};User Id={2}; Password={3}", db, server, user, pass);
                conn = new MySqlConnection(connectionString);
               
            }
            return conn;
        }

        public static ObservableCollection<StudentGroupModel> LoadAll()
        {
            ObservableCollection<StudentGroupModel> groups = new ObservableCollection<StudentGroupModel>();

            // Declare a data reader
            MySqlDataReader? rdr = null;

            try
            {
                // Instantiate a connection
                conn = GetConnection();
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM studentGroup", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the CategoryName of each record
                while (rdr.Read())
                {
                    StudentGroupModel g = new StudentGroupModel { group_id = rdr.GetInt32("group_id"), group_name = rdr.GetString("group_name") };
                    groups.Add(g);
                }
            }
            catch (MySqlException g)
            {
                Console.WriteLine("Error connecting to database: " + g);
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return groups;
        }


        public static ObservableCollection<ClassModel> LoadClassComboData()
        {
            ObservableCollection<ClassModel> classs= new ObservableCollection<ClassModel>();

            // Declare a data reader
            MySqlDataReader? rdr = null;

            try
            {
                // Instantiate a connection
                conn = GetConnection();
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("SELECT class_id FROM class", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the CategoryName of each record
                while (rdr.Read())
                {
                    ClassModel c = new ClassModel { class_id = rdr.GetInt32(0)};
                    classs.Add(c);
                }
            }
            catch (MySqlException c)
            {
                Console.WriteLine("Error connecting to database: " + c);
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return classs;
        }


        public static ObservableCollection<ClassWithGroupModel> LoadClassWithGroup()
        {
            ObservableCollection<ClassWithGroupModel> classWithGroups = new ObservableCollection<ClassWithGroupModel>();

            // Declare a data reader
            MySqlDataReader? rdr = null;

            try
            {
                // Instantiate a connection
                conn = GetConnection();
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("SELECT * from class c inner join studentGroup sg on c.group_id = sg.group_id", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the CategoryName of each record
                while (rdr.Read())
                {
                    ClassWithGroupModel cwg = new ClassWithGroupModel { class_id = rdr.GetInt32("class_id"), group_id = rdr.GetInt32("group_id"), group_name =rdr.GetString("group_name") };
                    classWithGroups.Add(cwg);
                }
            }
            catch (MySqlException cwg)
            {
                Console.WriteLine("Error connecting to database: " + cwg);
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return classWithGroups;
        }


        public static ObservableCollection<StudentModel> LoadStudents()
        {
            ObservableCollection<StudentModel> students = new ObservableCollection<StudentModel>();

            // Declare a data reader
            MySqlDataReader? rdr = null;

            try
            {
                // Instantiate a connection
                conn = GetConnection();
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("select * from student s inner join studentGroup sg on s.group_id = sg.group_id", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the CategoryName of each record
                while (rdr.Read())
                {
                    StudentModel stu = new StudentModel {  group_id = rdr.GetInt32("group_id"), student_id= rdr.GetInt32("student_id"), given_name = rdr.GetString("given_name") ,
                                                         family_name  = rdr.GetString("family_name") ,title = rdr.GetString("title"), campus = rdr.GetString("campus") , phone = rdr.GetString("phone"),
                                                            email = rdr.GetString("email") , category = rdr.GetString("category")   };
                    students.Add(stu);
                }
            }
            catch (MySqlException stu)
            {
                Console.WriteLine("Error connecting to database: " + stu);
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return students;
        }


        public static ObservableCollection<GroupIDOnlyModel> LoadGroupID()
        {
            ObservableCollection<GroupIDOnlyModel> groupIDs = new ObservableCollection<GroupIDOnlyModel>();

            // Declare a data reader
            MySqlDataReader? rdr = null;

            try
            {
                // Instantiate a connection
                conn = GetConnection();
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("SELECT group_id FROM studentGroup", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the CategoryName of each record
                while (rdr.Read())
                {
                    GroupIDOnlyModel grp = new GroupIDOnlyModel { group_id = rdr.GetInt32("group_id") };
                    groupIDs.Add(grp);
                }
            }
            catch (MySqlException grp)
            {
                Console.WriteLine("Error connecting to database: " + grp);
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return groupIDs;
        }

    }
}
