using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StudentBTN_Click(object sender, EventArgs e)
        {
            StudentFrm StudentFormOpen = new StudentFrm();
            StudentFormOpen.Show();
            this.Hide();
        }

        private void TeacherBTN_Click(object sender, EventArgs e)
        {
            LoginFrm LoginFormOpen = new LoginFrm();
            LoginFormOpen.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
