﻿namespace BisCarePosEdition
{
    partial class FrmItemsReport
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
            this.DataSetItemReport = new BisCarePosEdition.DataSetItemReport();
            this.SP_Items_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_Items_ReportTableAdapter = new BisCarePosEdition.DataSetItemReportTableAdapters.SP_Items_ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetItemReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Items_ReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_Items_ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BisCarePosEdition.ReportItems.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetItemReport
            // 
            this.DataSetItemReport.DataSetName = "DataSetItemReport";
            this.DataSetItemReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_Items_ReportBindingSource
            // 
            this.SP_Items_ReportBindingSource.DataMember = "SP_Items_Report";
            this.SP_Items_ReportBindingSource.DataSource = this.DataSetItemReport;
            // 
            // SP_Items_ReportTableAdapter
            // 
            this.SP_Items_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // FrmItemsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmItemsReport";
            this.Text = "FrmItemsReport";
            this.Load += new System.EventHandler(this.FrmItemsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetItemReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Items_ReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_Items_ReportBindingSource;
        private DataSetItemReport DataSetItemReport;
        private DataSetItemReportTableAdapters.SP_Items_ReportTableAdapter SP_Items_ReportTableAdapter;
    }
}