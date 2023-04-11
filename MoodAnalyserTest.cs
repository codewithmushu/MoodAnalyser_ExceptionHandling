using Mood_Analyser_ExceptionHandling;
namespace TestProject1
{
   [TestMethod]
        public void GivenClassName_WhenImproper_ShouldThrowMoodAnalysisException()
        {
            try
            {
                MoodAnalyserFactory.CreateMoodAnalyser("WrongClassName");
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, e.type);
            }
        }
}
