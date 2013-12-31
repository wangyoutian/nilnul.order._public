using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.order
{
	public partial class TotalOrderX
		
	{
		static public bool IsOrdered<T>(IEnumerable<T> list, TotalOrderI2<T> order) {

			nilnul.obj.Null.AssertNotNull(list);
			nilnul.obj.Null.AssertNotNull(order);
			if (list.Count()<2)
			{
				return true;
				
			}

			var orderFledged = new order.OrderFullFledged<T>(order);
			for (int i = 0; i < list.Count()-1; i++)
			{
				if ( orderFledged.notContains(  list.ElementAt(i) ,list.ElementAt(i+1)))
				{
					return false;
					
				}
				
			}
			return true;
		
		}


		public class Comparer<T>
			:IComparer<T>
		{
			public TotalOrderI2<T> order;
			public Comparer(
				TotalOrderI2<T> order
				
				)
			{
			}


			public int Compare(T x, T y)
			{
				if (object.Equals(x,y))
				{
					return 0;
					
				}
				if (order.contains(x,y))
				{
					return -1;
					
				}
				return 1;
			}
		}
		
	}
}
