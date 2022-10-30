using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    internal static class Starter
    {
        internal static void Run()
        {
            Console.WriteLine("[Log DateTime] [Log type] [Log message]");
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                int randomNum = random.Next(1, 4);

                Result answerFromAction = new Result();
                switch (randomNum)
                {
                    case 1:
                        {
                            // Action 1
                            answerFromAction = Actions.StartMethod();
                            break;
                        }

                    case 2:
                        {
                            // Action 2
                            answerFromAction = Actions.SkipMethod();
                            break;
                        }

                    case 3:
                        {
                            // Action 3
                            answerFromAction = Actions.BrakeMethod();
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

                if (answerFromAction.Status == false)
                {
                    answerFromAction.ErrorMessage = "Action failed by a reason:" + answerFromAction.ErrorMessage;
                    Logger.GetInstance().SaveNewLogEntry(answerFromAction);
                }
                else
                {
                    Logger.GetInstance().SaveNewLogEntry(answerFromAction);
                }
            }

            // Print logs from memory and to file
            LogWriter.PrintMemoryLogs(Logger.GetInstance().ReturnMemoryLogs());
            LogWriter.PrintLogsToFile(Logger.GetInstance().ReturnMemoryLogs());
            Console.WriteLine("\nNew logs have been added to log.txt file which is located in project directory");
        }
    }
}
