using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public interface IntervalI<T>
		:nilnul.collection.ContainsI<T>
		,
		ComparerAsPropI<T>
	{

		Cut<T> lower { get; }
		Cut<T> upper { get; }
		IComparer<T> comparer { get; }

	}
}
