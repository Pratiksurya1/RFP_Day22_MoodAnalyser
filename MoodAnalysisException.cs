using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_MoodAnalyser
{
    internal class MoodAnalysisException:Exception
    {
        public enum AnalysisErrors
        {
            NullMoodExeption,
            NoSuchClassException,
           
        }

        AnalysisErrors type;
        public MoodAnalysisException(AnalysisErrors type,String message) : base(message)
        {
            this.type = type;   
        }

    }
}
