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

        // Logging method
        internal void SaveNewLogEntry(Result logEntry)
        {
            _logList.Add(logEntry);
        }

        // Method that returns current logs
        internal List<Result> ReturnMemoryLogs()
        {
            return _logList;
        }
    }
}
