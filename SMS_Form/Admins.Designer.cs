namespace SMS_Form
{
    partial class Admins
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
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.btn_create = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_admin
            // 
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Location = new System.Drawing.Point(57, 183);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.Size = new System.Drawing.Size(438, 198);
            this.dgv_admin.TabIndex = 0;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_create.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(57, 137);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(263, 23);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "Create Account";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(68, 55);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(263, 23);
            this.name.TabIndex = 7;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(68, 97);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(263, 23);
            this.password.TabIndex = 8;
            // 
            // Admins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dgv_admin);
            this.Name = "Admins";
            this.Text = "Admins";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_admin;
        private System.Windows.Forms.Button btn_create;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
    }
}