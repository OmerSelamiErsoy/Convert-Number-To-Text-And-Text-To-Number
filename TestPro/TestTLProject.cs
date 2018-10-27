using System;
using CodilityProject.Bussiness;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPro
{
	[TestClass]
	public class TestTLProject
	{
		[TestMethod]
		public void TL_Convert_Number_to_Text()
		{
			string value = TurkishLiras.ConvertNumberToText(Convert.ToDecimal(785487)).ToString();
			string result = "yedi yüz seksen beş bin dört yüz seksen yedi tl";

			Assert.AreEqual(result.ToLower(), value.ToLower().Trim().Replace("  ", " "));

		}


		[TestMethod]
		public void TL_Convert_Text_to_Number()
		{
			string value = TurkishLiras.ConvertTextToNumber("yedi yüz seksen beş bin dört yüz seksen yedi").ToString();
			string result = "785487";

			Assert.AreEqual(result, value);

		}
	}
}
