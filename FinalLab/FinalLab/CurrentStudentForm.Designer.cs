namespace FinalLab
{
    partial class CurrentStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentStudentForm));
            this.comboStudent = new System.Windows.Forms.ComboBox();
            this.btnTakeQuiz = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboStudent
            // 
            this.comboStudent.FormattingEnabled = true;
            this.comboStudent.Location = new System.Drawing.Point(492, 151);
            this.comboStudent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboStudent.Name = "comboStudent";
            this.comboStudent.Size = new System.Drawing.Size(238, 33);
            this.comboStudent.TabIndex = 0;
            // 
            // btnTakeQuiz
            // 
            this.btnTakeQuiz.Location = new System.Drawing.Point(492, 210);
            this.btnTakeQuiz.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTakeQuiz.Name = "btnTakeQuiz";
            this.btnTakeQuiz.Size = new System.Drawing.Size(238, 44);
            this.btnTakeQuiz.TabIndex = 1;
            this.btnTakeQuiz.Text = "Take Quiz";
            this.btnTakeQuiz.UseVisualStyleBackColor = true;
            this.btnTakeQuiz.Click += new System.EventHandler(this.btnTakeQuiz_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(492, 278);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(238, 44);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select student name \r\nto start taking quiz.";
            // 
            // CurrentStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTakeQuiz);
            this.Controls.Add(this.comboStudent);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CurrentStudentForm";
            this.Text = "Current Student";
            this.Load += new System.EventHandler(this.CurrentStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboStudent;
        private System.Windows.Forms.Button btnTakeQuiz;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}