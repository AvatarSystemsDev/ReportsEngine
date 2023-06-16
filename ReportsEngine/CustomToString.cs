using DevExpress.XtraReports.Expressions;
using System;

namespace ReportsEngine
{
    class CustomToString : ReportCustomFunctionOperatorBase
    {
        public override string FunctionCategory
            => "Custom";
        public override string Description
            => "CustomFormatFunction(string format, object arg0)" +
            "\r\nConverts an arg0 value to a string based on a specified format";
        public override object Evaluate(params object[] operands)
        {
            string res = String.Format(operands[0].ToString(), operands[1]);
            return res;
        }
        public override string Name
            => "CustomToString";

    }
}