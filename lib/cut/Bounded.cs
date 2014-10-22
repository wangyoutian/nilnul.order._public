using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class Bounded<T>
		:Pair1<T>

		,

		nilnul.collection.ContainsI<T>
	{
		private OrderI1<T> _order;

		public OrderI1<T> order
		{
			get { return _order; }
			set { _order = value; }
		}

		public Bounded(order.Bound<T> lower, order.Bound<T> upper, OrderI1<T> order)
			:base(lower,upper)
		{
			this.order = order;

		}




		public bool contains(T item)
		{
			return new LowerBound1<T>(lower, order).contains(item) && new UpperBound1<T>(lower, order).contains(item);

			throw new NotImplementedException();
		}
	}
}
