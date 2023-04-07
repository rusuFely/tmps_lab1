namespace DIP
{
    internal interface IReportSender
    {
        void SendReport(ReportProcessor report);
        void SendReport(object formattedReport);
    }
}
