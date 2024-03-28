using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.task3
{
    internal class EndsWith
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Endswith("anaaaana", 'a'));
        //}
        public static bool Endswith(string s, char c)
        {
            bool flag= false;
            for (int i = s.Length-1; i >=0; i--)
            {
                if (s[i]==c)
                    flag = true;
            }
            return flag;
        }
    }
}
