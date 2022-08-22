namespace HR_System
{
    partial class ChemicalInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStockInBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPurch = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtChemicalName = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADD CHEMICAL INVENTORY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Quntity  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Chemical Name  :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 58);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Unit Price  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Stock in By  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Purchase Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Total:";
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
            this.btnDelete.Location = new System.Drawing.Point(452, 372);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 28);
            this.btnDelete.TabIndex = 39;
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
            this.btnUpdate.Location = new System.Drawing.Point(263, 372);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(166, 28);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "UPDATE";
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(74, 372);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 28);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCost
            // 
            this.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCost.DefaultText = "";
            this.txtCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCost.Enabled = false;
            this.txtCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.Location = new System.Drawing.Point(214, 312);
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.PlaceholderText = "Enter Name";
            this.txtCost.SelectedText = "";
            this.txtCost.Size = new System.Drawing.Size(405, 31);
            this.txtCost.TabIndex = 59;
            // 
            // txtQty
            // 
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.DefaultText = "0";
            this.txtQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQty.Location = new System.Drawing.Point(214, 126);
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderText = "Enter Qty";
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(405, 31);
            this.txtQty.TabIndex = 57;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitPrice.DefaultText = "0";
            this.txtUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnitPrice.Location = new System.Drawing.Point(214, 265);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PasswordChar = '\0';
            this.txtUnitPrice.PlaceholderText = "Enter Name";
            this.txtUnitPrice.SelectedText = "";
            this.txtUnitPrice.Size = new System.Drawing.Size(405, 31);
            this.txtUnitPrice.TabIndex = 56;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // txtStockInBy
            // 
            this.txtStockInBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockInBy.DefaultText = "";
            this.txtStockInBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStockInBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStockInBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockInBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockInBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockInBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockInBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStockInBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockInBy.Location = new System.Drawing.Point(214, 173);
            this.txtStockInBy.Name = "txtStockInBy";
            this.txtStockInBy.PasswordChar = '\0';
            this.txtStockInBy.PlaceholderText = "Enter Name";
            this.txtStockInBy.SelectedText = "";
            this.txtStockInBy.Size = new System.Drawing.Size(405, 31);
            this.txtStockInBy.TabIndex = 55;
            // 
            // txtPurch
            // 
            this.txtPurch.Checked = true;
            this.txtPurch.FillColor = System.Drawing.Color.Gainsboro;
            this.txtPurch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPurch.ForeColor = System.Drawing.Color.DimGray;
            this.txtPurch.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtPurch.Location = new System.Drawing.Point(214, 220);
            this.txtPurch.Margin = new System.Windows.Forms.Padding(2);
            this.txtPurch.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtPurch.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtPurch.Name = "txtPurch";
            this.txtPurch.Size = new System.Drawing.Size(405, 29);
            this.txtPurch.TabIndex = 60;
            this.txtPurch.Value = new System.DateTime(2022, 8, 21, 15, 18, 58, 197);
            // 
            // txtChemicalName
            // 
            this.txtChemicalName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtChemicalName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChemicalName.Location = new System.Drawing.Point(213, 81);
            this.txtChemicalName.Margin = new System.Windows.Forms.Padding(2);
            this.txtChemicalName.MaxDropDownItems = 100;
            this.txtChemicalName.Name = "txtChemicalName";
            this.txtChemicalName.Size = new System.Drawing.Size(406, 33);
            this.txtChemicalName.TabIndex = 61;
            // 
            // ChemicalInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 487);
            this.Controls.Add(this.txtChemicalName);
            this.Controls.Add(this.txtPurch);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtStockInBy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChemicalInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChemicalInventory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox txtChemicalName;
        public Guna.UI2.WinForms.Guna2Button btnDelete;
        public Guna.UI2.WinForms.Guna2Button btnUpdate;
        public Guna.UI2.WinForms.Guna2Button btnSave;
        public Guna.UI2.WinForms.Guna2TextBox txtCost;
        public Guna.UI2.WinForms.Guna2TextBox txtQty;
        public Guna.UI2.WinForms.Guna2TextBox txtUnitPrice;
        public Guna.UI2.WinForms.Guna2TextBox txtStockInBy;
        public Guna.UI2.WinForms.Guna2DateTimePicker txtPurch;
    }
}