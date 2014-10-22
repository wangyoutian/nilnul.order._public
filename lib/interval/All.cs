using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class All<T>
		:IntervalA<T>
	{
		public All(IComparer<T> order )
			:base(order)
		{

		}
		public override bool contains(T item)
		{
			return true;
			throw new NotImplementedException();
		}
	}
}
