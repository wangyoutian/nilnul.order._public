using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total.bound
{

	public partial class Order_FroComparer<T>
		:
		nilnul.order.total.Order_FroComparer<T>
	//	,OrderI<T>

		
	{

		public Order_FroComparer(total.bound.ComparerI<T> comparer)
			:base(comparer)
		{
		}
					
		
	}
}
