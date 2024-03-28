using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.task3
{

    internal class IndexOf
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Indexof("ana", 'a'));
        //}
        public static int Indexof(string s, char ch)
        {
            int ch1 = -1;
            for (int i = 0; i<=s.Length; i++)
            {

                if (s[i] == ch)
                {
                    ch1 = i;
                    break;
                }
            }
            return ch1;

        }
    }
}

