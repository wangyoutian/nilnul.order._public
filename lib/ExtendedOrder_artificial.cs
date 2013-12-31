using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{

	public partial class ExtendedOrder_artificial<T>
		:OrderI
		where T:IEquatable<T>
	{

		private OrderI<T> _order;

		public OrderI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}
		
		
		

		public ExtendedOrder_artificial(OrderI<T> order)
		{
			this.order = order;
		}
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="item1"></param>
		/// <param name="item2"></param>
		/// <returns></returns>
		/// <remarks>
		/// instance of T, or instance of Infinite(T) that's 
		/// </remarks>

		

	

		/// <summary>
		/// a is of type T, or is infinite(T) 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public bool contains(object a,object b) {
			if (a is T )
			{
				if (b is T)
				{
					return order.contains((T)a, (T) b);
					
				}
				else if(b is Infinite_artificial)
				{
					
					return true;
				}
				
				
			}
			else if (a is NegativeInfinite_artificial)
			{
				if (b is T)
				{
					return true;
					
				}
				if (b is Infinite_artificial)
				{
					return true;
					
				}
				
				
			}  //a is not T, e.g, a is infinite.
			return false;
		}



		
	}
}
