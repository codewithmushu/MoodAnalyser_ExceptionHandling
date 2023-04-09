using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser_ExceptionHandling
{
    public class Mood
    {
        private string message;

        public Mood()
        {
            message = "I am in Happy Mood";
        }

        public Mood(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (message == null || message == "")
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MOOD, "Mood should not be null");
                }

                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (MoodAnalysisException ex)
            {
                return ex.Message;
            }
        }
    }  
}


