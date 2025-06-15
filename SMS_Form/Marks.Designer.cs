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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marks)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_exam
            // 
            this.cmb_exam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_exam.FormattingEnabled = true;
            this.cmb_exam.Location = new System.Drawing.Point(145, 70);
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
            this.dgv_marks.Location = new System.Drawing.Point(145, 185);
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
            this.cmb_student.Location = new System.Drawing.Point(298, 68);
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
            // Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete_marks);
            this.Controls.Add(this.btn_update_mark);
            this.Controls.Add(this.cmb_student);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_marks);
            this.Controls.Add(this.txt_marks);
            this.Controls.Add(this.cmb_exam);
            this.Name = "Marks";
            this.Text = "Marks";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marks)).EndInit();
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
    }
}