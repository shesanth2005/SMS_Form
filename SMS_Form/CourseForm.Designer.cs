namespace SMS_Form
{
    partial class CourseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            this.CourseView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.TextBox();
            this.btn_add_course = new System.Windows.Forms.Button();
            this.btn_course_update = new System.Windows.Forms.Button();
            this.btn_course_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CourseView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CourseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CourseView.Location = new System.Drawing.Point(21, 129);
            this.CourseView.Name = "CourseView";
            this.CourseView.Size = new System.Drawing.Size(332, 276);
            this.CourseView.TabIndex = 0;
            this.CourseView.SelectionChanged += new System.EventHandler(this.CourseView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name:";
            // 
            // courseName
            // 
            this.courseName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.Location = new System.Drawing.Point(133, 30);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(189, 23);
            this.courseName.TabIndex = 2;
            // 
            // btn_add_course
            // 
            this.btn_add_course.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_course.Location = new System.Drawing.Point(252, 60);
            this.btn_add_course.Name = "btn_add_course";
            this.btn_add_course.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_add_course.Size = new System.Drawing.Size(75, 23);
            this.btn_add_course.TabIndex = 3;
            this.btn_add_course.Text = " Add";
            this.btn_add_course.UseVisualStyleBackColor = true;
            this.btn_add_course.Click += new System.EventHandler(this.btn_add_course_Click);
            // 
            // btn_course_update
            // 
            this.btn_course_update.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_course_update.Location = new System.Drawing.Point(5, 60);
            this.btn_course_update.Name = "btn_course_update";
            this.btn_course_update.Size = new System.Drawing.Size(75, 23);
            this.btn_course_update.TabIndex = 4;
            this.btn_course_update.Text = "Update";
            this.btn_course_update.UseVisualStyleBackColor = true;
            this.btn_course_update.Click += new System.EventHandler(this.btn_course_update_Click);
            // 
            // btn_course_delete
            // 
            this.btn_course_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_course_delete.Location = new System.Drawing.Point(129, 60);
            this.btn_course_delete.Name = "btn_course_delete";
            this.btn_course_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_course_delete.TabIndex = 5;
            this.btn_course_delete.Text = "Delete";
            this.btn_course_delete.UseVisualStyleBackColor = true;
            this.btn_course_delete.Click += new System.EventHandler(this.btn_course_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Course Records";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_course_update);
            this.groupBox1.Controls.Add(this.btn_add_course);
            this.groupBox1.Controls.Add(this.btn_course_delete);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 97);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Details";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseView);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Course ";
            ((System.ComponentModel.ISupportInitialize)(this.CourseView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CourseView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.Button btn_add_course;
        private System.Windows.Forms.Button btn_course_update;
        private System.Windows.Forms.Button btn_course_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}