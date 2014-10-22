using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// if T is infinite, i.e., with no maximal, this will be the artificial object to stand for the maximum. Note: this maximu is for the > relation only. No eq is defined on this (it's incomparable to itself.).
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Infinity
		//where T:InfiniteI
	{
		public const char _SIGN = '∞';

		public const string HTML_ENTITY = "infin";
		public const uint UNICODE = 0x221E;


	}
}
