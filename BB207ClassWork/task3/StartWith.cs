using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.task3
{
    internal class StartWith
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(StartsWith("anaaaana", 'a'));
        //}
        public static bool StartsWith(string s, char c)
        {
            bool flag = false;
            for (int i =0;i<s.Length;i++)
            {
                if (s[i] == c)
                    flag = true;
            }
            return flag;
        }
    }
}
