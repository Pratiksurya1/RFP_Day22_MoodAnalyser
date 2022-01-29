using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_MoodAnalyser
{
    internal class MoodAnalyser
    {
        public String AnalyzedMood(String message)
        { 
            if (message.ToLower().Contains("happy"))
                return "happy";
            else if (message.ToLower().Contains("sad"))
                return "sad";
            else
                return "give valid message";
        }
    }
}
