﻿namespace SemesterProjekt.GUI
{
    partial class VisLager
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
            this.PANEL_FindOrder = new System.Windows.Forms.Panel();
            this.LB_ShowStock = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeStockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeStockTable = new SemesterProjekt.StoreStockTable();
            this.storeStockTableAdapter = new SemesterProjekt.StoreStockTableTableAdapters.StoreStockTableAdapter();
            this.BTN_CreateTXTFile = new System.Windows.Forms.Button();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowStock);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(1080, 125);
            this.PANEL_FindOrder.TabIndex = 31;
            // 
            // LB_ShowStock
            // 
            this.LB_ShowStock.AutoSize = true;
            this.LB_ShowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_ShowStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowStock.Location = new System.Drawing.Point(336, 37);
            this.LB_ShowStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ShowStock.Name = "LB_ShowStock";
            this.LB_ShowStock.Size = new System.Drawing.Size(466, 48);
            this.LB_ShowStock.TabIndex = 16;
            this.LB_ShowStock.Text = "LAGER BEHOLDNING";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vATDataGridViewTextBoxColumn,
            this.amountOfProductDataGridViewTextBoxColumn,
            this.eANDataGridViewTextBoxColumn,
            this.storeStockIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.storeStockBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 125);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 885);
            this.dataGridView1.TabIndex = 32;
            // 
            // vATDataGridViewTextBoxColumn
            // 
            this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            this.vATDataGridViewTextBoxColumn.Width = 200;
            // 
            // amountOfProductDataGridViewTextBoxColumn
            // 
            this.amountOfProductDataGridViewTextBoxColumn.DataPropertyName = "AmountOfProduct";
            this.amountOfProductDataGridViewTextBoxColumn.HeaderText = "AmountOfProduct";
            this.amountOfProductDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.amountOfProductDataGridViewTextBoxColumn.Name = "amountOfProductDataGridViewTextBoxColumn";
            this.amountOfProductDataGridViewTextBoxColumn.Width = 200;
            // 
            // eANDataGridViewTextBoxColumn
            // 
            this.eANDataGridViewTextBoxColumn.DataPropertyName = "EAN";
            this.eANDataGridViewTextBoxColumn.HeaderText = "EAN";
            this.eANDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.eANDataGridViewTextBoxColumn.Name = "eANDataGridViewTextBoxColumn";
            this.eANDataGridViewTextBoxColumn.Width = 200;
            // 
            // storeStockIDDataGridViewTextBoxColumn
            // 
            this.storeStockIDDataGridViewTextBoxColumn.DataPropertyName = "StoreStockID";
            this.storeStockIDDataGridViewTextBoxColumn.HeaderText = "StoreStockID";
            this.storeStockIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.storeStockIDDataGridViewTextBoxColumn.Name = "storeStockIDDataGridViewTextBoxColumn";
            this.storeStockIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeStockIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // storeStockBindingSource
            // 
            this.storeStockBindingSource.DataMember = "StoreStock";
            this.storeStockBindingSource.DataSource = this.storeStockTable;
            // 
            // storeStockTable
            // 
            this.storeStockTable.DataSetName = "StoreStockTable";
            this.storeStockTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeStockTableAdapter
            // 
            this.storeStockTableAdapter.ClearBeforeFill = true;
            // 
            // BTN_CreateTXTFile
            // 
            this.BTN_CreateTXTFile.BackColor = System.Drawing.Color.White;
            this.BTN_CreateTXTFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_CreateTXTFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_CreateTXTFile.Location = new System.Drawing.Point(888, 894);
            this.BTN_CreateTXTFile.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BTN_CreateTXTFile.Name = "BTN_CreateTXTFile";
            this.BTN_CreateTXTFile.Size = new System.Drawing.Size(162, 58);
            this.BTN_CreateTXTFile.TabIndex = 107;
            this.BTN_CreateTXTFile.Text = "Udskriv";
            this.BTN_CreateTXTFile.UseVisualStyleBackColor = false;
            this.BTN_CreateTXTFile.Click += new System.EventHandler(this.BTN_CreateTXTFile_Click);
            // 
            // VisLager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1080, 1010);
            this.Controls.Add(this.BTN_CreateTXTFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VisLager";
            this.Text = "VisLager";
            this.Load += new System.EventHandler(this.VisLager_Load);
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label LB_ShowStock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StoreStockTable storeStockTable;
        private System.Windows.Forms.BindingSource storeStockBindingSource;
        private StoreStockTableTableAdapters.StoreStockTableAdapter storeStockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeStockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTN_CreateTXTFile;
    }
}