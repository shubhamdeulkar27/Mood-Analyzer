using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace MoodAnalyzer
{
    class MoodAnalyseFactory
    {
        /// <summary>
        /// GetConstructo method to get the instance of class.
        /// </summary>
        public static object CreateMoodAnalyse(ConstructorInfo constructor)
        {
            object moodAnalyse = Activator.CreateInstance(constructor.DeclaringType);
            return moodAnalyse;
        }
    }
}
