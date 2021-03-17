using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int[] myNumbers = { 1, 2, 3 };
				Console.WriteLine(myNumbers[10]);
			}
			catch (Exception e)
			{

				Console.WriteLine("Something went wrong.");
				Console.WriteLine(e.Message);
			}

			finally
			{
				Console.WriteLine("The try catch is finished.");
			}


			//checkAge(15);
			checkAge(32);

			Console.ReadLine();
        }


		static void checkAge(int age)
		{
			if (age < 18)
			{
				throw new ArithmeticException("Access denied-You must be at least 18 years old.");
			}
			else
			{

				Console.WriteLine("Access granted-You are old enough!");
			}
		}
	
    }
}
