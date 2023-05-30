﻿namespace SemesterProjekt.GUI
{
    partial class OpdaterKunde
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_OpdateSelectProduct_ShowCustomers = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visionTestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTable = new SemesterProjekt.CustomerTable();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Tlf = new System.Windows.Forms.TextBox();
            this.TB_EMail = new System.Windows.Forms.TextBox();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Discount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_PostNr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Test = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_Age = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_PostalCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_City = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_UpdatedAdress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_UpdatedEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_UpdatedTlf = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TB_UpdatedLastName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_UpdatedName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LB_ShowName = new System.Windows.Forms.Label();
            this.LB_ShowLastName = new System.Windows.Forms.Label();
            this.LB_ShowTlf = new System.Windows.Forms.Label();
            this.LB_ShowEmail = new System.Windows.Forms.Label();
            this.LB_ShowAdress = new System.Windows.Forms.Label();
            this.BTN_UpdateCustomer = new System.Windows.Forms.Button();
            this.BTN_DeleteCustomer = new System.Windows.Forms.Button();
            this.BTN_OpretOrdre = new System.Windows.Forms.Button();
            this.LL_Forklaring = new System.Windows.Forms.LinkLabel();
            this.customerTableAdapter = new SemesterProjekt.CustomerTableTableAdapters.CustomerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OpdateSelectProduct_ShowCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 51);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(244, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Opdater Kunde";
            // 
            // DGV_OpdateSelectProduct_ShowCustomers
            // 
            this.DGV_OpdateSelectProduct_ShowCustomers.AutoGenerateColumns = false;
            this.DGV_OpdateSelectProduct_ShowCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DGV_OpdateSelectProduct_ShowCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_OpdateSelectProduct_ShowCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.surNameDataGridViewTextBoxColumn,
            this.phoneNrDataGridViewTextBoxColumn,
            this.eMailAdressDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.visionTestDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn});
            this.DGV_OpdateSelectProduct_ShowCustomers.DataSource = this.customerBindingSource;
            this.DGV_OpdateSelectProduct_ShowCustomers.Location = new System.Drawing.Point(9, 97);
            this.DGV_OpdateSelectProduct_ShowCustomers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_OpdateSelectProduct_ShowCustomers.Name = "DGV_OpdateSelectProduct_ShowCustomers";
            this.DGV_OpdateSelectProduct_ShowCustomers.RowHeadersWidth = 51;
            this.DGV_OpdateSelectProduct_ShowCustomers.RowTemplate.Height = 24;
            this.DGV_OpdateSelectProduct_ShowCustomers.Size = new System.Drawing.Size(529, 116);
            this.DGV_OpdateSelectProduct_ShowCustomers.TabIndex = 19;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            // 
            // phoneNrDataGridViewTextBoxColumn
            // 
            this.phoneNrDataGridViewTextBoxColumn.DataPropertyName = "PhoneNr";
            this.phoneNrDataGridViewTextBoxColumn.HeaderText = "PhoneNr";
            this.phoneNrDataGridViewTextBoxColumn.Name = "phoneNrDataGridViewTextBoxColumn";
            // 
            // eMailAdressDataGridViewTextBoxColumn
            // 
            this.eMailAdressDataGridViewTextBoxColumn.DataPropertyName = "EMailAdress";
            this.eMailAdressDataGridViewTextBoxColumn.HeaderText = "EMailAdress";
            this.eMailAdressDataGridViewTextBoxColumn.Name = "eMailAdressDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // visionTestDataGridViewTextBoxColumn
            // 
            this.visionTestDataGridViewTextBoxColumn.DataPropertyName = "VisionTest";
            this.visionTestDataGridViewTextBoxColumn.HeaderText = "VisionTest";
            this.visionTestDataGridViewTextBoxColumn.Name = "visionTestDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerTable;
            // 
            // customerTable
            // 
            this.customerTable.DataSetName = "CustomerTable";
            this.customerTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tlf: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(210, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "E-Mail :";
            // 
            // TB_Tlf
            // 
            this.TB_Tlf.Location = new System.Drawing.Point(59, 62);
            this.TB_Tlf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_Tlf.Name = "TB_Tlf";
            this.TB_Tlf.Size = new System.Drawing.Size(129, 20);
            this.TB_Tlf.TabIndex = 22;
            // 
            // TB_EMail
            // 
            this.TB_EMail.Location = new System.Drawing.Point(299, 62);
            this.TB_EMail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_EMail.Name = "TB_EMail";
            this.TB_EMail.Size = new System.Drawing.Size(129, 20);
            this.TB_EMail.TabIndex = 23;
            // 
            // BTN_Search
            // 
            this.BTN_Search.BackColor = System.Drawing.Color.White;
            this.BTN_Search.FlatAppearance.BorderSize = 0;
            this.BTN_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Search.Location = new System.Drawing.Point(457, 62);
            this.BTN_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(81, 23);
            this.BTN_Search.TabIndex = 24;
            this.BTN_Search.Text = "Søg";
            this.BTN_Search.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Oplysninger";
            // 
            // TB_Discount
            // 
            this.TB_Discount.Location = new System.Drawing.Point(460, 720);
            this.TB_Discount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_Discount.Name = "TB_Discount";
            this.TB_Discount.Size = new System.Drawing.Size(297, 20);
            this.TB_Discount.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(285, 712);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 25);
            this.label11.TabIndex = 75;
            this.label11.Text = "Discount :";
            // 
            // TB_PostNr
            // 
            this.TB_PostNr.Location = new System.Drawing.Point(460, 681);
            this.TB_PostNr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_PostNr.Name = "TB_PostNr";
            this.TB_PostNr.Size = new System.Drawing.Size(297, 20);
            this.TB_PostNr.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(285, 673);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 73;
            this.label8.Text = "PostNr : ";
            // 
            // TB_Test
            // 
            this.TB_Test.Location = new System.Drawing.Point(460, 643);
            this.TB_Test.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_Test.Name = "TB_Test";
            this.TB_Test.Size = new System.Drawing.Size(297, 20);
            this.TB_Test.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(285, 636);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 71;
            this.label9.Text = "Synstest :";
            // 
            // TB_Age
            // 
            this.TB_Age.Location = new System.Drawing.Point(460, 601);
            this.TB_Age.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_Age.Name = "TB_Age";
            this.TB_Age.Size = new System.Drawing.Size(297, 20);
            this.TB_Age.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(285, 594);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.TabIndex = 69;
            this.label10.Text = "Alder : ";
            // 
            // TB_PostalCode
            // 
            this.TB_PostalCode.Location = new System.Drawing.Point(460, 565);
            this.TB_PostalCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_PostalCode.Name = "TB_PostalCode";
            this.TB_PostalCode.Size = new System.Drawing.Size(297, 20);
            this.TB_PostalCode.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(285, 558);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 67;
            this.label7.Text = "PostNr : ";
            // 
            // TB_City
            // 
            this.TB_City.Location = new System.Drawing.Point(460, 526);
            this.TB_City.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_City.Name = "TB_City";
            this.TB_City.Size = new System.Drawing.Size(297, 20);
            this.TB_City.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(285, 519);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 65;
            this.label6.Text = "By :";
            // 
            // TB_UpdatedAdress
            // 
            this.TB_UpdatedAdress.Location = new System.Drawing.Point(331, 402);
            this.TB_UpdatedAdress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedAdress.Name = "TB_UpdatedAdress";
            this.TB_UpdatedAdress.Size = new System.Drawing.Size(209, 20);
            this.TB_UpdatedAdress.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(12, 402);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 25);
            this.label12.TabIndex = 63;
            this.label12.Text = "Adresse :";
            // 
            // TB_UpdatedEmail
            // 
            this.TB_UpdatedEmail.Location = new System.Drawing.Point(331, 370);
            this.TB_UpdatedEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedEmail.Name = "TB_UpdatedEmail";
            this.TB_UpdatedEmail.Size = new System.Drawing.Size(209, 20);
            this.TB_UpdatedEmail.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(12, 370);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 25);
            this.label13.TabIndex = 61;
            this.label13.Text = "E-Mail :";
            // 
            // TB_UpdatedTlf
            // 
            this.TB_UpdatedTlf.Location = new System.Drawing.Point(331, 337);
            this.TB_UpdatedTlf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedTlf.Name = "TB_UpdatedTlf";
            this.TB_UpdatedTlf.Size = new System.Drawing.Size(209, 20);
            this.TB_UpdatedTlf.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(12, 337);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 25);
            this.label14.TabIndex = 59;
            this.label14.Text = "Tlf +45 :";
            // 
            // TB_UpdatedLastName
            // 
            this.TB_UpdatedLastName.Location = new System.Drawing.Point(331, 303);
            this.TB_UpdatedLastName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedLastName.Name = "TB_UpdatedLastName";
            this.TB_UpdatedLastName.Size = new System.Drawing.Size(209, 20);
            this.TB_UpdatedLastName.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(12, 303);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 25);
            this.label15.TabIndex = 57;
            this.label15.Text = "Efternavn :";
            // 
            // TB_UpdatedName
            // 
            this.TB_UpdatedName.Location = new System.Drawing.Point(331, 274);
            this.TB_UpdatedName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedName.Name = "TB_UpdatedName";
            this.TB_UpdatedName.Size = new System.Drawing.Size(209, 20);
            this.TB_UpdatedName.TabIndex = 56;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(12, 266);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 25);
            this.label16.TabIndex = 55;
            this.label16.Text = "Fornavn :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(326, 240);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(229, 25);
            this.label17.TabIndex = 77;
            this.label17.Text = "Opdater Oplysninger";
            // 
            // LB_ShowName
            // 
            this.LB_ShowName.AutoSize = true;
            this.LB_ShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_ShowName.ForeColor = System.Drawing.Color.White;
            this.LB_ShowName.Location = new System.Drawing.Point(135, 266);
            this.LB_ShowName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowName.Name = "LB_ShowName";
            this.LB_ShowName.Size = new System.Drawing.Size(159, 25);
            this.LB_ShowName.TabIndex = 78;
            this.LB_ShowName.Text = "LB_ShowName";
            // 
            // LB_ShowLastName
            // 
            this.LB_ShowLastName.AutoSize = true;
            this.LB_ShowLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_ShowLastName.ForeColor = System.Drawing.Color.White;
            this.LB_ShowLastName.Location = new System.Drawing.Point(135, 303);
            this.LB_ShowLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowLastName.Name = "LB_ShowLastName";
            this.LB_ShowLastName.Size = new System.Drawing.Size(200, 25);
            this.LB_ShowLastName.TabIndex = 79;
            this.LB_ShowLastName.Text = "LB_ShowLastName";
            // 
            // LB_ShowTlf
            // 
            this.LB_ShowTlf.AutoSize = true;
            this.LB_ShowTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_ShowTlf.ForeColor = System.Drawing.Color.White;
            this.LB_ShowTlf.Location = new System.Drawing.Point(135, 337);
            this.LB_ShowTlf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowTlf.Name = "LB_ShowTlf";
            this.LB_ShowTlf.Size = new System.Drawing.Size(127, 25);
            this.LB_ShowTlf.TabIndex = 80;
            this.LB_ShowTlf.Text = "LB_ShowTlf";
            // 
            // LB_ShowEmail
            // 
            this.LB_ShowEmail.AutoSize = true;
            this.LB_ShowEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_ShowEmail.ForeColor = System.Drawing.Color.White;
            this.LB_ShowEmail.Location = new System.Drawing.Point(135, 370);
            this.LB_ShowEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowEmail.Name = "LB_ShowEmail";
            this.LB_ShowEmail.Size = new System.Drawing.Size(156, 25);
            this.LB_ShowEmail.TabIndex = 81;
            this.LB_ShowEmail.Text = "LB_ShowEmail";
            // 
            // LB_ShowAdress
            // 
            this.LB_ShowAdress.AutoSize = true;
            this.LB_ShowAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_ShowAdress.ForeColor = System.Drawing.Color.White;
            this.LB_ShowAdress.Location = new System.Drawing.Point(135, 410);
            this.LB_ShowAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowAdress.Name = "LB_ShowAdress";
            this.LB_ShowAdress.Size = new System.Drawing.Size(170, 25);
            this.LB_ShowAdress.TabIndex = 82;
            this.LB_ShowAdress.Text = "LB_ShowAdress";
            // 
            // BTN_UpdateCustomer
            // 
            this.BTN_UpdateCustomer.BackColor = System.Drawing.Color.White;
            this.BTN_UpdateCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_UpdateCustomer.FlatAppearance.BorderSize = 0;
            this.BTN_UpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_UpdateCustomer.Location = new System.Drawing.Point(0, 468);
            this.BTN_UpdateCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_UpdateCustomer.Name = "BTN_UpdateCustomer";
            this.BTN_UpdateCustomer.Size = new System.Drawing.Size(652, 47);
            this.BTN_UpdateCustomer.TabIndex = 83;
            this.BTN_UpdateCustomer.Text = "Opdater Kunde";
            this.BTN_UpdateCustomer.UseVisualStyleBackColor = false;
            // 
            // BTN_DeleteCustomer
            // 
            this.BTN_DeleteCustomer.BackColor = System.Drawing.Color.White;
            this.BTN_DeleteCustomer.FlatAppearance.BorderSize = 0;
            this.BTN_DeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_DeleteCustomer.Location = new System.Drawing.Point(543, 179);
            this.BTN_DeleteCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_DeleteCustomer.Name = "BTN_DeleteCustomer";
            this.BTN_DeleteCustomer.Size = new System.Drawing.Size(81, 34);
            this.BTN_DeleteCustomer.TabIndex = 84;
            this.BTN_DeleteCustomer.Text = "Slet Kunde";
            this.BTN_DeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // BTN_OpretOrdre
            // 
            this.BTN_OpretOrdre.BackColor = System.Drawing.Color.White;
            this.BTN_OpretOrdre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_OpretOrdre.Location = new System.Drawing.Point(543, 140);
            this.BTN_OpretOrdre.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_OpretOrdre.Name = "BTN_OpretOrdre";
            this.BTN_OpretOrdre.Size = new System.Drawing.Size(81, 34);
            this.BTN_OpretOrdre.TabIndex = 85;
            this.BTN_OpretOrdre.Text = "Opret Ordre";
            this.BTN_OpretOrdre.UseVisualStyleBackColor = false;
            // 
            // LL_Forklaring
            // 
            this.LL_Forklaring.AutoSize = true;
            this.LL_Forklaring.LinkColor = System.Drawing.Color.White;
            this.LL_Forklaring.Location = new System.Drawing.Point(551, 112);
            this.LL_Forklaring.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LL_Forklaring.Name = "LL_Forklaring";
            this.LL_Forklaring.Size = new System.Drawing.Size(53, 13);
            this.LL_Forklaring.TabIndex = 86;
            this.LL_Forklaring.TabStop = true;
            this.LL_Forklaring.Text = "Forklaring";
            this.LL_Forklaring.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Forklaring_LinkClicked);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // OpdaterKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(652, 515);
            this.Controls.Add(this.LL_Forklaring);
            this.Controls.Add(this.BTN_OpretOrdre);
            this.Controls.Add(this.BTN_DeleteCustomer);
            this.Controls.Add(this.BTN_UpdateCustomer);
            this.Controls.Add(this.LB_ShowAdress);
            this.Controls.Add(this.LB_ShowEmail);
            this.Controls.Add(this.LB_ShowTlf);
            this.Controls.Add(this.LB_ShowLastName);
            this.Controls.Add(this.LB_ShowName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TB_Discount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB_PostNr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_Test);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_Age);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_PostalCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_City);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_UpdatedAdress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TB_UpdatedEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TB_UpdatedTlf);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TB_UpdatedLastName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TB_UpdatedName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.TB_EMail);
            this.Controls.Add(this.TB_Tlf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGV_OpdateSelectProduct_ShowCustomers);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "OpdaterKunde";
            this.Text = "OpdaterKunde";
            this.Load += new System.EventHandler(this.OpdaterKunde_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OpdateSelectProduct_ShowCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_OpdateSelectProduct_ShowCustomers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Tlf;
        private System.Windows.Forms.TextBox TB_EMail;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Discount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_PostNr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Test;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_Age;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_PostalCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_City;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_UpdatedAdress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_UpdatedEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TB_UpdatedTlf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TB_UpdatedLastName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TB_UpdatedName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LB_ShowName;
        private System.Windows.Forms.Label LB_ShowLastName;
        private System.Windows.Forms.Label LB_ShowTlf;
        private System.Windows.Forms.Label LB_ShowEmail;
        private System.Windows.Forms.Label LB_ShowAdress;
        private System.Windows.Forms.Button BTN_UpdateCustomer;
        private System.Windows.Forms.Button BTN_DeleteCustomer;
        private System.Windows.Forms.Button BTN_OpretOrdre;
        private System.Windows.Forms.LinkLabel LL_Forklaring;
        private CustomerTable customerTable;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustomerTableTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visionTestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
    }
}