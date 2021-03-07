using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Builder
{
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }
        public string DisplayReport()
        {
            string msg;
            msg = "Report Type :" + ReportType + Environment.NewLine;
            msg = msg + "Header :" + ReportHeader + Environment.NewLine;
            msg = msg + "Content :" + ReportContent + Environment.NewLine;
            msg = msg + "Footer :" + ReportFooter + Environment.NewLine;
            return msg;
        }
    }
}
