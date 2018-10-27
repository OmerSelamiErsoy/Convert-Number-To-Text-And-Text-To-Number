using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProject.Object.TurkishLira
{
	class NumberValue
	{
		internal NumberValue(int _number, string _text, int _digitIndex)
		{
			Number = _number;
			Text = _text;
			DigitIndex = _digitIndex;
		}
		internal int Number { get; set; }
		internal string Text { get; set; }
		internal int DigitIndex { get; set; }



	}
}
