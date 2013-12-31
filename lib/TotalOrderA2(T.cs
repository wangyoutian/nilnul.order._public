using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set.relation.order;

namespace nilnul.order
{
	/// <summary>
	/// establish order, a relation, on type T.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract partial class TotalOrderA2<T>
		:
		nilnul.order.TotalOrderI3<T>
	{

		public Sign compare(T x, T y)
		{
			if (contains(x, y) && contains(y, x))
			{
				return Sign.Eq;

			}
			if (contains(x, y))
			{
				return Sign.Lt;

			}
			return Sign.Gt;
		}


		public abstract  bool contains(T first, T second)	;

	







	}
}
