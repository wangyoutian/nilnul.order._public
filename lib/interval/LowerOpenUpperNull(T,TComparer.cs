using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class LowerOpenUpperNull<T,TComparer>
		:
		LowerOpenUpperNull<T>
		,
		
		LowerBoundI<T>
		where TComparer:IComparer<T>,new()
	{
		public LowerOpenUpperNull( T lowerBound)
			:base(SingletonByDefault<TComparer>.Instance,lowerBound)
		{

		}
		
	}
}
