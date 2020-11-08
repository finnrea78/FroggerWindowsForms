namespace FrontEnd2
{
    partial class Form1
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
            this.StudentBTN = new System.Windows.Forms.Button();
            this.TeacherBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentBTN
            // 
            this.StudentBTN.Location = new System.Drawing.Point(11, 10);
            this.StudentBTN.Margin = new System.Windows.Forms.Padding(2);
            this.StudentBTN.Name = "StudentBTN";
            this.StudentBTN.Size = new System.Drawing.Size(128, 228);
            this.StudentBTN.TabIndex = 0;
            this.StudentBTN.Text = "Student";
            this.StudentBTN.UseVisualStyleBackColor = true;
            this.StudentBTN.Click += new System.EventHandler(this.StudentBTN_Click);
            // 
            // TeacherBTN
            // 
            this.TeacherBTN.Location = new System.Drawing.Point(143, 10);
            this.TeacherBTN.Margin = new System.Windows.Forms.Padding(2);
            this.TeacherBTN.Name = "TeacherBTN";
            this.TeacherBTN.Size = new System.Drawing.Size(128, 228);
            this.TeacherBTN.TabIndex = 1;
            this.TeacherBTN.Text = "Teacher";
            this.TeacherBTN.UseVisualStyleBackColor = true;
            this.TeacherBTN.Click += new System.EventHandler(this.TeacherBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 253);
            this.Controls.Add(this.TeacherBTN);
            this.Controls.Add(this.StudentBTN);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentBTN;
        private System.Windows.Forms.Button TeacherBTN;
    }
}

