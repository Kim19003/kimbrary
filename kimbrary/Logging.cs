using System;

namespace Kimbrary
{
    namespace Logging
    {
        public enum LogType
        {
            None,
            Critical,
            Debug,
            Error,
            Information,
            Trace,
            Warning
        }

        public static class KLogger
        {
            public static string LogFilePath { get; private set; } = @"C:\Program Files\KLogs.log";
            public static string? Log { get; private set; } = null;
            public static LogType LogType { get; private set; } = LogType.None;

            public static void Initialize(string log)
            {
                Log = log;
            }

            public static void Initialize(string log, LogType logType)
            {
                Log = log;
                LogType = logType;
            }

            public static void Initialize(string log, string logFilePath)
            {
                Log = log;
                LogFilePath = logFilePath;
            }

            public static void Initialize(string log, LogType logType, string logFilePath)
            {
                Log = log;
                LogType = logType;
                LogFilePath = logFilePath;
            }

            public static void DoLog()
            {
                string _logType = GetLogTypeAsString(LogType);

                if (!string.IsNullOrEmpty(_logType))
                {
                    System.IO.File.AppendAllText(LogFilePath, $"[{DateTime.Now} (TD: {DateTime.Now.Hour - DateTime.UtcNow.Hour}) {_logType}] {Log}\n");
                }
                else
                {
                    System.IO.File.AppendAllText(LogFilePath, $"[{DateTime.Now} (TD: {DateTime.Now.Hour - DateTime.UtcNow.Hour})] {Log}\n");
                }
            }

            public static void DoLog(string log)
            {
                string _logType = GetLogTypeAsString(LogType);

                if (!string.IsNullOrEmpty(_logType))
                {
                    System.IO.File.AppendAllText(LogFilePath, $"[{DateTime.Now} (TD: {DateTime.Now.Hour - DateTime.UtcNow.Hour}) {_logType}] {log}\n");
                }
                else
                {
                    System.IO.File.AppendAllText(LogFilePath, $"[{DateTime.Now} (TD: {DateTime.Now.Hour - DateTime.UtcNow.Hour})] {log}\n");
                }
            }

            public static void DoLog(string log, LogType logType)
            {
                string _logType = GetLogTypeAsString(logType);

                if (!string.IsNullOrEmpty(_logType))
                {
                    System.IO.File.AppendAllText(LogFilePath, $"[{DateTime.Now} (TD: {DateTime.Now.Hour - DateTime.UtcNow.Hour}) {_logType}] {log}\n");
                }
                else
                {
                    System.IO.File.AppendAllText(LogFilePath, $"[{DateTime.Now} (TD: {DateTime.Now.Hour - DateTime.UtcNow.Hour})] {log}\n");
                }
            }

            public static void DoLog(string log, string logFilePath)
            {
                string _logType = GetLogTypeAsString(LogType);

                if (!string.IsNullOrEmpty(_logType))
                {
                    System.IO.File.AppendAllText(logFilePath, $"[{DateTime.Now} (TD: {DateTime.Now.Hour - DateTime.UtcNow.Hour}) {_logType}] {log}\n");
                }
                else
                {
                    System.IO.File.AppendAllText(logFilePath, $"[{DateTime.Now} (TD: {DateTime.Now.Hour - DateTime.UtcNow.Hour})] {log}\n");
                }
            }

            public static void DoLog(string log, LogType logType, string logFilePath)
            {
                string _logType = GetLogTypeAsString(logType);

                if (!string.IsNullOrEmpty(_logType))
                {
                    System.IO.File.AppendAllText(logFilePath, $"[{DateTime.Now} (TD: {DateTime.Now.Hour - DateTime.UtcNow.Hour}) {_logType}] {log}\n");
                }
                else
                {
                    System.IO.File.AppendAllText(logFilePath, $"[{DateTime.Now} (TD: {DateTime.Now.Hour - DateTime.UtcNow.Hour})] {log}\n");
                }
            }

            private static string GetLogTypeAsString(LogType logType)
            {
                switch (logType)
                {
                    case LogType.Critical:
                        return "CRITICAL";
                    case LogType.Debug:
                        return "DEBUG";
                    case LogType.Error:
                        return "ERROR";
                    case LogType.Information:
                        return "INFORMATION";
                    case LogType.Trace:
                        return "TRACE";
                    case LogType.Warning:
                        return "WARNING";
                }

                return string.Empty;
            }
        }
    }
}
