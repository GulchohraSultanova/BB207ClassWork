using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.lesson2
{
    public  class Human
    {
        public string Name;
		public string Surname;
		private int _age;

		public int Age
		{
			get { return _age; }

			set {
				if(value>0) { 
					_age = value;
				}
				else
				{
					Console.WriteLine("Yas menfi ola bilmez.");
				}
			}
		}
		public Human(string name,string surname)
		{
			Name = name;
			Surname= surname;
		}
		
			



	}
}
