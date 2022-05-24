using System;

namespace Kimbrary
{
    namespace Logging
    {
        public enum LogType
        {
            None,
			Successful,
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

			/// <summary>
			/// Initialize the logger.
			/// </summary>
			public static void Initialize(string log)
			{
				Log = log;
			}

			/// <summary>
			/// Initialize the logger.
			/// </summary>
			public static void Initialize(string log, LogType logType)
			{
				Log = log;
				LogType = logType;
			}

			/// <summary>
			/// Initialize the logger.
			/// </summary>
			public static void Initialize(string log, string logFilePath)
			{
				Log = log;
				LogFilePath = logFilePath;
			}

			/// <summary>
			/// Initialize the logger.
			/// </summary>
			public static void Initialize(string log, LogType logType, string logFilePath)
			{
				Log = log;
				LogType = logType;
				LogFilePath = logFilePath;
			}

			/// <summary>
			/// Write a new log.
			/// </summary>
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

			/// <summary>
			/// Write a new log.
			/// </summary>
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

			/// <summary>
			/// Write a new log.
			/// </summary>
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

			/// <summary>
			/// Write a new log.
			/// </summary>
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

			/// <summary>
			/// Write a new log.
			/// </summary>
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

			/// <summary>
			/// Remove old logs from the logs file.
			/// </summary>
			public static void RunGarbageCleaner(int maxAmountOfLogs)
			{
				if (!string.IsNullOrEmpty(LogFilePath))
				{
					try
					{
						string[] oldLogs = System.IO.File.ReadAllLines(LogFilePath);

						if (oldLogs.Length > maxAmountOfLogs)
						{
							string[] newLogs = oldLogs.GetLatestElements(maxAmountOfLogs);

							try
							{
								System.IO.File.WriteAllLines(LogFilePath, newLogs);
							}
							catch
							{
								throw new FormatException("Writing to the logs file failed.");
							}
						}  
					}
					catch
					{
						throw new FormatException("Reading the logs file failed.");
					}
				}
				else
				{
					throw new MissingFieldException("LogFilePath is null or empty!");
				}
			}

			/// <summary>
			/// Remove old logs from the logs file.
			/// </summary>
			public static void RunGarbageCleaner(DateTime olderThan)
			{
				if (!string.IsNullOrEmpty(LogFilePath))
				{
					try
					{
						string[] oldLogs = System.IO.File.ReadAllLines(LogFilePath);

						if (oldLogs.Length > 0)
						{
							List<string> newLogs = new();

							foreach (var oldLog in oldLogs)
							{
								try
								{
									DateTime oldLogDateTime = Convert.ToDateTime(oldLog[(oldLog.IndexOf("[") + 1)..(oldLog.IndexOf("(TD:") - 1)]);

									if (oldLogDateTime > olderThan)
									{
										newLogs.Add(oldLog);
									}
								}
								catch
								{
									throw new FormatException("Log DateTime parsing failed.");
								}
							}

							try
							{
								System.IO.File.WriteAllLines(LogFilePath, newLogs);
							}
							catch
							{
								throw new FormatException("Writing to the logs file failed.");
							}
						}
					}
					catch (Exception ex)
					{
						if (ex is FormatException)
						{
							throw;
						}
						else
						{
							throw new FormatException("Reading the logs file failed.");
						}
					}
				}
				else
				{
					throw new MissingFieldException("LogFilePath is null or empty!");
				}
			}

			private static string GetLogTypeAsString(LogType logType)
			{
				switch (logType)
				{
					case LogType.Successful:
                    	return "SUCCESSFUL";
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
