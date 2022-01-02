using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Student_Grading
{
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();

        }

        public string SelectedSubject;
        
        //meselen burada demisdim constructor yarada bilersiz
/*

public Grades(string subject){
   Grades(); //defaulc constructoru ya cagiririq
    this.SelectedSubject = subject; ///bu cur
}
*/

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Main frm = new Main();//frm variablein adi oxunaqli olsun
            frm.Show();
            this.Hide();
        }
        //this will provide connection to the database
        readonly OleDbConnection GradesDbConnect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\StudentGradesData.mdb; Persist Security Info=False;");
        
        //these variables will be used below
        string cols;
        string colsplus;
        string avgcols;
        int colcount;
        string colsdiv;

        //This is to data pull data from Access DB file
        void Listdata()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From " + SelectedSubject, GradesDbConnect);
            da.Fill(dt);
            
            //Finding Test columns count to use further for Average calculation
            colcount = dt.Columns.Count - 1;

            /* Define list of Test columns to use later */
            cols = dt.Columns[1].ColumnName;// exception ola biler. belke dt.Columns[] olcusu 2 den balacadi, onda dt.Columns[1] exception qaytaracaq.  olcusunu yoxlayin
            //evvelceden 
            for (int i = 2; i < dt.Columns.Count; i++)
            {
                cols = cols + "," + dt.Columns[i].ColumnName;
            }

            /* This is to create a string - Test1+Test2+Test3........
               Normal Test1+Test2 doesn't work in query, so we need to make it include NULL values
               IIf(IsNull([Test1]), 0, [Test1]) + IIf(IsNull([Test2]), 0, [Test2]) + ....... */
            colsplus = "IIf(IsNull([" + dt.Columns[1].ColumnName + "]), 0, [" + dt.Columns[1].ColumnName + "])";
            
            //COX qeliz yazilib bu hisseler, basa duse bilmedim ,burada ne etmek istemisiniz
            for (int i = 2; i < dt.Columns.Count; i++)
            {
                colsplus = colsplus + "+ IIf(IsNull([" + dt.Columns[i].ColumnName + "]), 0, [" + dt.Columns[i].ColumnName + "])";
            }

            /* When adding new test column its values will be NULL so we need it not to affect the average
               count of not null columns
            4-IIf(IsNull([Test1]),1,0)-IIf(IsNull([Test2]),1,0)- ...... */
            colsdiv = colcount + "-IIf(IsNull(["+dt.Columns[1].ColumnName+"]),1,0)";
            for (int i = 2; i < dt.Columns.Count; i++)
            {
                colsdiv = colsdiv + "-IIf(IsNull([" + dt.Columns[i].ColumnName + "]),1,0)";
            }

            /* To find class average we will need to find average of columns averages AVG(AVG(Test1)+AVG(Test2)...)
               To exclude NULL values it will be in this form - IIf(IsNull(Avg(Test1)), 0, Avg(Test1))+.......  */
            avgcols = "IIf(IsNull(Avg(" + dt.Columns[1].ColumnName + ")), 0, Avg(" + dt.Columns[1].ColumnName + "))";
            for (int i = 2; i < dt.Columns.Count; i++)
            {
                avgcols = avgcols + "+ IIf(IsNull(Avg(" + dt.Columns[i].ColumnName + ")), 0, Avg(" + dt.Columns[i].ColumnName + "))";
            }

            /* This is to add Test column names in the combo boxes for Test names */
            CmbTestAverage.Items.Clear();
            CmbSorByTest.Items.Clear();
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                CmbTestAverage.Items.Add(dt.Columns[i].ColumnName);
                CmbSorByTest.Items.Add(dt.Columns[i].ColumnName);
            }

            /* This is to generate final datatable from the initial loaded data and Average column */
            DataTable dt1 = new DataTable();
            OleDbDataAdapter da1 = new OleDbDataAdapter("SELECT *, Format(( "+colsplus+" )/( "+colsdiv+ " ),'Fixed') as Average FROM " + SelectedSubject, GradesDbConnect);//bu cur yazmaq olmaz, c# da query de where varsa, ve ora parameteler oturulurse, bu cur yazmirlar, sehv etmiremse, @ (231ci setirde o cur yazmisiz) isaresiynen yazilmalidi
            
            

            da1.Fill(dt1);
            DataGridView1.DataSource = dt1;
            DataGridView1.Columns["Average"].DisplayIndex = dt.Columns.Count;
        }

        /* To find the average grade for the whole class */
        void Classaverage()
        {
            DataTable dt = new DataTable();
            GradesDbConnect.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select format( (" + avgcols + ")/" + colcount + " , 'Fixed') from " + SelectedSubject, GradesDbConnect);
            //calisin queryni hemise ayrica bir deyisende yazin, sonra metoda oturun.meselen
//string sql = "Select format( (" + avgcols + ")/" + colcount + " , 'Fixed') from " + SelectedSubject;
// OleDbDataAdapter da = new OleDbDataAdapter(sql, GradesDbConnect);
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);
            GradesDbConnect.Close();
            LblClassAverage.Text = dt.Rows[0].ItemArray[0].ToString();
        }

        /* To find the average grade for the selected test */
        void Testaverage()
        {
            if (CmbTestAverage.Text != "Test average:")
            {
            DataTable dt = new DataTable();
            GradesDbConnect.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select format(Avg(" + CmbTestAverage.Text + "), 'Fixed') from " + SelectedSubject, GradesDbConnect);//121 ci setir
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);
            GradesDbConnect.Close();
            LblTestAverage.Text = dt.Rows[0].ItemArray[0].ToString();
            }
        }

        /* To find the best students based on the average grade */
        void BestStudent()
        {
            DataTable dt = new DataTable();
            GradesDbConnect.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select Student from "+ SelectedSubject + " Where " + colsplus + " = (Select Max(" + colsplus+") from " + SelectedSubject + ")", GradesDbConnect);
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);
            GradesDbConnect.Close();
            CmbBestStudents.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CmbBestStudents.Items.Add(dt.Rows[i].ItemArray[0].ToString());
            }
        }

        /* To find the worst students based on the average grade */
        void WorstStudent()
        {
            DataTable dt = new DataTable();
            GradesDbConnect.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select Student from " + SelectedSubject + " Where " + colsplus + " = (Select Min(" + colsplus + ") from " + SelectedSubject + ")", GradesDbConnect);
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);
            GradesDbConnect.Close();
            CmbWorstStudents.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CmbWorstStudents.Items.Add(dt.Rows[i].ItemArray[0].ToString());
            }
        }

        /* For adding new column to the database */
        void AddTest()
        {
            if (TxtTestAdd.Text == "") { }
            else if (cols.Contains(TxtTestAdd.Text).ToString() != "True")
            {
                GradesDbConnect.Open();
                OleDbCommand MyScript = new OleDbCommand("ALTER TABLE " + SelectedSubject + " ADD COLUMN " + TxtTestAdd.Text + " Long Integer", GradesDbConnect);
                MyScript.ExecuteNonQuery();
                GradesDbConnect.Close();
                Listdata();
                MessageBox.Show(TxtTestAdd.Text + " added to the table. You can add grades from Modify section.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(TxtTestAdd.Text + " already exists in the table.", "Existing column warning !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /* For deleting column from the database */
        void DeleteTest()
        {
            if (TxtTestAdd.Text == "")
            {
                // Do Nothing
            }
            else if (cols.Contains(TxtTestAdd.Text).ToString() == "True")
            {
                GradesDbConnect.Open();
                OleDbCommand MyScript = new OleDbCommand("ALTER TABLE " + SelectedSubject + " DROP COLUMN " + TxtTestAdd.Text, GradesDbConnect);
                MyScript.ExecuteNonQuery();
                GradesDbConnect.Close();
                Listdata();
                Classaverage();
                BestStudent();
                WorstStudent();
                MessageBox.Show(TxtTestAdd.Text + " deleted from the table.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(TxtTestAdd.Text + " does not exist in the table.", "Existing column warning !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /* For adding new student to the database */
        void AddStudent()
        {
            if (TxtStudentAdd.Text == "") { }
            else
            {
                GradesDbConnect.Open();
                OleDbCommand MyScript = new OleDbCommand("insert into " + SelectedSubject + " (Student) values (@p1)", GradesDbConnect);
                MyScript.Parameters.AddWithValue("@p1", TxtStudentAdd.Text);
                MyScript.ExecuteNonQuery();
                GradesDbConnect.Close();
                Listdata();
                MessageBox.Show("Student "+TxtStudentAdd.Text + " added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* For deleting student from the database */
        void DeleteStudent()
        {
            GradesDbConnect.Open();
            OleDbCommand MyScript = new OleDbCommand("Delete From " + SelectedSubject + " Where Student=@p1", GradesDbConnect);
            MyScript.Parameters.AddWithValue("@p1", TxtStudentAdd.Text);//bu metodu eger cagirirsinizsa, yaxsi olar ki, parameter kimi metodda gonderesiniz
            MyScript.ExecuteNonQuery();
            GradesDbConnect.Close();
            Listdata();
            MessageBox.Show("Student " + TxtStudentAdd.Text + " removed", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* For sorting the table by test columns */
        void SortbyCol()
        {
            if(CmbSorByTest.Text == "") { }
            else
            {
                DataGridView1.Sort(this.DataGridView1.Columns[CmbSorByTest.Text], ListSortDirection.Descending);
            }
            
        }

        /* To show results which average grade is higher that selected  */
        void AboveAverage()//metodun adi Fel (Verb) olmalidi
        {
            (DataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Average > '{0}'", TxtAboveAverage.Text);
        }

        /* When loading Grades window we need all above codes to run */
        private void Grades_Load(object sender, EventArgs e)
        {
            Listdata();
            Classaverage();
            BestStudent();
            WorstStudent();
            LblSubject.Text = SelectedSubject;
        }

        /* By clicking a cell in datagridview we will see details in the relevant cells above the datagridview */
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelRow = DataGridView1.SelectedCells[0].RowIndex;
            string ColHead = DataGridView1.SelectedCells[0].OwningColumn.HeaderCell.Value.ToString();

            if (ColHead == "Student" || ColHead == "Average" || ColHead == "Status")
            {
                TxtTestMdf.Text = "";
                TxtGradeMdf.Text = "";
                TxtTestAdd.Text = "";
            }
            else
            {
                TxtTestMdf.Text = ColHead;
                TxtGradeMdf.Text = DataGridView1.SelectedCells[0].Value.ToString();
                TxtTestAdd.Text = ColHead;
            }

            TxtStudentMdf.Text = DataGridView1.Rows[SelRow].Cells[1].Value.ToString();
            TxtStudentAdd.Text = DataGridView1.Rows[SelRow].Cells[1].Value.ToString();
        }

        /* This is to modify student grades */
        private void BtnModify_Click(object sender, EventArgs e)
        {
            GradesDbConnect.Open();
            OleDbCommand MyScript = new OleDbCommand("update "+ SelectedSubject +" set " + TxtTestMdf.Text + " = @P1  WHERE Student=@P2", GradesDbConnect);
            MyScript.Parameters.AddWithValue("@P1", TxtGradeMdf.Text);
            MyScript.Parameters.AddWithValue("@P2", TxtStudentMdf.Text);
            MyScript.ExecuteNonQuery();
            GradesDbConnect.Close();
            Listdata();
            Classaverage();
            Testaverage();
            BestStudent();
            WorstStudent();
            MessageBox.Show("Modifications Applied for " + TxtStudentMdf.Text + " for " + TxtTestMdf.Text + " as " + TxtGradeMdf.Text, "Modify", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddTest();
            AddStudent();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteTest();
            DeleteStudent();
            BestStudent();
            WorstStudent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            SortbyCol();
            AboveAverage();
        }

        /* This is to show the results only for selected student */
        private void TxtByStudent_TextChanged(object sender, EventArgs e)
        {
            (DataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Student", TxtByStudent.Text);
        }

        private void CmbTestAverage_SelectedValueChanged(object sender, EventArgs e)
        {
            Testaverage();
        }

        private void CmbBestStudents_SelectedValueChanged(object sender, EventArgs e)
        {
            TxtByStudent.Text = CmbBestStudents.Text;
        }

        private void CmbWorstStudents_SelectedValueChanged(object sender, EventArgs e)
        {
            TxtByStudent.Text = CmbWorstStudents.Text;
        }

        private void Grades_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?" + Environment.NewLine + "Note: You can go to Main window by clicking Back button", "Dialog Title", MessageBoxButtons.YesNo);
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
