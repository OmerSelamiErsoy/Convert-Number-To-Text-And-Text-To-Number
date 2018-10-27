using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProject.Object.TurkishLira
{
	class DigitValue
	{

		internal DigitValue(string _text, int _digitIndex)
		{		   			 
			Text = _text;
			DigitIndex = _digitIndex;
		}
		internal string Text { get; set; }
		internal int DigitIndex { get; set; }		  

	}
}
