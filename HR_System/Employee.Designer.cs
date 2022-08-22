namespace HR_System
{
    partial class Employee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtEmpCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtEndOn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtHiredOn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmployyeType = new System.Windows.Forms.ComboBox();
            this.txtDepartment = new System.Windows.Forms.ComboBox();
            this.txtDesignation = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuDatepicker3 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtDob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtOfficeNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMobileNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHomeAdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNic = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(705, 890);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 874);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblId);
            this.panel3.Controls.Add(this.txtEmpCode);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 100);
            this.panel3.TabIndex = 35;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DimGray;
            this.lblId.Location = new System.Drawing.Point(27, 65);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 20);
            this.lblId.TabIndex = 47;
            this.lblId.Text = "ID";
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpCode.DefaultText = "";
            this.txtEmpCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmpCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmpCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmpCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmpCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmpCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmpCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmpCode.Location = new System.Drawing.Point(268, 54);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.PasswordChar = '\0';
            this.txtEmpCode.PlaceholderText = "Enter Code";
            this.txtEmpCode.SelectedText = "";
            this.txtEmpCode.Size = new System.Drawing.Size(242, 31);
            this.txtEmpCode.TabIndex = 46;
            this.txtEmpCode.TextChanged += new System.EventHandler(this.txtEmpCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD EMPLOYEE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(181, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMP Code :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 123);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.13531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.86469F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 739);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtEndOn);
            this.groupBox2.Controls.Add(this.txtHiredOn);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtEmployyeType);
            this.groupBox2.Controls.Add(this.txtDepartment);
            this.groupBox2.Controls.Add(this.txtDesignation);
            this.groupBox2.Controls.Add(this.bunifuDatepicker3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(2, 394);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(658, 343);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Information";
            // 
            // btnDelete
            // 
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(420, 287);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 37);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "DELETE";
            // 
            // btnUpdate
            // 
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(227, 287);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 37);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEndOn
            // 
            this.txtEndOn.Checked = true;
            this.txtEndOn.FillColor = System.Drawing.Color.Gainsboro;
            this.txtEndOn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEndOn.ForeColor = System.Drawing.Color.DimGray;
            this.txtEndOn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtEndOn.Location = new System.Drawing.Point(208, 206);
            this.txtEndOn.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndOn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtEndOn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtEndOn.Name = "txtEndOn";
            this.txtEndOn.Size = new System.Drawing.Size(405, 29);
            this.txtEndOn.TabIndex = 62;
            this.txtEndOn.Value = new System.DateTime(2022, 8, 21, 15, 18, 58, 197);
            // 
            // txtHiredOn
            // 
            this.txtHiredOn.Checked = true;
            this.txtHiredOn.FillColor = System.Drawing.Color.Gainsboro;
            this.txtHiredOn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHiredOn.ForeColor = System.Drawing.Color.DimGray;
            this.txtHiredOn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtHiredOn.Location = new System.Drawing.Point(208, 168);
            this.txtHiredOn.Margin = new System.Windows.Forms.Padding(2);
            this.txtHiredOn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtHiredOn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtHiredOn.Name = "txtHiredOn";
            this.txtHiredOn.Size = new System.Drawing.Size(405, 29);
            this.txtHiredOn.TabIndex = 61;
            this.txtHiredOn.Value = new System.DateTime(2022, 8, 21, 15, 18, 58, 197);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(50, 287);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Add Employee";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmployyeType
            // 
            this.txtEmployyeType.FormattingEnabled = true;
            this.txtEmployyeType.Items.AddRange(new object[] {
            "Permanet",
            "Temp"});
            this.txtEmployyeType.Location = new System.Drawing.Point(208, 89);
            this.txtEmployyeType.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployyeType.Name = "txtEmployyeType";
            this.txtEmployyeType.Size = new System.Drawing.Size(406, 31);
            this.txtEmployyeType.TabIndex = 60;
            // 
            // txtDepartment
            // 
            this.txtDepartment.FormattingEnabled = true;
            this.txtDepartment.Location = new System.Drawing.Point(208, 49);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(406, 31);
            this.txtDepartment.TabIndex = 59;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesignation.DefaultText = "";
            this.txtDesignation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDesignation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDesignation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesignation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesignation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesignation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDesignation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesignation.Location = new System.Drawing.Point(208, 128);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.PasswordChar = '\0';
            this.txtDesignation.PlaceholderText = "Enter Name";
            this.txtDesignation.SelectedText = "";
            this.txtDesignation.Size = new System.Drawing.Size(405, 31);
            this.txtDesignation.TabIndex = 56;
            // 
            // bunifuDatepicker3
            // 
            this.bunifuDatepicker3.BackColor = System.Drawing.Color.DimGray;
            this.bunifuDatepicker3.BorderRadius = 0;
            this.bunifuDatepicker3.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker3.FormatCustom = null;
            this.bunifuDatepicker3.Location = new System.Drawing.Point(826, 344);
            this.bunifuDatepicker3.Margin = new System.Windows.Forms.Padding(20, 42, 20, 42);
            this.bunifuDatepicker3.Name = "bunifuDatepicker3";
            this.bunifuDatepicker3.Size = new System.Drawing.Size(256, 61);
            this.bunifuDatepicker3.TabIndex = 37;
            this.bunifuDatepicker3.Value = new System.DateTime(2022, 8, 17, 0, 54, 8, 128);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(46, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Employee Type  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(46, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ends On  :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(46, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Department  :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(46, 128);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Designation  :";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(46, 167);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Hired On  :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.txtDob);
            this.groupBox1.Controls.Add(this.txtOfficeNo);
            this.groupBox1.Controls.Add(this.txtMobileNo);
            this.groupBox1.Controls.Add(this.txtHomeAdd);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtNic);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(658, 388);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txtGender.Location = new System.Drawing.Point(208, 168);
            this.txtGender.Margin = new System.Windows.Forms.Padding(2);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(406, 31);
            this.txtGender.TabIndex = 65;
            // 
            // txtDob
            // 
            this.txtDob.Checked = true;
            this.txtDob.FillColor = System.Drawing.Color.Gainsboro;
            this.txtDob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDob.ForeColor = System.Drawing.Color.DimGray;
            this.txtDob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtDob.Location = new System.Drawing.Point(208, 209);
            this.txtDob.Margin = new System.Windows.Forms.Padding(2);
            this.txtDob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(405, 29);
            this.txtDob.TabIndex = 54;
            this.txtDob.Value = new System.DateTime(2022, 8, 21, 15, 18, 58, 197);
            // 
            // txtOfficeNo
            // 
            this.txtOfficeNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOfficeNo.DefaultText = "";
            this.txtOfficeNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOfficeNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOfficeNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOfficeNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOfficeNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOfficeNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfficeNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOfficeNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOfficeNo.Location = new System.Drawing.Point(208, 329);
            this.txtOfficeNo.Name = "txtOfficeNo";
            this.txtOfficeNo.PasswordChar = '\0';
            this.txtOfficeNo.PlaceholderText = "Office";
            this.txtOfficeNo.SelectedText = "";
            this.txtOfficeNo.Size = new System.Drawing.Size(405, 31);
            this.txtOfficeNo.TabIndex = 53;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobileNo.DefaultText = "";
            this.txtMobileNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMobileNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMobileNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobileNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobileNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobileNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMobileNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobileNo.Location = new System.Drawing.Point(208, 288);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.PasswordChar = '\0';
            this.txtMobileNo.PlaceholderText = "Personal";
            this.txtMobileNo.SelectedText = "";
            this.txtMobileNo.Size = new System.Drawing.Size(405, 31);
            this.txtMobileNo.TabIndex = 52;
            // 
            // txtHomeAdd
            // 
            this.txtHomeAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHomeAdd.DefaultText = "";
            this.txtHomeAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHomeAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHomeAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHomeAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHomeAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHomeAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHomeAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHomeAdd.Location = new System.Drawing.Point(208, 248);
            this.txtHomeAdd.Name = "txtHomeAdd";
            this.txtHomeAdd.PasswordChar = '\0';
            this.txtHomeAdd.PlaceholderText = "Enter Address";
            this.txtHomeAdd.SelectedText = "";
            this.txtHomeAdd.Size = new System.Drawing.Size(405, 31);
            this.txtHomeAdd.TabIndex = 51;
            // 
            // txtFullName
            // 
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Location = new System.Drawing.Point(208, 46);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "Enter Name";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(405, 31);
            this.txtFullName.TabIndex = 50;
            // 
            // txtNic
            // 
            this.txtNic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNic.DefaultText = "";
            this.txtNic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNic.Location = new System.Drawing.Point(208, 87);
            this.txtNic.Name = "txtNic";
            this.txtNic.PasswordChar = '\0';
            this.txtNic.PlaceholderText = "Enter NIC";
            this.txtNic.SelectedText = "";
            this.txtNic.Size = new System.Drawing.Size(405, 31);
            this.txtNic.TabIndex = 49;
            // 
            // txtAge
            // 
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.DefaultText = "";
            this.txtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAge.Location = new System.Drawing.Point(208, 128);
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.PlaceholderText = "Enter Age";
            this.txtAge.SelectedText = "";
            this.txtAge.Size = new System.Drawing.Size(405, 31);
            this.txtAge.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(46, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Full Name  :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(46, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Age  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(46, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Birth Date  :";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(46, 95);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "NIC  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(46, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Gender  :";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(46, 254);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Home Address  :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(46, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mobile Number  :";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(689, 874);
            this.panel5.TabIndex = 36;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 890);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        public Guna.UI2.WinForms.Guna2TextBox txtEmpCode;
        public System.Windows.Forms.ComboBox txtDepartment;
        public Guna.UI2.WinForms.Guna2TextBox txtDesignation;
        public Guna.UI2.WinForms.Guna2DateTimePicker txtDob;
        public Guna.UI2.WinForms.Guna2TextBox txtOfficeNo;
        public Guna.UI2.WinForms.Guna2TextBox txtMobileNo;
        public Guna.UI2.WinForms.Guna2TextBox txtHomeAdd;
        public Guna.UI2.WinForms.Guna2TextBox txtFullName;
        public Guna.UI2.WinForms.Guna2TextBox txtNic;
        public Guna.UI2.WinForms.Guna2TextBox txtAge;
        public System.Windows.Forms.ComboBox txtEmployyeType;
        public Guna.UI2.WinForms.Guna2Button btnSave;
        public Guna.UI2.WinForms.Guna2DateTimePicker txtEndOn;
        public Guna.UI2.WinForms.Guna2DateTimePicker txtHiredOn;
        public Guna.UI2.WinForms.Guna2Button btnDelete;
        public Guna.UI2.WinForms.Guna2Button btnUpdate;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.ComboBox txtGender;
    }
}