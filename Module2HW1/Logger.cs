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

        // Menu to interact with logger
        internal void LoggerInteractionMenu()
        {
            while (true)
            {
                Console.WriteLine("1.Generate 100 logs\n2.Show current memory logs\n3.Show all logs from log.txt file\n4.Clear current memory logs\n5.Clear all logs from log.txt file\nEnter corresponding number to continue:");
                int enteredNumber = -1;
                bool validation = int.TryParse(Console.ReadLine(), out enteredNumber);
                if (!validation)
                {
                    Console.WriteLine("You have entered invalid value. Please try again...");
                }
                else
                {
                    switch (enteredNumber)
                    {
                        case 1:
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("---------------------------------------\n 100 new logs have been added. Current memory logs:");
                                Console.ForegroundColor = ConsoleColor.White;
                                Starter.Run();
                                break;
                            }

                        case 2:
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("---------------------------------------\nAll logs from current memory:");
                                Console.ForegroundColor = ConsoleColor.White;
                                PrintMemoryLogs();
                                break;
                            }

                        case 3:
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("---------------------------------------\nAll logs from logs.txt:");
                                PrintFileLogs();
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }

                        case 4:
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("---------------------------------------\nMemory logs have been cleared");
                                Console.ForegroundColor = ConsoleColor.White;
                                ClearMemoryLogs();
                                break;
                            }

                        case 5:
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("---------------------------------------\nFile logs have been cleared");
                                Console.ForegroundColor = ConsoleColor.White;
                                ClearFileLogs();
                                break;
                            }
                    }
                }
            }

            Starter.Run();
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
