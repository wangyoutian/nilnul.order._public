using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public abstract partial class IntervalA<T>
		:

		nilnul.order.ComparerAsProp<T>
		,

		IntervalI1<T>

	{

		public IntervalA(IComparer<T> order)
			:base(order)
		{

		}





		public abstract bool contains(T item);

		
	}
}
