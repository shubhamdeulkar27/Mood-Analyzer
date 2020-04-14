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
        public static ConstructorInfo GetConstructor()
        {
            Type type = typeof(MoodAnalyse);
            Type[] types = new Type[1];
            types[0] = typeof(string);
            ConstructorInfo constructorInfo = type.GetConstructor(types);
            return constructorInfo;
        }

        /// <summary>
        /// Function to Create Instance From Parameteries Constructor.
        /// </summary>
        /// <param name="constructorInfo"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyse(ConstructorInfo constructorInfo, string[] message)
        {
            object newObject = constructorInfo.Invoke(message);
            return newObject;
        }
    }
}
