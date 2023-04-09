using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser_ExceptionHandling
{
    public class MoodAnalysisException : Exception
    {
        public MoodAnalysisException(string message) : base(message)
        {
        }
    }

}
