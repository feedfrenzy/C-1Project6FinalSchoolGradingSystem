namespace FinalLab
{
    partial class NewStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStudentForm));
            this.lblFirstN = new System.Windows.Forms.Label();
            this.lblLastN = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblClassOf = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtClassOf = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstN
            // 
            this.lblFirstN.AutoSize = true;
            this.lblFirstN.Location = new System.Drawing.Point(52, 412);
            this.lblFirstN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstN.Name = "lblFirstN";
            this.lblFirstN.Size = new System.Drawing.Size(208, 25);
            this.lblFirstN.TabIndex = 0;
            this.lblFirstN.Text = "Student First Name: ";
            // 
            // lblLastN
            // 
            this.lblLastN.AutoSize = true;
            this.lblLastN.Location = new System.Drawing.Point(52, 491);
            this.lblLastN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastN.Name = "lblLastN";
            this.lblLastN.Size = new System.Drawing.Size(201, 25);
            this.lblLastN.TabIndex = 1;
            this.lblLastN.Text = "Student Last Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(52, 335);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(119, 25);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID Number:";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(52, 566);
            this.lblMajor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(72, 25);
            this.lblMajor.TabIndex = 3;
            this.lblMajor.Text = "Major:";
            // 
            // lblClassOf
            // 
            this.lblClassOf.AutoSize = true;
            this.lblClassOf.Location = new System.Drawing.Point(52, 639);
            this.lblClassOf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClassOf.Name = "lblClassOf";
            this.lblClassOf.Size = new System.Drawing.Size(100, 25);
            this.lblClassOf.TabIndex = 4;
            this.lblClassOf.Text = "Class Of:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 739);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(260, 335);
            this.txtIDNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(196, 31);
            this.txtIDNumber.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(260, 412);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(196, 31);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(260, 491);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(196, 31);
            this.txtLastName.TabIndex = 8;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(260, 566);
            this.txtMajor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(196, 31);
            this.txtMajor.TabIndex = 9;
            // 
            // txtClassOf
            // 
            this.txtClassOf.Location = new System.Drawing.Point(260, 639);
            this.txtClassOf.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtClassOf.Name = "txtClassOf";
            this.txtClassOf.Size = new System.Drawing.Size(196, 31);
            this.txtClassOf.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(58, 739);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 44);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // NewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(536, 979);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtClassOf);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblClassOf);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblLastN);
            this.Controls.Add(this.lblFirstN);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "NewStudentForm";
            this.Text = "New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstN;
        private System.Windows.Forms.Label lblLastN;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblClassOf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtClassOf;
        private System.Windows.Forms.Button btnBack;
    }
}