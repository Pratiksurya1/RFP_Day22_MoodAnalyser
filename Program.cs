using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_MoodAnalyser
{
    internal class Program
    {
        
        public static void Main(String[] args)
        {
            String message = null ;
            String actual;
            try
            {
                Console.WriteLine("how is your mood today !");
                message = Console.ReadLine();
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                actual = moodAnalyser.AnalyzedMood();
                Console.WriteLine(actual);

                if (new MoodAnalyserFactory().Equals(moodAnalyser))
                    Console.WriteLine("Test passes if they are equal");
                else

                    throw new MoodAnalysisException(MoodAnalysisException.AnalysisErrors.NoSuchClassException, "Found No Such Class Exception");
            }
            catch(Exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.AnalysisErrors.NullMoodExeption, "Found Empty Mood Exception");
            }



        }
    }
}