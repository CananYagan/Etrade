using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        //Override(2 cons. tek metot)
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get;}

        public string Message  {get;}
    }
}
