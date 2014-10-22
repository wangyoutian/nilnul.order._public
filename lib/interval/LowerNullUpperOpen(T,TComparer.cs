using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class LowerNullUpperOpen<T,TComparer>
		:
		LowerNullUpperOpen<T>
		,
		
		UpperBoundI<T>
		where TComparer:IComparer<T>,new()
	{
		public LowerNullUpperOpen( T upperBound)
			:base(SingletonByDefault<TComparer>.Instance,upperBound)
		{

		}

		
	}
}
