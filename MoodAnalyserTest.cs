using Mood_Analyser_ExceptionHandling;
namespace TestProject1
{
   [TestClass]
    public class MoodAnalyserTest
    {

        [TestMethod]
        public void GivenMoodAnalyserClassName_WhenDefaultConstructorCalled_ShouldReturnObject()
        {
            Mood moodAnalyser = MoodAnalyserFactory.CreateMoodAnalyser();
            Assert.IsInstanceOfType(moodAnalyser, typeof(Mood));
        }

        [TestMethod]
        public void GivenMoodAnalyserClassName_WhenDefaultConstructorCalled_ShouldReturnEqualObjects()
        {
            Mood moodAnalyser1 = MoodAnalyserFactory.CreateMoodAnalyser();
            Mood moodAnalyser2 = MoodAnalyserFactory.CreateMoodAnalyser();
            Assert.AreEqual(moodAnalyser1, moodAnalyser2);
        }
    }
}
