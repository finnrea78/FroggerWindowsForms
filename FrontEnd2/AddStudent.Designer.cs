namespace FrontEnd2
{
    partial class AddStudent
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
            this.TXTForename = new System.Windows.Forms.TextBox();
            this.TXTSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.TXTPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTForename
            // 
            this.TXTForename.Location = new System.Drawing.Point(96, 23);
            this.TXTForename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXTForename.Name = "TXTForename";
            this.TXTForename.Size = new System.Drawing.Size(207, 22);
            this.TXTForename.TabIndex = 1;
            this.TXTForename.TextChanged += new System.EventHandler(this.TXTForename_TextChanged);
            // 
            // TXTSurname
            // 
            this.TXTSurname.Location = new System.Drawing.Point(96, 55);
            this.TXTSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXTSurname.Name = "TXTSurname";
            this.TXTSurname.Size = new System.Drawing.Size(207, 22);
            this.TXTSurname.TabIndex = 2;
            this.TXTSurname.TextChanged += new System.EventHandler(this.TXTSurname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Forename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname";
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(312, 23);
            this.BTNAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(123, 95);
            this.BTNAdd.TabIndex = 8;
            this.BTNAdd.Text = "Add";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // TXTPassword
            // 
            this.TXTPassword.Location = new System.Drawing.Point(96, 85);
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.Size = new System.Drawing.Size(207, 22);
            this.TXTPassword.TabIndex = 9;
            this.TXTPassword.TextChanged += new System.EventHandler(this.TXTPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTPassword);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTSurname);
            this.Controls.Add(this.TXTForename);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.Leave += new System.EventHandler(this.AddStudent_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTForename;
        private System.Windows.Forms.TextBox TXTSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.TextBox TXTPassword;
        private System.Windows.Forms.Label label1;
    }
}