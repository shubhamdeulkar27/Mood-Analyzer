using System;

namespace MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Message");
            string message = Console.ReadLine();
            MoodAnalyse moodAnalyse = new MoodAnalyse();
            string mood = moodAnalyse.AnalyseMood(message);
            Console.WriteLine(mood);
        }
    }
}
