using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace MoodAnalyzer
{
    public class MoodAnalyseFactory
    {
        /// <summary>
        /// Function to Create Instance and Return of MoodAnalyse Class.
        /// </summary>
        /// <returns></returns>
        public static object CreateMoodAnalyse(string className)
        {
            if (className.Equals("MoodAnalyse"))
            {
                Assembly executing = Assembly.GetExecutingAssembly();
                Type moodAnaylseType = executing.GetType(className);
                return Activator.CreateInstance(moodAnaylseType);
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS,"Class Not Found");
            }
        }
    }
}
