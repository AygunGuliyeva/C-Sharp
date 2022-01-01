
namespace Student_Grading
{
    partial class Grades
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
            this.LblPageName = new System.Windows.Forms.Label();
            this.GrpWholeGrading = new System.Windows.Forms.GroupBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrpAverages = new System.Windows.Forms.GroupBox();
            this.CmbWorstStudents = new System.Windows.Forms.ComboBox();
            this.LblTestAverage = new System.Windows.Forms.Label();
            this.CmbBestStudents = new System.Windows.Forms.ComboBox();
            this.CmbTestAverage = new System.Windows.Forms.ComboBox();
            this.LblClassAverage = new System.Windows.Forms.Label();
            this.LblClassAverageName = new System.Windows.Forms.Label();
            this.LblAboveAverage = new System.Windows.Forms.Label();
            this.TxtAboveAverage = new System.Windows.Forms.TextBox();
            this.GrpListing = new System.Windows.Forms.GroupBox();
            this.CmbSorByTest = new System.Windows.Forms.ComboBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.LblByStudent = new System.Windows.Forms.Label();
            this.TxtByStudent = new System.Windows.Forms.TextBox();
            this.LblSort = new System.Windows.Forms.Label();
            this.GrpAdd = new System.Windows.Forms.GroupBox();
            this.LblStudentAdd = new System.Windows.Forms.Label();
            this.TxtStudentAdd = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtTestAdd = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LblTestAdd = new System.Windows.Forms.Label();
            this.LblStudentMdf = new System.Windows.Forms.Label();
            this.TxtStudentMdf = new System.Windows.Forms.TextBox();
            this.GrpModify = new System.Windows.Forms.GroupBox();
            this.TxtGradeMdf = new System.Windows.Forms.TextBox();
            this.LblGradeMdf = new System.Windows.Forms.Label();
            this.TxtTestMdf = new System.Windows.Forms.TextBox();
            this.BtnModify = new System.Windows.Forms.Button();
            this.LblTestMdf = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblSubject = new System.Windows.Forms.Label();
            this.GrpWholeGrading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.GrpAverages.SuspendLayout();
            this.GrpListing.SuspendLayout();
            this.GrpAdd.SuspendLayout();
            this.GrpModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPageName
            // 
            this.LblPageName.AutoSize = true;
            this.LblPageName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPageName.ForeColor = System.Drawing.Color.DarkCyan;
            this.LblPageName.Location = new System.Drawing.Point(248, 9);
            this.LblPageName.Name = "LblPageName";
            this.LblPageName.Size = new System.Drawing.Size(357, 25);
            this.LblPageName.TabIndex = 0;
            this.LblPageName.Text = "Student Grades List for the subject:";
            // 
            // GrpWholeGrading
            // 
            this.GrpWholeGrading.Controls.Add(this.DataGridView1);
            this.GrpWholeGrading.Font = new System.Drawing.Font("Cambria", 12F);
            this.GrpWholeGrading.ForeColor = System.Drawing.Color.DarkCyan;
            this.GrpWholeGrading.Location = new System.Drawing.Point(12, 231);
            this.GrpWholeGrading.Name = "GrpWholeGrading";
            this.GrpWholeGrading.Size = new System.Drawing.Size(960, 349);
            this.GrpWholeGrading.TabIndex = 1;
            this.GrpWholeGrading.TabStop = false;
            this.GrpWholeGrading.Text = "Whole Grading";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(3, 22);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(954, 324);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // GrpAverages
            // 
            this.GrpAverages.Controls.Add(this.CmbWorstStudents);
            this.GrpAverages.Controls.Add(this.LblTestAverage);
            this.GrpAverages.Controls.Add(this.CmbBestStudents);
            this.GrpAverages.Controls.Add(this.CmbTestAverage);
            this.GrpAverages.Controls.Add(this.LblClassAverage);
            this.GrpAverages.Controls.Add(this.LblClassAverageName);
            this.GrpAverages.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrpAverages.ForeColor = System.Drawing.Color.DarkCyan;
            this.GrpAverages.Location = new System.Drawing.Point(268, 61);
            this.GrpAverages.Name = "GrpAverages";
            this.GrpAverages.Size = new System.Drawing.Size(232, 164);
            this.GrpAverages.TabIndex = 2;
            this.GrpAverages.TabStop = false;
            this.GrpAverages.Text = "Statistics";
            // 
            // CmbWorstStudents
            // 
            this.CmbWorstStudents.ForeColor = System.Drawing.Color.DarkCyan;
            this.CmbWorstStudents.FormattingEnabled = true;
            this.CmbWorstStudents.Location = new System.Drawing.Point(6, 121);
            this.CmbWorstStudents.Name = "CmbWorstStudents";
            this.CmbWorstStudents.Size = new System.Drawing.Size(219, 27);
            this.CmbWorstStudents.TabIndex = 19;
            this.CmbWorstStudents.Text = "Worst Students";
            this.CmbWorstStudents.SelectedValueChanged += new System.EventHandler(this.CmbWorstStudents_SelectedValueChanged);
            // 
            // LblTestAverage
            // 
            this.LblTestAverage.AutoSize = true;
            this.LblTestAverage.Font = new System.Drawing.Font("Cambria", 14F);
            this.LblTestAverage.Location = new System.Drawing.Point(142, 56);
            this.LblTestAverage.Name = "LblTestAverage";
            this.LblTestAverage.Size = new System.Drawing.Size(32, 22);
            this.LblTestAverage.TabIndex = 9;
            this.LblTestAverage.Text = "00";
            // 
            // CmbBestStudents
            // 
            this.CmbBestStudents.ForeColor = System.Drawing.Color.DarkCyan;
            this.CmbBestStudents.FormattingEnabled = true;
            this.CmbBestStudents.Location = new System.Drawing.Point(6, 88);
            this.CmbBestStudents.Name = "CmbBestStudents";
            this.CmbBestStudents.Size = new System.Drawing.Size(219, 27);
            this.CmbBestStudents.TabIndex = 18;
            this.CmbBestStudents.Text = "Best Students";
            this.CmbBestStudents.SelectedValueChanged += new System.EventHandler(this.CmbBestStudents_SelectedValueChanged);
            // 
            // CmbTestAverage
            // 
            this.CmbTestAverage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbTestAverage.ForeColor = System.Drawing.Color.DarkCyan;
            this.CmbTestAverage.FormattingEnabled = true;
            this.CmbTestAverage.Location = new System.Drawing.Point(6, 55);
            this.CmbTestAverage.Name = "CmbTestAverage";
            this.CmbTestAverage.Size = new System.Drawing.Size(119, 27);
            this.CmbTestAverage.TabIndex = 8;
            this.CmbTestAverage.Text = "Test average:";
            this.CmbTestAverage.SelectedValueChanged += new System.EventHandler(this.CmbTestAverage_SelectedValueChanged);
            // 
            // LblClassAverage
            // 
            this.LblClassAverage.AutoSize = true;
            this.LblClassAverage.Font = new System.Drawing.Font("Cambria", 14F);
            this.LblClassAverage.Location = new System.Drawing.Point(142, 24);
            this.LblClassAverage.Name = "LblClassAverage";
            this.LblClassAverage.Size = new System.Drawing.Size(32, 22);
            this.LblClassAverage.TabIndex = 3;
            this.LblClassAverage.Text = "65";
            // 
            // LblClassAverageName
            // 
            this.LblClassAverageName.AutoSize = true;
            this.LblClassAverageName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblClassAverageName.Location = new System.Drawing.Point(6, 27);
            this.LblClassAverageName.Name = "LblClassAverageName";
            this.LblClassAverageName.Size = new System.Drawing.Size(108, 19);
            this.LblClassAverageName.TabIndex = 0;
            this.LblClassAverageName.Text = "Class Average:";
            // 
            // LblAboveAverage
            // 
            this.LblAboveAverage.AutoSize = true;
            this.LblAboveAverage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblAboveAverage.Location = new System.Drawing.Point(6, 58);
            this.LblAboveAverage.Name = "LblAboveAverage";
            this.LblAboveAverage.Size = new System.Drawing.Size(114, 19);
            this.LblAboveAverage.TabIndex = 4;
            this.LblAboveAverage.Text = "Above this avg:";
            // 
            // TxtAboveAverage
            // 
            this.TxtAboveAverage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAboveAverage.ForeColor = System.Drawing.Color.DarkCyan;
            this.TxtAboveAverage.Location = new System.Drawing.Point(137, 56);
            this.TxtAboveAverage.Name = "TxtAboveAverage";
            this.TxtAboveAverage.Size = new System.Drawing.Size(92, 26);
            this.TxtAboveAverage.TabIndex = 6;
            this.TxtAboveAverage.Tag = "";
            this.TxtAboveAverage.Text = "0";
            this.TxtAboveAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GrpListing
            // 
            this.GrpListing.Controls.Add(this.CmbSorByTest);
            this.GrpListing.Controls.Add(this.BtnShow);
            this.GrpListing.Controls.Add(this.LblByStudent);
            this.GrpListing.Controls.Add(this.TxtByStudent);
            this.GrpListing.Controls.Add(this.LblSort);
            this.GrpListing.Controls.Add(this.LblAboveAverage);
            this.GrpListing.Controls.Add(this.TxtAboveAverage);
            this.GrpListing.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrpListing.ForeColor = System.Drawing.Color.DarkCyan;
            this.GrpListing.Location = new System.Drawing.Point(12, 61);
            this.GrpListing.Name = "GrpListing";
            this.GrpListing.Size = new System.Drawing.Size(235, 164);
            this.GrpListing.TabIndex = 8;
            this.GrpListing.TabStop = false;
            this.GrpListing.Text = "Listing options";
            // 
            // CmbSorByTest
            // 
            this.CmbSorByTest.FormattingEnabled = true;
            this.CmbSorByTest.Location = new System.Drawing.Point(137, 22);
            this.CmbSorByTest.Name = "CmbSorByTest";
            this.CmbSorByTest.Size = new System.Drawing.Size(92, 27);
            this.CmbSorByTest.TabIndex = 17;
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnShow.ForeColor = System.Drawing.Color.Yellow;
            this.BtnShow.Location = new System.Drawing.Point(170, 132);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(59, 26);
            this.BtnShow.TabIndex = 15;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // LblByStudent
            // 
            this.LblByStudent.AutoSize = true;
            this.LblByStudent.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblByStudent.Location = new System.Drawing.Point(6, 83);
            this.LblByStudent.Name = "LblByStudent";
            this.LblByStudent.Size = new System.Drawing.Size(88, 19);
            this.LblByStudent.TabIndex = 9;
            this.LblByStudent.Text = "By Student:";
            // 
            // TxtByStudent
            // 
            this.TxtByStudent.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtByStudent.ForeColor = System.Drawing.Color.DarkCyan;
            this.TxtByStudent.Location = new System.Drawing.Point(10, 103);
            this.TxtByStudent.Name = "TxtByStudent";
            this.TxtByStudent.Size = new System.Drawing.Size(219, 26);
            this.TxtByStudent.TabIndex = 10;
            this.TxtByStudent.Tag = "";
            this.TxtByStudent.TextChanged += new System.EventHandler(this.TxtByStudent_TextChanged);
            // 
            // LblSort
            // 
            this.LblSort.AutoSize = true;
            this.LblSort.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSort.Location = new System.Drawing.Point(6, 27);
            this.LblSort.Name = "LblSort";
            this.LblSort.Size = new System.Drawing.Size(114, 19);
            this.LblSort.TabIndex = 8;
            this.LblSort.Text = "Sort grades by:";
            // 
            // GrpAdd
            // 
            this.GrpAdd.Controls.Add(this.LblStudentAdd);
            this.GrpAdd.Controls.Add(this.TxtStudentAdd);
            this.GrpAdd.Controls.Add(this.BtnDelete);
            this.GrpAdd.Controls.Add(this.TxtTestAdd);
            this.GrpAdd.Controls.Add(this.BtnAdd);
            this.GrpAdd.Controls.Add(this.LblTestAdd);
            this.GrpAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrpAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.GrpAdd.Location = new System.Drawing.Point(797, 61);
            this.GrpAdd.Name = "GrpAdd";
            this.GrpAdd.Size = new System.Drawing.Size(175, 164);
            this.GrpAdd.TabIndex = 9;
            this.GrpAdd.TabStop = false;
            this.GrpAdd.Text = "Add/Delete";
            // 
            // LblStudentAdd
            // 
            this.LblStudentAdd.AutoSize = true;
            this.LblStudentAdd.Location = new System.Drawing.Point(6, 79);
            this.LblStudentAdd.Name = "LblStudentAdd";
            this.LblStudentAdd.Size = new System.Drawing.Size(108, 19);
            this.LblStudentAdd.TabIndex = 18;
            this.LblStudentAdd.Text = "Student name:";
            // 
            // TxtStudentAdd
            // 
            this.TxtStudentAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStudentAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.TxtStudentAdd.Location = new System.Drawing.Point(6, 98);
            this.TxtStudentAdd.Name = "TxtStudentAdd";
            this.TxtStudentAdd.Size = new System.Drawing.Size(163, 26);
            this.TxtStudentAdd.TabIndex = 17;
            this.TxtStudentAdd.Tag = "";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnDelete.ForeColor = System.Drawing.Color.Yellow;
            this.BtnDelete.Location = new System.Drawing.Point(94, 132);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 26);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtTestAdd
            // 
            this.TxtTestAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTestAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.TxtTestAdd.Location = new System.Drawing.Point(6, 47);
            this.TxtTestAdd.Name = "TxtTestAdd";
            this.TxtTestAdd.Size = new System.Drawing.Size(163, 26);
            this.TxtTestAdd.TabIndex = 15;
            this.TxtTestAdd.Tag = "";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnAdd.ForeColor = System.Drawing.Color.Yellow;
            this.BtnAdd.Location = new System.Drawing.Point(6, 132);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 26);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblTestAdd
            // 
            this.LblTestAdd.AutoSize = true;
            this.LblTestAdd.Location = new System.Drawing.Point(6, 27);
            this.LblTestAdd.Name = "LblTestAdd";
            this.LblTestAdd.Size = new System.Drawing.Size(83, 19);
            this.LblTestAdd.TabIndex = 0;
            this.LblTestAdd.Text = "Test name:";
            // 
            // LblStudentMdf
            // 
            this.LblStudentMdf.AutoSize = true;
            this.LblStudentMdf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblStudentMdf.Location = new System.Drawing.Point(6, 59);
            this.LblStudentMdf.Name = "LblStudentMdf";
            this.LblStudentMdf.Size = new System.Drawing.Size(66, 19);
            this.LblStudentMdf.TabIndex = 12;
            this.LblStudentMdf.Text = "Student:";
            // 
            // TxtStudentMdf
            // 
            this.TxtStudentMdf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStudentMdf.ForeColor = System.Drawing.Color.DarkCyan;
            this.TxtStudentMdf.Location = new System.Drawing.Point(95, 56);
            this.TxtStudentMdf.Name = "TxtStudentMdf";
            this.TxtStudentMdf.Size = new System.Drawing.Size(156, 26);
            this.TxtStudentMdf.TabIndex = 13;
            this.TxtStudentMdf.Tag = "";
            // 
            // GrpModify
            // 
            this.GrpModify.Controls.Add(this.TxtGradeMdf);
            this.GrpModify.Controls.Add(this.LblGradeMdf);
            this.GrpModify.Controls.Add(this.TxtTestMdf);
            this.GrpModify.Controls.Add(this.BtnModify);
            this.GrpModify.Controls.Add(this.LblTestMdf);
            this.GrpModify.Controls.Add(this.LblStudentMdf);
            this.GrpModify.Controls.Add(this.TxtStudentMdf);
            this.GrpModify.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrpModify.ForeColor = System.Drawing.Color.DarkCyan;
            this.GrpModify.Location = new System.Drawing.Point(521, 61);
            this.GrpModify.Name = "GrpModify";
            this.GrpModify.Size = new System.Drawing.Size(257, 164);
            this.GrpModify.TabIndex = 14;
            this.GrpModify.TabStop = false;
            this.GrpModify.Text = "Modify Grades";
            // 
            // TxtGradeMdf
            // 
            this.TxtGradeMdf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGradeMdf.ForeColor = System.Drawing.Color.DarkCyan;
            this.TxtGradeMdf.Location = new System.Drawing.Point(95, 88);
            this.TxtGradeMdf.Name = "TxtGradeMdf";
            this.TxtGradeMdf.Size = new System.Drawing.Size(156, 26);
            this.TxtGradeMdf.TabIndex = 17;
            this.TxtGradeMdf.Tag = "";
            // 
            // LblGradeMdf
            // 
            this.LblGradeMdf.AutoSize = true;
            this.LblGradeMdf.Location = new System.Drawing.Point(6, 91);
            this.LblGradeMdf.Name = "LblGradeMdf";
            this.LblGradeMdf.Size = new System.Drawing.Size(55, 19);
            this.LblGradeMdf.TabIndex = 16;
            this.LblGradeMdf.Text = "Grade:";
            // 
            // TxtTestMdf
            // 
            this.TxtTestMdf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTestMdf.ForeColor = System.Drawing.Color.DarkCyan;
            this.TxtTestMdf.Location = new System.Drawing.Point(95, 24);
            this.TxtTestMdf.Name = "TxtTestMdf";
            this.TxtTestMdf.Size = new System.Drawing.Size(156, 26);
            this.TxtTestMdf.TabIndex = 15;
            this.TxtTestMdf.Tag = "";
            // 
            // BtnModify
            // 
            this.BtnModify.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnModify.ForeColor = System.Drawing.Color.Yellow;
            this.BtnModify.Location = new System.Drawing.Point(176, 132);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 26);
            this.BtnModify.TabIndex = 14;
            this.BtnModify.Text = "Modify";
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // LblTestMdf
            // 
            this.LblTestMdf.AutoSize = true;
            this.LblTestMdf.Location = new System.Drawing.Point(6, 27);
            this.LblTestMdf.Name = "LblTestMdf";
            this.LblTestMdf.Size = new System.Drawing.Size(83, 19);
            this.LblTestMdf.TabIndex = 0;
            this.LblTestMdf.Text = "Test name:";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnBack.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.Yellow;
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(54, 27);
            this.BtnBack.TabIndex = 15;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblSubject
            // 
            this.LblSubject.AutoSize = true;
            this.LblSubject.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubject.ForeColor = System.Drawing.Color.Red;
            this.LblSubject.Location = new System.Drawing.Point(605, 9);
            this.LblSubject.Name = "LblSubject";
            this.LblSubject.Size = new System.Drawing.Size(143, 25);
            this.LblSubject.TabIndex = 16;
            this.LblSubject.Text = "Subject Name";
            // 
            // Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(985, 590);
            this.Controls.Add(this.LblSubject);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.GrpModify);
            this.Controls.Add(this.GrpAdd);
            this.Controls.Add(this.GrpAverages);
            this.Controls.Add(this.GrpListing);
            this.Controls.Add(this.GrpWholeGrading);
            this.Controls.Add(this.LblPageName);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "Grades";
            this.Text = "Grades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Grades_FormClosing);
            this.Load += new System.EventHandler(this.Grades_Load);
            this.GrpWholeGrading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.GrpAverages.ResumeLayout(false);
            this.GrpAverages.PerformLayout();
            this.GrpListing.ResumeLayout(false);
            this.GrpListing.PerformLayout();
            this.GrpAdd.ResumeLayout(false);
            this.GrpAdd.PerformLayout();
            this.GrpModify.ResumeLayout(false);
            this.GrpModify.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPageName;
        private System.Windows.Forms.GroupBox GrpWholeGrading;
        private System.Windows.Forms.GroupBox GrpAverages;
        private System.Windows.Forms.Label LblClassAverage;
        private System.Windows.Forms.Label LblClassAverageName;
        private System.Windows.Forms.Label LblAboveAverage;
        private System.Windows.Forms.TextBox TxtAboveAverage;
        private System.Windows.Forms.Label LblTestAverage;
        private System.Windows.Forms.GroupBox GrpListing;
        private System.Windows.Forms.Label LblByStudent;
        private System.Windows.Forms.TextBox TxtByStudent;
        private System.Windows.Forms.Label LblSort;
        private System.Windows.Forms.GroupBox GrpAdd;
        private System.Windows.Forms.TextBox TxtTestAdd;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LblTestAdd;
        private System.Windows.Forms.Label LblStudentMdf;
        private System.Windows.Forms.TextBox TxtStudentMdf;
        private System.Windows.Forms.GroupBox GrpModify;
        private System.Windows.Forms.TextBox TxtGradeMdf;
        private System.Windows.Forms.Label LblGradeMdf;
        private System.Windows.Forms.TextBox TxtTestMdf;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Label LblTestMdf;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.ComboBox CmbTestAverage;
        private System.Windows.Forms.Label LblSubject;
        private System.Windows.Forms.Button BtnDelete;
        public System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.ComboBox CmbSorByTest;
        private System.Windows.Forms.ComboBox CmbBestStudents;
        private System.Windows.Forms.ComboBox CmbWorstStudents;
        private System.Windows.Forms.TextBox TxtStudentAdd;
        private System.Windows.Forms.Label LblStudentAdd;
    }
}