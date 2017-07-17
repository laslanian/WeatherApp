using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Logger
{
    public class LogProvider : BaseLogProvider, IDisposable
    {
        private string m_path { get { return m_basepath; } }

        #region PUblic members
        public override void LogEntity(string caller, string entity, string message, DateTime dt)
        {
            throw new NotImplementedException();
        }
        public override void LogException(string caller, string exception, string message, DateTime dt)
        {       
        }
        public override void LogMessage(string caller, string message, DateTime dt)
        {
            throw new NotImplementedException();
        }

        #endregion
        #region Private members
        private void WriteLog(string logEntry, string path)
        {
            string StartDirectory = @"c:\Users\exampleuser\start";
            string EndDirectory = @"c:\Users\exampleuser\end";

         

            //  using(StreamWriter sw = new StreamWriter("C:\\test.txt") { }
        }
        #endregion
        #region Dispose
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    public class LogEntry
    {
        private string Caller{get;set;}
        private string Message { get; set; }
        private DateTime DateTime { get; set; }
        private LogType LogType { get; set; }
        
        public LogEntry(string caller, string message, LogType logType)
        {
            this.Caller = caller;
            this.Message = message;
            this.DateTime = DateTime.Now;
            this.LogType = logType;
        }
        public string[] CreateLogEntry()
        {
            List<string> args = new List<string>();

            args.Add(Environment.NewLine);
            args.Add(LogEntryConstants.LOGTIME + DateTime.Now);
            args.Add(LogEntryConstants.SEPARATOR);
            args.Add(LogEntryConstants.CALLER + Caller);
            args.Add(LogEntryConstants.LOGTYPE + LogType);
            args.Add(LogEntryConstants.SEPARATOR);
            args.Add(LogEntryConstants.MESSAGE + Message);
            args.Add(LogEntryConstants.SEPARATOR);
            args.Add(Environment.NewLine);
            
            return args.ToArray();
        }
    }
    public class LogType
    {
        public const string INFORMATION = "INFORMATION";
        public const string SEVERE = "SEVERE";
        public const string WARNING = "WARNING";
        public const string CHECKPOINT = "CHECKPOINT";
    }
    public class LogEntryConstants
    {
        public const string CALLER = "CALLER: ";
        public const string MESSAGE = "MESSAGE: ";
        public const string LOGTIME = "LOGTIME: ";
        public const string LOGTYPE = "LOGTYPE: ";
        public const string SEPARATOR = "------------------------------------------";
        
    }
}
