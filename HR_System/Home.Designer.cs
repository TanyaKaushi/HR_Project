namespace HR_System
{
    partial class Home
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
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel__Main = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.submenu_4 = new System.Windows.Forms.Panel();
            this.btn_AddDepartment = new System.Windows.Forms.Button();
            this.btn_ViewDepartment = new System.Windows.Forms.Button();
            this.btn_Department = new System.Windows.Forms.Button();
            this.submenu_3 = new System.Windows.Forms.Panel();
            this.btn_AddChemicalInventory = new System.Windows.Forms.Button();
            this.btn_ViewChemInventory = new System.Windows.Forms.Button();
            this.btn_ChemicalInventory = new System.Windows.Forms.Button();
            this.submenu_2 = new System.Windows.Forms.Panel();
            this.btn_AddChemical = new System.Windows.Forms.Button();
            this.btn_ViewChemical = new System.Windows.Forms.Button();
            this.btn_Chemical = new System.Windows.Forms.Button();
            this.submenu_1 = new System.Windows.Forms.Panel();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.btn_ViewEmployee = new System.Windows.Forms.Button();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.submenu_4.SuspendLayout();
            this.submenu_3.SuspendLayout();
            this.submenu_2.SuspendLayout();
            this.submenu_1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 66);
            this.panel1.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Image = global::HR_System.Properties.Resources.maximize__1_;
            this.btnMax.Location = new System.Drawing.Point(1112, 24);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 18);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 4;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Image = global::HR_System.Properties.Resources.minimize_sign;
            this.btnMin.Location = new System.Drawing.Point(1072, 32);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 18);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 3;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::HR_System.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1153, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "HR Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::HR_System.Properties.Resources.home__2_;
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel__Main
            // 
            this.panel__Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel__Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel__Main.Location = new System.Drawing.Point(238, 66);
            this.panel__Main.Name = "panel__Main";
            this.panel__Main.Size = new System.Drawing.Size(962, 664);
            this.panel__Main.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.submenu_4);
            this.panelMenu.Controls.Add(this.btn_Department);
            this.panelMenu.Controls.Add(this.submenu_3);
            this.panelMenu.Controls.Add(this.btn_ChemicalInventory);
            this.panelMenu.Controls.Add(this.submenu_2);
            this.panelMenu.Controls.Add(this.btn_Chemical);
            this.panelMenu.Controls.Add(this.submenu_1);
            this.panelMenu.Controls.Add(this.btn_Employee);
            this.panelMenu.Controls.Add(this.btn_Dashboard);
            this.panelMenu.Controls.Add(this.panel6);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 66);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(238, 664);
            this.panelMenu.TabIndex = 3;
            // 
            // submenu_4
            // 
            this.submenu_4.Controls.Add(this.btn_AddDepartment);
            this.submenu_4.Controls.Add(this.btn_ViewDepartment);
            this.submenu_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenu_4.Location = new System.Drawing.Point(0, 823);
            this.submenu_4.Name = "submenu_4";
            this.submenu_4.Size = new System.Drawing.Size(217, 132);
            this.submenu_4.TabIndex = 10;
            // 
            // btn_AddDepartment
            // 
            this.btn_AddDepartment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AddDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddDepartment.FlatAppearance.BorderSize = 0;
            this.btn_AddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddDepartment.ForeColor = System.Drawing.Color.White;
            this.btn_AddDepartment.Location = new System.Drawing.Point(0, 64);
            this.btn_AddDepartment.Name = "btn_AddDepartment";
            this.btn_AddDepartment.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_AddDepartment.Size = new System.Drawing.Size(217, 64);
            this.btn_AddDepartment.TabIndex = 6;
            this.btn_AddDepartment.Tag = "Add Department";
            this.btn_AddDepartment.Text = "Add Department";
            this.btn_AddDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddDepartment.UseVisualStyleBackColor = false;
            this.btn_AddDepartment.Click += new System.EventHandler(this.btn_AddDepartment_Click);
            // 
            // btn_ViewDepartment
            // 
            this.btn_ViewDepartment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ViewDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ViewDepartment.FlatAppearance.BorderSize = 0;
            this.btn_ViewDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewDepartment.ForeColor = System.Drawing.Color.White;
            this.btn_ViewDepartment.Location = new System.Drawing.Point(0, 0);
            this.btn_ViewDepartment.Name = "btn_ViewDepartment";
            this.btn_ViewDepartment.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_ViewDepartment.Size = new System.Drawing.Size(217, 64);
            this.btn_ViewDepartment.TabIndex = 5;
            this.btn_ViewDepartment.Tag = "View Department";
            this.btn_ViewDepartment.Text = "View Department";
            this.btn_ViewDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewDepartment.UseVisualStyleBackColor = false;
            this.btn_ViewDepartment.Click += new System.EventHandler(this.btn_ViewDepartment_Click);
            // 
            // btn_Department
            // 
            this.btn_Department.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Department.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Department.FlatAppearance.BorderSize = 0;
            this.btn_Department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Department.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Department.ForeColor = System.Drawing.Color.White;
            this.btn_Department.Image = global::HR_System.Properties.Resources.hierarchy;
            this.btn_Department.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Department.Location = new System.Drawing.Point(0, 759);
            this.btn_Department.Name = "btn_Department";
            this.btn_Department.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Department.Size = new System.Drawing.Size(217, 64);
            this.btn_Department.TabIndex = 9;
            this.btn_Department.Tag = "  Department";
            this.btn_Department.Text = "  Department";
            this.btn_Department.UseVisualStyleBackColor = false;
            this.btn_Department.Click += new System.EventHandler(this.btn_Department_Click);
            // 
            // submenu_3
            // 
            this.submenu_3.Controls.Add(this.btn_AddChemicalInventory);
            this.submenu_3.Controls.Add(this.btn_ViewChemInventory);
            this.submenu_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenu_3.Location = new System.Drawing.Point(0, 627);
            this.submenu_3.Name = "submenu_3";
            this.submenu_3.Size = new System.Drawing.Size(217, 132);
            this.submenu_3.TabIndex = 8;
            // 
            // btn_AddChemicalInventory
            // 
            this.btn_AddChemicalInventory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AddChemicalInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddChemicalInventory.FlatAppearance.BorderSize = 0;
            this.btn_AddChemicalInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddChemicalInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddChemicalInventory.ForeColor = System.Drawing.Color.White;
            this.btn_AddChemicalInventory.Location = new System.Drawing.Point(0, 64);
            this.btn_AddChemicalInventory.Name = "btn_AddChemicalInventory";
            this.btn_AddChemicalInventory.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_AddChemicalInventory.Size = new System.Drawing.Size(217, 64);
            this.btn_AddChemicalInventory.TabIndex = 6;
            this.btn_AddChemicalInventory.Tag = "Chemical Inventory";
            this.btn_AddChemicalInventory.Text = "Chemical Inventory";
            this.btn_AddChemicalInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddChemicalInventory.UseVisualStyleBackColor = false;
            this.btn_AddChemicalInventory.Click += new System.EventHandler(this.btn_ChemicalInventory_Click);
            // 
            // btn_ViewChemInventory
            // 
            this.btn_ViewChemInventory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ViewChemInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ViewChemInventory.FlatAppearance.BorderSize = 0;
            this.btn_ViewChemInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewChemInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewChemInventory.ForeColor = System.Drawing.Color.White;
            this.btn_ViewChemInventory.Location = new System.Drawing.Point(0, 0);
            this.btn_ViewChemInventory.Name = "btn_ViewChemInventory";
            this.btn_ViewChemInventory.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_ViewChemInventory.Size = new System.Drawing.Size(217, 64);
            this.btn_ViewChemInventory.TabIndex = 5;
            this.btn_ViewChemInventory.Tag = "View Chemical History";
            this.btn_ViewChemInventory.Text = "View Chemical History";
            this.btn_ViewChemInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewChemInventory.UseVisualStyleBackColor = false;
            this.btn_ViewChemInventory.Click += new System.EventHandler(this.btn_ViewChemInventory_Click_1);
            // 
            // btn_ChemicalInventory
            // 
            this.btn_ChemicalInventory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ChemicalInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ChemicalInventory.FlatAppearance.BorderSize = 0;
            this.btn_ChemicalInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChemicalInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChemicalInventory.ForeColor = System.Drawing.Color.White;
            this.btn_ChemicalInventory.Image = global::HR_System.Properties.Resources.inventory;
            this.btn_ChemicalInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChemicalInventory.Location = new System.Drawing.Point(0, 563);
            this.btn_ChemicalInventory.Name = "btn_ChemicalInventory";
            this.btn_ChemicalInventory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_ChemicalInventory.Size = new System.Drawing.Size(217, 64);
            this.btn_ChemicalInventory.TabIndex = 7;
            this.btn_ChemicalInventory.Tag = "  Chemical Inventory";
            this.btn_ChemicalInventory.Text = "  Chemical Inventory";
            this.btn_ChemicalInventory.UseVisualStyleBackColor = false;
            this.btn_ChemicalInventory.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // submenu_2
            // 
            this.submenu_2.Controls.Add(this.btn_AddChemical);
            this.submenu_2.Controls.Add(this.btn_ViewChemical);
            this.submenu_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenu_2.Location = new System.Drawing.Point(0, 423);
            this.submenu_2.Name = "submenu_2";
            this.submenu_2.Size = new System.Drawing.Size(217, 140);
            this.submenu_2.TabIndex = 6;
            // 
            // btn_AddChemical
            // 
            this.btn_AddChemical.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AddChemical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddChemical.FlatAppearance.BorderSize = 0;
            this.btn_AddChemical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddChemical.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddChemical.ForeColor = System.Drawing.Color.White;
            this.btn_AddChemical.Location = new System.Drawing.Point(0, 64);
            this.btn_AddChemical.Name = "btn_AddChemical";
            this.btn_AddChemical.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_AddChemical.Size = new System.Drawing.Size(217, 64);
            this.btn_AddChemical.TabIndex = 3;
            this.btn_AddChemical.Tag = "Add Chemical";
            this.btn_AddChemical.Text = "Add Chemical";
            this.btn_AddChemical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddChemical.UseVisualStyleBackColor = false;
            this.btn_AddChemical.Click += new System.EventHandler(this.btn_AddChemical_Click);
            // 
            // btn_ViewChemical
            // 
            this.btn_ViewChemical.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ViewChemical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ViewChemical.FlatAppearance.BorderSize = 0;
            this.btn_ViewChemical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewChemical.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewChemical.ForeColor = System.Drawing.Color.White;
            this.btn_ViewChemical.Location = new System.Drawing.Point(0, 0);
            this.btn_ViewChemical.Name = "btn_ViewChemical";
            this.btn_ViewChemical.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_ViewChemical.Size = new System.Drawing.Size(217, 64);
            this.btn_ViewChemical.TabIndex = 2;
            this.btn_ViewChemical.Tag = "View Chemical";
            this.btn_ViewChemical.Text = "View Chemical";
            this.btn_ViewChemical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewChemical.UseVisualStyleBackColor = false;
            this.btn_ViewChemical.Click += new System.EventHandler(this.btn_ViewChemical_Click);
            // 
            // btn_Chemical
            // 
            this.btn_Chemical.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Chemical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Chemical.FlatAppearance.BorderSize = 0;
            this.btn_Chemical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Chemical.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chemical.ForeColor = System.Drawing.Color.White;
            this.btn_Chemical.Image = global::HR_System.Properties.Resources.chemical_analysis;
            this.btn_Chemical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Chemical.Location = new System.Drawing.Point(0, 359);
            this.btn_Chemical.Name = "btn_Chemical";
            this.btn_Chemical.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Chemical.Size = new System.Drawing.Size(217, 64);
            this.btn_Chemical.TabIndex = 5;
            this.btn_Chemical.Tag = "Chemical ";
            this.btn_Chemical.Text = "Chemical";
            this.btn_Chemical.UseVisualStyleBackColor = false;
            this.btn_Chemical.Click += new System.EventHandler(this.button1_Click);
            // 
            // submenu_1
            // 
            this.submenu_1.Controls.Add(this.btn_AddEmployee);
            this.submenu_1.Controls.Add(this.btn_ViewEmployee);
            this.submenu_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenu_1.Location = new System.Drawing.Point(0, 228);
            this.submenu_1.Name = "submenu_1";
            this.submenu_1.Size = new System.Drawing.Size(217, 131);
            this.submenu_1.TabIndex = 4;
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddEmployee.FlatAppearance.BorderSize = 0;
            this.btn_AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_AddEmployee.Location = new System.Drawing.Point(0, 64);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_AddEmployee.Size = new System.Drawing.Size(217, 64);
            this.btn_AddEmployee.TabIndex = 3;
            this.btn_AddEmployee.Tag = "Add Employee";
            this.btn_AddEmployee.Text = "Add Employee";
            this.btn_AddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddEmployee.UseVisualStyleBackColor = false;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click_1);
            // 
            // btn_ViewEmployee
            // 
            this.btn_ViewEmployee.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ViewEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ViewEmployee.FlatAppearance.BorderSize = 0;
            this.btn_ViewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_ViewEmployee.Location = new System.Drawing.Point(0, 0);
            this.btn_ViewEmployee.Name = "btn_ViewEmployee";
            this.btn_ViewEmployee.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_ViewEmployee.Size = new System.Drawing.Size(217, 64);
            this.btn_ViewEmployee.TabIndex = 2;
            this.btn_ViewEmployee.Tag = "View Employee";
            this.btn_ViewEmployee.Text = "View Employee";
            this.btn_ViewEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewEmployee.UseVisualStyleBackColor = false;
            this.btn_ViewEmployee.Click += new System.EventHandler(this.btn_ViewEmployee_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Employee.FlatAppearance.BorderSize = 0;
            this.btn_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Employee.Image = global::HR_System.Properties.Resources.man__1_;
            this.btn_Employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Employee.Location = new System.Drawing.Point(0, 164);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Employee.Size = new System.Drawing.Size(217, 64);
            this.btn_Employee.TabIndex = 3;
            this.btn_Employee.Tag = "Employee";
            this.btn_Employee.Text = "Employee";
            this.btn_Employee.UseVisualStyleBackColor = false;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.Image = global::HR_System.Properties.Resources.layout;
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 100);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Dashboard.Size = new System.Drawing.Size(217, 64);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Tag = "Dashboard";
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Controls.Add(this.menuButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(217, 100);
            this.panel6.TabIndex = 0;
            // 
            // menuButton
            // 
            this.menuButton.Image = global::HR_System.Properties.Resources.menu;
            this.menuButton.Location = new System.Drawing.Point(22, 38);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(25, 25);
            this.menuButton.TabIndex = 10;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 730);
            this.Controls.Add(this.panel__Main);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Home_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.submenu_4.ResumeLayout(false);
            this.submenu_3.ResumeLayout(false);
            this.submenu_2.ResumeLayout(false);
            this.submenu_1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel__Main;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.Button btn_ViewEmployee;
        private System.Windows.Forms.Button btn_Employee;
        private System.Windows.Forms.Panel submenu_1;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn_Chemical;
        private System.Windows.Forms.Panel submenu_2;
        private System.Windows.Forms.Button btn_ViewChemical;
        private System.Windows.Forms.Panel submenu_3;
        private System.Windows.Forms.Button btn_ChemicalInventory;
        private System.Windows.Forms.Button btn_ViewChemInventory;
        private System.Windows.Forms.Button btn_AddChemical;
        private System.Windows.Forms.Button btn_AddChemicalInventory;
        private System.Windows.Forms.Button btn_Department;
        private System.Windows.Forms.Panel submenu_4;
        private System.Windows.Forms.Button btn_AddDepartment;
        private System.Windows.Forms.Button btn_ViewDepartment;
    }
}

