using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace FrontEnd2
{
    public class Data
    {
        private string Connection = @"Provider=SQLOLEDB; Data Source=.\SQLEXPRESS; Initial Catalog=ALevelDatabase; User ID= sa; Password= Pa$$w0rd";
        private string Connection2 = @"Data Source=.\SQLEXPRESS; Initial Catalog=ALevelDatabase; User ID=sa; Password=Pa$$w0rd"; // Different types of connections for different type of adapters 
        private const string SQL_COMMAND_TEACHERS = @"SELECT * FROM Teachers";
        private const string SQL_COMMAND_STUDENTS = @"SELECT StudentId, FirstName, Surname, Class, Score2,Score3,Score4,Score5,Score6,Score7,Score8,Score9 FROM Students Inner join Scores on Students.StudentId = Scores.ScoreID Order by StudentId ASC";
        private string Sql_Command_Login = @"where Username = @User and Pass = @Pass"; // Parmameterised sql 
        private const string SQL_COMMAND_SCORE = @"select * From Scores Inner join Students on Students.StudentId = Scores.ScoreID"; 


        

        private OleDbDataAdapter DaTblStudents;
        private OleDbDataAdapter DaTblTeachers;
        private OleDbDataAdapter DaTblScores; 


        private DataTable TblStudents;
        private DataTable TblTeachers;
        private DataTable TblLogin;
        private DataTable TblScores; 






        public Data(string UserName, string Password, string Table)
        {
            string TempLoginSelect = "";
            string TempId = "";
            // Temp login string used as Sql statement and Table wanting to be selected 
            //can't be passed in as parameterised sql
            // string Concatination used to over come this  

            if (UserName != "Admin" && Password != "Admin")
            {
                if (Table == "Users")
                {
                    TempLoginSelect = string.Concat("Select * from Users ", Sql_Command_Login);
                    TempId = "TeacherID";
                }
                else if (Table == "StudentUsers")
                {
                    TempLoginSelect = string.Concat("Select * from StudentUsers ", Sql_Command_Login);
                    TempId = "StudentId";
                }
                else
                {

                }
                SqlConnection conn = new SqlConnection(Connection2);


                SqlCommand cmd = new SqlCommand(TempLoginSelect, conn);


                cmd.Parameters.Add("@User", SqlDbType.VarChar);
                cmd.Parameters["@User"].Value = UserName;
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar);
                cmd.Parameters["@Pass"].Value = Hash(Password);


                TblLogin = new DataTable();
                SqlDataAdapter DaTblLogin = new SqlDataAdapter(cmd);

                DaTblLogin.Fill(TblLogin);

                if (TblLogin.Rows.Count == 1 && TblLogin.Columns[TempId] != null)
                {

                }
                else
                {
                    System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "index");
                    throw argEx;
                }
            }


                // ** Old Select statement This was unsecure as it was unparamenterised 
                // Allowing for code to written directly into the select statement 

            //if (UserName != "Admin" && Password != "Admin") // not admin account doesn't reduce table 
            //{
            //    //string Query = @"select * from @Table where Username = @User and Pass = @Pass"; // Parmameterised sql
            //    DaTblLogin = new OleDbDataAdapter(Query, Connection);
            //    TblLogin = new DataTable();
            //    DaTblLogin.Fill(TblLogin);

            //    if (TblLogin.Rows.Count == 1)
            //    {

            //    }
            //    else
            //    {
            //        System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "index");
            //        throw argEx;
            //    }
            //}



            DaTblStudents = new OleDbDataAdapter(SQL_COMMAND_STUDENTS, Connection);
            new OleDbCommandBuilder(DaTblStudents);
            // Allows for functions to act on the table
            TblStudents = new DataTable();
            DaTblStudents.Fill(TblStudents);
            // Student table populated

            DaTblTeachers = new OleDbDataAdapter(SQL_COMMAND_TEACHERS, Connection);
            new OleDbCommandBuilder(DaTblTeachers);   // Allows for functions to act on the table
            TblTeachers = new DataTable();
            DaTblTeachers.Fill(TblTeachers);
            // Teacher table populated



            DaTblScores = new OleDbDataAdapter(SQL_COMMAND_SCORE, Connection);
            new OleDbCommandBuilder(DaTblScores);
            TblScores = new DataTable();
            DaTblScores.Fill(TblScores); 



        }

        public string Hash(string Text)
        {
            string HashString = "";
            byte[] MyBytes = Encoding.Unicode.GetBytes(Text);
            SHA256Managed HashText = new SHA256Managed();
            byte[] HashedValues = HashText.ComputeHash(MyBytes);
            foreach(byte X in HashedValues)
            {
                HashString += String.Format("{0:x2}", X);
            }
            return HashString;
        }






        public string GetSqlCommand()
        {
            return SQL_COMMAND_TEACHERS;
        }


        // Returns Data tables and data adapters
        public DataTable ReturnTeacherTbl()
        {
            return TblTeachers;
        }

        public OleDbDataAdapter ReturnTeacherAdapter()
        {
            return DaTblTeachers;
        }

        public DataTable ReturnStudentTbl()
        {
            return TblStudents;
        }

        public OleDbDataAdapter ReturnStudentAdapter()
        {
            return DaTblStudents;
        }
        public DataTable ReturnScoresTbl()
        {
            return TblScores;
        }

        public OleDbDataAdapter ReturnScoreAdapter()
        {
            return DaTblScores;
        }
        public DataTable ReturnLoginTbl()
        {
            return TblLogin;
        }
    }
}