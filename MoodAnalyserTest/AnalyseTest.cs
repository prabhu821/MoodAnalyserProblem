using MoodAnalyserProblem;

namespace MoodAnalyseTest
{
    public class Tests
    {
        [Test]
        public void AnalyseMood_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string check = moodAnalyser.AnalyseMood();
            Assert.AreEqual(check, "Sad");
        }

        [Test]
        public void AnalyseMood_ShouldReturnHappy()
        {
            string message = "I am in Any Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string check = moodAnalyser.AnalyseMood();
            Assert.AreEqual(check, "Happy");
        }

        [Test]
        public void Given_Null_Mood_Should_Throw_MoodAnalysisException_NullMood()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string check = moodAnalyser.AnalyseMood();
            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }

        [Test]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string check = moodAnalyser.AnalyseMood();
            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
    }
}