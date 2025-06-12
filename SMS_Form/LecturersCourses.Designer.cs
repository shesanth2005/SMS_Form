namespace SMS_Form
{
    partial class LecturersCourses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.courseName = new System.Windows.Forms.TextBox();
            this.LecturerView = new System.Windows.Forms.DataGridView();
            this.CourseView = new System.Windows.Forms.DataGridView();
            this.LecturerCourseView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerCourseView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(170, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(230, 25);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lecturer\'s  Courses";
            // 
            // courseName
            // 
            this.courseName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.Location = new System.Drawing.Point(170, 62);
            this.courseName.Multiline = true;
            this.courseName.Name = "courseName";
            this.courseName.ReadOnly = true;
            this.courseName.Size = new System.Drawing.Size(230, 25);
            this.courseName.TabIndex = 3;
            // 
            // LecturerView
            // 
            this.LecturerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturerView.Location = new System.Drawing.Point(20, 190);
            this.LecturerView.Name = "LecturerView";
            this.LecturerView.Size = new System.Drawing.Size(240, 150);
            this.LecturerView.TabIndex = 4;
            this.LecturerView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LecturerView_CellContentClick);
            // 
            // CourseView
            // 
            this.CourseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseView.Location = new System.Drawing.Point(328, 190);
            this.CourseView.Name = "CourseView";
            this.CourseView.Size = new System.Drawing.Size(245, 150);
            this.CourseView.TabIndex = 5;
            this.CourseView.SelectionChanged += new System.EventHandler(this.CourseView_CellContentClick);
            // 
            // LecturerCourseView
            // 
            this.LecturerCourseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturerCourseView.Location = new System.Drawing.Point(633, 190);
            this.LecturerCourseView.Name = "LecturerCourseView";
            this.LecturerCourseView.Size = new System.Drawing.Size(240, 150);
            this.LecturerCourseView.TabIndex = 6;
            // 
            // LecturersCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.LecturerCourseView);
            this.Controls.Add(this.CourseView);
            this.Controls.Add(this.LecturerView);
            this.Controls.Add(this.groupBox1);
            this.Name = "LecturersCourses";
            this.Text = "Lecturer\'s Courses";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerCourseView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.DataGridView LecturerView;
        private System.Windows.Forms.DataGridView CourseView;
        private System.Windows.Forms.DataGridView LecturerCourseView;
    }
}