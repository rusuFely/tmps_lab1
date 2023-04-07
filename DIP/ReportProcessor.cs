namespace DIP
{
     class ReportProcessor
    {
        private readonly IReportSender _reportSender;
        public ILogger Logger { get; set; }

        public ReportProcessor(IReportSender reportSender)
        {
            _reportSender = reportSender;
            // Logger = GetDefaultLogger();
        }

        public void SendReport(ReportProcessor report, IReportFormatter formatter)
        {
            var formattedReport = formatter.Format(report);

            _reportSender.SendReport(formattedReport);
            Logger.Log("report send...");
        }
    }
}
