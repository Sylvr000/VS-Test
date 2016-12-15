using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Hello world");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Exception: {ex}");
			}
			finally
			{
				Console.WriteLine("Enter to exit");
				Console.ReadLine();
			}
		}
	}
}
