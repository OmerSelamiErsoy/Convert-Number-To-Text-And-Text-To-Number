using CodilityProject.Object.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProject.Utility
{
	//Dollars Text to  Number Methods
	static class DollarsTtoNMethods
	{
		private static DigitAreaList DAL;

		internal static DigitAreaList propDAL { get { return DAL;  } }

		internal static void DefaultValueBind()
		{
			if (DAL == null || DAL.DigitValues == null || DAL.DigitValues.Count == 0)
			{
				List<DigitArea> LSD = new List<DigitArea>();
				LSD.Add(new DigitArea("Trillion", 1000000000000, 1));
				LSD.Add(new DigitArea("Billion", 1000000000, 2));
				LSD.Add(new DigitArea("Million", 1000000, 3));
				LSD.Add(new DigitArea("Thousand", 1000, 4));
				LSD.Add(new DigitArea("Hundred", 100, 5));

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
				case "one":
					_Number = 1;
					break;
				case "two":
					_Number = 2;
					break;
				case "three":
					_Number = 3;
					break;
				case "four":
					_Number = 4;
					break;
				case "five":
					_Number = 5;
					break;
				case "six":
					_Number = 6;
					break;
				case "seven":
					_Number = 7;
					break;
				case "eight":
					_Number = 8;
					break;
				case "nine":
					_Number = 9;
					break;
				case "ten":
					_Number = 10;
					break;
				case "eleven":
					_Number = 11;
					break;
				case "twelve":
					_Number = 12;
					break;
				case "thirteen":
					_Number = 13;
					break;
				case "fourteen":
					_Number = 14;
					break;
				case "fifteen":
					_Number = 15;
					break;
				case "sixteen":
					_Number = 16;
					break;
				case "seventeen":
					_Number = 17;
					break;
				case "eighteen":
					_Number = 18;
					break;
				case "nineteen":
					_Number = 19;
					break;
				case "twenty":
					_Number = 20;
					break;
				case "thirty":
					_Number = 30;
					break;
				case "fourty":
					_Number = 40;
					break;
				case "fifty":
					_Number = 50;
					break;
				case "sixty":
					_Number = 60;
					break;
				case "seventy":
					_Number = 70;
					break;
				case "eighty":
					_Number = 80;
					break;
				case "ninety":
					_Number = 90;
					break;


			}
			return _Number;
		}
	}
}
