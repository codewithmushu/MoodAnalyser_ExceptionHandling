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
        public static Mood CreateMoodAnalyser()
        {
            Type type = typeof(Mood);
            ConstructorInfo constructor = type.GetConstructor(new Type[] { });
            Mood moodAnalyser = (Mood)constructor.Invoke(new object[] { });
            return moodAnalyser;
        }

    }
       
}
