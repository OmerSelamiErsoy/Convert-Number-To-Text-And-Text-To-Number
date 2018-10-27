using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProject.Utility
{
	//Dollars Number to Text Methods
	static class DollarsNtoTMethods
	{
		internal static string MoneyType(int _digitIndex)
		{

			string _text = "";
			switch (_digitIndex)
			{
				case 1:
					{
						_text = "Thousand";
						break;
					}
				case 2:
					{
						_text = "Million";
						break;
					}
				case 3:
					{
						_text = "Billion";
						break;
					}
				case 4:
					{
						_text = "Trillion";
						break;
					}
			}

			return _text;


		}

		internal static string Singular(string _numberText)
		{
			int i = Convert.ToInt32(_numberText);
			string _text = "";
			switch (i)
			{
				case 1:
					{
						_text = "One";
						break;
					}
				case 2:
					{
						_text = "Two";
						break;
					}
				case 3:
					{
						_text = "Three";
						break;
					}
				case 4:
					{
						_text = "Four";
						break;
					}
				case 5:
					{
						_text = "Five";
						break;
					}
				case 6:
					{
						_text = "Six";
						break;
					}
				case 7:
					{
						_text = "Seven";
						break;
					}
				case 8:
					{
						_text = "Eight";
						break;
					}
				case 9:
					{
						_text = "Nine";
						break;
					}
			}

			return _text;


		}

		internal static string Dual(string Number)
		{
			int _Number = Convert.ToInt32(Number);
			string _text = null;
			switch (_Number)
			{
				case 10:
					_text = "Ten";
					break;
				case 11:
					_text = "Eleven";
					break;
				case 12:
					_text = "Twelve";
					break;
				case 13:
					_text = "Thirteen";
					break;
				case 14:
					_text = "Fourteen";
					break;
				case 15:
					_text = "Fifteen";
					break;
				case 16:
					_text = "Sixteen";
					break;
				case 17:
					_text = "Seventeen";
					break;
				case 18:
					_text = "Eighteen";
					break;
				case 19:
					_text = "Nineteen";
					break;
				case 20:
					_text = "Twenty";
					break;
				case 30:
					_text = "Thirty";
					break;
				case 40:
					_text = "Fourty";
					break;
				case 50:
					_text = "Fifty";
					break;
				case 60:
					_text = "Sixty";
					break;
				case 70:
					_text = "Seventy";
					break;
				case 80:
					_text = "Eighty";
					break;
				case 90:
					_text = "Ninety";
					break;
				default:
					if (_Number > 0)
					{
						_text = Dual(Number.Substring(0, 1) + "0") + " " + Singular(Number.Substring(1));
					}
					break;
			}
			return _text;
		}

	}
}
