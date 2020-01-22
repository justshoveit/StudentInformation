namespace CourseWork
{
    partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.panelSelector = new System.Windows.Forms.Panel();
            this.btnEnrolStudent = new System.Windows.Forms.Button();
            this.panelChart = new System.Windows.Forms.Panel();
            this.chartWeeklyReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.dateEnrolDate = new System.Windows.Forms.DateTimePicker();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblEnrolDate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.comboCourse = new System.Windows.Forms.ComboBox();
            this.lblStudentInformation = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fnameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.genderErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lnameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contactErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.courseErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelReport = new System.Windows.Forms.Panel();
            this.dataGridReport = new System.Windows.Forms.DataGridView();
            this.lblWeeklyReport = new System.Windows.Forms.Label();
            this.dpReport = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnSortByDate = new System.Windows.Forms.Button();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeeklyReport)).BeginInit();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fnameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseErrorProvider)).BeginInit();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnReport);
            this.panelMain.Controls.Add(this.btnExit);
            this.panelMain.Controls.Add(this.btnChart);
            this.panelMain.Controls.Add(this.panelSelector);
            this.panelMain.Controls.Add(this.btnEnrolStudent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(160, 634);
            this.panelMain.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.Location = new System.Drawing.Point(0, 260);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(140, 80);
            this.btnReport.TabIndex = 24;
            this.btnReport.Text = "View Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(0, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 80);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChart
            // 
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Image = ((System.Drawing.Image)(resources.GetObject("btnChart.Image")));
            this.btnChart.Location = new System.Drawing.Point(0, 174);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(140, 80);
            this.btnChart.TabIndex = 22;
            this.btnChart.Text = "View Chart";
            this.btnChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // panelSelector
            // 
            this.panelSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelSelector.Location = new System.Drawing.Point(141, 88);
            this.panelSelector.Name = "panelSelector";
            this.panelSelector.Size = new System.Drawing.Size(19, 80);
            this.panelSelector.TabIndex = 21;
            // 
            // btnEnrolStudent
            // 
            this.btnEnrolStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrolStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnEnrolStudent.Image")));
            this.btnEnrolStudent.Location = new System.Drawing.Point(0, 88);
            this.btnEnrolStudent.Name = "btnEnrolStudent";
            this.btnEnrolStudent.Size = new System.Drawing.Size(140, 80);
            this.btnEnrolStudent.TabIndex = 20;
            this.btnEnrolStudent.Text = "Add Student Information";
            this.btnEnrolStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnrolStudent.UseVisualStyleBackColor = true;
            this.btnEnrolStudent.Click += new System.EventHandler(this.btnEnrolStudent_Click);
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.chartWeeklyReport);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(0, 0);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(790, 348);
            this.panelChart.TabIndex = 19;
            // 
            // chartWeeklyReport
            // 
            this.chartWeeklyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.chartWeeklyReport.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chartWeeklyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartWeeklyReport.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chartWeeklyReport.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            this.chartWeeklyReport.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartWeeklyReport.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartWeeklyReport.BorderlineWidth = 0;
            this.chartWeeklyReport.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chartWeeklyReport.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartWeeklyReport.BorderSkin.BorderWidth = 0;
            this.chartWeeklyReport.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea7.BackColor = System.Drawing.Color.Transparent;
            chartArea7.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea7.BorderColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            this.chartWeeklyReport.ChartAreas.Add(chartArea7);
            this.chartWeeklyReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartWeeklyReport.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.BackColor = System.Drawing.Color.Transparent;
            legend7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend7.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend7.InterlacedRowsColor = System.Drawing.Color.Transparent;
            legend7.IsTextAutoFit = false;
            legend7.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend7.Name = "Legend1";
            legend7.TitleBackColor = System.Drawing.Color.Transparent;
            legend7.TitleFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend7.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.chartWeeklyReport.Legends.Add(legend7);
            this.chartWeeklyReport.Location = new System.Drawing.Point(0, 0);
            this.chartWeeklyReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartWeeklyReport.Name = "chartWeeklyReport";
            this.chartWeeklyReport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series7.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series7.CustomProperties = "BarLabelStyle=Center, DrawingStyle=Cylinder";
            series7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.LabelBorderWidth = 0;
            series7.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            series7.Legend = "Legend1";
            series7.MarkerBorderWidth = 0;
            series7.MarkerSize = 0;
            series7.Name = "Students";
            this.chartWeeklyReport.Series.Add(series7);
            this.chartWeeklyReport.Size = new System.Drawing.Size(790, 348);
            this.chartWeeklyReport.TabIndex = 16;
            this.chartWeeklyReport.Text = "Weekly Report";
            title7.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title7.BackColor = System.Drawing.Color.Transparent;
            title7.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            title7.Name = "Title1";
            title7.Text = "Weekly Enrollment Report";
            this.chartWeeklyReport.Titles.Add(title7);
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.lblInfo);
            this.panelDataGrid.Controls.Add(this.dataGridStudents);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDataGrid.Location = new System.Drawing.Point(160, 348);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(790, 286);
            this.panelDataGrid.TabIndex = 20;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Bahnschrift", 20.25F);
            this.lblInfo.Location = new System.Drawing.Point(274, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(257, 33);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Student Information";
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.AllowUserToResizeColumns = false;
            this.dataGridStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(112)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridStudents.ColumnHeadersHeight = 35;
            this.dataGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStudents.DefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridStudents.EnableHeadersVisualStyles = false;
            this.dataGridStudents.GridColor = System.Drawing.Color.Silver;
            this.dataGridStudents.Location = new System.Drawing.Point(0, 50);
            this.dataGridStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridStudents.RowHeadersVisible = false;
            this.dataGridStudents.Size = new System.Drawing.Size(790, 236);
            this.dataGridStudents.TabIndex = 7;
            this.dataGridStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.panelChart);
            this.panelStudent.Controls.Add(this.btnSortByDate);
            this.panelStudent.Controls.Add(this.lblGender);
            this.panelStudent.Controls.Add(this.txtID);
            this.panelStudent.Controls.Add(this.lblCourse);
            this.panelStudent.Controls.Add(this.dateEnrolDate);
            this.panelStudent.Controls.Add(this.lblContactNo);
            this.panelStudent.Controls.Add(this.txtAddress);
            this.panelStudent.Controls.Add(this.btnClear);
            this.panelStudent.Controls.Add(this.txtContactNo);
            this.panelStudent.Controls.Add(this.btnUpdate);
            this.panelStudent.Controls.Add(this.lblEnrolDate);
            this.panelStudent.Controls.Add(this.lblEmail);
            this.panelStudent.Controls.Add(this.comboGender);
            this.panelStudent.Controls.Add(this.txtEmail);
            this.panelStudent.Controls.Add(this.btnSubmit);
            this.panelStudent.Controls.Add(this.lblAddress);
            this.panelStudent.Controls.Add(this.txtFirstName);
            this.panelStudent.Controls.Add(this.lblFirstName);
            this.panelStudent.Controls.Add(this.txtLastName);
            this.panelStudent.Controls.Add(this.lblLastName);
            this.panelStudent.Controls.Add(this.comboCourse);
            this.panelStudent.Controls.Add(this.lblStudentInformation);
            this.panelStudent.Controls.Add(this.lblID);
            this.panelStudent.Controls.Add(this.btnSortByName);
            this.panelStudent.Controls.Add(this.btnCancel);
            this.panelStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudent.Location = new System.Drawing.Point(160, 0);
            this.panelStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(790, 348);
            this.panelStudent.TabIndex = 18;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(121, 168);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(50, 16);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.DimGray;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Location = new System.Drawing.Point(206, 198);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 22);
            this.txtID.TabIndex = 8;
            this.txtID.Visible = false;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(445, 168);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(45, 16);
            this.lblCourse.TabIndex = 11;
            this.lblCourse.Text = "Course";
            // 
            // dateEnrolDate
            // 
            this.dateEnrolDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnrolDate.Location = new System.Drawing.Point(206, 133);
            this.dateEnrolDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateEnrolDate.Name = "dateEnrolDate";
            this.dateEnrolDate.Size = new System.Drawing.Size(161, 21);
            this.dateEnrolDate.TabIndex = 10;
            this.dateEnrolDate.Value = new System.DateTime(2020, 1, 5, 3, 41, 43, 0);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(445, 136);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(72, 16);
            this.lblContactNo.TabIndex = 13;
            this.lblContactNo.Text = "Contact No";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.DimGray;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.Location = new System.Drawing.Point(206, 101);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(161, 22);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(567, 231);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 42);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.Color.DimGray;
            this.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtContactNo.Location = new System.Drawing.Point(519, 133);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(161, 22);
            this.txtContactNo.TabIndex = 12;
            this.txtContactNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtContactNo_Validating);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(448, 231);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 42);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblEnrolDate
            // 
            this.lblEnrolDate.AutoSize = true;
            this.lblEnrolDate.Location = new System.Drawing.Point(121, 136);
            this.lblEnrolDate.Name = "lblEnrolDate";
            this.lblEnrolDate.Size = new System.Drawing.Size(63, 16);
            this.lblEnrolDate.TabIndex = 11;
            this.lblEnrolDate.Text = "Enrol Date";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(445, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 16);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // comboGender
            // 
            this.comboGender.BackColor = System.Drawing.Color.DimGray;
            this.comboGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboGender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Others"});
            this.comboGender.Location = new System.Drawing.Point(206, 163);
            this.comboGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(161, 25);
            this.comboGender.TabIndex = 6;
            this.comboGender.Text = "Select a Gender";
            this.comboGender.Validating += new System.ComponentModel.CancelEventHandler(this.comboGender_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.DimGray;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(519, 101);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 22);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.Location = new System.Drawing.Point(448, 231);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 42);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(121, 104);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 16);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.DimGray;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.Location = new System.Drawing.Point(206, 69);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(161, 22);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(121, 72);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(62, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.DimGray;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Location = new System.Drawing.Point(519, 69);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(161, 22);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(445, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(62, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "LastName";
            // 
            // comboCourse
            // 
            this.comboCourse.BackColor = System.Drawing.Color.DimGray;
            this.comboCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCourse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCourse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboCourse.FormattingEnabled = true;
            this.comboCourse.Items.AddRange(new object[] {
            "Computing",
            "Multimedia",
            "Networking"});
            this.comboCourse.Location = new System.Drawing.Point(519, 165);
            this.comboCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboCourse.Name = "comboCourse";
            this.comboCourse.Size = new System.Drawing.Size(161, 25);
            this.comboCourse.TabIndex = 12;
            this.comboCourse.Text = "Select a Course";
            this.comboCourse.Validating += new System.ComponentModel.CancelEventHandler(this.comboCourse_Validating);
            // 
            // lblStudentInformation
            // 
            this.lblStudentInformation.AutoSize = true;
            this.lblStudentInformation.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInformation.Location = new System.Drawing.Point(241, 14);
            this.lblStudentInformation.Name = "lblStudentInformation";
            this.lblStudentInformation.Size = new System.Drawing.Size(311, 33);
            this.lblStudentInformation.TabIndex = 16;
            this.lblStudentInformation.Text = "Add Student Information";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(121, 201);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 16);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(448, 281);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 42);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fnameErrorProvider
            // 
            this.fnameErrorProvider.ContainerControl = this;
            this.fnameErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("fnameErrorProvider.Icon")));
            // 
            // addressErrorProvider
            // 
            this.addressErrorProvider.ContainerControl = this;
            this.addressErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("addressErrorProvider.Icon")));
            // 
            // genderErrorProvider
            // 
            this.genderErrorProvider.ContainerControl = this;
            this.genderErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("genderErrorProvider.Icon")));
            // 
            // lnameErrorProvider
            // 
            this.lnameErrorProvider.ContainerControl = this;
            this.lnameErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("lnameErrorProvider.Icon")));
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            this.emailErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("emailErrorProvider.Icon")));
            // 
            // contactErrorProvider
            // 
            this.contactErrorProvider.ContainerControl = this;
            this.contactErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("contactErrorProvider.Icon")));
            // 
            // courseErrorProvider
            // 
            this.courseErrorProvider.ContainerControl = this;
            this.courseErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("courseErrorProvider.Icon")));
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.btnGenerateReport);
            this.panelReport.Controls.Add(this.dpReport);
            this.panelReport.Controls.Add(this.lblWeeklyReport);
            this.panelReport.Controls.Add(this.dataGridReport);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(160, 0);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(790, 348);
            this.panelReport.TabIndex = 24;
            // 
            // dataGridReport
            // 
            this.dataGridReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(112)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridReport.ColumnHeadersHeight = 35;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridReport.DefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridReport.Location = new System.Drawing.Point(294, 130);
            this.dataGridReport.Name = "dataGridReport";
            this.dataGridReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridReport.RowHeadersVisible = false;
            this.dataGridReport.Size = new System.Drawing.Size(237, 173);
            this.dataGridReport.TabIndex = 0;
            // 
            // lblWeeklyReport
            // 
            this.lblWeeklyReport.AutoSize = true;
            this.lblWeeklyReport.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyReport.Location = new System.Drawing.Point(245, 9);
            this.lblWeeklyReport.Name = "lblWeeklyReport";
            this.lblWeeklyReport.Size = new System.Drawing.Size(305, 33);
            this.lblWeeklyReport.TabIndex = 17;
            this.lblWeeklyReport.Text = "Generate Weekly Report";
            // 
            // dpReport
            // 
            this.dpReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dpReport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpReport.Location = new System.Drawing.Point(206, 72);
            this.dpReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpReport.Name = "dpReport";
            this.dpReport.Size = new System.Drawing.Size(161, 21);
            this.dpReport.TabIndex = 18;
            this.dpReport.Value = new System.DateTime(2020, 1, 5, 3, 41, 43, 0);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateReport.Image")));
            this.btnGenerateReport.Location = new System.Drawing.Point(448, 52);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(145, 57);
            this.btnGenerateReport.TabIndex = 19;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortByDate.Image = ((System.Drawing.Image)(resources.GetObject("btnSortByDate.Image")));
            this.btnSortByDate.Location = new System.Drawing.Point(254, 281);
            this.btnSortByDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(113, 42);
            this.btnSortByDate.TabIndex = 20;
            this.btnSortByDate.Text = "Sort by Enroll Date";
            this.btnSortByDate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSortByDate.UseVisualStyleBackColor = true;
            this.btnSortByDate.Click += new System.EventHandler(this.btnSortByDate_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortByName.Image = ((System.Drawing.Image)(resources.GetObject("btnSortByName.Image")));
            this.btnSortByName.Location = new System.Drawing.Point(119, 281);
            this.btnSortByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(113, 42);
            this.btnSortByName.TabIndex = 21;
            this.btnSortByName.Text = "Sort by Name";
            this.btnSortByName.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSortByName.UseVisualStyleBackColor = true;
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(950, 634);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWeeklyReport)).EndInit();
            this.panelDataGrid.ResumeLayout(false);
            this.panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fnameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseErrorProvider)).EndInit();
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Panel panelSelector;
        private System.Windows.Forms.Button btnEnrolStudent;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeeklyReport;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox comboCourse;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.DateTimePicker dateEnrolDate;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblEnrolDate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lblStudentInformation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider fnameErrorProvider;
        private System.Windows.Forms.ErrorProvider addressErrorProvider;
        private System.Windows.Forms.ErrorProvider genderErrorProvider;
        private System.Windows.Forms.ErrorProvider lnameErrorProvider;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider contactErrorProvider;
        private System.Windows.Forms.ErrorProvider courseErrorProvider;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.DataGridView dataGridReport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DateTimePicker dpReport;
        private System.Windows.Forms.Label lblWeeklyReport;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnSortByDate;
    }
}

