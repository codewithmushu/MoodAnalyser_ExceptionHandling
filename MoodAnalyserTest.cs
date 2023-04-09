using Mood_Analyser_ExceptionHandling;
namespace TestProject1
{
    [TestClass]
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void GivenMessage_WhenNull_ShouldReturnHappy()
        {
            Mood moodAnalyser = new Mood(null);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", mood);
        }
    }
}
