using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.cut
{
	public partial class UpperBoundOpen<T,TComparer>
		:UpperBoundOpen<T>
		where TComparer:IComparer<T>,new()
	{
		
		public UpperBoundOpen(T benchmark)
			:base(benchmark,SingletonByDefault<TComparer>.Instance)
		{

		}

		
	}
}
