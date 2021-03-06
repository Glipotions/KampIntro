using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
	class Program
	{
		static void Main(string[] args)
		{	/*
			string[] isimler = new string[] { "Hamza", "Ahmet", "Mehmet", "Caner" };
			Console.WriteLine(isimler[0]);
			Console.WriteLine(isimler[1]);
			Console.WriteLine(isimler[2]);
			Console.WriteLine(isimler[3]);
			
			//Console.WriteLine(isimler[4]); //--> Bunu yazarsan hata alırsın çünkü ilk başta isimler arrayini 4 elemanlı olarak tanımladın.
			isimler = new string[5];
			isimler[4] = "Ali";
			Console.WriteLine(isimler[4]);
			Console.WriteLine(isimler[0]); // -> Boş Yazıcak bunu çünkü yeni oluşturduktan sonra sıfırlandı.

			// Array dizilerini genişletemediğimiz için List gibi Koleksiyonlar kullanılır. 

			*/


			List<string> isimler2 = new List<string> { "Hamza", "Ahmet", "Mehmet", "Caner" };
			Console.WriteLine(isimler2[0]);
			Console.WriteLine(isimler2[1]);
			Console.WriteLine(isimler2[2]);
			Console.WriteLine(isimler2[3]);

			isimler2.Add("Ali");
			Console.WriteLine(isimler2[4]);
			Console.WriteLine(isimler2[0]);



		}
	}
}
