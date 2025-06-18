namespace SMS_Form
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_course = new System.Windows.Forms.Button();
            this.btn_subject = new System.Windows.Forms.Button();
            this.btn_room = new System.Windows.Forms.Button();
            this.btn_lecturer = new System.Windows.Forms.Button();
            this.btn_lec_dtail = new System.Windows.Forms.Button();
            this.mainMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLecturerSubmenu = new System.Windows.Forms.Panel();
            this.btn_lec_course = new System.Windows.Forms.Button();
            this.btn_timetable = new System.Windows.Forms.Button();
            this.btn_marks = new System.Windows.Forms.Button();
            this.btn_exam = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_staff = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuPanel.SuspendLayout();
            this.panelLecturerSubmenu.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_student
            // 
            this.btn_student.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_student.FlatAppearance.BorderSize = 0;
            this.btn_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_student.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.ForeColor = System.Drawing.Color.White;
            this.btn_student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_student.Location = new System.Drawing.Point(3, 3);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(234, 50);
            this.btn_student.TabIndex = 0;
            this.btn_student.Text = "Manage Student";
            this.btn_student.UseVisualStyleBackColor = false;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // btn_course
            // 
            this.btn_course.FlatAppearance.BorderSize = 0;
            this.btn_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_course.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_course.Location = new System.Drawing.Point(3, 355);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(234, 50);
            this.btn_course.TabIndex = 1;
            this.btn_course.Text = "Manage Course";
            this.btn_course.UseVisualStyleBackColor = true;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_subject
            // 
            this.btn_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_subject.FlatAppearance.BorderSize = 0;
            this.btn_subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subject.ForeColor = System.Drawing.Color.White;
            this.btn_subject.Location = new System.Drawing.Point(3, 243);
            this.btn_subject.Name = "btn_subject";
            this.btn_subject.Size = new System.Drawing.Size(234, 50);
            this.btn_subject.TabIndex = 2;
            this.btn_subject.Text = "Manage Subject";
            this.btn_subject.UseVisualStyleBackColor = false;
            this.btn_subject.Click += new System.EventHandler(this.btn_subject_Click);
            // 
            // btn_room
            // 
            this.btn_room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_room.FlatAppearance.BorderSize = 0;
            this.btn_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_room.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room.ForeColor = System.Drawing.Color.White;
            this.btn_room.Location = new System.Drawing.Point(3, 187);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(234, 50);
            this.btn_room.TabIndex = 3;
            this.btn_room.Text = "Manage Room";
            this.btn_room.UseVisualStyleBackColor = false;
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // btn_lecturer
            // 
            this.btn_lecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_lecturer.FlatAppearance.BorderSize = 0;
            this.btn_lecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lecturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lecturer.ForeColor = System.Drawing.Color.White;
            this.btn_lecturer.Location = new System.Drawing.Point(3, 59);
            this.btn_lecturer.Name = "btn_lecturer";
            this.btn_lecturer.Size = new System.Drawing.Size(234, 50);
            this.btn_lecturer.TabIndex = 6;
            this.btn_lecturer.Text = "Manage Lecturer";
            this.btn_lecturer.UseVisualStyleBackColor = false;
            this.btn_lecturer.Click += new System.EventHandler(this.btn_lecturer_Click);
            // 
            // btn_lec_dtail
            // 
            this.btn_lec_dtail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_lec_dtail.FlatAppearance.BorderSize = 0;
            this.btn_lec_dtail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lec_dtail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lec_dtail.ForeColor = System.Drawing.Color.White;
            this.btn_lec_dtail.Location = new System.Drawing.Point(0, 3);
            this.btn_lec_dtail.Name = "btn_lec_dtail";
            this.btn_lec_dtail.Size = new System.Drawing.Size(214, 35);
            this.btn_lec_dtail.TabIndex = 7;
            this.btn_lec_dtail.Text = "- Lecturer Details";
            this.btn_lec_dtail.UseVisualStyleBackColor = false;
            this.btn_lec_dtail.Click += new System.EventHandler(this.btn_lec_dtail_Click);
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.AutoScroll = true;
            this.mainMenuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mainMenuPanel.Controls.Add(this.btn_student);
            this.mainMenuPanel.Controls.Add(this.btn_lecturer);
            this.mainMenuPanel.Controls.Add(this.panelLecturerSubmenu);
            this.mainMenuPanel.Controls.Add(this.btn_room);
            this.mainMenuPanel.Controls.Add(this.btn_subject);
            this.mainMenuPanel.Controls.Add(this.btn_timetable);
            this.mainMenuPanel.Controls.Add(this.btn_course);
            this.mainMenuPanel.Controls.Add(this.btn_marks);
            this.mainMenuPanel.Controls.Add(this.btn_exam);
            this.mainMenuPanel.Controls.Add(this.btn_user);
            this.mainMenuPanel.Controls.Add(this.btn_staff);
            this.mainMenuPanel.Controls.Add(this.btn_admin);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainMenuPanel.ForeColor = System.Drawing.Color.White;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 68);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(237, 769);
            this.mainMenuPanel.TabIndex = 8;
            this.mainMenuPanel.WrapContents = false;
            // 
            // panelLecturerSubmenu
            // 
            this.panelLecturerSubmenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLecturerSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelLecturerSubmenu.Controls.Add(this.btn_lec_course);
            this.panelLecturerSubmenu.Controls.Add(this.btn_lec_dtail);
            this.panelLecturerSubmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLecturerSubmenu.Location = new System.Drawing.Point(20, 112);
            this.panelLecturerSubmenu.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelLecturerSubmenu.Name = "panelLecturerSubmenu";
            this.panelLecturerSubmenu.Size = new System.Drawing.Size(217, 72);
            this.panelLecturerSubmenu.TabIndex = 9;
            this.panelLecturerSubmenu.Visible = false;
            // 
            // btn_lec_course
            // 
            this.btn_lec_course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_lec_course.FlatAppearance.BorderSize = 0;
            this.btn_lec_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lec_course.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lec_course.ForeColor = System.Drawing.Color.White;
            this.btn_lec_course.Location = new System.Drawing.Point(0, 34);
            this.btn_lec_course.Name = "btn_lec_course";
            this.btn_lec_course.Size = new System.Drawing.Size(214, 35);
            this.btn_lec_course.TabIndex = 8;
            this.btn_lec_course.Text = "- Lecturer Courses";
            this.btn_lec_course.UseVisualStyleBackColor = false;
            this.btn_lec_course.Click += new System.EventHandler(this.btn_lec_course_Click);
            // 
            // btn_timetable
            // 
            this.btn_timetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_timetable.FlatAppearance.BorderSize = 0;
            this.btn_timetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timetable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timetable.Location = new System.Drawing.Point(3, 299);
            this.btn_timetable.Name = "btn_timetable";
            this.btn_timetable.Size = new System.Drawing.Size(234, 50);
            this.btn_timetable.TabIndex = 10;
            this.btn_timetable.Text = "Timetable";
            this.btn_timetable.UseVisualStyleBackColor = false;
            this.btn_timetable.Click += new System.EventHandler(this.btn_timetable_Click);
            // 
            // btn_marks
            // 
            this.btn_marks.FlatAppearance.BorderSize = 0;
            this.btn_marks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marks.Location = new System.Drawing.Point(3, 411);
            this.btn_marks.Name = "btn_marks";
            this.btn_marks.Size = new System.Drawing.Size(234, 50);
            this.btn_marks.TabIndex = 9;
            this.btn_marks.Text = "Marks";
            this.btn_marks.UseVisualStyleBackColor = true;
            this.btn_marks.Click += new System.EventHandler(this.btn_marks_Click);
            // 
            // btn_exam
            // 
            this.btn_exam.FlatAppearance.BorderSize = 0;
            this.btn_exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exam.Location = new System.Drawing.Point(3, 467);
            this.btn_exam.Name = "btn_exam";
            this.btn_exam.Size = new System.Drawing.Size(234, 50);
            this.btn_exam.TabIndex = 9;
            this.btn_exam.Text = "Exam";
            this.btn_exam.UseVisualStyleBackColor = true;
            this.btn_exam.Click += new System.EventHandler(this.btn_exam_Click);
            // 
            // btn_user
            // 
            this.btn_user.FlatAppearance.BorderSize = 0;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.Location = new System.Drawing.Point(3, 523);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(234, 50);
            this.btn_user.TabIndex = 12;
            this.btn_user.Text = "Manage User";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.FlatAppearance.BorderSize = 0;
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff.Location = new System.Drawing.Point(3, 579);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(234, 50);
            this.btn_staff.TabIndex = 11;
            this.btn_staff.Text = "Manage Staff";
            this.btn_staff.UseVisualStyleBackColor = true;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Location = new System.Drawing.Point(3, 635);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(234, 50);
            this.btn_admin.TabIndex = 13;
            this.btn_admin.Text = "Manage Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.logo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1286, 68);
            this.TopPanel.TabIndex = 9;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::SMS_Form.Properties.Resources.UNICOM_TIC_LOGO;
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(234, 59);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(237, 68);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1049, 769);
            this.mainPanel.TabIndex = 10;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 837);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.mainMenuPanel.ResumeLayout(false);
            this.panelLecturerSubmenu.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_subject;
        private System.Windows.Forms.Button btn_room;
        private System.Windows.Forms.Button btn_lecturer;
        private System.Windows.Forms.Button btn_lec_dtail;
        private System.Windows.Forms.FlowLayoutPanel mainMenuPanel;
        private System.Windows.Forms.Button btn_lec_course;
        private System.Windows.Forms.Panel panelLecturerSubmenu;
        private System.Windows.Forms.Button btn_timetable;
        private System.Windows.Forms.Button btn_exam;
        private System.Windows.Forms.Button btn_marks;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.FlowLayoutPanel TopPanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}