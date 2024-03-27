using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.lesson2
{
     public class User:Human
    {
		private string  _username;

		public string  Username
		{
			get { return _username; }
			set { 
				if(value.Length>5 && value.Length < 26)
				{
					_username = value;
				}
				else
				{
					Console.WriteLine("Username duzgun deyil!");
				}
			}
		}
		
		private string _passWord;

		public string PassWord
		{
			get { return _passWord; }

			set { 
				if(value.Length>7 && value.Length < 26) { _passWord = value;}
				else
				{
					Console.WriteLine("Password duzgun deyil!");
				}
			}
		}
		public User(string name,string surname,string username,string password) : base(name,surname){
			Username= username;
			PassWord= password;

		}
		
		


	}
}
