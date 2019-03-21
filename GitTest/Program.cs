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

        private static void MergeFail()
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
		{
			//add New Method
			NewMethod();
			//remove mergeFail() call at start
			ConflictResolve();
			Console.WriteLine("Git Test!");

			ConflictResolve();
		}

		private static void ConflictResolve()
		{
			Console.WriteLine("Program::ConflictResolve() be called");

			Console.WriteLine("Testing"); 
			Console.WriteLine("Program::MergeFail() be called" + "in master branch");
		}
	}
}
