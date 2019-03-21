using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
	public class Program
	{
		private static void NewMethod()
		{
			//do something
			MergeFail();
			//do something
		}

		static void Main(string[] args)
		{
			//add New Method
			NewMethod();
			//remove mergeFail() call at start
			Console.WriteLine("Git Test!");

			MergeFail();
		}

		private static void MergeFail()
		{
			Console.WriteLine("Program::MergeFail() be called" + "in master branch");
		}
	}
}
