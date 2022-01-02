using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grading
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Below 6 buttons set "SelectedSubject" variable to the subject name to be used further for DB query
        // Also the buttons hide "Main" window and load "Grades" window

        private void BtnMathematics_Click(object sender, EventArgs e)
        {
            Grades frm = new Grades(); //frm yox form yazsaz daha yaxsi olar, ya da gradesForm
            frm.SelectedSubject = "Mathematics";
            frm.Show();
            this.Hide();
        }

        private void BtnInformatics_Click(object sender, EventArgs e)
        {
            Grades frm = new Grades(); //25ci setirdeki kimi
            frm.SelectedSubject = "Informatics";
            frm.Show();
            this.Hide();
        }

        private void BtnGeography_Click(object sender, EventArgs e)
        {
            Grades frm = new Grades();
            frm.SelectedSubject = "Geography";
            frm.Show();
            this.Hide();
        }

        private void BtnBiology_Click(object sender, EventArgs e)
        {
            Grades frm = new Grades();
            frm.SelectedSubject = "Biology";
            frm.Show();
            this.Hide();
        }

        private void BtnChemistry_Click(object sender, EventArgs e)
        {
            Grades frm = new Grades();
            frm.SelectedSubject = "Chemistry";
            frm.Show();
            this.Hide();
        }

        private void BtnLiterature_Click(object sender, EventArgs e)
        {
            Grades frm = new Grades(); //fikir verirsinizse, bu 2 setir, 65,66,67 tekrar tekrar istifade olunur, kicik private metod yazib, duplicationdan qacmaq olar
//men 71ci setirde yazdim
            frm.SelectedSubject = "Literature";
            frm.Show();
            this.Hide();
//ikinci variant ise Grades classinda yeni constructor teyin edirsiz,parameter kimi subject gotursun ve o constructorun icinde SelectedSubject=subject; olsun
//meselen yaziram. Grades form = new Grades("Literature"); //Grades classinda edecem deyisiklik
        }
/*
//private Form (tipi->Gradesin tipini bilmediyimden) createGradeForm(String subject) {
Grades form = new Greades();
form.SelectedSubject = subject;
return form;
}
*/
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        // Below command is to prompt a question when the user wants to exit
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit from Student Grading", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
