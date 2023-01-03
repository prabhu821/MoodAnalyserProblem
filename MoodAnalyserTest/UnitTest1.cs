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
    }
}