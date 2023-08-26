﻿using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;


namespace ReportsEngine.Reports
{
    public partial class GeneralLedgerDetail : DevExpress.XtraReports.UI.XtraReport
    {
        private double GrandAccountTotalDebitx;
        private double GrandAccountTotalCreditx;
        private double GrandPeriodTotalDebitx;
        private double GrandPeriodTotalCreditx;
        public GeneralLedgerDetail()
        {
            InitializeComponent();
            //xrAccountTotalDebit.AfterPrint += xrAccountTotalDebit_AfterPrint;
            //BeforePrint += GeneralLedgerDetail_BeforePrint;
            xrReportAccountSumDebit.PrintOnPage += xrReportAccountSumDebit_PrintOnPage;
            xrReportAccountSumCredit.PrintOnPage += xrReportAccountSumCredit_PrintOnPage;

            xrAccountTotalDebit.PrintOnPage += xrAccountTotalDebit_PrintOnPage;
            xrAccountTotalCredit.PrintOnPage += xrAccountTotalCredit_PrintOnPage;

            xrReportPeriodSumDebit.PrintOnPage += xrReportPeriodSumDebit_PrintOnPage;
            xrReportPeriodSumCredit.PrintOnPage += xrReportPeriodSumCredit_PrintOnPage;

            xrPeriodTotalDebit.PrintOnPage += xrPeriodTotalDebit_PrintOnPage;
            xrPeriodTotalCredit.PrintOnPage += xrPeriodTotalCredit_PrintOnPage;

        }

        private void GeneralLedgerDetail_BeforePrint(object sender, CancelEventArgs e)
        {
            GrandAccountTotalDebitx = 0;
            GrandAccountTotalCreditx = 0;
            GrandPeriodTotalDebitx = 0;
            GrandPeriodTotalCreditx = 0;
        }
        private void xrAccountTotalDebit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            if (((XRLabel)sender).Text != "")
            {
                try
                {
                    GrandAccountTotalDebitx += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                }
                catch
                {

                }
            }
        }
        private void xrAccountTotalCredit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            if (((XRLabel)sender).Text != "")
            {
                try
                {
                    GrandAccountTotalCreditx += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                }
                catch
                {

                }
            }
        }


        private void xrReportAccountSumDebit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            if (GrandAccountTotalDebitx <= 0)
            {
                ((XRLabel)sender).Text = GrandAccountTotalDebitx.ToString("N2"); 
            }
            else
            {
                ((XRLabel)sender).Text = GrandAccountTotalDebitx.ToString("N2");
            }
        }
        private void xrReportAccountSumCredit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            if (GrandAccountTotalDebitx <= 0)
            {
                ((XRLabel)sender).Text = GrandAccountTotalCreditx.ToString("N2");
            }
            else
            {
                ((XRLabel)sender).Text = GrandAccountTotalCreditx.ToString("N2");
            }
        }







        private void xrPeriodTotalDebit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            if (((XRLabel)sender).Text != "")
            {
                try
                {
                    GrandPeriodTotalDebitx += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                }
                catch
                {

                }
            }
        }
        private void xrPeriodTotalCredit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            if (((XRLabel)sender).Text != "")
            {
                try
                {
                    GrandPeriodTotalCreditx += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                }
                catch
                {

                }
            }
        }


        private void xrReportPeriodSumDebit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            if (GrandPeriodTotalDebitx <= 0)
            {
                ((XRLabel)sender).Text = GrandPeriodTotalDebitx.ToString("N2");
            }
            else
            {
                ((XRLabel)sender).Text = GrandPeriodTotalDebitx.ToString("N2");
            }
        }
        private void xrReportPeriodSumCredit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            if (GrandPeriodTotalDebitx <= 0)
            {
                ((XRLabel)sender).Text = GrandPeriodTotalCreditx.ToString("N2");
            }
            else
            {
                ((XRLabel)sender).Text = GrandPeriodTotalCreditx.ToString("N2");
            }
        }
    }
}
