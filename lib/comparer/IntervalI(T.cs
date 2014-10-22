using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public interface IntervalI<T>
		:nilnul.collection.ContainsI<T>
		,
		ComparerAsPropI<T>
	{

		order.cut.Cut<T> lower { get; }
		order.cut.Cut<T> upper { get; }
		IComparer<T> comparer { get; }

	}
}
