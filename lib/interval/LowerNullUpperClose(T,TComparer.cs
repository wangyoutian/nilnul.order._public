using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class LowerNullUpperClose<T,TComparer>
		:
		LowerNullUpperClose<T>
		,
		
		UpperBoundI<T>
		where TComparer:IComparer<T>,new()
	{
		public LowerNullUpperClose( T upperBound)
			:base(SingletonByDefault<TComparer>.Instance,upperBound)
		{

		}

		
	}
}
