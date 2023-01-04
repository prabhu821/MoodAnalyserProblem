using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,NO_SUCH_FIELD,
            NO_SUCH_CLASS, NO_SUCH_METHOD,OBJECT_CREATION_ISSUE
        }
        public ExceptionType exceptionType;
        public MoodAnalyserCustomException(ExceptionType exceptionType,string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
