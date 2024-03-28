using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.task3
{
    internal class Join
    {
        //static void Main(string[] args)
        //{
        //    string[] a = { "ana", "ata", "baci"};
        //    Console.WriteLine(join(a, 'b'));
        //}
        public static string join(string[] str,char ch)
        {
            string s = "";
           for (int   i = 0; i < str.Length-1; i++)
            {
                s += str[i] + ch;
               
            }
            s += str[str.Length - 1];
            return s;
        }
    }
}
