using CodilityProject.Object.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProject.Utility
{
	//Turkish Liras  Text to Number Methods
	class TurkishLirasTtoNMethods
	{
		private static DigitAreaList DAL;

		internal static DigitAreaList propDAL { get { return DAL; } }

		internal static void DefaultValueBind()
		{
			if (DAL == null || DAL.DigitValues == null || DAL.DigitValues.Count == 0)
			{
				List<DigitArea> LSD = new List<DigitArea>();
				LSD.Add(new DigitArea("Trilyon", 1000000000000, 1));
				LSD.Add(new DigitArea("Milyar", 1000000000, 2));
				LSD.Add(new DigitArea("Milyon", 1000000, 3));
				LSD.Add(new DigitArea("Bin", 1000, 4));
				LSD.Add(new DigitArea("Yüz", 100, 5));

				if (DAL == null)
				{ DAL = new DigitAreaList(); }
				DAL.DigitValues = LSD;

			}

		}

		internal static int TextNumberValue(string text)
		{
			int _Number = 0;
			switch (text.ToLower())
			{
				case "bir":
					_Number = 1;
					break;
				case "iki":
					_Number = 2;
					break;
				case "üç":
					_Number = 3;
					break;
				case "dört":
					_Number = 4;
					break;
				case "beş":
					_Number = 5;
					break;
				case "altı":
					_Number = 6;
					break;
				case "yedi":
					_Number = 7;
					break;
				case "sekiz":
					_Number = 8;
					break;
				case "dokuz":
					_Number = 9;
					break;
				case "on":
					_Number = 10;
					break;		   
				case "yirmi":
					_Number = 20;
					break;
				case "otuz":
					_Number = 30;
					break;
				case "kırk":
					_Number = 40;
					break;
				case "elli":
					_Number = 50;
					break;
				case "altmış":
					_Number = 60;
					break;
				case "atmış":
					_Number = 60;
					break;
				case "yetmiş":
					_Number = 70;
					break;
				case "seksen":
					_Number = 80;
					break;
				case "doksan":
					_Number = 90;
					break;


			}
			return _Number;
		}
	}
}
