using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.compare
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



		public bool Gt(T a, T b)
		{
			return Ge(a, b) && Neq(a, b);

			throw new NotImplementedException();
		}

		public bool Ge(T a, T b)
		{
			return order.Compare(b, a)>=0;
			throw new NotImplementedException();
		}

		public bool Lt(T a, T b)
		{
			return Le(a, b) && Neq(a, b);
			throw new NotImplementedException();
		}

		public bool Le(T a, T b)
		{
			return order.Compare(a, b)<=0;

			throw new NotImplementedException();
		}

		public bool Eq(T a, T b)
		{
			return order.Compare(a, b)==0;
			throw new NotImplementedException();
		}

		public bool Neq(T a, T b)
		{
			return !Eq(a, b);

			throw new NotImplementedException();
		}
	}
}
