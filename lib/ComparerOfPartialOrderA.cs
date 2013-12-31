using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public abstract class ComparerOfPartialOrderA<T>
	{
		public CompareResult compare(
			T a,T b
			
		){
			if (order.contains(a,b) && order.contains(b,a))
			{
				return CompareResult.Eq;
				
			}
			if (order.contains(a,b))
			{
				return CompareResult.Lt;
				
			}
			if (order.contains(b,a))
			{
				return CompareResult.Gt;
			}
			return CompareResult.Incomparable;
		
		}

		public enum CompareResult{
				Lt,
				Eq,
				Gt,
				Incomparable
			
		}

		private OrderI<T> _order;

		public OrderI<T> order
		{
			get { return _order; }
			set { _order = value.EnsureNotNull(); }
		}
		
		public ComparerOfPartialOrderA(OrderI<T> order)
		{
			this.order = order;

		}


					
	}
}
