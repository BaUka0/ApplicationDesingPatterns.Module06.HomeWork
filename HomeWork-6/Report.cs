using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public enum Format
    {
        Text, 
        Html, 
        Pdf
    }
    public interface IReportBuiler
    {
        void SetHeader(string header);
        void SetContent(string content);
        void SetFooter(string footer);
        void SetStyle(ReportStyle style);
        Report GetReport();
    }
    public class TextReportBuilder : IReportBuiler
    {
        private Report report = new Report();
        public void SetHeader(string header)
        {
            report.Header = header + "\n";
        }
        public void SetContent(string content)
        {
            report.Content = content + "\n";
        }
        public void SetFooter(string footer)
        {
            report.Footer = footer + "\n";
        }
        public void SetStyle(ReportStyle style)
        {
            report.Style = style;
        }
        public Report GetReport()
        {
            return report;
        }
    }
    public class HtmlReportBuilder : IReportBuiler
    {
        private Report report = new Report();

        public void SetHeader(string header)
        {
            report.Header = $"<h1>{header}</h1>";
        }
        public void SetContent(string content)
        {
            report.Content = $"<p>{content}</p>";
        }
        public void SetFooter(string footer)
        {
            report.Footer = $"<footer>{footer}</footer>";
        }
        public void SetStyle(ReportStyle style)
        {
            report.Style = style;
        }
        public Report GetReport()
        {
            return report;
        }
    }
    public class XmlReportBuilder : IReportBuiler
    {
        private Report report = new Report();

        public void SetHeader(string header)
        {
            report.Header = $"<Header>{header}</Header>";
        }

        public void SetContent(string content)
        {
            report.Content = $"<Content>{content}</Content>";
        }

        public void SetFooter(string footer)
        {
            report.Footer = $"<Footer>{footer}</Footer>";
        }
        public void SetStyle(ReportStyle style)
        {
            report.Style = style;
        }

        public Report GetReport()
        {
            return report;
        }
    }

    public class ReportStyle
    {
        public string BackgroundColor { get; set; }
        public string FontColor { get; set; }
        public int FontSize { get; set; }
    }

    public class ReportDirector
    {
        private IReportBuiler reportBuilder;

        public ReportDirector(IReportBuiler ReportBuilder)
        {
            reportBuilder = ReportBuilder;
        }

        public void BuildReport(string header, string content, string footer, ReportStyle style)
        {
            reportBuilder.SetHeader(header);
            reportBuilder.SetContent(content);
            reportBuilder.SetFooter(footer);
            reportBuilder.SetStyle(style);
        }

        public Report GetReport()
        {
            return reportBuilder.GetReport();
        }
    }
    public class Report
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public string Footer { get; set; }
        public ReportStyle Style { get; set; }
        public override string ToString()
        {
            return $"{Header}\n{Content}\n{Footer}";
        }

    }
}
