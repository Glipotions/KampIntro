using System;
using System.Collections.Generic;

namespace OOP3
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Kodlar Kötüden iyiye doğru gidiyor. Her numara bir çözüm yöntemini temsil eder ve her yöntem bir öncekinden iyidir.
			 * 
			 * 
			 */

			// 1.Yol
			/*
			TasıtKrediManager tasitKrediManager = new TasıtKrediManager();
			tasitKrediManager.Hesapla();

			KonutKrediManager konutKrediManager = new KonutKrediManager();
			konutKrediManager.Hesapla();

			IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
			ihtiyacKrediManager.Hesapla();
			*/


			//2.Yol
			/*
			IKrediManager tasitKrediManager = new TasıtKrediManager();
			tasitKrediManager.Hesapla();

			IKrediManager konutKrediManager = new KonutKrediManager();
			konutKrediManager.Hesapla();

			IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
			ihtiyacKrediManager.Hesapla();
			*/


			//3. Yol
			/*
			IKrediManager tasitKrediManager = new TasıtKrediManager();
			IKrediManager konutKrediManager = new KonutKrediManager();
			IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();


			BasvuruManager basvuruManager = new BasvuruManager();
			basvuruManager.BasvuruYap(konutKrediManager);
			basvuruManager.BasvuruYap(tasitKrediManager);
			basvuruManager.BasvuruYap(ihtiyacKrediManager);
			*/

			//4.Yol
			IKrediManager tasitKrediManager = new TasıtKrediManager();
			IKrediManager konutKrediManager = new KonutKrediManager();
			IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

			ILoggerService databaseLogger = new DatabaseLoggerService();
			ILoggerService fileLogger = new FileLoggerService();

			BasvuruManager basvuruManager = new BasvuruManager();
			basvuruManager.BasvuruYap(konutKrediManager, fileLogger);


			//List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, konutKrediManager };
			//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

		}
	}
}
