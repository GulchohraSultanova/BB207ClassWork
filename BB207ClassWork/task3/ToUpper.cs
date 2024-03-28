using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.task3
{
    internal class ToUpper
    {

        //static void Main(string[] args)
        //{
        //    string s = "hello";
        //    Console.WriteLine(ToUpperOfString(s));
        //}
        public static string ToUpperOfString(string s)
        {
            string newStr = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]>=97 && s[i] <= 122)
                {
                    newStr += (char)(s[i]-32);
                }
                else
                {
                    newStr += (char)s[i];
                }
            }
            return newStr;
        }
    }
}
