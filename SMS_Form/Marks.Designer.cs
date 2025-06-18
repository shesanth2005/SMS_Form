namespace SMS_Form
{
    partial class Marks
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
            this.cmb_exam = new System.Windows.Forms.ComboBox();
            this.txt_marks = new System.Windows.Forms.TextBox();
            this.dgv_marks = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.cmb_student = new System.Windows.Forms.ComboBox();
            this.btn_update_mark = new System.Windows.Forms.Button();
            this.btn_delete_marks = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_exam
            // 
            this.cmb_exam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_exam.FormattingEnabled = true;
            this.cmb_exam.Location = new System.Drawing.Point(265, 70);
            this.cmb_exam.Name = "cmb_exam";
            this.cmb_exam.Size = new System.Drawing.Size(121, 25);
            this.cmb_exam.TabIndex = 0;
            // 
            // txt_marks
            // 
            this.txt_marks.Location = new System.Drawing.Point(473, 70);
            this.txt_marks.Name = "txt_marks";
            this.txt_marks.Size = new System.Drawing.Size(100, 20);
            this.txt_marks.TabIndex = 2;
            // 
            // dgv_marks
            // 
            this.dgv_marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marks.Location = new System.Drawing.Point(38, 178);
            this.dgv_marks.Name = "dgv_marks";
            this.dgv_marks.Size = new System.Drawing.Size(428, 150);
            this.dgv_marks.TabIndex = 3;
            this.dgv_marks.SelectionChanged += new System.EventHandler(this.dgv_marks_CellContentClick);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(473, 131);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cmb_student
            // 
            this.cmb_student.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_student.FormattingEnabled = true;
            this.cmb_student.Location = new System.Drawing.Point(81, 30);
            this.cmb_student.Name = "cmb_student";
            this.cmb_student.Size = new System.Drawing.Size(121, 25);
            this.cmb_student.TabIndex = 7;
            // 
            // btn_update_mark
            // 
            this.btn_update_mark.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_mark.Location = new System.Drawing.Point(344, 131);
            this.btn_update_mark.Name = "btn_update_mark";
            this.btn_update_mark.Size = new System.Drawing.Size(75, 23);
            this.btn_update_mark.TabIndex = 8;
            this.btn_update_mark.Text = "Update";
            this.btn_update_mark.UseVisualStyleBackColor = true;
            this.btn_update_mark.Click += new System.EventHandler(this.btn_update_mark_Click);
            // 
            // btn_delete_marks
            // 
            this.btn_delete_marks.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_marks.Location = new System.Drawing.Point(191, 140);
            this.btn_delete_marks.Name = "btn_delete_marks";
            this.btn_delete_marks.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_marks.TabIndex = 9;
            this.btn_delete_marks.Text = "Delete";
            this.btn_delete_marks.UseVisualStyleBackColor = true;
            this.btn_delete_marks.Click += new System.EventHandler(this.btn_delete_marks_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_student);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 131);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marks Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(124, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Exam Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(118, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Exam Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(422, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Marks";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_delete_marks);
            this.Controls.Add(this.btn_update_mark);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_marks);
            this.Controls.Add(this.txt_marks);
            this.Controls.Add(this.cmb_exam);
            this.Controls.Add(this.groupBox1);
            this.Name = "Marks";
            this.Text = "Marks";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_exam;
        private System.Windows.Forms.TextBox txt_marks;
        private System.Windows.Forms.DataGridView dgv_marks;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmb_student;
        private System.Windows.Forms.Button btn_update_mark;
        private System.Windows.Forms.Button btn_delete_marks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}