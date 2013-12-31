using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TTotalOrderSingleton"></typeparam>
	public partial class EqualityFromTotalOrder<T>
		:nilnul.relation.EqualI<T>, nilnul.order.EqualityI<T>
		
	{
		private OrderI<T> _order;

		public OrderI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}
		

		public EqualityFromTotalOrder(OrderI<T> order)
		{
			this.order = order;
		}
					

	
		public bool contains(T first, T second)
		{
			return order.contains(first, second) && order.contains(second, first);

			throw new NotImplementedException();
		}

		static public EqualityFromTotalOrder<T> Create(OrderI<T> order){

			return new EqualityFromTotalOrder<T>(order);
		}

		






	
	}
}
