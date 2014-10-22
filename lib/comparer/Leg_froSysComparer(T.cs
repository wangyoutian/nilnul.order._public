using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class Leg_froSysComparer<T>
		:LegI<T>

	{
		private IComparer<T> _order;

		public IComparer<T> order
		{
			get { return _order; }
			set { _order = value; }
		}
		
		public Leg_froSysComparer(IComparer<T> order)
		{
			this._order = order;

		}



		public bool gt(T a, T b)
		{
			return ge(a, b) && ne(a, b);

			throw new NotImplementedException();
		}

		public bool ge(T a, T b)
		{
			return order.Compare(b, a)>=0;
			throw new NotImplementedException();
		}

		public bool lt(T a, T b)
		{
			return le(a, b) && ne(a, b);
			throw new NotImplementedException();
		}

		public bool le(T a, T b)
		{
			return order.Compare(a, b)<=0;

			throw new NotImplementedException();
		}

		public bool eq(T a, T b)
		{
			return order.Compare(a, b)==0;
			throw new NotImplementedException();
		}

		public bool ne(T a, T b)
		{
			return !eq(a, b);

			throw new NotImplementedException();
		}
	}
}
