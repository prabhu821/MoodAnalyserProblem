using MoodAnalyserProblem;

namespace MoodAnalyseTest
{
    public class Tests
    {
        [Test]
        public void AnalyseMood_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string check = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual(check, "Sad");
        }
    }
}