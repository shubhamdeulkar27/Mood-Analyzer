using System;
using System.Reflection;

namespace MoodAnalyzer
{
    public class MoodAnalyseFactory
    {
        /// <summary>
        /// CreateMoodAnalyse method to create object of MoodAnalyse class.
        /// </summary>
        public static object CreateMoodAnalyse()
        {
            Assembly executing = Assembly.GetExecutingAssembly();
            Type moodAnaylseType = executing.GetType("MoodAnalyse");
            return Activator.CreateInstance(moodAnaylseType);
        }
    }
}
