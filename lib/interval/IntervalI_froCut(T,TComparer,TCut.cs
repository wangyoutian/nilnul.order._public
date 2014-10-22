using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public interface IntervalI_froCut<T,TComparer,TCut>
		:
		
		nilnul.collection.ContainsI<T>
		,
		ComparerAsPropI<T>
		where TComparer:IComparer<T>
		where TCut : order.cut.Cut<T>
	{

		TCut lower { get; }
		TCut upper { get; }
		TComparer comparer { get; }

	}
}
