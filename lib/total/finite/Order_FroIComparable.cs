using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total.finite
{
	public abstract partial class Order_FroIComparableA<T>
		:
		OrderI<T>
		where T:IComparable<T>
	{
		public bool contains(T first, T second)
		{
			return first.CompareTo(second) <= 0;
		}

		public abstract T maximum
		{
			get;
		}

		public abstract T minimum
		{
			get;
		}
	}
}
