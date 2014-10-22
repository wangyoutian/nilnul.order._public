using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.bounded.be
{
	public partial class NonEmpty<T>
	{
		static public bool Eval(BoundedA<T> interval) {
			return !Empty<T>.Eval(interval);
		}

	}
}
