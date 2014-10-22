using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.order.extended;

namespace nilnul.order.extended
{

	public partial class Order<T>
		:OrderI<ExtendedTypeI2<T>>
	//	where T:IEquatable<T>
	{

		private OrderI<T> _order;

		public OrderI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}
		

		public Order(OrderI<T> order)
		{
			this.order = order;
		}

		public Order(IComparer<T> comparer)
			:this(new total.Le_boxComparer<T>(comparer))
		{

		}




		public bool contains(T a,T b) {

			return order.contains(a, b);
		
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
