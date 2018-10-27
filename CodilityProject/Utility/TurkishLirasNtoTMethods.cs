using CodilityProject.Object.TurkishLira;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProject.Utility
{
	//Turkish Liras Number to Text Methods
	static class TurkishLirasNtoTMethods
	{
		static NumberValueList SDL;
		static DigitValueList BDL;

		internal static DigitValueList prop_BDL { get { return BDL; } }

		internal static string BlockCalculate(string _PriceBlock) // 3lü bloklar halinde hesaplıyoruz 
		{

			StringBuilder sb = new StringBuilder();


			int _firstIndex = Convert.ToInt32(_PriceBlock.Substring(0, 1));
			int _secondIndex = Convert.ToInt32(_PriceBlock.Substring(1, 1));
			int _ThirdIndex = Convert.ToInt32(_PriceBlock.Substring(2, 1));
			string returnVal = SDL.ReturnValue(_firstIndex, 3);
			if (!String.IsNullOrEmpty(returnVal))
				sb.Append(returnVal + " ");
			returnVal = SDL.ReturnValue(_secondIndex, 2);
			if (!String.IsNullOrEmpty(returnVal))
				sb.Append(returnVal + " ");
			returnVal = SDL.ReturnValue(_ThirdIndex, 1);
			if (!String.IsNullOrEmpty(returnVal))
				sb.Append(returnVal);
			return sb.ToString();
		}






		internal static void DefaultValueBind()
		{
			if (SDL == null || SDL.NumberValues == null || SDL.NumberValues.Count == 0)
			{
				List<NumberValue> LSD = new List<NumberValue>();
				for (int i = 1; i < 10; i++)
				{

					string valueFirstIndex = "";
					string valueSecondIndex = "";
					string valueThirdIndex = "";
					switch (i)
					{
						case 1:
							{
								valueFirstIndex = "Bir";
								valueSecondIndex = "On";
								valueThirdIndex = "Yüz";
								break;
							}
						case 2:
							{
								valueFirstIndex = "İki";
								valueSecondIndex = "Yirmi";
								valueThirdIndex = "İki Yüz";
								break;
							}
						case 3:
							{
								valueFirstIndex = "Üç";
								valueSecondIndex = "Otuz";
								valueThirdIndex = "Üç Yüz";
								break;
							}
						case 4:
							{
								valueFirstIndex = "Dört";
								valueSecondIndex = "Kırk";
								valueThirdIndex = "Dört Yüz";
								break;
							}
						case 5:
							{
								valueFirstIndex = "Beş";
								valueSecondIndex = "Elli";
								valueThirdIndex = "Beş Yüz";
								break;
							}
						case 6:
							{
								valueFirstIndex = "Altı";
								valueSecondIndex = "Altmış";
								valueThirdIndex = "Altı Yüz";
								break;
							}
						case 7:
							{
								valueFirstIndex = "Yedi";
								valueSecondIndex = "Yetmiş";
								valueThirdIndex = "Yedi Yüz";
								break;
							}
						case 8:
							{
								valueFirstIndex = "Sekiz";
								valueSecondIndex = "Seksen";
								valueThirdIndex = "Sekiz Yüz";
								break;
							}
						case 9:
							{
								valueFirstIndex = "Dokuz";
								valueSecondIndex = "Doksan";
								valueThirdIndex = "Dokuz Yüz";
								break;
							}
					}



					LSD.Add(new NumberValue(i, valueFirstIndex, 1));
					LSD.Add(new NumberValue(i, valueSecondIndex, 2));
					LSD.Add(new NumberValue(i, valueThirdIndex, 3));
				}

				if (SDL == null)
				{ SDL = new NumberValueList(); }
				SDL.NumberValues = LSD;


				List<DigitValue> LBD = new List<DigitValue>();
				LBD.Add(new DigitValue("Bin", 1));
				LBD.Add(new DigitValue("Milyon", 2));
				LBD.Add(new DigitValue("Milyar", 3));
				LBD.Add(new DigitValue("Trilyon", 4));
				LBD.Add(new DigitValue("Katrilyon", 5));

				if (BDL == null)
				{ BDL = new DigitValueList(); }
				BDL.DigitValues = LBD;

			}

		}
	}
}
