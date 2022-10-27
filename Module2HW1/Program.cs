using System;

namespace Module2HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Calling logger interaction menu to begin logging
            Logger logger = Logger.GetInstance();
            logger.LoggerInteractionMenu();
        }
    }
}
