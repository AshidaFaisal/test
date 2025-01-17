﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BisCarePosEdition
{
    public partial class FrmReportOtherIncomeType : Form
    {
        public FrmReportOtherIncomeType()
        {
            InitializeComponent();
        }
        DateTime start, end;
        int mode;
        string type;
        public FrmReportOtherIncomeType(DateTime end1, string start1, string tpe, int mod1)
        {
            InitializeComponent();
            start = Convert.ToDateTime(start1);
            end = end1;
            type = tpe;
            mode = mod1;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void FrmReportOtherIncomeType_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'dbBizcarePosDataSetReportOtherIncomeType.spReportOtherIncome' table. You can move, or remove it, as needed.
            this.spReportOtherIncomeTableAdapter.Fill(this.dbBizcarePosDataSetReportOtherIncomeType.spReportOtherIncome, start, end, type, mode);

            this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void FrmReportOtherIncomeType_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
