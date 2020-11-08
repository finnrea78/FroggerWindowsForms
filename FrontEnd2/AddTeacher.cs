using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace FrontEnd2
{
    public partial class AddTeacher : Form
    {
        private Data Teachers;
        public AddTeacher(Data inTeacher)
        {
            Teachers = inTeacher;
            InitializeComponent();
        }

        private void TXT_Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_Class_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNADD_Click(object sender, EventArgs e)
        {



            if (TXT_Class.Text != "" && TXT_Firstname.Text != "" && TXT_Password.Text != "" && TXT_surname.Text != "")
            {

                string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=ALevelDatabase; User ID=sa; Password=Pa$$w0rd";


                string NewTeacherInsert = "INSERT INTO Teachers([First Name], [Surname Name], Class)  values ( @FirstName, @Surname,@class)";
                string NewLoginInsert = "Insert INTO USERS values (@UserName, @Pass)";


                using (SqlConnection insertSQL = new SqlConnection(connectionString))
                {


                    SqlCommand myCommand = new SqlCommand(NewTeacherInsert, insertSQL);
                    SqlCommand myCommand2 = new SqlCommand(NewLoginInsert, insertSQL);


                    myCommand.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    myCommand.Parameters["@FirstName"].Value = TXT_Firstname.Text;

                    myCommand.Parameters.Add("@Surname", SqlDbType.VarChar);
                    myCommand.Parameters["@surname"].Value = TXT_surname.Text;

                    myCommand.Parameters.Add("@class", SqlDbType.VarChar);
                    myCommand.Parameters["@class"].Value = TXT_Class.Text;

                    myCommand2.Parameters.Add("@UserName", SqlDbType.VarChar);
                    myCommand2.Parameters["@UserName"].Value = string.Concat("T", CreateUserName(TXT_Firstname.Text, TXT_surname.Text, FindColumnValues("Username")));
                    // T added at the begining so a teacher and student with the same first and last name have Unique passwords
                    myCommand2.Parameters.Add("@Pass", SqlDbType.VarChar);
                    myCommand2.Parameters["@Pass"].Value = Hash(TXT_Password.Text);



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

                    MessageBox.Show(FindColumnValues("Username")[FindColumnValues("Username").Count - 1]);
                    TXT_Class.Clear();
                    TXT_Firstname.Clear();
                    TXT_surname.Clear();
                    TXT_Password.Clear();


                    Teachers.ReturnTeacherTbl().Clear();
                    Teachers.ReturnTeacherAdapter().Fill(Teachers.ReturnTeacherTbl());
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields", "missing fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
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





        private string CreateUserName(string FirstName, string Surname, List<string> CurrentlyUsed)
        {
            string UserName = "";
            int temp = 1;
            bool Existing = true;
            while (Existing)
            // Re-checks list to see if another now exists 
            {
                Existing = false;
                UserName = string.Concat(FirstName.Substring(0, 1), Surname, temp.ToString());

                for (int i = 0; i < CurrentlyUsed.Count(); i++)
                {
                    if (UserName == CurrentlyUsed[i])
                    {
                        temp++;
                        UserName = string.Concat(UserName.Substring(0, UserName.Length - 1), temp.ToString());
                        Existing = true;
                    }
                }
            }
            return UserName;



        }








        static List<string> FindColumnValues(string column)
        {
            // finds all values in a row this will be used to check if a prexisting username is being used 
            //so not to class usernames and passwords
            DataTable Temptbl;
            OleDbDataAdapter TempDaTbl;
            string Command = "select * from Users";
            string connection = @"Provider=SQLOLEDB; Data Source=.\SQLEXPRESS; Initial Catalog=ALevelDatabase; User ID= sa; Password= Pa$$w0rd";
            List<string> ListFromColumm = new List<string>();
            TempDaTbl = new OleDbDataAdapter(Command, connection);
            new OleDbCommandBuilder(TempDaTbl);
            Temptbl = new DataTable();
            TempDaTbl.Fill(Temptbl);
            bool notnull = true;
            int count = 0;
            //AddStudent all values from a column to a list
            while (notnull)
            {
                try
                {
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
        private void AddTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}

