using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public partial class Order_FroIComparable<T>
		:
		OrderI<T>
		where T:IComparable<T>
	{
		public bool contains(T first, T second)
		{
			return first.CompareTo(second) <= 0;
		}
	}
}
