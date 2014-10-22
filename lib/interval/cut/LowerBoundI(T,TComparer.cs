using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.cut
{
	public partial interface LowerBoundI<T,TComparer>
		:LowerBoundI<T>
		where TComparer:IComparer<T>,new()
	{
	}
}
