using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{
	public partial class Literal<T>
		: nilnul.Box<T>
		,
		
		nilnul.order.ExtendedI<T>
		,LiteralI
	{
		public Literal(T val)
			:base(val)
		{

		}
	}
}
