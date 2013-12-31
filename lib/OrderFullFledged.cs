using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class OrderFullFledged<T>
	{
		OrderI<T> order;

		public OrderFullFledged(OrderI<T> order)
		{
			this.order = order;

		}

		public bool contains(T left,T right) {
			return order.contains(left, right);
		}
		public bool notContains(T left, T right) {
			return !contains(left, right);
		}

		public bool isLinear(IEnumerable<T> list) {
			nilnul.obj.Null.AssertNotNull(list);

			for (int i = 0; i < list.Count()-1; i++)
			{
				if ( notContains( list.ElementAt(i),list.ElementAt(i+1)))
				{
					return false;
					
				}
				
			}
			return true;
		
		}

		public void assertLinear(IEnumerable<T> list) {

			nilnul.bit.Assert.True(isLinear(list));
		
		}


					

	}
}
