using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public abstract partial class IntervalA<T,TComparer>
		:
		IntervalA<T>
		
		where TComparer:IComparer<T>,new()

	{

		public IntervalA()
			:base(SingletonByDefault<TComparer>.Instance)
			
		{

		}





		

		
	}
}
