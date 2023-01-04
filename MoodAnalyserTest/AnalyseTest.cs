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
            catch (MoodAnalyserCustomException e)
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
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }

        //TC 4.1,4.2,4.3
        [Test]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object check = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
            check.Equals(obj);
        }

        [Test]
        public void GivenImproperClassName_ShouldThrowMoodAnalyserCustomException()
        {
            string check = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual(check, e.Message);
            }
        }

        [Test]
        public void GivenImproperConstructor_ShouldThrowMoodAnalyserCustomException()
        {
            string check = "Constructor Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual(check, e.Message);
            }
        }

        
    }
}