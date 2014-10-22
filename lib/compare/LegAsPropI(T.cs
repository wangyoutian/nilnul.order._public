using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.compare
{
	public partial interface LegAsPropI<T>
	{
		LegI<T> comparer { get; }
	}
}
