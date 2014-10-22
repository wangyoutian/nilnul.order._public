using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial interface BoundedI<T>
		:
		LowerBoundI<T>
		,
		UpperBoundI<T>
		,
		IntervalI1<T>
	

	{


	}
}
