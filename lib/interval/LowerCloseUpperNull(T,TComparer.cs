using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class LowerCloseUpperNull<T,TComparer>
		:
		LowerCloseUpperNull<T>

,		
			LowerBoundUpperNullI<T,TComparer>
		where TComparer:IComparer<T>,new()
	{
		public LowerCloseUpperNull( T lowerBound)
			:base(SingletonByDefault<TComparer>.Instance,lowerBound)
		{

		}
	

		
	}
}
