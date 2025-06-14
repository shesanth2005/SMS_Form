﻿namespace SMS_Form
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
            this.lecturerName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.courseName = new System.Windows.Forms.TextBox();
            this.LecturerView = new System.Windows.Forms.DataGridView();
            this.CourseView = new System.Windows.Forms.DataGridView();
            this.LecturerCourseView = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
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
            // lecturerName
            // 
            this.lecturerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerName.Location = new System.Drawing.Point(170, 27);
            this.lecturerName.Multiline = true;
            this.lecturerName.Name = "lecturerName";
            this.lecturerName.ReadOnly = true;
            this.lecturerName.Size = new System.Drawing.Size(230, 25);
            this.lecturerName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lecturerName);
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
            this.LecturerView.SelectionChanged += new System.EventHandler(this.LecturerView_CellContentClick);
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
            this.LecturerCourseView.Location = new System.Drawing.Point(589, 190);
            this.LecturerCourseView.Name = "LecturerCourseView";
            this.LecturerCourseView.Size = new System.Drawing.Size(342, 150);
            this.LecturerCourseView.TabIndex = 6;
            this.LecturerCourseView.SelectionChanged += new System.EventHandler(this.LecturerCourseView_CellContentClick);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(457, 136);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(271, 136);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(114, 136);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // LecturersCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
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
        private System.Windows.Forms.TextBox lecturerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.DataGridView LecturerView;
        private System.Windows.Forms.DataGridView CourseView;
        private System.Windows.Forms.DataGridView LecturerCourseView;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}