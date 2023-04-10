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
        public static Mood CreateMoodAnalyserObject(string className, string constructorName)
        {
            Type type = Type.GetType(className);
            try
            {
                if (type == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
                ConstructorInfo constructor = type.GetConstructor(new[] { Type.GetType(constructorName) });
                if (constructor == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
                }
                object moodAnalyser = constructor.Invoke(new object[] { });
                return (Mood)moodAnalyser;
            }
            catch (TargetInvocationException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.OBJECT_CREATION_ISSUE, "Issue while creating object");
            }
        }
    }
}
