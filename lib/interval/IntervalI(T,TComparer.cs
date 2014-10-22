using nilnul.interval;
using nilnul.order.interval;
using System;
using System.Collections.Generic;
namespace nilnul.order.interval
{
	public partial interface IntervalI<T,TComparer>
		:
IntervalI1<T>
		where TComparer:IComparer<T>,new()
	{
		
	}
}
