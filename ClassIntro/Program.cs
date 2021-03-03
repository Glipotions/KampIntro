using System;

namespace ClassIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			Kurs kurs1 = new Kurs();
			kurs1.Egitmen = "Hamza Kavak";
			kurs1.IzlenmeOrani = 94;
			kurs1.KursAdi = "C#";

			Kurs kurs2 = new Kurs();
			kurs2.Egitmen = "Cafer Kavak";
			kurs2.IzlenmeOrani = 84;
			kurs2.KursAdi = "Java";

			Kurs kurs3 = new Kurs();
			kurs3.Egitmen = "Mustafa Kavak";
			kurs3.IzlenmeOrani = 54;
			kurs3.KursAdi = "Python";

			Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

			foreach (var kurs in kurslar)
			{
				Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen);
			}

		}
	}

	class Kurs
	{
		public string KursAdi { get; set; }
		public string Egitmen { get; set; }
		public int IzlenmeOrani { get; set; }
	}


}
