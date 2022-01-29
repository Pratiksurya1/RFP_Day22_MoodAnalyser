using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_MoodAnalyser
{
    internal class MoodAnalyser
    {
        public String message;
        public MoodAnalyser(String message)
        {
            this.message = message;
        }
        public String AnalyzedMood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                    return "sad";
                else
                    return "happy";
            }
            catch (NullReferenceException)
            {
                return "happy";
            }
            return message;
        }
    }
}
