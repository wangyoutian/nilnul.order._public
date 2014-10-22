using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public partial class Comparer<T>
		:ComparerI3<T>
	{
		private OrderI<T> _order;

		public OrderI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}
		
		public Comparer(total.OrderI<T> order)
		{
			this._order = order;

		}



		public bool Gt(T a, T b)
		{
			return Ge(a, b) && Neq(a, b);

			throw new NotImplementedException();
		}

		public bool Ge(T a, T b)
		{
			return order.contains(b, a);
			throw new NotImplementedException();
		}

		public bool Lt(T a, T b)
		{
			return Le(a, b) && Neq(a, b);
			throw new NotImplementedException();
		}

		public bool Le(T a, T b)
		{
			return order.contains(a, b);

			throw new NotImplementedException();
		}

		public bool Eq(T a, T b)
		{
			return order.contains(a, b) && order.contains(b, a);
			throw new NotImplementedException();
		}

		public bool Neq(T a, T b)
		{
			return !Eq(a, b);

			throw new NotImplementedException();
		}
	}
}
