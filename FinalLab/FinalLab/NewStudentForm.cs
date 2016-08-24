using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalLab
{
    public partial class NewStudentForm : Form
    {

        system nStudent = new system();

        public NewStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID;
            int Class;

            bool testID = int.TryParse(txtIDNumber.Text, out ID);
            bool testClassOF = int.TryParse(txtClassOf.Text, out Class);

            if (testID == false)
            {
                MessageBox.Show("ID must be numeric!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testClassOF == false)
            {
                MessageBox.Show("Year of class must be numeric", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int getID = Convert.ToInt32(txtIDNumber.Text);
                int getYear = Convert.ToInt32(txtClassOf.Text);
                string getFirstN = Convert.ToString(txtFirstName.Text);
                string getLastN = Convert.ToString(txtLastName.Text);
                string getMajor = Convert.ToString(txtMajor.Text);

                Student sManage = new Student(getID, getYear, getFirstN, getLastN, getMajor);

                int rData = nStudent.addStudent(sManage);

                if (rData == 1)
                {
                    MessageBox.Show("Data Saved!");

                    txtIDNumber.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtMajor.Text = "";
                    txtClassOf.Text = "";
                }
                else
                {
                    MessageBox.Show("Duplicate ID Number Enter!! Please Restart the program again");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
