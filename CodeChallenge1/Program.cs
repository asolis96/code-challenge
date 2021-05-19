using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckEnding("abc", "bC"));
            Console.WriteLine(CheckEnding("abc", "d"));
            Console.WriteLine(CheckEnding("samurai", "zi"));
            Console.WriteLine(CheckEnding("feminine", "nine"));
            Console.WriteLine(CheckEnding("convention", "tio"));

            Console.ReadKey();
        }

        public static bool CheckEnding(string s1, string s2)
        {
            return s1.ToLower().EndsWith(s2.ToLower());
            
        }
    }
}
