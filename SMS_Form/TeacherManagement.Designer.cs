namespace SMS_Form
{
    partial class TeacherManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_teacher = new System.Windows.Forms.Button();
            this.btn_update_teach = new System.Windows.Forms.Button();
            this.LecturerView = new System.Windows.Forms.DataGridView();
            this.btn_delete_teach = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telephone);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lecturer Details";
            // 
            // telephone
            // 
            this.telephone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone.Location = new System.Drawing.Point(142, 97);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(230, 25);
            this.telephone.TabIndex = 5;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(142, 62);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(230, 25);
            this.address.TabIndex = 4;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(142, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(230, 25);
            this.name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btn_add_teacher
            // 
            this.btn_add_teacher.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_teacher.Location = new System.Drawing.Point(349, 170);
            this.btn_add_teacher.Name = "btn_add_teacher";
            this.btn_add_teacher.Size = new System.Drawing.Size(124, 25);
            this.btn_add_teacher.TabIndex = 1;
            this.btn_add_teacher.Text = "Add";
            this.btn_add_teacher.UseVisualStyleBackColor = true;
            this.btn_add_teacher.Click += new System.EventHandler(this.btn_add_teacher_Click);
            // 
            // btn_update_teach
            // 
            this.btn_update_teach.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_teach.Location = new System.Drawing.Point(20, 170);
            this.btn_update_teach.Name = "btn_update_teach";
            this.btn_update_teach.Size = new System.Drawing.Size(124, 25);
            this.btn_update_teach.TabIndex = 2;
            this.btn_update_teach.Text = "Update";
            this.btn_update_teach.UseVisualStyleBackColor = true;
            this.btn_update_teach.Click += new System.EventHandler(this.btn_update_teach_Click);
            // 
            // LecturerView
            // 
            this.LecturerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturerView.Location = new System.Drawing.Point(20, 229);
            this.LecturerView.Name = "LecturerView";
            this.LecturerView.Size = new System.Drawing.Size(453, 301);
            this.LecturerView.TabIndex = 3;
            this.LecturerView.SelectionChanged += new System.EventHandler(this.LecturerView_CellContentClick);
            // 
            // btn_delete_teach
            // 
            this.btn_delete_teach.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_teach.Location = new System.Drawing.Point(182, 170);
            this.btn_delete_teach.Name = "btn_delete_teach";
            this.btn_delete_teach.Size = new System.Drawing.Size(124, 25);
            this.btn_delete_teach.TabIndex = 4;
            this.btn_delete_teach.Text = "Delete";
            this.btn_delete_teach.UseVisualStyleBackColor = true;
            this.btn_delete_teach.Click += new System.EventHandler(this.btn_delete_teach_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lecturer Records";
            // 
            // TeacherManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 542);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_delete_teach);
            this.Controls.Add(this.LecturerView);
            this.Controls.Add(this.btn_update_teach);
            this.Controls.Add(this.btn_add_teacher);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeacherManagement";
            this.Text = "Lecturer Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button btn_add_teacher;
        private System.Windows.Forms.Button btn_update_teach;
        private System.Windows.Forms.DataGridView LecturerView;
        private System.Windows.Forms.Button btn_delete_teach;
        private System.Windows.Forms.Label label4;
    }
}