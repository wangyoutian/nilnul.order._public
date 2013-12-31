using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class ExtendedOrder_infiniteOfOrder<T>
		:OrderI
		where T:IEquatable<T>
	{

		private UnboundI<T> _order;

		public UnboundI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}
		
		
		

		public ExtendedOrder_infiniteOfOrder(UnboundI<T> order)
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
				else if(b is Infinite_ofOrder<T>)
				{
					var bAsInfinite=b as Infinite_ofOrder<T>;

					if (bAsInfinite.order == this.order)	//order is equal if order. note: order is singleton, and the mechanism to judge wether two order is equal would be difficult. todo: check this before use this. maker sure the order is singleton.
					{
						return true;
					}
					else
					{
						return false;
					}


				}
				else
				{
					return false;
				}
				
			}
			else
			{
				return false;
			}
		}

	}
}
