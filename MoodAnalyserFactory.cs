using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_MoodAnalyser
{
    internal class MoodAnalyserFactory
    {
        String message;
        public static MoodAnalyser ObjCreater()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            return moodAnalyser;
        }
        public MoodAnalyserFactory()
        {
            message = null; 
        }
        public MoodAnalyserFactory(String message)
        {
            this.message = message;
        }
    }
}
