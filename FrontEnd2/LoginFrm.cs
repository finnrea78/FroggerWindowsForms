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

namespace FrontEnd2
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {

            if (UsernameTXT.Text != "" && PasswordTXT.Text != "")
            {

                bool Success = true;
                Data Students = null;


                Success = true;
                // Create clear for students to allow for retrying of login 

                try
                {

                    Students = new Data(UsernameTXT.Text, PasswordTXT.Text, "Users");
                    // Creation of tables 
                }
                catch (ArgumentException Ex)
                {
                    MessageBox.Show("Incorrect username or Password", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(Ex);
                    Success = false;
                    PasswordTXT.Clear();
                    UsernameTXT.Clear();
                }



                // checks if user inputs correct userr name and password allows for them to retry 

                if (Success)
                {
                    this.Hide();
                    TeacherFrm FrmTeacher = new TeacherFrm(Students, UsernameTXT.Text, PasswordTXT.Text);
                    FrmTeacher.Show();

                }
            }
            else if (UsernameTXT.Text != "" && PasswordTXT.Text == "")
            {
                MessageBox.Show("Missing Password, please fill all fields", "Missing login details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (UsernameTXT.Text == "" && PasswordTXT.Text != "")
            {
                MessageBox.Show("Missing Username, please fill all fields", "Missing login details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Missing login details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void BTNHome_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Close();
        }

        private void PasswordTXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
