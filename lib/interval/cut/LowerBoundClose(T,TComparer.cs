using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.cut
{
	public partial class LowerBoundClose<T,TComparer>
		:LowerBoundClose<T>
		where TComparer:IComparer<T>,new()
	{
		
		public LowerBoundClose(T benchmark)
			:base(benchmark,SingletonByDefault<TComparer>.Instance)
		{

		}

		
	}
}
