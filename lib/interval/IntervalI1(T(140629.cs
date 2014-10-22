using nilnul.interval;
using nilnul.order.interval;
using System;
namespace nilnul.order.interval
{
	public partial interface IntervalI1<T>
		:
		nilnul.collection.ContainsI<T>
		,
		ComparerAsPropI<T>
	{
		
	}
}
