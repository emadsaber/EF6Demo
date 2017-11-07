using ELogger.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                        break;
                    case LogLevel.Info:

                        break;
                    case LogLevel.Trace:

                        break;
                    case LogLevel.Warning:

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
                using (StreamWriter sw = new StreamWriter(Constants.LOG_PATH))
                {
                    sw.WriteLine($"[{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}] [ERROR] : {ex.Message} \n {ex.StackTrace}");
                }
            }
            catch { }
        }
        public static void LogTrace(Exception ex) { }
        public static void LogInfo(Exception ex) { }
        public static void LogWarning(Exception ex) { }
    }
}
