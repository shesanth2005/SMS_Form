namespace SMS_Form
{
    partial class Users
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
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.role_comboBox = new System.Windows.Forms.ComboBox();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.btn_savechange = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(128, 61);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 20);
            this.name.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(128, 99);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(200, 25);
            this.password.TabIndex = 3;
            // 
            // role_comboBox
            // 
            this.role_comboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_comboBox.FormattingEnabled = true;
            this.role_comboBox.Location = new System.Drawing.Point(128, 138);
            this.role_comboBox.Name = "role_comboBox";
            this.role_comboBox.Size = new System.Drawing.Size(200, 25);
            this.role_comboBox.TabIndex = 11;
            // 
            // dgv_admin
            // 
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Location = new System.Drawing.Point(46, 231);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.Size = new System.Drawing.Size(554, 150);
            this.dgv_admin.TabIndex = 13;
            this.dgv_admin.SelectionChanged += new System.EventHandler(this.dgv_admin_CellContentClick);
            // 
            // btn_savechange
            // 
            this.btn_savechange.Location = new System.Drawing.Point(307, 187);
            this.btn_savechange.Name = "btn_savechange";
            this.btn_savechange.Size = new System.Drawing.Size(198, 23);
            this.btn_savechange.TabIndex = 14;
            this.btn_savechange.Text = "Save Changes";
            this.btn_savechange.UseVisualStyleBackColor = true;
            this.btn_savechange.Click += new System.EventHandler(this.btn_savechange_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(46, 187);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(198, 23);
            this.delete_button.TabIndex = 15;
            this.delete_button.Text = "Delete User";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.btn_savechange);
            this.Controls.Add(this.dgv_admin);
            this.Controls.Add(this.role_comboBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Name = "Users";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox role_comboBox;
        private System.Windows.Forms.DataGridView dgv_admin;
        private System.Windows.Forms.Button btn_savechange;
        private System.Windows.Forms.Button delete_button;
    }
}