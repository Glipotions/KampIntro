using System;

namespace OOP1
{
	class Program
	{
		static void Main(string[] args)
		{
			Product product1 = new Product();
			product1.Id = 1;
			product1.CategoryId = 2;
			product1.ProductName = "Masa";
			product1.UnitPrice = 252;
			product1.UnitsInStock = 12;


			Product product2 = new Product() { Id = 2, ProductName = "Kırbaç", CategoryId = 4,	UnitPrice=45,UnitsInStock=10 };

			ProductManager productManager = new ProductManager();
			productManager.Add(product1);
			Console.WriteLine(product1.ProductName);


			//int string bool... değer tip
			//diziler, class, abbstract class, interface... referans tip
			/*
			int sayi1= 100;
			productManager.DoSomething(sayi1);
			Console.WriteLine(sayi1);
			*/

			int sayi = productManager.Topla(5, 6); //-> public int olan
			productManager.Topla2(5, 6); // public void olan -> Bundaki sonucu başka işlemlerde kullanamayız.

			Console.WriteLine(sayi+5);
			

		}
	}
}
