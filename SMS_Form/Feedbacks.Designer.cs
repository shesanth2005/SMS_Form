namespace SMS_Form
{
    partial class Feedbacks
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
            this.txt_feedback = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.dgv_feedback = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_feedback)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feedback";
            // 
            // txt_feedback
            // 
            this.txt_feedback.Location = new System.Drawing.Point(18, 51);
            this.txt_feedback.Margin = new System.Windows.Forms.Padding(4);
            this.txt_feedback.Multiline = true;
            this.txt_feedback.Name = "txt_feedback";
            this.txt_feedback.Size = new System.Drawing.Size(548, 171);
            this.txt_feedback.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(491, 229);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 25);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // dgv_feedback
            // 
            this.dgv_feedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_feedback.Location = new System.Drawing.Point(18, 260);
            this.dgv_feedback.Name = "dgv_feedback";
            this.dgv_feedback.Size = new System.Drawing.Size(949, 414);
            this.dgv_feedback.TabIndex = 3;
            this.dgv_feedback.SelectionChanged += new System.EventHandler(this.dgv_feedback_CellContentClick);
            // 
            // Feedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 686);
            this.Controls.Add(this.dgv_feedback);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_feedback);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Feedbacks";
            this.Text = "Feedbacks";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_feedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_feedback;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DataGridView dgv_feedback;
    }
}