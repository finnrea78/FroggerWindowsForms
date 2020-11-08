namespace FrontEnd2
{
    partial class AddTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNADD = new System.Windows.Forms.Button();
            this.TXT_Firstname = new System.Windows.Forms.TextBox();
            this.TXT_surname = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.TXT_Class = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNADD
            // 
            this.BTNADD.Location = new System.Drawing.Point(305, 11);
            this.BTNADD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(112, 110);
            this.BTNADD.TabIndex = 0;
            this.BTNADD.Text = "Add New Teacher";
            this.BTNADD.UseVisualStyleBackColor = true;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // TXT_Firstname
            // 
            this.TXT_Firstname.Location = new System.Drawing.Point(96, 11);
            this.TXT_Firstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Firstname.Name = "TXT_Firstname";
            this.TXT_Firstname.Size = new System.Drawing.Size(200, 22);
            this.TXT_Firstname.TabIndex = 1;
            this.TXT_Firstname.TextChanged += new System.EventHandler(this.TXT_Firstname_TextChanged);
            // 
            // TXT_surname
            // 
            this.TXT_surname.Location = new System.Drawing.Point(96, 41);
            this.TXT_surname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_surname.Name = "TXT_surname";
            this.TXT_surname.Size = new System.Drawing.Size(200, 22);
            this.TXT_surname.TabIndex = 2;
            this.TXT_surname.TextChanged += new System.EventHandler(this.TXT_surname_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(16, 14);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(72, 17);
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "FirstName";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(16, 44);
            this.Surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(65, 17);
            this.Surname.TabIndex = 4;
            this.Surname.Text = "Surname";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(16, 74);
            this.Class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(42, 17);
            this.Class.TabIndex = 5;
            this.Class.Text = "Class";
            // 
            // TXT_Class
            // 
            this.TXT_Class.Location = new System.Drawing.Point(96, 71);
            this.TXT_Class.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Class.Name = "TXT_Class";
            this.TXT_Class.Size = new System.Drawing.Size(200, 22);
            this.TXT_Class.TabIndex = 6;
            this.TXT_Class.TextChanged += new System.EventHandler(this.TXT_Class_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // TXT_Password
            // 
            this.TXT_Password.Location = new System.Drawing.Point(96, 102);
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.Size = new System.Drawing.Size(200, 22);
            this.TXT_Password.TabIndex = 8;
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 143);
            this.Controls.Add(this.TXT_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_Class);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.TXT_surname);
            this.Controls.Add(this.TXT_Firstname);
            this.Controls.Add(this.BTNADD);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddTeacher";
            this.Text = "AddTeacher";
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.TextBox TXT_Firstname;
        private System.Windows.Forms.TextBox TXT_surname;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.TextBox TXT_Class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Password;
    }
}