using CodilityProject.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProject.Object.Common
{
	class DigitAreaList
	{
		internal List<DigitArea> DigitValues { get; set; }

		internal Int64 ReturnIndex(string _text)
		{
			if (DigitValues.Exists(x => x.Text.ToLower().ToReplaceTurkishCharacter() == _text.ToLower().ToReplaceTurkishCharacter()))
				return DigitValues.Where(x => x.Text.ToLower().ToReplaceTurkishCharacter() == _text.ToLower().ToReplaceTurkishCharacter()).ToList()[0].DigitIndex;
			else
				return 0;
		}

	 
	}
}
