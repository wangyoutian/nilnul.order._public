using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.cut
{
	public partial class UpperBoundClose<T,TComparer>
		:UpperBoundClose<T>
		where TComparer:IComparer<T>,new()
	{
		
		public UpperBoundClose(T benchmark)
			:base(benchmark,SingletonByDefault<TComparer>.Instance)
		{

		}

		
	}
}
