using ELogger.Enums;
using System;
using System.IO;

namespace ELogger
{
    public static class Logs
    {
        public static void Log(Exception ex, LogLevel level)
        {
            try
            {
                if (ex == null) return;
                switch (level)
                {
                    case LogLevel.Error:
                        LogError(ex);
                        break;
                    case LogLevel.Info:
                        LogInfo(ex);
                        break;
                    case LogLevel.Trace:
                        LogTrace(ex);
                        break;
                    case LogLevel.Warning:
                        LogWarning(ex);
                        break;
                }
            }
            catch
            {
            }
        }

        public static void LogError(Exception ex)
        {
            try
            {
                if (!File.Exists(Constants.LOG_PATH))
                {
                    Directory.CreateDirectory(Constants.LOG_DIR);
                    File.CreateText(Constants.LOG_FILE);
                }
                using (StreamWriter sw = new StreamWriter(Constants.LOG_PATH,true))
                {
                    sw.WriteLine($"[{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}] [ERROR] : {ex.Message} \n {ex.StackTrace}");
                }
            }
            catch (Exception e){ }
        }
        public static void LogTrace(Exception ex) { }
        public static void LogInfo(Exception ex) { }
        public static void LogWarning(Exception ex) { }
    }
}
