using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    internal static class LogWriter
    {
        // Print current logs to log.txt file
        internal static void PrintLogsToFile(List<Result> logList)
        {
             string path = @"../../../../log.txt";
             foreach (Result result in logList)
             {
                    File.AppendAllText(path, "[" + result.LogTime + "] [" + result.LogType + "] [" + result.ErrorMessage + "]\n");
             }
        }

        // Print current memory logs
        internal static void PrintMemoryLogs(List<Result> logList)
        {
            if (logList.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No logs in memory...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                foreach (Result logEntry in logList)
                {
                    Console.WriteLine("[" + logEntry.LogTime + "] [" + logEntry.LogType + "] [" + logEntry.ErrorMessage + "]");
                }
            }
        }

        // Print logs from log.txt file
        internal static void PrintFileLogs()
        {
            if (File.Exists(@"../../../../log.txt"))
            {
                string fileText = File.ReadAllText(@"../../../../log.txt");
                if (fileText == string.Empty)
                {
                    Console.WriteLine("No logs in file...");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(fileText);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No logs in file...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
