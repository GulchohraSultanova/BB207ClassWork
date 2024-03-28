using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.task3
{
    internal class ToCharArray
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(ToCharArry("murad", 0, 3));
        //}

        public static char[] ToCharArry(string s,int a,int b)
        {
            char [] array= new char[0];
            for (int i = a; i <=b; i++) {
                Array.Resize(ref array,array.Length+1);
                array[array.Length-1] = s[i];
            }
            return array;
        }
    }
}
