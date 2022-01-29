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
            String message;
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            Console.WriteLine("how is your mood today !");
            message=Console.ReadLine();
            string actual = moodAnalyser.AnalyzedMood(message); 
            Console.WriteLine(actual);



        }
    }
}