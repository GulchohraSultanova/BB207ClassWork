using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.task3
{
    internal class Remove
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(remove("anaaaaaaaa",0,4));
        //}
        public static string remove(string s,int startIndex,int count)
        {
            string newStr = "";
           
            for (int i = startIndex; i < count; i++)
            {
                newStr += s[i];
                
            }
            return newStr;
        }
    }
}
