namespace Logger.Contracts
{
    using System;

    using Logger.Models;

    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        ILayout Layout { get; }

        void Append(DateTime date, ReportLevel reportLevel, string message);
    }
}
