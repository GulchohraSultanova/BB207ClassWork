using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.task3
{
    internal class PadLeft
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Padleft("ana", 5, 'a'));
        //}
        public static string Padleft(string s,int a,char ch)
        {
            string newStr = "";
            for (int i = 0; i < a-s.Length; i++)
            {
                newStr += ch;
            }
            newStr+=s;
            return newStr;
        }
    }
}
