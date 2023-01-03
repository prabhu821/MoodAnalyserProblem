namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (message.ToLower().Contains("sad"))
                return "Sad";
            return "Happy";
        }
    }
}