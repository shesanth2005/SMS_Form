namespace SMS_Form
{
    partial class SubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectForm));
            this.course_comboBox = new System.Windows.Forms.ComboBox();
            this.btn_add_subject = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.SubjectView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update_subject = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_subject_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // course_comboBox
            // 
            this.course_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course_comboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_comboBox.FormattingEnabled = true;
            this.course_comboBox.Location = new System.Drawing.Point(142, 62);
            this.course_comboBox.Name = "course_comboBox";
            this.course_comboBox.Size = new System.Drawing.Size(230, 25);
            this.course_comboBox.TabIndex = 1;
            // 
            // btn_add_subject
            // 
            this.btn_add_subject.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_subject.Location = new System.Drawing.Point(336, 135);
            this.btn_add_subject.Name = "btn_add_subject";
            this.btn_add_subject.Size = new System.Drawing.Size(102, 23);
            this.btn_add_subject.TabIndex = 2;
            this.btn_add_subject.Text = "Add";
            this.btn_add_subject.UseVisualStyleBackColor = true;
            this.btn_add_subject.Click += new System.EventHandler(this.btn_add_subject_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(142, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(230, 25);
            this.name.TabIndex = 3;
            // 
            // SubjectView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SubjectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjectView.DefaultCellStyle = dataGridViewCellStyle2;
            this.SubjectView.Location = new System.Drawing.Point(20, 190);
            this.SubjectView.Name = "SubjectView";
            this.SubjectView.Size = new System.Drawing.Size(418, 248);
            this.SubjectView.TabIndex = 4;
            this.SubjectView.SelectionChanged += new System.EventHandler(this.SubjectView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.course_comboBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(49, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Course Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject Name:";
            // 
            // btn_update_subject
            // 
            this.btn_update_subject.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_subject.Location = new System.Drawing.Point(20, 135);
            this.btn_update_subject.Name = "btn_update_subject";
            this.btn_update_subject.Size = new System.Drawing.Size(102, 23);
            this.btn_update_subject.TabIndex = 6;
            this.btn_update_subject.Text = "Update";
            this.btn_update_subject.UseVisualStyleBackColor = true;
            this.btn_update_subject.Click += new System.EventHandler(this.btn_update_subject_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subject Records";
            // 
            // btn_subject_delete
            // 
            this.btn_subject_delete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subject_delete.Location = new System.Drawing.Point(177, 135);
            this.btn_subject_delete.Name = "btn_subject_delete";
            this.btn_subject_delete.Size = new System.Drawing.Size(102, 23);
            this.btn_subject_delete.TabIndex = 8;
            this.btn_subject_delete.Text = "Delete";
            this.btn_subject_delete.UseVisualStyleBackColor = true;
            this.btn_subject_delete.Click += new System.EventHandler(this.btn_subject_delete_Click);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 459);
            this.Controls.Add(this.btn_subject_delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_update_subject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SubjectView);
            this.Controls.Add(this.btn_add_subject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SubjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.SubjectView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox course_comboBox;
        private System.Windows.Forms.Button btn_add_subject;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridView SubjectView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update_subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_subject_delete;
    }
}