using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_MoodAnalyser
{
    internal class MoodAnalyserFactory
    {
        public static MoodAnalyser ObjCreater()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            return moodAnalyser;
        }
    }
}
