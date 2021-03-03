using System;

namespace Metotlar
{
	class Program
	{
		static void Main(string[] args)
		{
			Urun urun1 = new Urun();
			Urun urun2 = new Urun();

			urun1.Id = 1;
			urun1.Adi = "Elma";
			urun1.aciklama = "Amasya Elması";
			urun1.fiyati = 6;
			urun1.stokAdedi = 7;

			urun2.Id = 2;
			urun2.Adi = "Karpuz";
			urun2.aciklama = "Diyarbakır Karpuzu";
			urun2.fiyati = 75;
			urun2.stokAdedi = 36;

			Urun[] urunler = new Urun[] {urun1,urun2 };
			foreach (Urun urun in urunler)
			{
				Console.WriteLine("Id: "+urun.Id);
				Console.WriteLine(urun.Adi);
				Console.WriteLine(urun.aciklama);
				Console.WriteLine(urun.fiyati);
				Console.WriteLine(urun.stokAdedi);
				Console.WriteLine("-----------------");
			}
			Console.WriteLine("------------Metotlar------------");
			//Encapsulation -> sınıflandırma ürünü sınıflandırarak olası değişimlerde işimizi çok daha kolay hale getirdik
			//mesela class yapılmamış ürünün stok adedini eklemek için tüm sayfalarda değişiklik yapmamız gerekir ancak class yapılmış üründe sadece stok adedini ekleriz ve tüm sayfalarda gözükür.
			SepetManager sepetManager = new SepetManager();
			sepetManager.Ekle(urun1);
			sepetManager.Ekle(urun2);

			sepetManager.Ekle2("Armut","Yeşil Armut",12,24);
			sepetManager.Ekle2("Karpuz", "Sarı Armut",36, 50);

		}
	}
}
