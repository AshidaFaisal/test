﻿namespace BisCarePosEdition
{
    partial class StockReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbBizcarePosDataSetStkReportnew = new BisCarePosEdition.dbBizcarePosDataSetStkReportnew();
            this.spGetStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetStockTableAdapter = new BisCarePosEdition.dbBizcarePosDataSetStkReportnewTableAdapters.spGetStockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetStkReportnew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spGetStockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportStock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(838, 444);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dbBizcarePosDataSetStkReportnew
            // 
            this.dbBizcarePosDataSetStkReportnew.DataSetName = "dbBizcarePosDataSetStkReportnew";
            this.dbBizcarePosDataSetStkReportnew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetStockBindingSource
            // 
            this.spGetStockBindingSource.DataMember = "spGetStock";
            this.spGetStockBindingSource.DataSource = this.dbBizcarePosDataSetStkReportnew;
            // 
            // spGetStockTableAdapter
            // 
            this.spGetStockTableAdapter.ClearBeforeFill = true;
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 444);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StockReport";
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.StockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBizcarePosDataSetStkReportnew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spGetStockBindingSource;
        private dbBizcarePosDataSetStkReportnew dbBizcarePosDataSetStkReportnew;
        private dbBizcarePosDataSetStkReportnewTableAdapters.spGetStockTableAdapter spGetStockTableAdapter;
    }
}