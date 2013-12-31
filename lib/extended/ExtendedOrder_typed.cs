using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.order.extended;

namespace nilnul.order.extended
{

	public partial class ExtendedOrder<T>
		:OrderI<ExtendedTypeI2<T>>
		where T:IEquatable<T>
	{

		private OrderI<T> _order;

		public OrderI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}
		
		
		

		public ExtendedOrder(OrderI<T> order)
		{
			this.order = order;
		}
		

	
		

	

	

		public bool contains(ExtendedTypeI2<T> a,ExtendedTypeI2<T> b) {
			if (a is NegativeInfinite<T>)
			{
				if (b is extended.Literal<T>)
				{
					return true;
					
				}
				if (b is extended.Infinite<T>)
				{
					return true;
					
				}
				
			}
			else if (a is extended.Literal<T>)
			{
				if (b is extended.Literal<T>)
				{
					return order.contains((a as Literal<T>).literal, (b as Literal<T>).literal);
				}
				if (b is Infinite<T>)
				{
					return true;
					
				}
				
			}
			return false;
 
		
		}




		
	}
}
