using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace MoodAnalyzer
{
    public class MoodAnalyseFactory
    {
        /// <summary>
        /// Function to get Parameteres Constructor.
        /// </summary>
        /// <returns></returns>
        public static ConstructorInfo GetConstructor(string className)
        {
            try
            {
                Type type = typeof(MoodAnalyse);
                Type[] types = new Type[1];
                types[0] = typeof(string);
                ConstructorInfo constructorInfo = type.GetConstructor(types);
                return constructorInfo;
            }
            catch(MoodAnalysisException exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "No Such Class Found");
            }
        }

        /// <summary>
        /// Function to Create Instance From Parameteries Constructor.
        /// </summary>
        /// <param name="constructorInfo"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyse(ConstructorInfo constructorInfo, string[] message)
        {
            if(constructorInfo.Equals(MoodAnalyseFactory.GetConstructor("MoodAnalyse")))
            {
                object newObject = constructorInfo.Invoke(message);
                return newObject;
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD,"No Such Method Found");
            }
        }
    }
}
