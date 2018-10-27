using CodilityProject.Object.Common;
using CodilityProject.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityProject.Bussiness
{
	public class Dollars
	{


		public static Int64 ConvertTextToNumber(string _text)
		{
			DollarsTtoNMethods.DefaultValueBind();
							    

			Int64 Result = 0;
			string[] split = _text.Split(' ');
			Int64 calculate = 0;
			foreach (var item in split)
			{
				if (DollarsTtoNMethods.propDAL.DigitValues.Exists(x => x.Text.ToLower() == item.ToLower()))
				{
					calculate = ((calculate == 0) ? 1 : calculate) * DollarsTtoNMethods.propDAL.ReturnIndex(item);
					
					if (item.ToLower()  != "hundred")
					{
						Result += calculate;
						calculate = 0;
					}
					
				}
				else
				{
					calculate += DollarsTtoNMethods.TextNumberValue(item);
				}
			}

			if (calculate > 0)
			{
				Result += calculate;
			}


			return Result;
		}



		public static string ConvertNumberToText(decimal Price)
		{
			 
			string _price = Price.ToString("F2").Replace('.', ',');
			string _integer = _price.Substring(0, _price.IndexOf(',')); // tutarın tam kısmı
			string _Cents = _price.Substring(_price.IndexOf(',') + 1, 2);  // tutarın kuruşlu kısmı			    

			int BlockLenght = 3;
			int Mod3 = BlockLenght - (_integer.Length % BlockLenght);
			if (Mod3 > 0 && Mod3 < BlockLenght)  
				_integer = _integer.ToString().PadLeft(_integer.Length + Mod3, '0');   //sayının soluna '0' eklenerek sayıyı 3 ün katına tamamlıyoruz.  

			int _totalDigitIndex = _integer.Length / BlockLenght;
			StringBuilder ResultValue = new StringBuilder();
			int _digitStateIndex = _totalDigitIndex - 1;	   
			for (int i = 0; i < _totalDigitIndex; i++)
			{
				string _value = _integer.Substring(BlockLenght * i, BlockLenght);
				string _singular = DollarsNtoTMethods.Singular(_value.Substring(0,1));
				if (!String.IsNullOrEmpty(_singular))
					ResultValue.Append(_singular + " Hundred ");
									   
				string _dual = DollarsNtoTMethods.Dual(_value.Substring(1));
				if (!String.IsNullOrEmpty(_dual))
					ResultValue.Append(_dual + " ");



				if (_digitStateIndex > 0)
				{
					ResultValue.Append(DollarsNtoTMethods.MoneyType(_digitStateIndex));
					ResultValue.Append(" ");
					_digitStateIndex--;
				}
			}

			ResultValue.Append(" dollars ");
			if (!String.IsNullOrEmpty(_Cents) && Convert.ToInt32(_Cents) > 0 )
			{
				string _dual = DollarsNtoTMethods.Dual(_Cents);
				if (!String.IsNullOrEmpty(_dual))
					ResultValue.Append(_dual + " cents ");
			}

			return ResultValue.ToString();
		}


			   
	 
	}
}
