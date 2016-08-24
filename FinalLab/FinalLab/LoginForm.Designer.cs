namespace FinalLab
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.checkConnection = new System.Windows.Forms.Label();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnCurrentStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.Location = new System.Drawing.Point(94, 40);
            this.checkConnection.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(0, 25);
            this.checkConnection.TabIndex = 0;
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(862, 326);
            this.btnNewStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(168, 63);
            this.btnNewStudent.TabIndex = 1;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.Location = new System.Drawing.Point(862, 65);
            this.btnProfessor.Margin = new System.Windows.Forms.Padding(6);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(168, 69);
            this.btnProfessor.TabIndex = 2;
            this.btnProfessor.Text = "Professor";
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnCurrentStudent
            // 
            this.btnCurrentStudent.Location = new System.Drawing.Point(862, 196);
            this.btnCurrentStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btnCurrentStudent.Name = "btnCurrentStudent";
            this.btnCurrentStudent.Size = new System.Drawing.Size(168, 67);
            this.btnCurrentStudent.TabIndex = 3;
            this.btnCurrentStudent.Text = "Current Student";
            this.btnCurrentStudent.UseVisualStyleBackColor = true;
            this.btnCurrentStudent.Click += new System.EventHandler(this.btnCurrentStudent_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1078, 561);
            this.Controls.Add(this.btnCurrentStudent);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.checkConnection);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkConnection;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnCurrentStudent;
    }
}

