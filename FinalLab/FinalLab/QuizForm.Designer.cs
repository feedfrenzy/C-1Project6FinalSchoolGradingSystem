namespace FinalLab
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.comboQuestions = new System.Windows.Forms.ComboBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.btnAnswerEnter = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.comboStudent = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblpointShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboQuestions
            // 
            this.comboQuestions.FormattingEnabled = true;
            this.comboQuestions.Location = new System.Drawing.Point(662, 105);
            this.comboQuestions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboQuestions.Name = "comboQuestions";
            this.comboQuestions.Size = new System.Drawing.Size(238, 33);
            this.comboQuestions.TabIndex = 0;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(662, 172);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(238, 31);
            this.txtAnswer.TabIndex = 1;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(536, 178);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(89, 25);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Location = new System.Drawing.Point(536, 111);
            this.lblQuestions.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(115, 25);
            this.lblQuestions.TabIndex = 3;
            this.lblQuestions.Text = "Questions:";
            // 
            // btnAnswerEnter
            // 
            this.btnAnswerEnter.Location = new System.Drawing.Point(770, 308);
            this.btnAnswerEnter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAnswerEnter.Name = "btnAnswerEnter";
            this.btnAnswerEnter.Size = new System.Drawing.Size(150, 44);
            this.btnAnswerEnter.TabIndex = 4;
            this.btnAnswerEnter.Text = "Enter";
            this.btnAnswerEnter.UseVisualStyleBackColor = true;
            this.btnAnswerEnter.Click += new System.EventHandler(this.btnAnswerEnter_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(648, 260);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(78, 25);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "Points:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(536, 42);
            this.lblStudent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(92, 25);
            this.lblStudent.TabIndex = 6;
            this.lblStudent.Text = "Student:";
            // 
            // comboStudent
            // 
            this.comboStudent.FormattingEnabled = true;
            this.comboStudent.Location = new System.Drawing.Point(662, 36);
            this.comboStudent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboStudent.Name = "comboStudent";
            this.comboStudent.Size = new System.Drawing.Size(238, 33);
            this.comboStudent.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(534, 308);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 44);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblpointShow
            // 
            this.lblpointShow.AutoSize = true;
            this.lblpointShow.Location = new System.Drawing.Point(722, 260);
            this.lblpointShow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblpointShow.Name = "lblpointShow";
            this.lblpointShow.Size = new System.Drawing.Size(0, 25);
            this.lblpointShow.TabIndex = 9;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(964, 411);
            this.Controls.Add(this.lblpointShow);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboStudent);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnAnswerEnter);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.comboQuestions);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "QuizForm";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboQuestions;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Button btnAnswerEnter;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox comboStudent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblpointShow;
    }
}