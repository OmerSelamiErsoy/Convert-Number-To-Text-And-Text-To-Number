using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProject.Object.TurkishLira
{
	class DigitValueList
	{
		internal List<DigitValue> DigitValues { get; set; }

		internal string ReturnValue(int _digitIndex)
		{
			if (DigitValues.Exists(x => x.DigitIndex == _digitIndex))
				return DigitValues.Where(x => x.DigitIndex == _digitIndex).ToList()[0].Text.ToString();
			else
				return "";
		}

	}
}
