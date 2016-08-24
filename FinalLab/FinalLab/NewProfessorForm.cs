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
    public partial class NewProfessorForm : Form
    {
        system Data = new system();

        public NewProfessorForm()
        {
            InitializeComponent();
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            int test;
            bool result;

            if ((result = int.TryParse(txtpID.Text, out test) == false))
            {
                MessageBox.Show("Professor ID Must be interger!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int professorID = Convert.ToInt32(txtpID.Text);
                string professorFN = txtpFN.Text;
                string professorLN = txtpLN.Text;
                string professorCT = txtCT.Text;

                professor nProfessor = new professor(professorID,professorFN,professorLN,professorCT);

                int value = Data.addProfessor(nProfessor);

                if (value == 1)
                {
                    txtpID.Text = "";
                    txtpFN.Text = "";
                    txtpLN.Text = "";
                    txtCT.Text = "";

                    MessageBox.Show("Professor Data Added", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Duplicate ID Number!!, Please restart this form again to enter correct one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfessorForm nP = new ProfessorForm();
            nP.Show();
        }
    }
}
