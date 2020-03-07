﻿namespace Dealership
{
    partial class Dealership
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.customerTab = new MetroFramework.Controls.MetroTabPage();
            this.cust_PhoneNbrTxtB = new System.Windows.Forms.TextBox();
            this.cust_PhoneNbrLbl = new System.Windows.Forms.Label();
            this.cust_dataGridView = new System.Windows.Forms.DataGridView();
            this.cust_emailTxtB = new System.Windows.Forms.TextBox();
            this.cust_emailLbl = new System.Windows.Forms.Label();
            this.cust_lastNMLbl = new System.Windows.Forms.Label();
            this.cust_lastNMTxtB = new System.Windows.Forms.TextBox();
            this.cust_middleNMTxtB = new System.Windows.Forms.TextBox();
            this.cust_middleNMLbl = new System.Windows.Forms.Label();
            this.cust_firstNMLbl = new System.Windows.Forms.Label();
            this.cust_firstNMTxtB = new System.Windows.Forms.TextBox();
            this.salesHistory_Tab = new MetroFramework.Controls.MetroTabPage();
            this.salesHistory_EmployeeCheckBox = new System.Windows.Forms.CheckBox();
            this.saleHistory_CustCheckBox = new System.Windows.Forms.CheckBox();
            this.salesHistory_LastNameLbl = new System.Windows.Forms.Label();
            this.salesHistory_LastNameTxtB = new System.Windows.Forms.TextBox();
            this.salesHistory_FirstNameLbl = new System.Windows.Forms.Label();
            this.salesHistory_FirstNameTxtB = new System.Windows.Forms.TextBox();
            this.salesHistory_ToDateTimePicker = new System.Windows.Forms.Label();
            this.salesHistory_2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salesHistory_DateLbl = new System.Windows.Forms.Label();
            this.salesHistory_FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sale_dataGridView = new System.Windows.Forms.DataGridView();
            this.carTab = new MetroFramework.Controls.MetroTabPage();
            this.testBtn = new System.Windows.Forms.Button();
            this.cars_NoCheckBox = new System.Windows.Forms.CheckBox();
            this.cars_YesCheckBox = new System.Windows.Forms.CheckBox();
            this.cars_YearTxtB = new System.Windows.Forms.TextBox();
            this.cars_YearLbl = new System.Windows.Forms.Label();
            this.cars_dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cars_modelLbl = new System.Windows.Forms.Label();
            this.cars_modelTxtB = new System.Windows.Forms.TextBox();
            this.cars_makeTxtB = new System.Windows.Forms.TextBox();
            this.cars_makeLbl = new System.Windows.Forms.Label();
            this.cars_VINLbl = new System.Windows.Forms.Label();
            this.cars_VINTxtB = new System.Windows.Forms.TextBox();
            this.employeeTab = new MetroFramework.Controls.MetroTabPage();
            this.cust_CreateButton = new System.Windows.Forms.Button();
            this.cust_UpdateButton = new System.Windows.Forms.Button();
            this.cust_ListAllButton = new System.Windows.Forms.Button();
            this.sales_Tab = new MetroFramework.Controls.MetroTabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sales_VinNumberLabel = new System.Windows.Forms.Label();
            this.sales_VinNumberTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.customerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_dataGridView)).BeginInit();
            this.salesHistory_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sale_dataGridView)).BeginInit();
            this.carTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cars_dataGridView)).BeginInit();
            this.sales_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1425, 80);
            this.panel1.TabIndex = 0;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(0, 0);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(401, 64);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Car Dealership";
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.customerTab);
            this.metroTabControl.Controls.Add(this.salesHistory_Tab);
            this.metroTabControl.Controls.Add(this.carTab);
            this.metroTabControl.Controls.Add(this.employeeTab);
            this.metroTabControl.Controls.Add(this.sales_Tab);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(0, 80);
            this.metroTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(1425, 671);
            this.metroTabControl.TabIndex = 1;
            this.metroTabControl.UseSelectable = true;
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.cust_ListAllButton);
            this.customerTab.Controls.Add(this.cust_UpdateButton);
            this.customerTab.Controls.Add(this.cust_CreateButton);
            this.customerTab.Controls.Add(this.cust_PhoneNbrTxtB);
            this.customerTab.Controls.Add(this.cust_PhoneNbrLbl);
            this.customerTab.Controls.Add(this.cust_dataGridView);
            this.customerTab.Controls.Add(this.cust_emailTxtB);
            this.customerTab.Controls.Add(this.cust_emailLbl);
            this.customerTab.Controls.Add(this.cust_lastNMLbl);
            this.customerTab.Controls.Add(this.cust_lastNMTxtB);
            this.customerTab.Controls.Add(this.cust_middleNMTxtB);
            this.customerTab.Controls.Add(this.cust_middleNMLbl);
            this.customerTab.Controls.Add(this.cust_firstNMLbl);
            this.customerTab.Controls.Add(this.cust_firstNMTxtB);
            this.customerTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTab.HorizontalScrollbarBarColor = true;
            this.customerTab.HorizontalScrollbarHighlightOnWheel = false;
            this.customerTab.HorizontalScrollbarSize = 15;
            this.customerTab.Location = new System.Drawing.Point(4, 38);
            this.customerTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerTab.Name = "customerTab";
            this.customerTab.Size = new System.Drawing.Size(1417, 629);
            this.customerTab.TabIndex = 0;
            this.customerTab.Text = "Customers";
            this.customerTab.VerticalScrollbarBarColor = true;
            this.customerTab.VerticalScrollbarHighlightOnWheel = false;
            this.customerTab.VerticalScrollbarSize = 15;
            // 
            // cust_PhoneNbrTxtB
            // 
            this.cust_PhoneNbrTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_PhoneNbrTxtB.Location = new System.Drawing.Point(268, 275);
            this.cust_PhoneNbrTxtB.Name = "cust_PhoneNbrTxtB";
            this.cust_PhoneNbrTxtB.Size = new System.Drawing.Size(286, 39);
            this.cust_PhoneNbrTxtB.TabIndex = 12;
            // 
            // cust_PhoneNbrLbl
            // 
            this.cust_PhoneNbrLbl.AutoSize = true;
            this.cust_PhoneNbrLbl.BackColor = System.Drawing.Color.White;
            this.cust_PhoneNbrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_PhoneNbrLbl.Location = new System.Drawing.Point(12, 282);
            this.cust_PhoneNbrLbl.Name = "cust_PhoneNbrLbl";
            this.cust_PhoneNbrLbl.Size = new System.Drawing.Size(205, 32);
            this.cust_PhoneNbrLbl.TabIndex = 11;
            this.cust_PhoneNbrLbl.Text = "Phone Number";
            // 
            // cust_dataGridView
            // 
            this.cust_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cust_dataGridView.Location = new System.Drawing.Point(579, 14);
            this.cust_dataGridView.Name = "cust_dataGridView";
            this.cust_dataGridView.RowHeadersWidth = 51;
            this.cust_dataGridView.RowTemplate.Height = 24;
            this.cust_dataGridView.Size = new System.Drawing.Size(828, 575);
            this.cust_dataGridView.TabIndex = 10;
            // 
            // cust_emailTxtB
            // 
            this.cust_emailTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_emailTxtB.Location = new System.Drawing.Point(268, 360);
            this.cust_emailTxtB.Name = "cust_emailTxtB";
            this.cust_emailTxtB.Size = new System.Drawing.Size(286, 39);
            this.cust_emailTxtB.TabIndex = 9;
            // 
            // cust_emailLbl
            // 
            this.cust_emailLbl.AutoSize = true;
            this.cust_emailLbl.BackColor = System.Drawing.Color.White;
            this.cust_emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_emailLbl.Location = new System.Drawing.Point(12, 366);
            this.cust_emailLbl.Name = "cust_emailLbl";
            this.cust_emailLbl.Size = new System.Drawing.Size(87, 32);
            this.cust_emailLbl.TabIndex = 8;
            this.cust_emailLbl.Text = "Email";
            // 
            // cust_lastNMLbl
            // 
            this.cust_lastNMLbl.AutoSize = true;
            this.cust_lastNMLbl.BackColor = System.Drawing.Color.White;
            this.cust_lastNMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_lastNMLbl.Location = new System.Drawing.Point(12, 195);
            this.cust_lastNMLbl.Name = "cust_lastNMLbl";
            this.cust_lastNMLbl.Size = new System.Drawing.Size(151, 32);
            this.cust_lastNMLbl.TabIndex = 7;
            this.cust_lastNMLbl.Text = "Last Name";
            // 
            // cust_lastNMTxtB
            // 
            this.cust_lastNMTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_lastNMTxtB.Location = new System.Drawing.Point(268, 189);
            this.cust_lastNMTxtB.Name = "cust_lastNMTxtB";
            this.cust_lastNMTxtB.Size = new System.Drawing.Size(286, 39);
            this.cust_lastNMTxtB.TabIndex = 6;
            // 
            // cust_middleNMTxtB
            // 
            this.cust_middleNMTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_middleNMTxtB.Location = new System.Drawing.Point(268, 102);
            this.cust_middleNMTxtB.Name = "cust_middleNMTxtB";
            this.cust_middleNMTxtB.Size = new System.Drawing.Size(286, 39);
            this.cust_middleNMTxtB.TabIndex = 5;
            // 
            // cust_middleNMLbl
            // 
            this.cust_middleNMLbl.AutoEllipsis = true;
            this.cust_middleNMLbl.AutoSize = true;
            this.cust_middleNMLbl.BackColor = System.Drawing.Color.White;
            this.cust_middleNMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_middleNMLbl.ForeColor = System.Drawing.Color.Black;
            this.cust_middleNMLbl.Location = new System.Drawing.Point(12, 106);
            this.cust_middleNMLbl.Name = "cust_middleNMLbl";
            this.cust_middleNMLbl.Size = new System.Drawing.Size(182, 32);
            this.cust_middleNMLbl.TabIndex = 4;
            this.cust_middleNMLbl.Text = "Middle Name";
            // 
            // cust_firstNMLbl
            // 
            this.cust_firstNMLbl.AutoSize = true;
            this.cust_firstNMLbl.BackColor = System.Drawing.Color.White;
            this.cust_firstNMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_firstNMLbl.Location = new System.Drawing.Point(12, 14);
            this.cust_firstNMLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_firstNMLbl.Name = "cust_firstNMLbl";
            this.cust_firstNMLbl.Size = new System.Drawing.Size(152, 32);
            this.cust_firstNMLbl.TabIndex = 3;
            this.cust_firstNMLbl.Text = "First Name";
            // 
            // cust_firstNMTxtB
            // 
            this.cust_firstNMTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_firstNMTxtB.Location = new System.Drawing.Point(268, 14);
            this.cust_firstNMTxtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cust_firstNMTxtB.Name = "cust_firstNMTxtB";
            this.cust_firstNMTxtB.Size = new System.Drawing.Size(286, 39);
            this.cust_firstNMTxtB.TabIndex = 2;
            // 
            // salesHistory_Tab
            // 
            this.salesHistory_Tab.Controls.Add(this.salesHistory_EmployeeCheckBox);
            this.salesHistory_Tab.Controls.Add(this.saleHistory_CustCheckBox);
            this.salesHistory_Tab.Controls.Add(this.salesHistory_LastNameLbl);
            this.salesHistory_Tab.Controls.Add(this.salesHistory_LastNameTxtB);
            this.salesHistory_Tab.Controls.Add(this.salesHistory_FirstNameLbl);
            this.salesHistory_Tab.Controls.Add(this.salesHistory_FirstNameTxtB);
            this.salesHistory_Tab.Controls.Add(this.salesHistory_ToDateTimePicker);
            this.salesHistory_Tab.Controls.Add(this.salesHistory_2DateTimePicker);
            this.salesHistory_Tab.Controls.Add(this.salesHistory_DateLbl);
            this.salesHistory_Tab.Controls.Add(this.salesHistory_FromDateTimePicker);
            this.salesHistory_Tab.Controls.Add(this.sale_dataGridView);
            this.salesHistory_Tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesHistory_Tab.HorizontalScrollbarBarColor = true;
            this.salesHistory_Tab.HorizontalScrollbarHighlightOnWheel = false;
            this.salesHistory_Tab.HorizontalScrollbarSize = 15;
            this.salesHistory_Tab.Location = new System.Drawing.Point(4, 38);
            this.salesHistory_Tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesHistory_Tab.Name = "salesHistory_Tab";
            this.salesHistory_Tab.Size = new System.Drawing.Size(1417, 629);
            this.salesHistory_Tab.TabIndex = 1;
            this.salesHistory_Tab.Text = "Sales History";
            this.salesHistory_Tab.VerticalScrollbarBarColor = true;
            this.salesHistory_Tab.VerticalScrollbarHighlightOnWheel = false;
            this.salesHistory_Tab.VerticalScrollbarSize = 15;
            // 
            // salesHistory_EmployeeCheckBox
            // 
            this.salesHistory_EmployeeCheckBox.AutoSize = true;
            this.salesHistory_EmployeeCheckBox.BackColor = System.Drawing.Color.White;
            this.salesHistory_EmployeeCheckBox.Location = new System.Drawing.Point(290, 208);
            this.salesHistory_EmployeeCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesHistory_EmployeeCheckBox.Name = "salesHistory_EmployeeCheckBox";
            this.salesHistory_EmployeeCheckBox.Size = new System.Drawing.Size(265, 36);
            this.salesHistory_EmployeeCheckBox.TabIndex = 31;
            this.salesHistory_EmployeeCheckBox.Text = "Employee Search";
            this.salesHistory_EmployeeCheckBox.UseVisualStyleBackColor = false;
            // 
            // saleHistory_CustCheckBox
            // 
            this.saleHistory_CustCheckBox.AutoSize = true;
            this.saleHistory_CustCheckBox.BackColor = System.Drawing.Color.White;
            this.saleHistory_CustCheckBox.Location = new System.Drawing.Point(18, 208);
            this.saleHistory_CustCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saleHistory_CustCheckBox.Name = "saleHistory_CustCheckBox";
            this.saleHistory_CustCheckBox.Size = new System.Drawing.Size(260, 36);
            this.saleHistory_CustCheckBox.TabIndex = 30;
            this.saleHistory_CustCheckBox.Text = "Customer Search";
            this.saleHistory_CustCheckBox.UseVisualStyleBackColor = false;
            // 
            // salesHistory_LastNameLbl
            // 
            this.salesHistory_LastNameLbl.AutoSize = true;
            this.salesHistory_LastNameLbl.BackColor = System.Drawing.Color.White;
            this.salesHistory_LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesHistory_LastNameLbl.Location = new System.Drawing.Point(12, 406);
            this.salesHistory_LastNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesHistory_LastNameLbl.Name = "salesHistory_LastNameLbl";
            this.salesHistory_LastNameLbl.Size = new System.Drawing.Size(151, 32);
            this.salesHistory_LastNameLbl.TabIndex = 29;
            this.salesHistory_LastNameLbl.Text = "Last Name";
            // 
            // salesHistory_LastNameTxtB
            // 
            this.salesHistory_LastNameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesHistory_LastNameTxtB.Location = new System.Drawing.Point(18, 448);
            this.salesHistory_LastNameTxtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesHistory_LastNameTxtB.Name = "salesHistory_LastNameTxtB";
            this.salesHistory_LastNameTxtB.Size = new System.Drawing.Size(300, 39);
            this.salesHistory_LastNameTxtB.TabIndex = 28;
            // 
            // salesHistory_FirstNameLbl
            // 
            this.salesHistory_FirstNameLbl.AutoSize = true;
            this.salesHistory_FirstNameLbl.BackColor = System.Drawing.Color.White;
            this.salesHistory_FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesHistory_FirstNameLbl.Location = new System.Drawing.Point(12, 308);
            this.salesHistory_FirstNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesHistory_FirstNameLbl.Name = "salesHistory_FirstNameLbl";
            this.salesHistory_FirstNameLbl.Size = new System.Drawing.Size(152, 32);
            this.salesHistory_FirstNameLbl.TabIndex = 27;
            this.salesHistory_FirstNameLbl.Text = "First Name";
            // 
            // salesHistory_FirstNameTxtB
            // 
            this.salesHistory_FirstNameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesHistory_FirstNameTxtB.Location = new System.Drawing.Point(18, 349);
            this.salesHistory_FirstNameTxtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesHistory_FirstNameTxtB.Name = "salesHistory_FirstNameTxtB";
            this.salesHistory_FirstNameTxtB.Size = new System.Drawing.Size(300, 39);
            this.salesHistory_FirstNameTxtB.TabIndex = 26;
            // 
            // salesHistory_ToDateTimePicker
            // 
            this.salesHistory_ToDateTimePicker.AutoSize = true;
            this.salesHistory_ToDateTimePicker.BackColor = System.Drawing.Color.White;
            this.salesHistory_ToDateTimePicker.Location = new System.Drawing.Point(12, 112);
            this.salesHistory_ToDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesHistory_ToDateTimePicker.Name = "salesHistory_ToDateTimePicker";
            this.salesHistory_ToDateTimePicker.Size = new System.Drawing.Size(48, 32);
            this.salesHistory_ToDateTimePicker.TabIndex = 25;
            this.salesHistory_ToDateTimePicker.Text = "To";
            // 
            // salesHistory_2DateTimePicker
            // 
            this.salesHistory_2DateTimePicker.Location = new System.Drawing.Point(108, 106);
            this.salesHistory_2DateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesHistory_2DateTimePicker.Name = "salesHistory_2DateTimePicker";
            this.salesHistory_2DateTimePicker.Size = new System.Drawing.Size(460, 39);
            this.salesHistory_2DateTimePicker.TabIndex = 24;
            // 
            // salesHistory_DateLbl
            // 
            this.salesHistory_DateLbl.AutoSize = true;
            this.salesHistory_DateLbl.BackColor = System.Drawing.Color.White;
            this.salesHistory_DateLbl.Location = new System.Drawing.Point(12, 22);
            this.salesHistory_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesHistory_DateLbl.Name = "salesHistory_DateLbl";
            this.salesHistory_DateLbl.Size = new System.Drawing.Size(80, 32);
            this.salesHistory_DateLbl.TabIndex = 23;
            this.salesHistory_DateLbl.Text = "From";
            // 
            // salesHistory_FromDateTimePicker
            // 
            this.salesHistory_FromDateTimePicker.Location = new System.Drawing.Point(108, 15);
            this.salesHistory_FromDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesHistory_FromDateTimePicker.Name = "salesHistory_FromDateTimePicker";
            this.salesHistory_FromDateTimePicker.Size = new System.Drawing.Size(460, 39);
            this.salesHistory_FromDateTimePicker.TabIndex = 22;
            // 
            // sale_dataGridView
            // 
            this.sale_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sale_dataGridView.Location = new System.Drawing.Point(578, 15);
            this.sale_dataGridView.Name = "sale_dataGridView";
            this.sale_dataGridView.RowHeadersWidth = 51;
            this.sale_dataGridView.RowTemplate.Height = 24;
            this.sale_dataGridView.Size = new System.Drawing.Size(828, 575);
            this.sale_dataGridView.TabIndex = 21;
            // 
            // carTab
            // 
            this.carTab.Controls.Add(this.testBtn);
            this.carTab.Controls.Add(this.cars_NoCheckBox);
            this.carTab.Controls.Add(this.cars_YesCheckBox);
            this.carTab.Controls.Add(this.cars_YearTxtB);
            this.carTab.Controls.Add(this.cars_YearLbl);
            this.carTab.Controls.Add(this.cars_dataGridView);
            this.carTab.Controls.Add(this.label2);
            this.carTab.Controls.Add(this.cars_modelLbl);
            this.carTab.Controls.Add(this.cars_modelTxtB);
            this.carTab.Controls.Add(this.cars_makeTxtB);
            this.carTab.Controls.Add(this.cars_makeLbl);
            this.carTab.Controls.Add(this.cars_VINLbl);
            this.carTab.Controls.Add(this.cars_VINTxtB);
            this.carTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTab.HorizontalScrollbarBarColor = true;
            this.carTab.HorizontalScrollbarHighlightOnWheel = false;
            this.carTab.HorizontalScrollbarSize = 15;
            this.carTab.Location = new System.Drawing.Point(4, 38);
            this.carTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carTab.Name = "carTab";
            this.carTab.Size = new System.Drawing.Size(1417, 629);
            this.carTab.TabIndex = 2;
            this.carTab.Text = "Cars";
            this.carTab.VerticalScrollbarBarColor = true;
            this.carTab.VerticalScrollbarHighlightOnWheel = false;
            this.carTab.VerticalScrollbarSize = 15;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(202, 483);
            this.testBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(112, 49);
            this.testBtn.TabIndex = 26;
            this.testBtn.Text = "TestQ";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // cars_NoCheckBox
            // 
            this.cars_NoCheckBox.AutoSize = true;
            this.cars_NoCheckBox.BackColor = System.Drawing.Color.White;
            this.cars_NoCheckBox.Location = new System.Drawing.Point(417, 374);
            this.cars_NoCheckBox.Name = "cars_NoCheckBox";
            this.cars_NoCheckBox.Size = new System.Drawing.Size(77, 36);
            this.cars_NoCheckBox.TabIndex = 25;
            this.cars_NoCheckBox.Text = "No";
            this.cars_NoCheckBox.UseVisualStyleBackColor = false;
            // 
            // cars_YesCheckBox
            // 
            this.cars_YesCheckBox.AutoSize = true;
            this.cars_YesCheckBox.BackColor = System.Drawing.Color.White;
            this.cars_YesCheckBox.Location = new System.Drawing.Point(324, 374);
            this.cars_YesCheckBox.Name = "cars_YesCheckBox";
            this.cars_YesCheckBox.Size = new System.Drawing.Size(90, 36);
            this.cars_YesCheckBox.TabIndex = 24;
            this.cars_YesCheckBox.Text = "Yes";
            this.cars_YesCheckBox.UseVisualStyleBackColor = false;
            // 
            // cars_YearTxtB
            // 
            this.cars_YearTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_YearTxtB.Location = new System.Drawing.Point(267, 283);
            this.cars_YearTxtB.Name = "cars_YearTxtB";
            this.cars_YearTxtB.Size = new System.Drawing.Size(286, 39);
            this.cars_YearTxtB.TabIndex = 23;
            // 
            // cars_YearLbl
            // 
            this.cars_YearLbl.AutoSize = true;
            this.cars_YearLbl.BackColor = System.Drawing.Color.White;
            this.cars_YearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_YearLbl.Location = new System.Drawing.Point(10, 289);
            this.cars_YearLbl.Name = "cars_YearLbl";
            this.cars_YearLbl.Size = new System.Drawing.Size(75, 32);
            this.cars_YearLbl.TabIndex = 22;
            this.cars_YearLbl.Text = "Year";
            // 
            // cars_dataGridView
            // 
            this.cars_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cars_dataGridView.Location = new System.Drawing.Point(578, 22);
            this.cars_dataGridView.Name = "cars_dataGridView";
            this.cars_dataGridView.RowHeadersWidth = 51;
            this.cars_dataGridView.RowTemplate.Height = 24;
            this.cars_dataGridView.Size = new System.Drawing.Size(828, 575);
            this.cars_dataGridView.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Used?";
            // 
            // cars_modelLbl
            // 
            this.cars_modelLbl.AutoSize = true;
            this.cars_modelLbl.BackColor = System.Drawing.Color.White;
            this.cars_modelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_modelLbl.Location = new System.Drawing.Point(10, 203);
            this.cars_modelLbl.Name = "cars_modelLbl";
            this.cars_modelLbl.Size = new System.Drawing.Size(93, 32);
            this.cars_modelLbl.TabIndex = 18;
            this.cars_modelLbl.Text = "Model";
            // 
            // cars_modelTxtB
            // 
            this.cars_modelTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_modelTxtB.Location = new System.Drawing.Point(267, 197);
            this.cars_modelTxtB.Name = "cars_modelTxtB";
            this.cars_modelTxtB.Size = new System.Drawing.Size(286, 39);
            this.cars_modelTxtB.TabIndex = 17;
            // 
            // cars_makeTxtB
            // 
            this.cars_makeTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_makeTxtB.Location = new System.Drawing.Point(267, 109);
            this.cars_makeTxtB.Name = "cars_makeTxtB";
            this.cars_makeTxtB.Size = new System.Drawing.Size(286, 39);
            this.cars_makeTxtB.TabIndex = 16;
            // 
            // cars_makeLbl
            // 
            this.cars_makeLbl.AutoEllipsis = true;
            this.cars_makeLbl.AutoSize = true;
            this.cars_makeLbl.BackColor = System.Drawing.Color.White;
            this.cars_makeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_makeLbl.ForeColor = System.Drawing.Color.Black;
            this.cars_makeLbl.Location = new System.Drawing.Point(10, 114);
            this.cars_makeLbl.Name = "cars_makeLbl";
            this.cars_makeLbl.Size = new System.Drawing.Size(84, 32);
            this.cars_makeLbl.TabIndex = 15;
            this.cars_makeLbl.Text = "Make";
            // 
            // cars_VINLbl
            // 
            this.cars_VINLbl.AutoSize = true;
            this.cars_VINLbl.BackColor = System.Drawing.Color.White;
            this.cars_VINLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_VINLbl.Location = new System.Drawing.Point(10, 22);
            this.cars_VINLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_VINLbl.Name = "cars_VINLbl";
            this.cars_VINLbl.Size = new System.Drawing.Size(168, 32);
            this.cars_VINLbl.TabIndex = 14;
            this.cars_VINLbl.Text = "VIN Number";
            // 
            // cars_VINTxtB
            // 
            this.cars_VINTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_VINTxtB.Location = new System.Drawing.Point(267, 22);
            this.cars_VINTxtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cars_VINTxtB.Name = "cars_VINTxtB";
            this.cars_VINTxtB.Size = new System.Drawing.Size(286, 39);
            this.cars_VINTxtB.TabIndex = 13;
            // 
            // employeeTab
            // 
            this.employeeTab.HorizontalScrollbarBarColor = true;
            this.employeeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.employeeTab.HorizontalScrollbarSize = 15;
            this.employeeTab.Location = new System.Drawing.Point(4, 38);
            this.employeeTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Size = new System.Drawing.Size(1417, 629);
            this.employeeTab.TabIndex = 3;
            this.employeeTab.Text = "Employees";
            this.employeeTab.VerticalScrollbarBarColor = true;
            this.employeeTab.VerticalScrollbarHighlightOnWheel = false;
            this.employeeTab.VerticalScrollbarSize = 15;
            // 
            // cust_CreateButton
            // 
            this.cust_CreateButton.Location = new System.Drawing.Point(34, 453);
            this.cust_CreateButton.Name = "cust_CreateButton";
            this.cust_CreateButton.Size = new System.Drawing.Size(130, 54);
            this.cust_CreateButton.TabIndex = 13;
            this.cust_CreateButton.Text = "Create new customer";
            this.cust_CreateButton.UseVisualStyleBackColor = true;
            // 
            // cust_UpdateButton
            // 
            this.cust_UpdateButton.Location = new System.Drawing.Point(203, 453);
            this.cust_UpdateButton.Name = "cust_UpdateButton";
            this.cust_UpdateButton.Size = new System.Drawing.Size(130, 54);
            this.cust_UpdateButton.TabIndex = 14;
            this.cust_UpdateButton.Text = "Update customer";
            this.cust_UpdateButton.UseVisualStyleBackColor = true;
            // 
            // cust_ListAllButton
            // 
            this.cust_ListAllButton.Location = new System.Drawing.Point(374, 453);
            this.cust_ListAllButton.Name = "cust_ListAllButton";
            this.cust_ListAllButton.Size = new System.Drawing.Size(130, 54);
            this.cust_ListAllButton.TabIndex = 15;
            this.cust_ListAllButton.Text = "List all customer";
            this.cust_ListAllButton.UseVisualStyleBackColor = true;
            this.cust_ListAllButton.Click += new System.EventHandler(this.cust_ListAllButton_Click);
            // 
            // sales_Tab
            // 
            this.sales_Tab.Controls.Add(this.button1);
            this.sales_Tab.Controls.Add(this.checkBox1);
            this.sales_Tab.Controls.Add(this.checkBox2);
            this.sales_Tab.Controls.Add(this.textBox1);
            this.sales_Tab.Controls.Add(this.label1);
            this.sales_Tab.Controls.Add(this.dataGridView1);
            this.sales_Tab.Controls.Add(this.label3);
            this.sales_Tab.Controls.Add(this.label4);
            this.sales_Tab.Controls.Add(this.textBox2);
            this.sales_Tab.Controls.Add(this.textBox3);
            this.sales_Tab.Controls.Add(this.label5);
            this.sales_Tab.Controls.Add(this.sales_VinNumberLabel);
            this.sales_Tab.Controls.Add(this.sales_VinNumberTextBox);
            this.sales_Tab.HorizontalScrollbarBarColor = true;
            this.sales_Tab.HorizontalScrollbarHighlightOnWheel = false;
            this.sales_Tab.HorizontalScrollbarSize = 10;
            this.sales_Tab.Location = new System.Drawing.Point(4, 38);
            this.sales_Tab.Name = "sales_Tab";
            this.sales_Tab.Size = new System.Drawing.Size(1417, 629);
            this.sales_Tab.TabIndex = 4;
            this.sales_Tab.Text = "Sales";
            this.sales_Tab.VerticalScrollbarBarColor = true;
            this.sales_Tab.VerticalScrollbarHighlightOnWheel = false;
            this.sales_Tab.VerticalScrollbarSize = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 488);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 49);
            this.button1.TabIndex = 39;
            this.button1.Text = "TestQ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(417, 379);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 24);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "No";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(324, 379);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 24);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.Text = "Yes";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(267, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 39);
            this.textBox1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Year";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(578, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(828, 575);
            this.dataGridView1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "Used?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "CustomerID";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(267, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 39);
            this.textBox2.TabIndex = 31;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(267, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(286, 39);
            this.textBox3.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "EmployeeID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // sales_VinNumberLabel
            // 
            this.sales_VinNumberLabel.AutoSize = true;
            this.sales_VinNumberLabel.BackColor = System.Drawing.Color.White;
            this.sales_VinNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_VinNumberLabel.Location = new System.Drawing.Point(10, 27);
            this.sales_VinNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sales_VinNumberLabel.Name = "sales_VinNumberLabel";
            this.sales_VinNumberLabel.Size = new System.Drawing.Size(168, 32);
            this.sales_VinNumberLabel.TabIndex = 28;
            this.sales_VinNumberLabel.Text = "VIN Number";
            // 
            // sales_VinNumberTextBox
            // 
            this.sales_VinNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_VinNumberTextBox.Location = new System.Drawing.Point(267, 27);
            this.sales_VinNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sales_VinNumberTextBox.Name = "sales_VinNumberTextBox";
            this.sales_VinNumberTextBox.Size = new System.Drawing.Size(286, 39);
            this.sales_VinNumberTextBox.TabIndex = 27;
            // 
            // Dealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 751);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dealership";
            this.Text = "Car Dealership";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabControl.ResumeLayout(false);
            this.customerTab.ResumeLayout(false);
            this.customerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_dataGridView)).EndInit();
            this.salesHistory_Tab.ResumeLayout(false);
            this.salesHistory_Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sale_dataGridView)).EndInit();
            this.carTab.ResumeLayout(false);
            this.carTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cars_dataGridView)).EndInit();
            this.sales_Tab.ResumeLayout(false);
            this.sales_Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLbl;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage customerTab;
        private MetroFramework.Controls.MetroTabPage salesHistory_Tab;
        private MetroFramework.Controls.MetroTabPage carTab;
        private MetroFramework.Controls.MetroTabPage employeeTab;
        private System.Windows.Forms.Label cust_firstNMLbl;
        private System.Windows.Forms.TextBox cust_firstNMTxtB;
        private System.Windows.Forms.Label cust_lastNMLbl;
        private System.Windows.Forms.TextBox cust_lastNMTxtB;
        private System.Windows.Forms.TextBox cust_middleNMTxtB;
        private System.Windows.Forms.Label cust_middleNMLbl;
        private System.Windows.Forms.Label cust_emailLbl;
        private System.Windows.Forms.TextBox cust_emailTxtB;
        private System.Windows.Forms.DataGridView cust_dataGridView;
        private System.Windows.Forms.TextBox cust_PhoneNbrTxtB;
        private System.Windows.Forms.Label cust_PhoneNbrLbl;
        private System.Windows.Forms.DateTimePicker salesHistory_FromDateTimePicker;
        private System.Windows.Forms.DataGridView sale_dataGridView;
        private System.Windows.Forms.Label salesHistory_DateLbl;
        private System.Windows.Forms.CheckBox salesHistory_EmployeeCheckBox;
        private System.Windows.Forms.CheckBox saleHistory_CustCheckBox;
        private System.Windows.Forms.Label salesHistory_LastNameLbl;
        private System.Windows.Forms.TextBox salesHistory_LastNameTxtB;
        private System.Windows.Forms.Label salesHistory_FirstNameLbl;
        private System.Windows.Forms.TextBox salesHistory_FirstNameTxtB;
        private System.Windows.Forms.Label salesHistory_ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker salesHistory_2DateTimePicker;
        private System.Windows.Forms.CheckBox cars_NoCheckBox;
        private System.Windows.Forms.CheckBox cars_YesCheckBox;
        private System.Windows.Forms.TextBox cars_YearTxtB;
        private System.Windows.Forms.Label cars_YearLbl;
        private System.Windows.Forms.DataGridView cars_dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cars_modelLbl;
        private System.Windows.Forms.TextBox cars_modelTxtB;
        private System.Windows.Forms.TextBox cars_makeTxtB;
        private System.Windows.Forms.Label cars_makeLbl;
        private System.Windows.Forms.Label cars_VINLbl;
        private System.Windows.Forms.TextBox cars_VINTxtB;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button cust_ListAllButton;
        private System.Windows.Forms.Button cust_UpdateButton;
        private System.Windows.Forms.Button cust_CreateButton;
        private MetroFramework.Controls.MetroTabPage sales_Tab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sales_VinNumberLabel;
        private System.Windows.Forms.TextBox sales_VinNumberTextBox;
    }
}

