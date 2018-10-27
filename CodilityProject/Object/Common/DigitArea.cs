using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProject.Object.Common
{
	class DigitArea
	{
		internal DigitArea(string _text, Int64 _digitIndex, int _Priority)
		{
			Text = _text;
			DigitIndex = _digitIndex;
			Priority = _Priority;
		}
		internal string Text { get; set; }
		internal Int64 DigitIndex { get; set; }
		internal int Priority { get; set; }
	}
}
