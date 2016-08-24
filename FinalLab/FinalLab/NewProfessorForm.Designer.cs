namespace FinalLab
{
    partial class NewProfessorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProfessorForm));
            this.lblpID = new System.Windows.Forms.Label();
            this.lblpFN = new System.Windows.Forms.Label();
            this.lblpLN = new System.Windows.Forms.Label();
            this.btnAddP = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtpID = new System.Windows.Forms.TextBox();
            this.txtpFN = new System.Windows.Forms.TextBox();
            this.txtpLN = new System.Windows.Forms.TextBox();
            this.txtCT = new System.Windows.Forms.TextBox();
            this.lblClassTeach = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblpID
            // 
            this.lblpID.AutoSize = true;
            this.lblpID.Location = new System.Drawing.Point(624, 75);
            this.lblpID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblpID.Name = "lblpID";
            this.lblpID.Size = new System.Drawing.Size(136, 25);
            this.lblpID.TabIndex = 0;
            this.lblpID.Text = "Professor ID:";
            // 
            // lblpFN
            // 
            this.lblpFN.AutoSize = true;
            this.lblpFN.Location = new System.Drawing.Point(624, 164);
            this.lblpFN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblpFN.Name = "lblpFN";
            this.lblpFN.Size = new System.Drawing.Size(122, 25);
            this.lblpFN.TabIndex = 1;
            this.lblpFN.Text = "First Name:";
            // 
            // lblpLN
            // 
            this.lblpLN.AutoSize = true;
            this.lblpLN.Location = new System.Drawing.Point(624, 250);
            this.lblpLN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblpLN.Name = "lblpLN";
            this.lblpLN.Size = new System.Drawing.Size(106, 25);
            this.lblpLN.TabIndex = 2;
            this.lblpLN.Text = "Last Last:";
            // 
            // btnAddP
            // 
            this.btnAddP.Location = new System.Drawing.Point(864, 454);
            this.btnAddP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(150, 44);
            this.btnAddP.TabIndex = 3;
            this.btnAddP.Text = "Add";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(630, 454);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 44);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtpID
            // 
            this.txtpID.Location = new System.Drawing.Point(814, 75);
            this.txtpID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtpID.Name = "txtpID";
            this.txtpID.Size = new System.Drawing.Size(196, 31);
            this.txtpID.TabIndex = 5;
            // 
            // txtpFN
            // 
            this.txtpFN.Location = new System.Drawing.Point(814, 164);
            this.txtpFN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtpFN.Name = "txtpFN";
            this.txtpFN.Size = new System.Drawing.Size(196, 31);
            this.txtpFN.TabIndex = 6;
            // 
            // txtpLN
            // 
            this.txtpLN.Location = new System.Drawing.Point(814, 250);
            this.txtpLN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtpLN.Name = "txtpLN";
            this.txtpLN.Size = new System.Drawing.Size(196, 31);
            this.txtpLN.TabIndex = 7;
            // 
            // txtCT
            // 
            this.txtCT.Location = new System.Drawing.Point(814, 340);
            this.txtCT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(196, 31);
            this.txtCT.TabIndex = 8;
            // 
            // lblClassTeach
            // 
            this.lblClassTeach.AutoSize = true;
            this.lblClassTeach.Location = new System.Drawing.Point(624, 346);
            this.lblClassTeach.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClassTeach.Name = "lblClassTeach";
            this.lblClassTeach.Size = new System.Drawing.Size(138, 25);
            this.lblClassTeach.TabIndex = 9;
            this.lblClassTeach.Text = "Class Teach:";
            // 
            // NewProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1090, 768);
            this.Controls.Add(this.lblClassTeach);
            this.Controls.Add(this.txtCT);
            this.Controls.Add(this.txtpLN);
            this.Controls.Add(this.txtpFN);
            this.Controls.Add(this.txtpID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddP);
            this.Controls.Add(this.lblpLN);
            this.Controls.Add(this.lblpFN);
            this.Controls.Add(this.lblpID);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "NewProfessorForm";
            this.Text = "NewProfessorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpID;
        private System.Windows.Forms.Label lblpFN;
        private System.Windows.Forms.Label lblpLN;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtpID;
        private System.Windows.Forms.TextBox txtpFN;
        private System.Windows.Forms.TextBox txtpLN;
        private System.Windows.Forms.TextBox txtCT;
        private System.Windows.Forms.Label lblClassTeach;
    }
}