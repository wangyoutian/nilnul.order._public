using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class TotalOrderAssertion<T>
	{
		TotalOrderI2<T> order;

		public TotalOrderAssertion(TotalOrderI2<T> order)
		{
			this.order = order;

		}



		public bool contains(T left,T right) {
			return order.contains(left, right);
		}
		public bool notContains(T left, T right) {
			return !contains(left, right);
		}

		#region MyRegion

		public bool gt(T x, T y)
		{
			return order.compare(x, y) == Sign.Gt;
		}

		public bool lt(T x, T y)
		{

			return order.compare(x, y) == Sign.Lt;

		}

		public bool eq(T x, T y)
		{
			return order.compare(x, y) == Sign.Eq;

		}

		public bool neq(T x, T y)
		{
			return !eq(x, y);

		}



		public bool ge(T x, T y)
		{
			return gt(x, y) || eq(x, y);

		}

		public bool le(T x, T y)
		{
			return lt(x, y) || eq(x, y);

		}


	
		#endregion

		static public TotalOrderAssertion<T> Create(TotalOrderI2<T> order) {
			return new TotalOrderAssertion<T>(order);
		
		}
	


					

	}
}
