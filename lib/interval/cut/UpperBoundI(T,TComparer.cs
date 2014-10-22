using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.cut
{
	public partial interface UpperBoundI<T,TComparer>
		:UpperBoundI<T>
		where TComparer:IComparer<T>,new()
	{
	}
}
