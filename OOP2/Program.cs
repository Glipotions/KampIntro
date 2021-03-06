using System;

namespace OOP2
{
	class Program
	{
		static void Main(string[] args)
		{
			CorpateCustomer customer1 = new CorpateCustomer();
			customer1.Id = 1;
			customer1.CustomerNo = "21312412";
			customer1.CompanyName = "Glipotions.to";
			customer1.TaxNo = "1231241231";


			IndividualCustomer customer2 = new IndividualCustomer();
			customer2.Id = 2;
			customer2.CustomerNo = "24231234";
			customer2.Name = "Hamza";
			customer2.LastName = "Kavak";
			customer2.TcNo = "100000000001";

			Customer customer3 = new IndividualCustomer();
			Customer customer4 = new CorpateCustomer();





		}
	}
}
