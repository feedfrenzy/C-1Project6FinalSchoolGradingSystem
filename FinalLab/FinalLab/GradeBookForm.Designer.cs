namespace FinalLab
{
    partial class GradeBookForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.GridGrade = new System.Windows.Forms.DataGridView();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(664, 667);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 44);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GridGrade
            // 
            this.GridGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGrade.Location = new System.Drawing.Point(114, 110);
            this.GridGrade.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GridGrade.Name = "GridGrade";
            this.GridGrade.Size = new System.Drawing.Size(1274, 498);
            this.GridGrade.TabIndex = 2;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(108, 52);
            this.lblHint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(345, 25);
            this.lblHint.TabIndex = 3;
            this.lblHint.Text = "This shows the student information";
            // 
            // GradeBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 771);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.GridGrade);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "GradeBookForm";
            this.Text = "GradeBookForm";
            this.Load += new System.EventHandler(this.GradeBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView GridGrade;
        private System.Windows.Forms.Label lblHint;
    }
}