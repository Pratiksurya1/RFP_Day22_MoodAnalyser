﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_MoodAnalyser
{
    internal class MoodAnalyser
    {
        public String message;
        public MoodAnalyser()
        {
            message = null;
        }
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

                if (new MoodAnalyserFactory(message).Equals(message.ToLower()))
                    return "equals";
                else
                {
                    return "not equals";
                }
            }
            catch (MoodAnalysisException)
            {
                throw  new MoodAnalysisException(MoodAnalysisException.AnalysisErrors.NoSuchClassException, "No Such Class Exception");
            }
            return message;
        }
    }
}
