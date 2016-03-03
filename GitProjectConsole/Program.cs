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

        public static string ReverseString(string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }
}
