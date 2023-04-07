namespace LSP
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee intern = new InternDevelopers();
            ReportableEmployee senior = new SeniorDeveloper();

            senior.PrintDetails();
            intern.PrintDetails();

            senior.ReportWork();
        }
    }
}