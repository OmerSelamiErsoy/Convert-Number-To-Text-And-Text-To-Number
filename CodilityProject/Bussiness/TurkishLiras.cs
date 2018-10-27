using CodilityProject.Object.TurkishLira;
using CodilityProject.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodilityProject.Bussiness
{
	public class TurkishLiras
	{


		public static Int64 ConvertTextToNumber(string _text)
		{
			TurkishLirasTtoNMethods.DefaultValueBind();


			Int64 Result = 0;
			string[] split = _text.Split(' ');
			Int64 calculate = 0;
			foreach (var item in split)
			{
				if (TurkishLirasTtoNMethods.propDAL.DigitValues.Exists(x => x.Text.ToLower() == item.ToLower()))
				{
					calculate = ((calculate == 0) ? 1 : calculate) * TurkishLirasTtoNMethods.propDAL.ReturnIndex(item);

					if (item.ToLower() != "yüz")
					{
						Result += calculate;
						calculate = 0;
					}

				}
				else
				{
					calculate += TurkishLirasTtoNMethods.TextNumberValue(item);
				}
			}

			if (calculate > 0)
			{
				Result += calculate;
			}


			return Result;
		}


		//Daha farklı bi yöntemle yaptık	  
		public static string ConvertNumberToText(decimal Price)
		{
			TurkishLirasNtoTMethods.DefaultValueBind();
			string _price = Price.ToString("F2").Replace('.', ',');
			string _integer = _price.Substring(0, _price.IndexOf(',')); // tutarın tam kısmı	
			int priceIndex = _integer.Length;
			string _Cents = _price.Substring(_price.IndexOf(',') + 1, 2);  // tutarın kuruşlu kısmı			    

			int BlockLenght = 3;
			int Mod3 = BlockLenght - (_integer.Length % BlockLenght);
			if (Mod3 > 0 && Mod3 < BlockLenght)  
				_integer = _integer.ToString().PadLeft(_integer.Length + Mod3, '0');  //sayının soluna '0' eklenerek sayıyı 3 ün katına tamamlıyoruz.  

			int _totalDigitIndex = _integer.Length / BlockLenght;
			StringBuilder ResultValue = new StringBuilder();
			int _digitStateIndex = _totalDigitIndex - 1;
			for (int i = 0; i < _totalDigitIndex; i++)
			{
				string _value = TurkishLirasNtoTMethods.BlockCalculate(_integer.Substring(BlockLenght * i, BlockLenght));
				if (!(priceIndex == 4 && _value.ToLower() == "bir"))
				{
					ResultValue.Append(_value);
					ResultValue.Append(" ");
				}

				if (_digitStateIndex > 0 && !String.IsNullOrEmpty(_value))
				{
					ResultValue.Append(TurkishLirasNtoTMethods.prop_BDL.DigitValues.Where(x => x.DigitIndex == _digitStateIndex).ToList()[0].Text);
					ResultValue.Append(" ");
					_digitStateIndex--;
				}

			}

			ResultValue.Append("TL ");
			if (!String.IsNullOrEmpty(_Cents) && Convert.ToInt32(_Cents) > 0)
			{
				string _dual = TurkishLirasNtoTMethods.BlockCalculate("0" + _Cents);
				if (!String.IsNullOrEmpty(_dual))
					ResultValue.Append(_dual + " Kuruş ");
			}

			return ResultValue.ToString();
		}

	


	}
}
