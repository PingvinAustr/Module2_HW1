using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    internal static class Actions
    {
        // The signature of the methods in the Actions class: the methods do not accept anything and return an object of the Result class.
        internal static Result StartMethod()
        {
            // 1st method writes “Start method:” + the name of this method. The method returns Result where Status = true
            Result startResult = new Result(true, "Start method: StartMethod()", Result.LogTypeEnum.Info, DateTime.Now);
            return startResult;
        }

        internal static Result SkipMethod()
        {
            // 2nd method writes “Skipped logic in method:” + the name of this method. The method returns Result where Status = true
            Result skipResult = new Result(true, "Skipped logic in method: SkipMethod()", Result.LogTypeEnum.Warning, DateTime.Now);
            return skipResult;
        }

        internal static Result BrakeMethod()
        {
            // 3rd method returns Result with error property = “I broke a logic”. Status = false
            Result brakeResult = new Result(false, "I broke a logic", Result.LogTypeEnum.Error, DateTime.Now);
            return brakeResult;
        }
    }
}
