using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace FrontEnd2
{
    public partial class AddStudent : Form
    {
        private Data Students;
        private int Class;
        


        public AddStudent(Data inStudents, int inClass)
        {
            Students = inStudents;
            Class = inClass;
            
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void TXTID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {


            if (TXTForename.Text != "" && TXTPassword.Text != "" && TXTSurname.Text != "")
            {

                string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=ALevelDatabase; User ID=sa; Password=Pa$$w0rd";


                string CommandText = "INSERT INTO Students(FirstName, Surname, Class)  values ( @FirstName, @Surname,@class)";
                string CommandText2 = "Insert into Scores(Score2,Score3,Score4,Score5,Score6,Score7,Score8,Score9) values(0, 0, 0, 0, 0, 0, 0, 0)";
                string CommandText3 = "Insert into StudentUsers values (@UserName, @Pass)";



                using (SqlConnection insertSQL = new SqlConnection(connectionString))
                {


                    SqlCommand myCommand = new SqlCommand(CommandText, insertSQL);      // delcare SQLCommand using the command and insertSQL
                    SqlCommand myCommand2 = new SqlCommand(CommandText2, insertSQL);
                    SqlCommand myCommand3 = new SqlCommand(CommandText3, insertSQL);



                    myCommand.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    myCommand.Parameters["@FirstName"].Value = TXTForename.Text;

                    myCommand.Parameters.Add("@Surname", SqlDbType.VarChar);
                    myCommand.Parameters["@Surname"].Value = TXTSurname.Text;

                    myCommand.Parameters.Add("@class", SqlDbType.Int);
                    myCommand.Parameters["@class"].Value = Class;


                    myCommand3.Parameters.Add("@UserName", SqlDbType.VarChar);
                    myCommand3.Parameters["@UserName"].Value = CreateUserNamePassWord(TXTForename.Text, TXTSurname.Text, FindColumnValues("UserName"));

                    myCommand3.Parameters.Add("@Pass", SqlDbType.VarChar);
                    myCommand3.Parameters["@Pass"].Value = Hash(TXTPassword.Text);





                    try         // try to execute to avoid errors causing a program crash.
                    {
                        //SqlDataReader myDataReaderInsert;
                        insertSQL.Open();

                        myCommand.ExecuteReader();       // Here our query will be executed and data saved into the database.
                        MessageBox.Show("Connection made." + Environment.NewLine + "Inserting Data...");        // MessageBox used to visibly show the event has gone ahead.

                        insertSQL.Close();

                        insertSQL.Open();
                        myCommand2.ExecuteReader();
                        insertSQL.Close();

                        insertSQL.Open();
                        myCommand3.ExecuteReader();
                        insertSQL.Close();




                        // Close connection when done...
                    }
                    catch (Exception ex)        // catch exceptions and handle them here
                    {
                        MessageBox.Show(ex.Message);
                    }


                    finally                     // if all else fails, finally do this.
                    {
                        if (insertSQL == null)
                        {
                            MessageBox.Show("Connection Failed!");
                        }
                    }


                    MessageBox.Show(string.Concat("New Username:",FindColumnValues("UserName")[FindColumnValues("UserName").Count - 1]));

                    TXTSurname.Clear();
                    TXTForename.Clear();
                    TXTPassword.Clear();

                    Students.ReturnStudentTbl().Clear();
                    Students.ReturnStudentAdapter().Fill(Students.ReturnStudentTbl());
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
    }



        public string Hash(string Text)
        {
            string HashString = "";
            byte[] MyBytes = Encoding.Unicode.GetBytes(Text);
            SHA256Managed HashText = new SHA256Managed();
            byte[] HashedValues = HashText.ComputeHash(MyBytes);
            foreach (byte X in HashedValues)
            {
                HashString += String.Format("{0:x2}", X);
            }
            return HashString;
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudent_Leave(object sender, EventArgs e)
        {
            TeacherFrm NewTeacher = new TeacherFrm(Students, (string)Students.ReturnLoginTbl().Rows[0]["Username"], (string)Students.ReturnLoginTbl().Rows[0]["Pass"]);
            NewTeacher.Show();
        }


        private string CreateUserNamePassWord(string FirstName, string SurName, List<string> CurrentllyUsed)
        {
            string UserName = "";
            int temp = 1;
            bool Existing = true;


            while (Existing)
                // Re-checks list to see if another now exists 
            {
                Existing = false;
                UserName = string.Concat(FirstName.Substring(0, 1), SurName, temp.ToString());

                for (int i = 0; i < CurrentllyUsed.Count(); i++)
                {
                    if (UserName == CurrentllyUsed[i])
                    {
                        temp++;
                        UserName = string.Concat(UserName.Substring(0, UserName.Length - 1), temp.ToString());
                        Existing = true;
                    }
                }
            }
            return UserName;

        }




        public static List<string> FindColumnValues(string column)
        {
            // finds all values in a row this will be used to check if a prexisting username is being used 
            //so not to class usernames and passwords
            DataTable Temptbl;
            OleDbDataAdapter TempDaTbl;
            string Command = "select * from StudentUsers";
            string connection = @"Provider=SQLOLEDB; Data Source=.\SQLEXPRESS; Initial Catalog=ALevelDatabase; User ID= sa; Password= Pa$$w0rd";

            List<string> ListFromColumm = new List<string>();


            TempDaTbl = new OleDbDataAdapter(Command,connection);
            new OleDbCommandBuilder(TempDaTbl);
            Temptbl = new DataTable();
            TempDaTbl.Fill(Temptbl);

            bool notnull = true;
            int count = 0;
            //AddStudent all values from a column to a list
            while (notnull)
            {
                try {
                    
                    ListFromColumm.Add((string)Temptbl.Rows[count][column]);
                }
                catch
                {
                    notnull = false;
                }

                count++;
                }

            return ListFromColumm;


        }

        private void TXTPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
