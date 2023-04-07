namespace DIP
{
    class Program
    {

        static void Main(string[] args)
        {
            Report report = new Report();
            ReportProcessor reportProcessor = new ReportProcessor(new FtpReportSender());
            ReportLongFormatter longFormatter = new ReportLongFormatter();
            ReportShortFormatter shortFormatter = new ReportShortFormatter();

            reportProcessor.Logger = new ConsoleLogger();
            reportProcessor.Logger = new EmailLogger();

            report.Text = "Hello World";
            reportProcessor.SendReport(report, shortFormatter);
        }
    }
}