using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser_ExceptionHandling
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            NO_SUCH_FIELD,
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_CONSTRUCTOR,
            OBJECT_CREATION_ISSUE
        }

        public readonly ExceptionType type;

        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
