using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.task3
{
    internal class Contains
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Contain("ana", 'a'));
        //}
        public static bool  Contain(string s, char ch)
        {
            bool flag = false;
            foreach (char c in s)
            {
                if(ch == c)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
            
        }
    }
}
