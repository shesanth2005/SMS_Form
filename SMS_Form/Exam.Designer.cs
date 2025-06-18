namespace SMS_Form
{
    partial class Exam
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
            this.cmb_subject = new System.Windows.Forms.ComboBox();
            this.txt_exam_name = new System.Windows.Forms.TextBox();
            this.dgv_exam = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.student_groupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exam)).BeginInit();
            this.student_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_subject
            // 
            this.cmb_subject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_subject.FormattingEnabled = true;
            this.cmb_subject.Location = new System.Drawing.Point(324, 61);
            this.cmb_subject.Name = "cmb_subject";
            this.cmb_subject.Size = new System.Drawing.Size(121, 25);
            this.cmb_subject.TabIndex = 0;
            this.cmb_subject.SelectedIndexChanged += new System.EventHandler(this.cmb_subject_SelectedIndexChanged);
            // 
            // txt_exam_name
            // 
            this.txt_exam_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exam_name.Location = new System.Drawing.Point(126, 61);
            this.txt_exam_name.Name = "txt_exam_name";
            this.txt_exam_name.Size = new System.Drawing.Size(121, 25);
            this.txt_exam_name.TabIndex = 1;
            // 
            // dgv_exam
            // 
            this.dgv_exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_exam.Location = new System.Drawing.Point(20, 196);
            this.dgv_exam.Name = "dgv_exam";
            this.dgv_exam.Size = new System.Drawing.Size(453, 284);
            this.dgv_exam.TabIndex = 2;
            this.dgv_exam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_exam_CellContentClick);
            this.dgv_exam.SelectionChanged += new System.EventHandler(this.dgv_exam_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exam Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(398, 131);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 25);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(20, 131);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 25);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(203, 131);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 25);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // student_groupBox
            // 
            this.student_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.student_groupBox.Controls.Add(this.label2);
            this.student_groupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_groupBox.ForeColor = System.Drawing.Color.Black;
            this.student_groupBox.Location = new System.Drawing.Point(20, 20);
            this.student_groupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.student_groupBox.Name = "student_groupBox";
            this.student_groupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.student_groupBox.Size = new System.Drawing.Size(453, 105);
            this.student_groupBox.TabIndex = 11;
            this.student_groupBox.TabStop = false;
            this.student_groupBox.Text = "Exam Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Exam Records";
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 492);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_exam);
            this.Controls.Add(this.txt_exam_name);
            this.Controls.Add(this.cmb_subject);
            this.Controls.Add(this.student_groupBox);
            this.Name = "Exam";
            this.Text = "Exam";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exam)).EndInit();
            this.student_groupBox.ResumeLayout(false);
            this.student_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_subject;
        private System.Windows.Forms.TextBox txt_exam_name;
        private System.Windows.Forms.DataGridView dgv_exam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox student_groupBox;
        private System.Windows.Forms.Label label4;
    }
}