using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.task3
{
    internal class LastIndex
    {
        //static void Main(string[] args)
        //{
        //    string s = "hello";
        //    char  ch = 'e';
        //    Console.WriteLine(LastIndexof(s,ch));
            
        //}
    public static int LastIndexof(string s,char ch)
        {
            int  ch1=-1;
            for (int i = s.Length - 1; i >= 0; i--)
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
