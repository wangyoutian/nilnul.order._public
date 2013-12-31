using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total.unbound
{
	public class StrictFroTotal<T>
			:
			StrictOrderI<T>
		{

			private OrderI<T> _order;

			public OrderI<T> order
			{
				get { return _order; }
				set { _order = value; }
			}

			public StrictFroTotal(OrderI<T> order)
			{
				this.order = order;
			}



			public  bool contains(T first, T second)
			{
				return _order.contains(first,second) && EqualityFromTotalOrder<T>.Create(order).contains(first,second);
			}


			static public StrictFroTotal<T> Create(
				OrderI<T> order
				) {
					return new StrictFroTotal<T>(order);
			}

		
		}
}
