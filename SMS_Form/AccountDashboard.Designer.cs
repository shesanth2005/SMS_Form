namespace SMS_Form
{
    partial class AccountDashboard
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
            this.student_groupBox = new System.Windows.Forms.GroupBox();
            this.text_role = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.Label();
            this.realname = new System.Windows.Forms.TextBox();
            this.txt_role = new System.Windows.Forms.Label();
            this.student_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // student_groupBox
            // 
            this.student_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.student_groupBox.Controls.Add(this.text_role);
            this.student_groupBox.Controls.Add(this.txt_username);
            this.student_groupBox.Controls.Add(this.name);
            this.student_groupBox.Controls.Add(this.txt_name);
            this.student_groupBox.Controls.Add(this.realname);
            this.student_groupBox.Controls.Add(this.txt_role);
            this.student_groupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_groupBox.ForeColor = System.Drawing.Color.Black;
            this.student_groupBox.Location = new System.Drawing.Point(20, 20);
            this.student_groupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.student_groupBox.Name = "student_groupBox";
            this.student_groupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.student_groupBox.Size = new System.Drawing.Size(453, 144);
            this.student_groupBox.TabIndex = 11;
            this.student_groupBox.TabStop = false;
            this.student_groupBox.Text = "User Details";
            // 
            // text_role
            // 
            this.text_role.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_role.Location = new System.Drawing.Point(142, 97);
            this.text_role.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_role.Name = "text_role";
            this.text_role.Size = new System.Drawing.Size(230, 25);
            this.text_role.TabIndex = 6;
            // 
            // txt_username
            // 
            this.txt_username.AutoSize = true;
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.Location = new System.Drawing.Point(72, 30);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(67, 17);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "Username";
            this.txt_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.name.Location = new System.Drawing.Point(142, 27);
            this.name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(230, 25);
            this.name.TabIndex = 3;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(75, 65);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(43, 17);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "Name";
            this.txt_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // realname
            // 
            this.realname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realname.Location = new System.Drawing.Point(142, 62);
            this.realname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.realname.Name = "realname";
            this.realname.Size = new System.Drawing.Size(230, 25);
            this.realname.TabIndex = 4;
            // 
            // txt_role
            // 
            this.txt_role.AutoSize = true;
            this.txt_role.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_role.ForeColor = System.Drawing.Color.Black;
            this.txt_role.Location = new System.Drawing.Point(75, 100);
            this.txt_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(34, 17);
            this.txt_role.TabIndex = 2;
            this.txt_role.Text = "Role";
            this.txt_role.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccountDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.student_groupBox);
            this.Name = "AccountDashboard";
            this.Text = "AccountDashboard";
            this.student_groupBox.ResumeLayout(false);
            this.student_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox student_groupBox;
        private System.Windows.Forms.Label txt_username;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.TextBox realname;
        private System.Windows.Forms.Label txt_role;
        private System.Windows.Forms.TextBox text_role;
    }
}