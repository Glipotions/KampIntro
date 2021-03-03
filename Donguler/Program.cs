using System;

namespace Donguler
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] kurslar=new string[] { "Python", "c#", "Java" };
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(kurslar[i]);
			}

			Console.WriteLine("For Sonu");

			foreach (string kurs in kurslar)
			{
				Console.WriteLine(kurs);
			}
		}
	}
}
