using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// This is a sample reverse
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns></returns>
        public static string ReverseString(string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }

    static class Util
    {
        public static int ToInt32(this string input)
        {
            return Convert.ToInt32(input);
        }

        public static Int64 ToInt64(this string input)
        {
            return Convert.ToInt64(input);
        }
    }
}
