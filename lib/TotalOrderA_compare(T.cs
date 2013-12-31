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
	public abstract partial class TotalOrderA_compare<T>
		:
		nilnul.order.TotalOrderI2<T>
	{

		public abstract Sign compare(T x, T y);
		


		public  bool contains(T first, T second) {
			return (compare(first, second) <= 0);
		
		}

	







	}
}
