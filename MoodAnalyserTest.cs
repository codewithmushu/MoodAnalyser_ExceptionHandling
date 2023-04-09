using Mood_Analyser_ExceptionHandling;
namespace TestProject1
{
    [TestClass]
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void GivenMessage_WhenNull_ShouldThrowMoodAnalysisException()
        {
            try
            {
                Mood moodAnalyser = new Mood(null);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NULL_MOOD, ex.GetType());
            }
        }

        [TestMethod]
        public void GivenMessage_WhenEmpty_ShouldThrowMoodAnalysisException()
        {
            try
            {
                Mood moodAnalyser = new Mood("");
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.EMPTY_MOOD, ex.GetType());
            }
        }
     }
}
