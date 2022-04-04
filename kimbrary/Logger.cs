using System;

namespace Kimbrary
{
    namespace Logger
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

        public static class Logger
        {
            public static string LogFilePath { get; } = @"c/logpath/goes/here";

            public static string? LogMessage { get; private set; } = null;
            public static LogType LogType { get; private set; } = LogType.None;

            public static void Initialize(string logMessage, LogType logType)
            {
                LogMessage = logMessage;
                LogType = logType;
            }

            public static void Write()
            {
                if (LogMessage != null && LogType != LogType.None)
                {
                    string logType = "";

                    switch (LogType)
                    {
                        case LogType.Critical:
                            logType = "CRITICAL";
                            break;
                        case LogType.Debug:
                            logType = "DEBUG";
                            break;
                        case LogType.Error:
                            logType = "ERROR";
                            break;
                        case LogType.Information:
                            logType = "INFORMATION";
                            break;
                        case LogType.Trace:
                            logType = "TRACE";
                            break;
                        case LogType.Warning:
                            logType = "WARNING";
                            break;
                    }

                    System.IO.File.AppendAllText(LogFilePath, $"[{DateTime.Now} (TD: {DateTime.Now.Hour - DateTime.UtcNow.Hour}) {logType}] {LogMessage}\n");
                }
                else
                {
                    throw new NullReferenceException("Logger not initialized yet. Use Initialize method to initialize the logger.");
                }
            }

            public static void Write(string logMessage, LogType logType, string logFilePath)
            {
                if (!string.IsNullOrEmpty(logMessage) && logType != LogType.None && !string.IsNullOrEmpty(logFilePath))
                {
                    string _logType = "";

                    switch (logType)
                    {
                        case LogType.Critical:
                            _logType = "CRITICAL";
                            break;
                        case LogType.Debug:
                            _logType = "DEBUG";
                            break;
                        case LogType.Error:
                            _logType = "ERROR";
                            break;
                        case LogType.Information:
                            _logType = "INFORMATION";
                            break;
                        case LogType.Trace:
                            _logType = "TRACE";
                            break;
                        case LogType.Warning:
                            _logType = "WARNING";
                            break;
                    }

                    System.IO.File.AppendAllText(logFilePath, $"[{DateTime.Now} (TD: {DateTime.Now.Hour - DateTime.UtcNow.Hour}) {_logType}] {logMessage}\n");
                }
                else
                {
                    throw new ArgumentException("None of the given arguments can be null, empty or None.");
                }
            }
        }
    }
}
