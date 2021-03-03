using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
	class SepetManager
	{ 
		
		public void Ekle(Urun urun)
		{
			Console.WriteLine("Tebrikler. Sepete Eklediniz! : "+urun.Adi);
		}

		public void Ekle2(string urunAdi,string aciklama,int fiyat,int stok)
		{
			Console.WriteLine("Tebrikler. Sepete Eklediniz! : " + urunAdi);
		}
	}
}
