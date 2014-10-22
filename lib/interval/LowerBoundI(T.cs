using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial interface LowerBoundI<T>
		:LowerBoundI
	{
		T lowerBound
		{
			get;
		}
	}
}
