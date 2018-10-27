using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodilityProject.Bussiness;

namespace TestPro
{
	/// <summary>
	/// Summary description for TestDollarProject
	/// </summary>
	[TestClass]
	public class TestDollarProject
	{
		[TestMethod]
		public void Dollar_Convert_Number_to_Text()
		{
			string value = Dollars.ConvertNumberToText(Convert.ToDecimal(785487)).ToString();
			string result = "seven hundred eighty five thousand four hundred eighty seven dollars";

			Assert.AreEqual(result.ToLower(), value.ToLower().Trim().Replace("  "," "));

		}


		[TestMethod]
		public void Dollar_Convert_Text_to_Number()
		{
			string value = Dollars.ConvertTextToNumber("seven hundred eighty five thousand four hundred eighty seven").ToString();
			string result = "785487";

			Assert.AreEqual(result, value);

		}

	}
}
