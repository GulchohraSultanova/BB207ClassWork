using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.task3
{
    internal class PadRight
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Padright("ana", 5, 'a'));
        //}
        public static string Padright(string s, int a, char ch)
        {
            string newStr = "";
            newStr += s;
            for (int i = 0; i < a - s.Length; i++)
            {
                newStr += ch;
            }
            return newStr;
        }
    }
}
