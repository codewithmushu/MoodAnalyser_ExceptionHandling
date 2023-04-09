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
            NULL_MOOD,
            EMPTY_MOOD
        }

        private readonly ExceptionType type;

        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

        public ExceptionType GetType()
        {
            return type;
        }
    }

}
