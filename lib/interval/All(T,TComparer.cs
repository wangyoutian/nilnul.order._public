using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class All<T,TComparer>
		:All<T>
		,
		IntervalI<T,TComparer>
		where TComparer:IComparer<T>,new()
	{
		public All( )
			:base(SingletonByDefault<TComparer>.Instance)
		{

		}
		
	}
}
