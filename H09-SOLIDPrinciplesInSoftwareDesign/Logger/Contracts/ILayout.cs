namespace Logger.Contracts
{
    using System;

    using Logger.Models;

    public interface ILayout
    {
        string FormatLog(DateTime date, ReportLevel reportLevel, string message);
    }
}
