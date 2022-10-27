using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    internal class Logger
    {
        private static Logger instance;
        private List<Result> _logList = new List<Result>();
        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        // Save new log to log.txt and to memory
        internal void SaveNewLogEntry(Result logEntry)
        {
            _logList.Add(logEntry);
            string path = @"../../../../log.txt";
            File.AppendAllText(path, "[" + logEntry.LogTime + "] [" + logEntry.LogType + "] [" + logEntry.ErrorMessage + "]\n");
        }

        // Print current memory logs
        internal void PrintMemoryLogs()
        {
            if (_logList.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No logs in memory...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                foreach (Result logEntry in _logList)
                {
                    Console.WriteLine("[" + logEntry.LogTime + "] [" + logEntry.LogType + "] [" + logEntry.ErrorMessage + "]");
                }
            }
        }

        // Print logs from log.txt file
        private void PrintFileLogs()
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

        // Clear memory (delete all logs)
        private void ClearMemoryLogs()
        {
            _logList.Clear();
        }

        // Clear log.txt (delete all logs)
        private void ClearFileLogs()
        {
            string path = @"../../../../log.txt";
            File.WriteAllText(path, string.Empty);
        }
    }
}
