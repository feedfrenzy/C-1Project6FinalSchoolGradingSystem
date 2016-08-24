namespace FinalLab
{
    partial class ProfessorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessorForm));
            this.comboProfessor = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.lblAnswers = new System.Windows.Forms.Label();
            this.txtQuestions = new System.Windows.Forms.TextBox();
            this.txtAnswers = new System.Windows.Forms.TextBox();
            this.txtQuestionID = new System.Windows.Forms.TextBox();
            this.lblQuestionID = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.comboDeleteQuiz = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddProfessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboProfessor
            // 
            this.comboProfessor.FormattingEnabled = true;
            this.comboProfessor.Location = new System.Drawing.Point(692, 42);
            this.comboProfessor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboProfessor.Name = "comboProfessor";
            this.comboProfessor.Size = new System.Drawing.Size(238, 33);
            this.comboProfessor.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(980, 271);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 44);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Quiz";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(1002, 42);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(150, 40);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Grade Book";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(984, 484);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Quiz";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(980, 341);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 44);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Edit Quiz";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(476, 42);
            this.lblProfessor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(196, 25);
            this.lblProfessor.TabIndex = 5;
            this.lblProfessor.Text = "Select A Professor:";
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Location = new System.Drawing.Point(530, 275);
            this.lblQuestions.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(104, 25);
            this.lblQuestions.TabIndex = 6;
            this.lblQuestions.Text = "Question:";
            // 
            // lblAnswers
            // 
            this.lblAnswers.AutoSize = true;
            this.lblAnswers.Location = new System.Drawing.Point(544, 350);
            this.lblAnswers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(89, 25);
            this.lblAnswers.TabIndex = 7;
            this.lblAnswers.Text = "Answer:";
            // 
            // txtQuestions
            // 
            this.txtQuestions.Location = new System.Drawing.Point(670, 275);
            this.txtQuestions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtQuestions.Name = "txtQuestions";
            this.txtQuestions.Size = new System.Drawing.Size(196, 31);
            this.txtQuestions.TabIndex = 8;
            // 
            // txtAnswers
            // 
            this.txtAnswers.Location = new System.Drawing.Point(670, 337);
            this.txtAnswers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAnswers.Name = "txtAnswers";
            this.txtAnswers.Size = new System.Drawing.Size(196, 31);
            this.txtAnswers.TabIndex = 9;
            // 
            // txtQuestionID
            // 
            this.txtQuestionID.Location = new System.Drawing.Point(670, 184);
            this.txtQuestionID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtQuestionID.Name = "txtQuestionID";
            this.txtQuestionID.Size = new System.Drawing.Size(196, 31);
            this.txtQuestionID.TabIndex = 10;
            // 
            // lblQuestionID
            // 
            this.lblQuestionID.AutoSize = true;
            this.lblQuestionID.Location = new System.Drawing.Point(502, 188);
            this.lblQuestionID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuestionID.Name = "lblQuestionID";
            this.lblQuestionID.Size = new System.Drawing.Size(130, 25);
            this.lblQuestionID.TabIndex = 11;
            this.lblQuestionID.Text = "Question ID:";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(502, 104);
            this.lblHint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(497, 50);
            this.lblHint.TabIndex = 12;
            this.lblHint.Text = "Hint: please enter the quiz id, question and answer\r\nto be able to create and edi" +
    "t.";
            // 
            // comboDeleteQuiz
            // 
            this.comboDeleteQuiz.FormattingEnabled = true;
            this.comboDeleteQuiz.Location = new System.Drawing.Point(674, 488);
            this.comboDeleteQuiz.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboDeleteQuiz.Name = "comboDeleteQuiz";
            this.comboDeleteQuiz.Size = new System.Drawing.Size(238, 33);
            this.comboDeleteQuiz.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 494);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select Quiz ID";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(502, 421);
            this.lblDelete.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(429, 25);
            this.lblDelete.TabIndex = 16;
            this.lblDelete.Text = "Hint: to delete a quiz please select a quiz id\r\n";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(692, 548);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 44);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddProfessor
            // 
            this.btnAddProfessor.Location = new System.Drawing.Point(980, 181);
            this.btnAddProfessor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddProfessor.Name = "btnAddProfessor";
            this.btnAddProfessor.Size = new System.Drawing.Size(150, 67);
            this.btnAddProfessor.TabIndex = 18;
            this.btnAddProfessor.Text = "Add Professor";
            this.btnAddProfessor.UseVisualStyleBackColor = true;
            this.btnAddProfessor.Click += new System.EventHandler(this.btnAddProfessor_Click);
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1218, 623);
            this.Controls.Add(this.btnAddProfessor);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDeleteQuiz);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblQuestionID);
            this.Controls.Add(this.txtQuestionID);
            this.Controls.Add(this.txtAnswers);
            this.Controls.Add(this.txtQuestions);
            this.Controls.Add(this.lblAnswers);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.comboProfessor);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ProfessorForm";
            this.Text = "Professor";
            this.Load += new System.EventHandler(this.ProfessorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboProfessor;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Label lblAnswers;
        private System.Windows.Forms.TextBox txtQuestions;
        private System.Windows.Forms.TextBox txtAnswers;
        private System.Windows.Forms.TextBox txtQuestionID;
        private System.Windows.Forms.Label lblQuestionID;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.ComboBox comboDeleteQuiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddProfessor;
    }
}