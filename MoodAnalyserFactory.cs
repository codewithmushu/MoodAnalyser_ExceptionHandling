using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser_ExceptionHandling
{
    public class MoodAnalyserFactory
    {
        public static Mood CreateMoodAnalyser(string className)
        {
            Type type = null;
            try
            {
                type = Type.GetType(className);
                if (type == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
                ConstructorInfo constructor = type.GetConstructor(new Type[] { });
                Mood moodAnalyser = (Mood)constructor.Invoke(new object[] { });
                return moodAnalyser;
            }
            catch (ArgumentNullException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Message should not be null");
            }
            catch (TargetInvocationException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor not found");
            }
        }

    }
       
}
