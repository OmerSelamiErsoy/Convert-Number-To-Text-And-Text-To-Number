using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProject.Object.TurkishLira
{
	class NumberValueList
	{
		internal List<NumberValue> NumberValues { get; set; }

		internal string ReturnValue(int _number, int _digitIndex)
		{
			if (NumberValues.Exists(x => x.Number == _number && x.DigitIndex == _digitIndex))
				return NumberValues.Where(x => x.Number == _number && x.DigitIndex == _digitIndex).ToList()[0].Text.ToString();
			else
				return "";
		}

	}

}
