using System;
using System.Collections.Generic;

namespace GenericsIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<string> myList = new MyList<string>();
			myList.Add ("Hamza");
			myList.Add("Cafer");
			myList.Listele();

		}
	}
}
