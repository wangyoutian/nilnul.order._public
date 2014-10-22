using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class Bounded<T>
		: 
		bound.Pair<T>

		,

		nilnul.collection.ContainsI<T>
	{
		private IComparer<T> _order;

		public IComparer<T> order
		{
			get { return _order; }
			set { _order = value; }
		}

		public Bounded(order.Bound<T> lower, order.Bound<T> upper, IComparer<T> order)
			: base(lower, upper)
		{
			this.order = order;

		}






		public bool contains(T item)
		{
			return new LowerBound<T>(lower, order).contains(item) && new UpperBound<T>(lower, order).contains(item);

			throw new NotImplementedException();
		}
	}
}
